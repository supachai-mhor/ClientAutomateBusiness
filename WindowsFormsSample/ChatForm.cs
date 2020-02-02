using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;

namespace WindowsFormsSample
{
    
    public partial class ChatForm : Form
    {
        public static NameValueCollection AppSettings { get; }
        private HubConnection _connection;

        public TimeSpan countRunningtimes;
        public TimeSpan countDownTimetimes;
        public TimeSpan countSettingtimes;
        public TimeSpan countIdletimes;

        public TimeSpan bbcountRunningtimes;
        public TimeSpan bbcountDownTimetimes;
        public TimeSpan bbcountSettingtimes;
        public TimeSpan bbcountIdletimes;

       // public TimeSpan countUncounttimes;
        public TimeSpan startTime;
        public TimeSpan endTime;
        private TimeSpan tikerTime;
        public void AppendTextBox(string user, string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string,string>(AppendTextBox), new object[] { user, message });
                return;
            }
            OnSend(user, message);
        }
        
        public ChatForm()
        {
            InitializeComponent();

            txtAddressHubs.Text = Properties.Settings.Default.AddressHubs;
            txtAdminUsers.Text = Properties.Settings.Default.AdminName;
            txtPassword.Text = Properties.Settings.Default.AdminPassword;
            txtCompanyName.Text = Properties.Settings.Default.CompanyName;
            txtMachineName.Text = Properties.Settings.Default.MachineName;

            //lbAlertMessage.Text = "WAITING";
            //PanelAlertMessage.BackColor = Color.DarkOrange;
            //lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;

            countRunningtimes = Properties.Settings.Default.RunningTimes;
            countDownTimetimes = Properties.Settings.Default.DownTimes;
            countSettingtimes = Properties.Settings.Default.SettingTimes;

            startTime = Properties.Settings.Default.StartTime;
            endTime = Properties.Settings.Default.EndTime;

            dtStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, startTime.Hours, startTime.Minutes, startTime.Seconds);
            dtEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, endTime.Hours, endTime.Minutes, endTime.Seconds);           

            //startTime = DateTime.Now.TimeOfDay.Add(new TimeSpan(0,0,20));


            if (startTime > DateTime.Now.TimeOfDay)
            {
                countSettingtimes = new TimeSpan(0, 0, 0);
                countIdletimes = new TimeSpan(0);
                countDownTimetimes = new TimeSpan(0, 0, 0);
                countRunningtimes = new TimeSpan(0, 0, 0);
                lbAlertMessage.Text = "Wait Until To Start Time";
                lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
                PanelAlertMessage.BackColor = Color.DarkCyan;
                txtMessage.Text = "Waiting...";
            }
            else
            {
                tikerTime = DateTime.Now.TimeOfDay;
                countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
                bbcountIdletimes = countIdletimes;
                IdleTimer.Start();
            }

            currentTimer.Start();
            updateChartTimer.Start();


            txtStartTime.Text = startTime.ToString("hh'h:'mm'm:'ss's'");
            txtEndTime.Text = endTime.ToString("hh'h:'mm'm:'ss's'");
            txtRunningTimes.Text = countRunningtimes.ToString("hh'h:'mm'm:'ss's'");
            txtDownTimes.Text = countDownTimetimes.ToString("hh'h:'mm'm:'ss's'");
            txtIdleTimes.Text = countIdletimes.ToString("hh'h:'mm'm:'ss's'");
            txtSettingTimes.Text = countSettingtimes.ToString("hh'h:'mm'm:'ss's'");


            chart1.Series[0].Points.AddXY("Setting",(int)countSettingtimes.TotalSeconds/ 86400*100);
            chart1.Series[0].Points.AddXY("Idletime", (int)countIdletimes.TotalSeconds / 86400 * 100);
            chart1.Series[0].Points.AddXY("Downtime", (int)countDownTimetimes.TotalSeconds / 86400 * 100);
            chart1.Series[0].Points.AddXY("Running", (int)countRunningtimes.TotalSeconds / 86400 * 100);

            chart1.Series[0].Points[3].Color = Color.Lime;

        }
        
        private void ChatForm_Load(object sender, EventArgs e)
        {
            txtMessage.Focus();
            //txtAddressHubs.Focus();
            //txtBarcode.Focus();
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = connectButton;
        }
        private async void connectButton_Click(object sender, EventArgs e)
        {
            UpdateState(connected: false);

            var token = getToken();
            _connection = new HubConnectionBuilder()
                .WithAutomaticReconnect()
                .WithUrl(txtAddressHubs.Text, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .Build();


            _connection.On<string, string>("ReceiveData", (s1, s2) => OnSend(s1, s2));
            //_connection.On<string, string>("ReceiveData", (user, message) => AppendTextBox(user, message));
        
            _connection.On<double, string>("ReceiveMessage", (s1, s2) => OnReceived(s1, s2));

            Log(Color.Gray, "Starting connection...");
            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString());
                return;
            }

            Log(Color.Gray, "Connection established.");

            UpdateState(connected: true);

            messageTextBox.Focus();
        }

        private async void disconnectButton_Click(object sender, EventArgs e)
        {
            Log(Color.Gray, "Stopping connection...");
            try
            {
                await _connection.StopAsync();
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString());
            }

            Log(Color.Gray, "Connection terminated.");

            UpdateState(connected: false);
        }

        private void messageTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = sendButton;
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                await _connection.InvokeAsync("SendMessage", messageTextBox.Text, "");
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString());
            }
        }

        private void UpdateState(bool connected)
        {
            disconnectButton.Enabled = connected;
            connectButton.Enabled = !connected;
            txtAddressHubs.Enabled = !connected;

            messageTextBox.Enabled = connected;
            sendButton.Enabled = connected;
        }

        private void OnSend(string name, string message)
        {
            Log(Color.Black, name + ": " + message);
        }
        private void OnReceived(double name, string message)
        {
            Log(Color.Lime, name + ": " + message);
        }
        
        private void Log(Color color, string message)
        {
            Action callback = () =>
            {
                messagesList.Items.Add(new LogMessage(color, message));
            };

            Invoke(callback);
        }

        private class LogMessage
        {
            public Color MessageColor { get; }

            public string Content { get; }

            public LogMessage(Color messageColor, string content)
            {
                MessageColor = messageColor;
                Content = content;
            }
        }

        private void messagesList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var message = (LogMessage)messagesList.Items[e.Index];
            e.Graphics.DrawString(
                message.Content,
                messagesList.Font,
                new SolidBrush(message.MessageColor),
                e.Bounds);
        }

        public string getToken()
        {
            var userName = txtAdminUsers.Text;

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub,userName),
                new Claim(JwtRegisteredClaimNames.Email,userName),
                new Claim(ClaimTypes.Role,"Machine"),
                new Claim("FactoryName",txtCompanyName.Text),
                new Claim("MachineName",txtMachineName.Text)


                //new Claim(JwtRegisteredClaimNames.NameId,userName),
                //new Claim("my key","my value"),
            };
            
            // Define const Key this should be private secret key  stored in some safe place
            string key = "secret-keymhor";

           // Create Security key  using private key above:
           // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new SymmetricSecurityKey(Encoding.UTF32.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var secToken = new JwtSecurityToken(
                issuer: "https://localhost:44377/",
                audience: "https://localhost:44377/",
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires:DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );


            var handler = new JwtSecurityTokenHandler();

            // Token to String so you can use it in your client
            var tokenString = handler.WriteToken(secToken);

            return tokenString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    var t = VerifyUserNamePassword(u, p);
            //    MessageBox.Show(t.ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //// MessageBox.Show(getToken());


            //try
            //{
            //    var t = CreateUser(u, p);
            //    var errores = "";
            //    t.Errors.ToList().ForEach(x => errores += x + Environment.NewLine);
            //    MessageBox.Show(t.ToString() + errores);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }


        private void btnExit_Click(object sender, EventArgs e)
        {

            IdleTimer.Stop();
            currentTimer.Stop();
            RuningTimer.Stop();
            SettingTimer.Stop();
            DowntimeTimer.Stop();
            updateChartTimer.Stop();

            Properties.Settings.Default.RunningTimes = countRunningtimes;
            Properties.Settings.Default.DownTimes = countDownTimetimes;
            Properties.Settings.Default.SettingTimes = countSettingtimes;

            Properties.Settings.Default.Save();

            Close();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            tikerTime = DateTime.Now.TimeOfDay;
            IdleTimer.Stop();
            SettingTimer.Stop();
            DowntimeTimer.Stop();

            PanelAlertMessage.BackColor = Color.LimeGreen;
            bbcountRunningtimes = countRunningtimes;
            RuningTimer.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
          
            RuningTimer.Stop();
            SettingTimer.Stop();
            DowntimeTimer.Stop();

            PanelAlertMessage.BackColor = Color.DarkOrange;
            tikerTime = DateTime.Now.TimeOfDay;

            countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
            bbcountIdletimes = countIdletimes;
            IdleTimer.Start();

        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            tikerTime = DateTime.Now.TimeOfDay;
            RuningTimer.Stop();
            IdleTimer.Stop();
            DowntimeTimer.Stop();

            PanelAlertMessage.BackColor = Color.DeepSkyBlue;
            bbcountSettingtimes = countSettingtimes;
            SettingTimer.Start();
           
        }

        private void btnMachineError_Click(object sender, EventArgs e)
        {
            tikerTime = DateTime.Now.TimeOfDay;
            RuningTimer.Stop();
            IdleTimer.Stop();
            SettingTimer.Stop();

            PanelAlertMessage.BackColor = Color.Crimson;
            bbcountDownTimetimes = countDownTimetimes;
            DowntimeTimer.Start();
           
        }

       
        private void RunningTimer_Tick(object sender, EventArgs e)
        {

            TimeSpan diff = DateTime.Now.TimeOfDay.Subtract(tikerTime);
            countRunningtimes = diff + bbcountRunningtimes;
            txtRunningTimes.Text = countRunningtimes.ToString("hh'h:'mm'm:'ss's'");

            lbAlertMessage.Text = "RUNNING(" + txtRunningTimes.Text + ")";
            lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
        }

        private void DowntimeTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now.TimeOfDay.Subtract(tikerTime);
            countDownTimetimes = diff + bbcountDownTimetimes;
            txtDownTimes.Text = countDownTimetimes.ToString("hh'h:'mm'm:'ss's'");

            lbAlertMessage.Text = "DOWNTIME";
            lbAlertMessage.Text = "DOWNTIME(" + txtDownTimes.Text + ")";
            lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
        }

        private void SettingTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now.TimeOfDay.Subtract(tikerTime);
            countSettingtimes = diff + bbcountSettingtimes;
            txtSettingTimes.Text = countSettingtimes.ToString("hh'h:'mm'm:'ss's'");

            lbAlertMessage.Text = "SETTING(" + txtSettingTimes.Text + ")";
            lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now.TimeOfDay.Subtract(tikerTime);
            countIdletimes = diff + bbcountIdletimes;
            txtIdleTimes.Text = countIdletimes.ToString("hh'h:'mm'm:'ss's'");

            lbAlertMessage.Text = "WAITING(" + txtIdleTimes.Text + ")";
            lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
        }

        private void btnSubmitError_Click(object sender, EventArgs e)
        {
            
            DowntimeTimer.Stop();

            //Send data Hubs

            tikerTime = DateTime.Now.TimeOfDay;
            countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
            bbcountIdletimes = countIdletimes;
            PanelAlertMessage.BackColor = Color.DarkOrange;

            IdleTimer.Start();

        }
        private int countSenddataToHubs = 0;
        private void currentTimer_Tick(object sender, EventArgs e)
        {
            countSenddataToHubs += 1;

            if (countSenddataToHubs == 60)
            {
                currentTimer.Stop();
                //send data to Hubs server



                currentTimer.Start();
                
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if(dtEndTime.Value.TimeOfDay == new TimeSpan(0))
            {
                MessageBox.Show("Maximum End time is 23:59:59, please reset again");
            }
            else
            {
                Properties.Settings.Default.RunningTimes = countRunningtimes;
                Properties.Settings.Default.DownTimes = countDownTimetimes;
                Properties.Settings.Default.SettingTimes = countSettingtimes;
                Properties.Settings.Default.MachineName = "ME-2001-2993";

                Properties.Settings.Default.StartTime = dtStartTime.Value.TimeOfDay;
                Properties.Settings.Default.EndTime = dtEndTime.Value.TimeOfDay;
                
                startTime = Properties.Settings.Default.StartTime;
                endTime = Properties.Settings.Default.EndTime;

                Properties.Settings.Default.Save();

                txtStartTime.Text = startTime.ToString("hh'h:'mm'm:'ss's'");
                txtEndTime.Text = endTime.ToString("hh'h:'mm'm:'ss's'");

                MessageBox.Show("Save config done");

            }

            
        }

        private bool resetDone = false;
        private void updateChartTimer_Tick(object sender, EventArgs e)
        {
                       
            if ((DateTime.Now.TimeOfDay >= endTime) && (DateTime.Now.TimeOfDay > startTime))
            {
                if(resetDone==false)
                {
                    resetDone = true;
                    //startTime =startTime.Subtract(new TimeSpan(1, 0, 0, 0));
                    txtMessage.Text = "Stop all process because now is reset data time !!!";
                    //send data to server




                    //reset data and save to local
                    IdleTimer.Stop();
                    RuningTimer.Stop();
                    SettingTimer.Stop();
                    DowntimeTimer.Stop();

                    countSettingtimes = new TimeSpan(0);
                    countIdletimes = new TimeSpan(0);
                    countDownTimetimes = new TimeSpan(0);
                    countRunningtimes = new TimeSpan(0);

                    txtRunningTimes.Text = "00h:00m:00s";
                    txtSettingTimes.Text = "00h:00m:00s";
                    txtDownTimes.Text = "00h:00m:00s";
                    txtIdleTimes.Text = "00h:00m:00s";


                    Properties.Settings.Default.RunningTimes = countRunningtimes;
                    Properties.Settings.Default.DownTimes = countDownTimetimes;
                    Properties.Settings.Default.SettingTimes = countSettingtimes;

                    Properties.Settings.Default.Save();

                    lbAlertMessage.Text = "RESET TIME";
                    PanelAlertMessage.BackColor = Color.Gray;
                    lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;

                }
                else 
                {
                    lbAlertMessage.Text = "END PROCESS TIME";
                    PanelAlertMessage.BackColor = Color.DarkOrange;
                    lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;
                    txtMessage.Text = "Now is End of Process time";
                }


            }
            else if((DateTime.Now.TimeOfDay < endTime) && (DateTime.Now.TimeOfDay > startTime))
            {
                TimeSpan countAlltime = countSettingtimes + countIdletimes + countDownTimetimes + countRunningtimes;

                if (countSettingtimes.TotalSeconds > 0) chart1.Series[0].Points[0].SetValueY((double)(countSettingtimes.TotalSeconds * 100 / (countAlltime.TotalSeconds)));
                if (countIdletimes.TotalSeconds > 0) chart1.Series[0].Points[1].SetValueY((double)(countIdletimes.TotalSeconds * 100 / (countAlltime.TotalSeconds)));
                if (countDownTimetimes.TotalSeconds > 0) chart1.Series[0].Points[2].SetValueY((double)(countDownTimetimes.TotalSeconds * 100 / (countAlltime.TotalSeconds)));
                if (countRunningtimes.TotalSeconds > 0) chart1.Series[0].Points[3].SetValueY((double)(countRunningtimes.TotalSeconds * 100 / (countAlltime.TotalSeconds)));
                
                chart1.Refresh();

                resetDone = false;

                if (!DowntimeTimer.Enabled && !SettingTimer.Enabled && !RuningTimer.Enabled && !IdleTimer.Enabled)
                {
                    txtMessage.Text = "Please key or scan job barcode before start process";
                    tikerTime = DateTime.Now.TimeOfDay;
                    countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
                    bbcountIdletimes = countIdletimes;
                    PanelAlertMessage.BackColor = Color.DarkOrange;
                    IdleTimer.Start();

                }
            }

        }
           

        private void btnResetConfig_Click(object sender, EventArgs e)
        {

            PanelAlertMessage.BackColor = Color.Gray;
            lbAlertMessage.Text = "RESET TIME";
            lbAlertMessage.Left = (PanelAlertMessage.Width - lbAlertMessage.Width) / 2;

            //reset data and save to local
            IdleTimer.Stop();
            RuningTimer.Stop();
            SettingTimer.Stop();
            DowntimeTimer.Stop();

            countSettingtimes = new TimeSpan(0);
            countIdletimes = new TimeSpan(0);
            countDownTimetimes = new TimeSpan(0);
            countRunningtimes = new TimeSpan(0);

            txtRunningTimes.Text = "00h:00m:00s";
            txtSettingTimes.Text = "00h:00m:00s";
            txtDownTimes.Text = "00h:00m:00s";
            txtIdleTimes.Text = "00h:00m:00s";


            Properties.Settings.Default.RunningTimes = countRunningtimes;
            Properties.Settings.Default.DownTimes = countDownTimetimes;
            Properties.Settings.Default.SettingTimes = countSettingtimes;

            Properties.Settings.Default.Save();

            tikerTime = DateTime.Now.TimeOfDay;
            countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
            bbcountIdletimes = countIdletimes;
            PanelAlertMessage.BackColor = Color.DarkOrange;
            IdleTimer.Start();
        }
    }
}
