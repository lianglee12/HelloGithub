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
    public partial class Form1 : Form
    {
        public static Form1 main = null;
        public Form1()
        {
            InitializeComponent();
            main = this;
            EventDispatch.addEventListener(this,"do ",this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Task.Run(() => {
                U3DSocket.shareSocket().ConnectTo("192.168.1.105", 8888, () => {
                    Console.WriteLine("连接服务器成功");
               
                }, (str) => {
                    MessageBox.Show("F");
                });
            });
            
        }
       // public void 
        public void do120(ByteBuffer buffer)
        {
            string s = buffer.readString();
    
            Console.WriteLine(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegWindow reg = new RegWindow();
            reg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Load load = new Load();
            load.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game game = new Game();
          
            game.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 观战页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Show();
            
        }
    }
}
