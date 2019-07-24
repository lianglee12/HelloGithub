using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using util.core;
using util.net;

namespace _7._17qq
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();         
           // EventDispatch.addEventListener(this);
        }

       

        private void Game_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    DeskTop d = new DeskTop();
            //    this.DesktopParent.Controls.Add(d);
            //}
            Task.Run(() =>
            {
                Thread.Sleep(300);
                MessageQueue.shareMessageQueue().StartRead();
               // ByteBuffer buffer = ByteBuffer.CreateBufferAndType(5001);
              //  buffer.Send();
            });
        }
        
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            string item = listbox.SelectedItem.ToString();
            this.label1.Text = "正在向" + item + "发消息";
          //  MessageBox.Show(listbox.SelectedItem.ToString(), "提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ByteBuffer buffer = ByteBuffer.CreateBufferAndType(1003);
         //   buffer.Send();
        }
        public void do1003(ByteBuffer buffer)
        {
            int flg = buffer.readInt();
            string _name = buffer.readString();
            string _cName = buffer.readString();
            if (flg > 0)
            {

                ListViewItem item = new ListViewItem();
                item.Text = _name;
                item.SubItems.Add(_cName);
             //   this.listView2.Items.Add(item);
            }
            else
            {
                //int count = this.listView2.Items.Count;
                //for (int i = 0; i < count; i--)
                //{
                //    string s = this.listView2.Items[i].Text;
                //    if (s.Equals(_name))
                //    {
                //        this.listView2.Items.RemoveAt(i);
                //        break;
                //    }
                //}
            }
            //string str = buffer.readString();
            //string[] users = str.Split('@');
            //for (int i = 0; i < users.Length; i++)
            //{
            //    string[] us = users[i].Split('#');
            //    ListViewItem item = new ListViewItem();
            //    item.Text = us[0];
            //    item.SubItems.Add(us[1]);
            //    this.listView1.Items.Add(item);
            //}
            //string[] users = buffer.readString().Split('@');
            //for (int i = 0; i < users.Length; i++)
            //{
            //    string[] us = users[i].Split('#');
            //    ListViewItem item = new ListViewItem();
            //    item.Text = us[0];
            //    item.SubItems.Add(us[1]);
            //this.listView1.Items.Add(item);
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public void do2001(ByteBuffer buffer)
        {
          string _name=  buffer.readString();
            string _cName = buffer.readString();
            string message = buffer.readString();
            this.listBox1.Items.Add(_name + " " + _cName + "  :" + message);
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
           

        }
        public void do2002(ByteBuffer buffer)
        {
            string _name = buffer.readString();
            string _cName = buffer.readString();
            string message = buffer.readString();
            this.listBox1.Items.Add(_name + " " + _cName + "  :" + message);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.main.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           // listBox2.Text
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        public void SendMessage()
        {//群聊按钮选中
            if (radioButton1.Checked)
            {
                ByteBuffer buffer = ByteBuffer.CreateBufferAndType(2001);
                buffer.writeString(richTextBox1.Text);
              //  buffer.Send();
                richTextBox1.Text = " ";
            }
            else if(radioButton2.Checked)
            {//私聊
                ByteBuffer buffer = ByteBuffer.CreateBufferAndType(2002);
                ListView.SelectedIndexCollection list = userListView.SelectedIndices;
                buffer.writeString(userListView.Items[list[0]].Text);

                buffer.writeString(richTextBox1.Text);
              //  buffer.Send();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listview = (ListView)sender;
            int a = listview.SelectedIndices[0];
            string str = userListView.Items[a].Text;
            this.label1.Text="正在给"+str+"发消息 ";
        }

        private void DesktopParent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
