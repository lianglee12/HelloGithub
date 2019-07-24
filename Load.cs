using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util.core;
using util.net;

namespace _7._17qq
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            EventDispatch.addEventListener(this,"do");
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            ByteBuffer buffer = ByteBuffer.CreateBufferAndType(1001);
            buffer.writeString(userName.Text);
            buffer.writeString(pwd.Text);
            buffer.Send();
        }
        public void do1001(ByteBuffer buffer)
        {
            Console.WriteLine("登录成功");
            this.label3.Text = "登录成功";
            Player p = Player.sharePlayer();
            p.UserName = buffer.readString();
            p.ChinaName = buffer.readString();
            this.Hide();
            //打开房间，关闭登入界面
            Room a = new Room();
            a.Show();
        }

        private void Load_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.main.Show();
        }
    }
}
