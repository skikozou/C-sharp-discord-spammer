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
            //�܂���message���M���������
            //txt�t�@�C���ɏ������݁������commandline���œǂݎ�肻���đ��M
            //�����͎��s�� ���Ȃ炻�̉񐔁@inf�@�������� �L���Ȃ� infinity
            string pass = Interaction.InputBox("input your private pass");
            if (pass == "this password is fake")
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("ok");
                Thread.Sleep(1500);
                MessageBox.Show("�G���[\n�Ή����Ă���dll��������܂���ł���\n�\�t�g���ċN�����A������x�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("token��ǂݍ��߂܂���ł���","�G���[",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Channel Id���Ԉ���Ă��܂�","�G���[",MessageBoxButtons.OK,MessageBoxIcon.Error);
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