using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util.net;
using System.IO;

namespace _7._17qq
{
    public partial class UserDaskTop : UserControl
    {
        public string daskName = null;
        public string daskId = null;
        public bool leftSitDowm = false;
        private string password = null;
        public void setUser(string uname,string _uimg=null,int pos=-1)
        {
            if (pos < 0)
            {
                this.lab_leftUser.Text = uname;
                if (_uimg != null)
                {
                    this.pic_left_user.LoadAsync(_uimg);//异步
                }

            }
            else
            {
                this.lab_rightUser.Text = uname;
                if (_uimg != null)
                {
                    this.pic_right_user.LoadAsync(_uimg);//异步
                }

            }
        }
        public void RemoveUser(int pos)
        {
            if (pos < 0)
            {
                this.lab_leftUser.Text = " ";
                this.pic_left_user.Image = Properties.Resources.nod32z;
            }else
            {
                this.lab_rightUser.Text = "";
                this.pic_right_user.Image = Properties.Resources.nod32z;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        // public int roomName = 0;
//        public void setUserName(string uName,string ImgUrl=null,int leftOrRight=-1)
//        {
//            if (leftOrRight<0)
//            {
//                this.lab_leftUser.Text = uName;
//                if (ImgUrl != null)
//                {
//                    pic_left_user.LoadAsync(ImgUrl);
//;                }
//                this.leftSitDowm = true;
//            }else
//            {

//                this.lab_rightUser.Text = uName;
//                if (ImgUrl != null)
//                {
//                    pic_right_user.LoadAsync(ImgUrl);
                    
//                }
//               // this.leftSitDowm = true;


//            }
//        }
        public void setRoomState(string str)
        {
            this.lab_roomUse.Text = str;
        }
        public UserDaskTop()
        {
            InitializeComponent();
        }
        public void SetDeskName(string name)
        {
            this.daskName = name;
            this.lab_roomName.Text = name;
        }
        public void setDeskNumber(string daskid)
        {
           this.daskId = daskid;
            this.lab_roomId.Text = "房间号："+daskid;
        }

        private void linkLabel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine("加入房间");
            ByteBuffer buffer = ByteBuffer.CreateBufferAndType(6310);
            buffer.writeInt(Convert.ToInt32(this.daskId));
            buffer.Send();
        }

        private void UserDaskTop_Load(object sender, EventArgs e)
        {

        }
    }
}
