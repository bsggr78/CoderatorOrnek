using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace CoderatorOrnek
{
    public partial class Form1 : Form
    {
        public TelegramBotClient bot = new TelegramBotClient("BOTTOKEN");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bot.SendTextMessageAsync(KENDIIDNIZVEYABIRBASKASI, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bot.StartReceiving();
            bot.OnMessage += Bot_OnMessage;
        }

        private void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text == "Selamün Aleyküm") {
                bot.SendTextMessageAsync(e.Message.Chat.Id, "Aleyküm Selam");
            }
            if (e.Message.Text == "Çık")
            {
                Application.Exit();
            }
        }
    }
}
