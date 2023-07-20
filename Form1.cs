using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using System.Timers;
using System.Threading.Channels;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace spammer
{
    public partial class Form1 : Form
    {
        private DiscordSocketClient _client;
        public Form1()
        {
            InitializeComponent();
            //まずはmessage送信部分を作る
            //txtファイルに書き込み＆それをcommandline側で読み取りそして送信
            //引数は実行回数 数ならその回数　inf　もしくは 記号なら infinity
            string pass = Interaction.InputBox("input your private pass");
            if (pass == "this password is fake")
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("ok");
                Thread.Sleep(1500);
                MessageBox.Show("エラー\n対応しているdllが見つかりませんでした\nソフトを再起動し、もう一度試してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            Main();
            static async Task Main()
            {
                var client = new DiscordSocketClient();
                //client.MessageReceived += Client_MessageReceived;
                try
                {
                    StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\token.txt", Encoding.GetEncoding("UTF-8"));
                    await client.LoginAsync(TokenType.Bot, sr.ReadToEnd());
                    await client.StartAsync();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("tokenを読み込めませんでした","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                await Task.Delay(-1);
            }
        }
        private void spamming(object sender, EventArgs e)
        {
            bool check;
            try
            {
                ulong n = ulong.Parse(channelid.Text);
                check = true;
            }
            catch
            {
                check = false;
            }
            if (check)
            {
                string Dir = Directory.GetCurrentDirectory();
                Encoding enc = Encoding.GetEncoding("UTF-8");
                StreamWriter writer = new StreamWriter("message.txt", false, enc);
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = Dir + "\\commandline.exe";
                if (checkBox1.Checked == true)
                {
                    pInfo.Arguments = channelid.Text + "inf";
                }
                else if (checkBox1.Checked == false)
                {
                    pInfo.Arguments = channelid.Text + numericUpDown1.Value;
                }
                Process.Start(pInfo);
            }
            else
            {
                MessageBox.Show("Channel Idが間違っています","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void check_chenged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcessesByName("commandline");
            foreach (Process p in ps){p.Kill();}
        }
    }
}