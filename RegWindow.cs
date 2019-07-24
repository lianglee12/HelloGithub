using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using util.core;
using util.net;

namespace _7._17qq
{
    public partial class RegWindow : Form
    {
        private byte[] imgByte;
        private string imgName;

        public RegWindow()
        {
            InitializeComponent();
            EventDispatch.addEventListener(this);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ByteBuffer buffer = ByteBuffer.CreateBufferTypeAndLength(1002, 1000 * 2000);
            buffer.writeString(userId.Text);//用户名
            buffer.writeString(userName.Text);//昵称
            buffer.writeString(sex.Text);//性别
            buffer.writeInt(Convert.ToInt32(age.Text));//年龄
            buffer.writeString(pwd.Text);//密码

            buffer.writeInt(this.imgByte==null?-1:1);//.jpg
            if (this.imgByte != null)
            {
                buffer.writeString(imgName.Substring(imgName.IndexOf('.')));
                buffer.writeInt(imgByte.Length);
                buffer.writeBytes(imgByte);

            }

            buffer.Send();
        }

        public void do1002(ByteBuffer buffer)
        {
            MessageBox.Show("注册成功");
        }

        private void RegWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.main.Show();
        }

        private void RegWindow_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG" + "|All Files (*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = this.openFileDialog1.FileName;
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    imgByte = new Byte[fs.Length];
                    this.imgName = path.Substring(path.LastIndexOf("\\") + 1);
                    this.lab_path.Text = "位置:" + this.imgName;
                    this.lab_size.Text = "大小:" + (imgByte.Length / 1000) + " KB  ";
                    fs.Read(imgByte, 0, imgByte.Length);
                    fs.Close();

                    Image m = Image.FromFile(path);
                    this.pictureBox1.Image = m;
                }
                catch (Exception)
                {
                }
            }

        }
    }
}
