using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util.net;

namespace _7._17qq
{
    public partial class GameRoom : Form
    {
        public static GameRoom gameRoom = null;
        private bool sendClient = false;

        public bool SendClient
        {
            get
            {
                return sendClient;
            }

            set
            {
                sendClient = value;
            }
        }

        public GameRoom()
        {
            gameRoom = this;
            InitializeComponent();
            this.ShowXQLable(false);
        }
        public void GameStart(string userName)
        {
            this.left_state.Hide();
            this.right_state.Text = "";
            if (userName == Player.sharePlayer().UserName)
            {
                this.ShowXQLable(true, "我方下白棋");
            }else
            {
                this.ShowXQLable(true,"对方先执白棋");
            }
        }
        public void ShowXQLable(bool f = true, string str = " ")
        {
            if (f)
            {
                this.lab_xq.Show();
            }
            else
            {
                this.lab_xq.Hide();
            }
        }
        public void SetGameState(string userName,int flg)
        {
            if (userName==Player.sharePlayer().UserName)
            {
                if (flg > 0)
                {
                    this.left_state.Text = "取消准备";
                }else
                {
                    this.left_state.Text = "准备";
                }
            }
            else
            {
                if (flg > 0)
                {
                    this.right_state.Text = "【已准备】";

                }
                else
                {
                    this.right_state.Text = "【未准备】";
                }
            }
        }
        public void setUserName(string name,string img,bool isMe=true)
        {
            if (isMe)
            {
               this.lab_left_name.Text = name;
               this.lab_left_dw.Text = "倔强青铜4";
               
                if (img == null)
                {
                    this.pic_left_img.Image = Properties.Resources.hd;
                }
                else
                {
                    this.pic_left_img.LoadAsync(img);
                }
            }
            else
            {
               Console.WriteLine("lxl");
               //   this.lab_right_dw.Text = "wnb";
                this.lab_right_name.Text = name;
              this.lab_right_dw.Text = "最强王者";
                if (img == null)
                {
                    this.pic_right_img.Image = Properties.Resources.hd;
                }
                else
                {
                    this.pic_right_img.LoadAsync(img);
                }
            }
        }
  

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //得到画笔,画布工具，画图功能
            Graphics g = this.pictureBox1.CreateGraphics();
            //for (int i = 0; i < 15; i++)
            //{
            //    g.DrawLine(Pens.Red, new Point(0, 35 * i+5), new Point(this.pictureBox1.Width+5, 35 * i+5));
            //}
            //Pen p = new Pen(Color.Red, 2);
            for (int i = 0; i < 15; i++)
            {
                g.DrawLine(Pens.White, new Point(0, i * 35 + 5), new Point(this.pictureBox1.Width, i * 35 + 5));
                g.DrawLine(Pens.White, new Point(i * 35 + 5, 0), new Point(i * 35 + 5, this.pictureBox1.Height));
            }

            //  g.DrawLine(Pens.White, new Point(0, 0), e.Location);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           // ProductPiece(Properties.Resources.bd, e);
            ProductPiece(Properties.Resources.hd, e);
            //  int row = (e.Location.Y-5)/ 35;
            //  int col= (e.Location.X - 5) / 35;
            //  this.lab_rc.Text = row+","+col;

            //  PictureBox t1 = new PictureBox();
            //  PictureBox t2 = new PictureBox();
            //  t1.Image = Properties.Resources.hd;
            ////  t2.Image=
            //  t1.Size = new Size(30, 30);
            //  t1.BackColor = Color.Transparent;
            //  t1.Parent = this.pictureBox1;
            //  t1.SizeMode = PictureBoxSizeMode.Zoom;
            //  int vx =col*35+(35/2)+5-t1.Width / 2;
            //  int vy = row*35 +5+ (35 / 2)-t1.Height/2;
            //      t1.Location = new Point(vx, vy);
        }
        public void ProductPiece(Image _image, MouseEventArgs e)
        {
            int row = (e.Location.Y - 5) / 35;
            int col = (e.Location.X - 5) / 35;
            PictureBox p = new PictureBox();
            p.Image = _image;
            p.Size = new Size(30, 30);
            p.BackColor = Color.Transparent;
            p.Parent = this.pictureBox1;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            int vx = col * 35 + (35 / 2) + 5 - p.Width / 2;
            int vy = row * 35 + 5 + (35 / 2) - p.Height / 2;
            p.Location = new Point(vx, vy);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.label1.Text = e.Location.X + " , " + e.Location.Y;
        }

        public void PlayerExitRoom()
        {
            this.lab_right_name.Text = "no player";
            this.lab_right_dw.Text = "";
            this.pic_right_img.Image = Properties.Resources.nod32z;
        }
        //sender谁点击是谁
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (SendClient)
            {
                MessageBox.Show("你点击过快");
                return;
            }
            Button btn = (Button)sender;
            if (btn.Text == "准备")
            {
               
                this.SendGameState(1);
            }else
            {
             
                this.SendGameState(-1);
            }
            SendClient = true;
        }
        public void SendGameState(int flg)
        {
            if (flg > 0)
            {
                ByteBuffer buffer = ByteBuffer.CreateBufferAndType(7006);
                buffer.writeInt(flg);
                buffer.Send();
            }else
            {
                ByteBuffer buffer = ByteBuffer.CreateBufferAndType(7007);
                buffer.writeInt(flg);
                buffer.Send();
            }
              
           
          
           
           
        }
        private void GameRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameRoom = null;
            ByteBuffer buffer = ByteBuffer.CreateBufferAndType(7999);
            buffer.Send();
        }
    }
}
