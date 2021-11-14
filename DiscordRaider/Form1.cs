using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using RestSharp;
using System.IO;
using System.Threading;
using System.Net;
using System.Collections.Specialized;

namespace DiscordRaider
{
    public partial class DiscordRaider_form : Form
    {
        int mov;
        int movX;
        int movY;

        List<string> tokenList = new List<string>();
        List<string> badTokens = new List<string>();

        public DiscordRaider_form()
        {
            InitializeComponent();
            foreach (string token in File.ReadAllLines(Directory.GetCurrentDirectory() + "/tokens.txt"))
            {
                if (token != "" || token != Environment.NewLine)
                {
                    tokenList.Add(token);
                    tokenTextBox.Text += token + Environment.NewLine;
                }
            }
        }

        private void DiscordRaider_form_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void ResetTokens()
        {
            tokenTextBox.Text = "";
            foreach (string token in tokenList)
            {
                tokenTextBox.Text += token + Environment.NewLine;
            }
        }

        private void InviteButton_Click(object sender, EventArgs e)
        {
            string invite = InviteBox.Text;

            foreach (string token in tokenList)
            {
                string Url = "https://discordapp.com/api/v9/invites/" + invite;
                var client = new RestClient(Url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-encoding", "gzip, deflate, br");
                request.AddHeader("accept-language", "en-US");
                request.AddHeader("Authorization", token);
                request.AddHeader("content-length", "0");
                request.AddHeader("cookie", "__dcfduid=75af9050ff6211ebad731ffdee3c037e; __sdcfduid=75af9051ff6211ebad731ffdee3c037e933998e6356b1dffdf296486c9c67f3f52108589d44d26d29febc86909e52537; __stripe_mid=b1d29ec9-19c8-41d7-9ace-e35266d8e9d1725cd3; __cfruid=402026f51d740991320e719ec5b87763fb9f0b58-1630164866");
                request.AddHeader("origin", "https://canary.discord.com");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.600 Chrome/91.0.4472.106 Electron/13.1.4 Safari/537.36");
                request.AddHeader("x-context-properties", "eyJsb2NhdGlvbiI6Ikludml0ZSBCdXR0b24gRW1iZWQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6Ijg3OTc4MjM4MDAxMTk0NjAyNCIsImxvY2F0aW9uX2NoYW5uZWxfaWQiOiI4ODExMDg4MDc5NjE0MTk3OTYiLCJsb2NhdGlvbl9jaGFubmVsX3R5cGUiOjAsImxvY2F0aW9uX21lc3NhZ2VfaWQiOiI4ODExOTkzOTI5MTExNTkzNTcifQ==");
                request.AddHeader("x-debug-options", "bugReporterEnabled");
                request.AddHeader("x-super-properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJjYW5hcnkiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC42MDAiLCJvc192ZXJzaW9uIjoiMTAuMC4yMjAwMCIsIm9zX2FyY2giOiJ4NjQiLCJzeXN0ZW1fbG9jYWxlIjoic2siLCJjbGllbnRfYnVpbGRfbnVtYmVyIjo5NTM1MywiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");

                IRestResponse response = client.Execute(request);
                System.Windows.Forms.MessageBox.Show(response.Content.ToString(), response.Content.ToString()+"!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!response.IsSuccessful)
                {
                    badTokens.Add(token);
                }
                break;
            }
            foreach (string token in badTokens)
            {
                tokenList.Remove(token);
            }
            ResetTokens();
        }

        private void Spam()
        {
            var ChannelID = ChannelBox.Text;
            var Message = MessageBox.Text;

            while (SpamButton.Text == "Stop")
            {
                foreach (string token in tokenList)
                {
                    var client = new RestClient("https://discordapp.com/api/v6/channels/" + ChannelID + "/messages");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("authorization", token);
                    request.AddParameter("content", Message);
                    IRestResponse response = client.Execute(request);
                }
            }
        }

        private void SpamButton_Click(object sender, EventArgs e)
        {
            if (SpamButton.Text == "Spam")
            {
                SpamButton.Text = "Stop";
                Thread Spammer = new Thread(Spam);
                Spammer.Start();
            }
            else if (SpamButton.Text == "Stop")
            {
                SpamButton.Text = "Spam";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetTokens();
        }
    }
}
