namespace _7._17qq
{
    partial class UserDaskTop
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_leftUser = new System.Windows.Forms.Label();
            this.lab_roomName = new System.Windows.Forms.Label();
            this.lab_rightUser = new System.Windows.Forms.Label();
            this.lab_roomId = new System.Windows.Forms.Label();
            this.lab_roomUse = new System.Windows.Forms.Label();
            this.pic_left_user = new System.Windows.Forms.PictureBox();
            this.pic_right_user = new System.Windows.Forms.PictureBox();
            this.pic_center = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_left_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_center)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_leftUser
            // 
            this.lab_leftUser.AutoSize = true;
            this.lab_leftUser.Location = new System.Drawing.Point(21, 172);
            this.lab_leftUser.Name = "lab_leftUser";
            this.lab_leftUser.Size = new System.Drawing.Size(55, 15);
            this.lab_leftUser.TabIndex = 3;
            this.lab_leftUser.Text = "label1";
            // 
            // lab_roomName
            // 
            this.lab_roomName.AutoSize = true;
            this.lab_roomName.Location = new System.Drawing.Point(132, 27);
            this.lab_roomName.Name = "lab_roomName";
            this.lab_roomName.Size = new System.Drawing.Size(52, 15);
            this.lab_roomName.TabIndex = 4;
            this.lab_roomName.Text = "房间名";
            // 
            // lab_rightUser
            // 
            this.lab_rightUser.AutoSize = true;
            this.lab_rightUser.Location = new System.Drawing.Point(231, 159);
            this.lab_rightUser.Name = "lab_rightUser";
            this.lab_rightUser.Size = new System.Drawing.Size(55, 15);
            this.lab_rightUser.TabIndex = 5;
            this.lab_rightUser.Text = "label2";
            // 
            // lab_roomId
            // 
            this.lab_roomId.AutoSize = true;
            this.lab_roomId.Location = new System.Drawing.Point(135, 194);
            this.lab_roomId.Name = "lab_roomId";
            this.lab_roomId.Size = new System.Drawing.Size(52, 15);
            this.lab_roomId.TabIndex = 6;
            this.lab_roomId.Text = "房间号";
            // 
            // lab_roomUse
            // 
            this.lab_roomUse.AutoSize = true;
            this.lab_roomUse.Location = new System.Drawing.Point(37, 216);
            this.lab_roomUse.Name = "lab_roomUse";
            this.lab_roomUse.Size = new System.Drawing.Size(55, 15);
            this.lab_roomUse.TabIndex = 7;
            this.lab_roomUse.Text = "label1";
            // 
            // pic_left_user
            // 
            this.pic_left_user.Image = global::_7._17qq.Properties.Resources.nod32z;
            this.pic_left_user.Location = new System.Drawing.Point(24, 79);
            this.pic_left_user.Name = "pic_left_user";
            this.pic_left_user.Size = new System.Drawing.Size(52, 77);
            this.pic_left_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_left_user.TabIndex = 8;
            this.pic_left_user.TabStop = false;
            // 
            // pic_right_user
            // 
            this.pic_right_user.Image = global::_7._17qq.Properties.Resources.bd;
            this.pic_right_user.Location = new System.Drawing.Point(234, 70);
            this.pic_right_user.Name = "pic_right_user";
            this.pic_right_user.Size = new System.Drawing.Size(39, 86);
            this.pic_right_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_right_user.TabIndex = 2;
            this.pic_right_user.TabStop = false;
            // 
            // pic_center
            // 
            this.pic_center.Image = global::_7._17qq.Properties.Resources.qp;
            this.pic_center.Location = new System.Drawing.Point(94, 45);
            this.pic_center.Name = "pic_center";
            this.pic_center.Size = new System.Drawing.Size(134, 142);
            this.pic_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_center.TabIndex = 1;
            this.pic_center.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(186, 216);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "正在加入房间";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseDoubleClick);
            // 
            // UserDaskTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pic_left_user);
            this.Controls.Add(this.lab_roomUse);
            this.Controls.Add(this.lab_roomId);
            this.Controls.Add(this.lab_rightUser);
            this.Controls.Add(this.lab_roomName);
            this.Controls.Add(this.lab_leftUser);
            this.Controls.Add(this.pic_right_user);
            this.Controls.Add(this.pic_center);
            this.Name = "UserDaskTop";
            this.Size = new System.Drawing.Size(292, 243);
            this.Load += new System.EventHandler(this.UserDaskTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_left_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_right_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_center)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_center;
        private System.Windows.Forms.PictureBox pic_right_user;
        private System.Windows.Forms.Label lab_leftUser;
        private System.Windows.Forms.Label lab_roomName;
        private System.Windows.Forms.Label lab_rightUser;
        private System.Windows.Forms.Label lab_roomId;
        private System.Windows.Forms.Label lab_roomUse;
        private System.Windows.Forms.PictureBox pic_left_user;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
