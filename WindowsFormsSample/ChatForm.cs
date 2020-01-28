using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System.IdentityModel;
using System.Security;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.SqlClient;
namespace WindowsFormsSample
{
    public partial class ChatForm : Form
    {
        private HubConnection _connection;

        public ChatForm()
        {
            InitializeComponent();
        }
        
        private void ChatForm_Load(object sender, EventArgs e)
        {
            addressTextBox.Focus();
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
                .WithUrl("https://localhost:44377/ChatHub",options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .Build();
           //_connection.On<string, string>("broadcastMessage", (s1, s2) => OnSend(s1, s2));

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
            addressTextBox.Enabled = !connected;

            messageTextBox.Enabled = connected;
            sendButton.Enabled = connected;
        }

        private void OnSend(string name, string message)
        {
            Log(Color.Black, name + ": " + message);
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
            var userName = txtUsers.Text;

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub,userName),
                new Claim(JwtRegisteredClaimNames.Email,userName),
                new Claim(ClaimTypes.Role,"Machine"),
                new Claim("FactoryName","Tanjai Delivery")
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
                expires:DateTime.Now.AddMonths(3),
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
       

    }
}
