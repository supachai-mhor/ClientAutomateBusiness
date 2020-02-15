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
using Newtonsoft.Json;

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

        public TimeSpan startTime;
        public TimeSpan endTime;
        private TimeSpan tikerTime;


        //data from server by job number
        private int planQty = 5000;
        private int expectRatio = 95;
        private int qtyPerInput = 50 ;
        
        private int expectValue = 0;
        private int totalInputValue = 0;
        private int totalPassValue = 0;
        private double yieldValue = 0.0;
        private double OEEValue = 0.0;
        public bool getJobFromHubs = false;
        public bool serverRequestData = false;
        public int everyTiggerTime = 60;

        public enum MachineState
        {
            isRunning,
            isDowntime,
            isIdle,
            isSetting
        }
        public class MachineData
        {
            public MachineState machineState;
            public double runningtimes;
            public double downTimetimes;
            public double settingtimes;
            public double idletimes;

            public TimeSpan RunningTimeSpan;
            public TimeSpan DownTimeSpan;
            public TimeSpan SettingTimeSpan;
            public TimeSpan IdleTimeSpan;

            public int totalInput;
            public int totalPass;

            public int input;
            public int pass;
            public double yield;
            public double oee;

            public string machineName;
            public string jobNumber;
            public string supervisorName;
            public string operatorName;
            public TimeSpan startTime;
            public TimeSpan endTime;
        }
        public class PlaningViewModel
        {
            public int id { get; set; }
            public string job_number { get; set; }
            public int planQty { get; set; }
            public int expectRatio { get; set; }
            public int qtyPerInput { get; set; }
            public string job_detail { get; set; }

        }

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
            //txtMessage.Focus();
            //txtAddressHubs.Focus();
            txtBarcode.Focus();
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            //AcceptButton = connectButton;
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

            _connection.On<bool,int>("ServerRequestRealTime", (s1,s2) => OnRequest(s1,s2));
            //_connection.On<string, string>("ReceiveData", (user, message) => AppendTextBox(user, message));

            _connection.On<string>("ReceiveJobDetail", (s1) => OnReceived(s1));
            _connection.On<string>("ReceiveMessagFromSupervisor", (s1) => OnReceiveMessageToSupervisor(s1));
            
           // _connection.On<string>("ReceiveRealTimeData", (s1) => OnReceivedRealTimeData(s1));

            Log(Color.Gray, "Starting connection...",messagesList);
            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
                return;
            }

            Log(Color.Gray, "Connection established.", messagesList);

            UpdateState(connected: true);

            messageTextBox.Focus();
        }

        private async void disconnectButton_Click(object sender, EventArgs e)
        {
            Log(Color.Gray, "Stopping connection...", messagesList);
            try
            {
                await _connection.StopAsync();
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
            }

            Log(Color.Gray, "Connection terminated.", messagesList);

            UpdateState(connected: false);
        }

        private void messageTextBox_Enter(object sender, EventArgs e)
        {
            //AcceptButton = sendButton;
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                await _connection.InvokeAsync("GetJobDetail", txtBarcode.Text);
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
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
            Log(Color.Black, name + ": " + message, messagesList);
        }
        private void OnRequest(bool data,int everyTime)
        {

            everyTiggerTime = everyTime;
            if (data)
            {
                
                serverRequestData = true;
                countSenddataToHubs = 0;
                Log(Color.Orange,  "Server : Start Request Data", messagesList);
            }
            else
            {
                serverRequestData = false;
                countSenddataToHubs = 0;
                Log(Color.Orange, "Server : Stop Request Data", messagesList);
            }
           
        }
        
        private void OnReceivedRealTimeData(string message)
        {
            Log(Color.DeepPink, "Hubs" + ": " + message, messagesList);
        }
        private void OnReceiveMessageToSupervisor(string message)
        {
            AddRichTextBoxItem("Supervisor : " + message, Color.Green);
        }
        
        private void OnReceived(string message)
        {
            Log(Color.Lime, "Hubs" + ": " + message, messagesList);
            var myObj = JsonConvert.DeserializeObject<PlaningViewModel>(message);

            txtJobNo.Text = myObj.job_number;
            getJobFromHubs = true;
            planQty = myObj.planQty;
            expectRatio = myObj.expectRatio;
            qtyPerInput = myObj.qtyPerInput;

            expectValue = 0;
            totalInputValue = 0;
            totalPassValue = 0;
            yieldValue = 0.0;
            OEEValue = 0.0;

            numNGqty.Maximum = (decimal)qtyPerInput;
          
            txtQtyPlan.Text = planQty.ToString();
            txtQtyExpect.Text = expectValue.ToString();
            txtQtyInput.Text = totalInputValue.ToString();
            btnQtyPass.Text = totalPassValue.ToString();
            txtQtyYield.Text = yieldValue.ToString("N2") + "%";
            txtOEEvalue.Text = OEEValue.ToString("N3") + "%";
            txtMessage.Text = "Get job from server successed, please run by push Start button.";

        }

        private void Log(Color color, string message, ListBox ls)
        {
            Action callback = () =>
            {
                ls.Items.Add(new LogMessage(color, message));
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
            // job detail from server
            if(txtJobNo.Text != "")
            {
                txtBarcode.Enabled = false;
                txtMessage.Text = "Machine is running";

                tikerTime = DateTime.Now.TimeOfDay;
                IdleTimer.Stop();
                SettingTimer.Stop();
                DowntimeTimer.Stop();

                PanelAlertMessage.BackColor = Color.LimeGreen;
                bbcountRunningtimes = countRunningtimes;
                RuningTimer.Start();
            }
            else
            {
                MessageBox.Show("Please scan barcode or key job number before start");
            }
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            getJobFromHubs = false;
            txtBarcode.Enabled = true;
            txtBarcode.Text = "SCAN BARCODE";
            txtMessage.Text = "Machine is stop";
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
            txtMessage.Text = "Machine is trial";

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
            txtMessage.Text = "Machine is error"; 

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

        private async void btnSubmitError_Click(object sender, EventArgs e)
        {
            
            DowntimeTimer.Stop();

            try
            {
                //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                await _connection.InvokeAsync("SendMachineError", DateTime.Now.ToString(),cmbErrorReason.Text,txtErrorDescription.Text);
                Log(Color.Brown, "SendError to server " + ": " + cmbErrorReason.Text, messagesList);
                
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
                serverRequestData = false;
                countSenddataToHubs = 0;
            }

            txtErrorDescription.Text = "";
            //Send data Hubs

            tikerTime = DateTime.Now.TimeOfDay;
            countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
            bbcountIdletimes = countIdletimes;
            PanelAlertMessage.BackColor = Color.DarkOrange;

            IdleTimer.Start();

        }
        private int countSenddataToHubs = 0;
        public MachineState checkStateMachine;
        public double settingPercen;
        public double downtimePercen;
        public double idlePercen;
        public double runningPercen;
        public int lastInput=0;
        public int lastPass=0;
        private async void currentTimer_Tick(object sender, EventArgs e)
        {
            if (serverRequestData)
            {
                countSenddataToHubs += 1;
                lbCountTrigger.Text = countSenddataToHubs.ToString();
                if (countSenddataToHubs == everyTiggerTime)
                {
                    countSenddataToHubs = 0;
                    //send data to Hubs server

                    currentTimer.Stop();
                    //send data to Hubs server

                    if (RuningTimer.Enabled) checkStateMachine = MachineState.isRunning;
                    else if (DowntimeTimer.Enabled) checkStateMachine = MachineState.isDowntime;
                    else if (SettingTimer.Enabled) checkStateMachine = MachineState.isSetting;
                    else checkStateMachine = MachineState.isIdle;

                    TimeSpan countAlltime = countSettingtimes + countIdletimes + countDownTimetimes + countRunningtimes;
                    if (countSettingtimes.TotalSeconds > 0) settingPercen = (double)(countSettingtimes.TotalSeconds * 100 / (countAlltime.TotalSeconds));
                    if (countIdletimes.TotalSeconds > 0) idlePercen = (double)(countIdletimes.TotalSeconds * 100 / (countAlltime.TotalSeconds));
                    if (countDownTimetimes.TotalSeconds > 0) downtimePercen = (double)(countDownTimetimes.TotalSeconds * 100 / (countAlltime.TotalSeconds));
                    if (countRunningtimes.TotalSeconds > 0) runningPercen = (double)(countRunningtimes.TotalSeconds * 100 / (countAlltime.TotalSeconds));

                    var countLastInput = totalInputValue - lastInput;
                    var countLastPass = totalPassValue - lastPass;

                    if (countLastInput > 0 && countLastPass > 0)
                    {
                        lastInput = totalInputValue;
                        lastPass = totalPassValue;
                    }
                    var datatoSendtoHub = new MachineData
                    {
                        machineState = checkStateMachine,

                        runningtimes = runningPercen,
                        downTimetimes = downtimePercen,
                        settingtimes = settingPercen,
                        idletimes = idlePercen,

                        RunningTimeSpan = countRunningtimes,
                        DownTimeSpan = countDownTimetimes,
                        SettingTimeSpan = countSettingtimes,
                        IdleTimeSpan = countIdletimes,

                        totalInput = totalInputValue,
                        totalPass = totalPassValue,
                        input = countLastInput,
                        pass = countLastPass,
                        yield = yieldValue,
                        oee = OEEValue,

                        machineName = txtMachineName.Text,
                        jobNumber = txtJobNo.Text,
                        supervisorName = txtSupervisorName.Text,
                        operatorName = txtOperatorName.Text,
                        startTime = startTime,
                        endTime = endTime
                    };

                    var dataJson = JsonConvert.SerializeObject(datatoSendtoHub);
                    try
                    {
                        //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                        await _connection.InvokeAsync("SendMachineData", dataJson);
                        Log(Color.Brown, "Senddata to server " + ": " + dataJson, messagesList);
                    }
                    catch (Exception ex)
                    {
                        Log(Color.Red, ex.ToString(), messagesList);
                        serverRequestData = false;
                        countSenddataToHubs = 0;
                    }

                    currentTimer.Start();

                }
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

                calYieldandOEE();


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

            planQty = 0;
            expectValue = 0;
            totalInputValue = 0;
            totalPassValue = 0;
            yieldValue = 0.0;
            OEEValue = 0.0;

            expectRatio = 0;
            qtyPerInput = 0;

            txtQtyPlan.Text = planQty.ToString();
            txtQtyExpect.Text = expectValue.ToString();
            txtQtyInput.Text = totalInputValue.ToString();
            btnQtyPass.Text = totalPassValue.ToString();
            txtQtyYield.Text = yieldValue.ToString("N2") + "%";
            txtOEEvalue.Text = OEEValue.ToString("N3") + "%";

            tikerTime = DateTime.Now.TimeOfDay;
            countIdletimes = tikerTime - startTime - countRunningtimes - countDownTimetimes - countSettingtimes;
            bbcountIdletimes = countIdletimes;
            PanelAlertMessage.BackColor = Color.DarkOrange;
            IdleTimer.Start();
        }

        private async void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //txtJobNo.Text = txtBarcode.Text;
                
                    try
                    {
                        if (_connection.State == HubConnectionState.Connected)
                        {
                            await _connection.InvokeAsync("GetJobDetail", txtBarcode.Text);
                        }
                        else
                        {
                            MessageBox.Show("Now is disconnect with Server Hubs, please connect before");
                            txtMessage.Text = "Now is disconnect with Server Hubs";
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

               

                //numNGqty.Maximum = (decimal)qtyPerInput;

                //planQty = 5000;
                //expectRatio = 95;
                //qtyPerInput = 50;

                //expectValue = 0;
                //totalInput = 0;
                //totalPass = 0;
                //yieldValue = 0.0;
                //OEEValue = 0.0;

                //txtQtyPlan.Text = planQty.ToString();
                //txtQtyExpect.Text = expectValue.ToString();
                //txtQtyInput.Text = totalInput.ToString();
                //btnQtyPass.Text = totalPass.ToString();
                //txtQtyYield.Text = yieldValue.ToString("N2") + "%";
                //txtOEEvalue.Text = OEEValue.ToString("N3") + "%";
                //txtMessage.Text = "Get job from server successed, please run by push Start button.";
            }
        }

        private void txtBarcode_MouseClick(object sender, MouseEventArgs e)
        {
            txtBarcode.Text = "";
        }

        private void calYieldandOEE()
        {
            if (totalPassValue > 0 && totalInputValue > 0)
            {
                yieldValue = (double)totalPassValue / totalInputValue * 100;
                txtQtyYield.Text = yieldValue.ToString("N2") + "%";

                //calculate OEE
                TimeSpan countAlltime = countSettingtimes + countIdletimes + countDownTimetimes + countRunningtimes;
                if (countRunningtimes.TotalSeconds > 0)
                {
                        double BpA =(double)(countRunningtimes.TotalSeconds / (countAlltime.TotalSeconds));
                        OEEValue = (double)(BpA * yieldValue);
                        txtOEEvalue.Text = OEEValue.ToString("N3") + "%";
                }

            }
        }

        private void btnInputPart_Click(object sender, EventArgs e)
        {
            if (RuningTimer.Enabled)
            {
                totalInputValue += qtyPerInput;
                expectValue = (int)(totalInputValue * expectRatio / 100);
                txtQtyInput.Text = totalInputValue.ToString();
                txtQtyExpect.Text = expectValue.ToString();

            }
            else
            {
                MessageBox.Show("Please start button before input part");
            }
            
        }

        private void btnOKPart_Click(object sender, EventArgs e)
        {
            if (RuningTimer.Enabled)
            {
                totalPassValue += qtyPerInput;
                btnQtyPass.Text = totalPassValue.ToString();

            }
            else
            {
                MessageBox.Show("Please start button before OK part");
            }
            
        }

        private void btnNGPart_Click(object sender, EventArgs e)
        {

            if (RuningTimer.Enabled)
            {
                totalPassValue += (qtyPerInput - (int)numNGqty.Value);
                btnQtyPass.Text = totalPassValue.ToString();

            }
            else
            {
                MessageBox.Show("Please start button before NG part");
            }
        }

        private async void btnTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                await _connection.InvokeAsync("TrigerRealTimeMachine", txtMachineName.Text, txtCompanyName.Text,true,5);
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
            }
        }

        private async void btnTriggerOff_Click(object sender, EventArgs e)
        {
            try
            {
                //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                await _connection.InvokeAsync("TrigerRealTimeMachine", txtMachineName.Text, txtCompanyName.Text, false,0);
            }
            catch (Exception ex)
            {
                Log(Color.Red, ex.ToString(), messagesList);
            }
        }
        private async void btnSendMsgToSup_Click(object sender, EventArgs e)
        {
            if (txtMsgToSup.Text != "")
            {
                AddRichTextBoxItem("Machine : " + txtMsgToSup.Text, Color.Blue);
                try
                {
                    //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                    await _connection.InvokeAsync("SendMessageToSupervisor", txtMsgToSup.Text, DateTime.Now.ToString(), Properties.Settings.Default.SupervisorEmail);
                }
                catch
                {
                    AddRichTextBoxItem("Server : Unsend message to supervisor, please reconnect to server", Color.Red);
                }
                txtMsgToSup.Text = "";
            }
            
        }

        private async void txtMsgToSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddRichTextBoxItem("Machine : " + txtMsgToSup.Text, Color.Blue);

                try
                {
                    //await _connection.InvokeAsync("Send", "WinFormsApp", messageTextBox.Text);
                    await _connection.InvokeAsync("SendMessageToSupervisor", txtMsgToSup.Text, DateTime.Now.ToString(), Properties.Settings.Default.SupervisorEmail);
                }
                catch
                {
                    AddRichTextBoxItem("Server : Unsend message to supervisor, please reconnect to server", Color.Red);
                }

                txtMsgToSup.Text = "";
            }
        }

        public delegate void AddRichTextBoxItemDelegate(string item, Color color);
        public void AddRichTextBoxItem(string item, Color color)
        {

            if (this.rtbMsgSup.InvokeRequired)
            {
                // This is a worker thread so delegate the task.
                this.rtbMsgSup.Invoke(new AddRichTextBoxItemDelegate(AddRichTextBoxItem), item, color);
            }
            else
            {
                // This is the UI thread so perform the task.

                rtbMsgSup.SelectionFont = rtbMsgSup.SelectionFont;
                rtbMsgSup.SelectionColor = color;
                rtbMsgSup.SelectedText = item + "\n\n";

            }

        }

        private void rtbMsgSup_DoubleClick(object sender, EventArgs e)
        {
            rtbMsgSup.Clear();
        }
    }
}