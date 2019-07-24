using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util.core;
using util.net;

namespace _7._17qq
{
    
    public partial class Room : Form
    {
       
        public Room()
        {
         
            InitializeComponent();
            
            MainLogicBusiness main = new MainLogicBusiness(this);
            GameRoomLogicBusiness room = new GameRoomLogicBusiness();
         
        }

        private void Room_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                MessageQueue.shareMessageQueue().StartRead();
            });
        }

        private void Room_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        //public void do6211(ByteBuffer buffer)
        //{
        //    MessageBox.Show("1");
        //    int roomId = buffer.readInt();
        //    string userName = buffer.readString();
        //    int deskPso = buffer.readInt();
        //    int havImg = buffer.readInt();
        //    Image img = null;
        //    if (havImg > 0)
        //    {
        //        ByteBuffer bf = buffer.readBuffer();
        //        Stream stream = new MemoryStream(buffer.getBuffer());
        //        img = Image.FromStream(stream);
        //    }
        //    UserDaskTop dt = dict[roomId.ToString()];
        //    dt.setUserName(userName,null);
        //}


        //d.setDeskNumber(Convert.ToString(roomId));
        //d.SetDeskName(roomName);
        //// dict.Add(roomName, d);
        //string password = buffer.readString();
        //int userLeng = buffer.readInt();
        //if (userLeng > 0)
        //{
        //    string userName = buffer.readString();
        //    int dsekPos = buffer.readInt();
        //    string havImg = buffer.readString();
        //    if (havImg == "null")
        //    {
        //        havImg = null;
        //    }
        //    d.setUserName(userName, havImg, dsekPos);
        //    userLeng--;
        //}
    }
}
