namespace QQ2013
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.toolShow = new System.Windows.Forms.ToolTip(this.components);
            this.btnDuoId = new CCWin.SkinControl.SkinButtom();
            this.btnSandeng = new CCWin.SkinControl.SkinButtom();
            this.btnDl = new CCWin.SkinControl.SkinButtom();
            this.chkZdLogin = new CCWin.SkinControl.SkinCheckBox();
            this.btnMima = new CCWin.SkinControl.SkinButtom();
            this.btnZc = new CCWin.SkinControl.SkinButtom();
            this.pnlId = new CCWin.SkinControl.SkinPanel();
            this.txtId = new CCWin.SkinControl.WaterTextBox();
            this.btnId = new CCWin.SkinControl.SkinButtom();
            this.txtPwd = new CCWin.SkinControl.SkinTextBox();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.pnlImgTx = new CCWin.SkinControl.SkinPanel();
            this.btnState = new CCWin.SkinControl.SkinButtom();
            this.tuopan = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuState = new CCWin.SkinControl.SkinContextMenuStrip();
            this.ItemImonline = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemAway = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemInVisble = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMima = new CCWin.SkinControl.SkinCheckBox();
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.pnlId.SuspendLayout();
            this.pnlTx.SuspendLayout();
            this.pnlImgTx.SuspendLayout();
            this.MenuState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuoId
            // 
            this.btnDuoId.BackColor = System.Drawing.Color.Transparent;
            this.btnDuoId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDuoId.DownBack = global::QQ2013.Properties.Resources.corner_back_press;
            this.btnDuoId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDuoId.Location = new System.Drawing.Point(1, 251);
            this.btnDuoId.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuoId.MouseBack = global::QQ2013.Properties.Resources.corner_back_hover;
            this.btnDuoId.Name = "btnDuoId";
            this.btnDuoId.NormlBack = global::QQ2013.Properties.Resources.corner_back;
            this.btnDuoId.Size = new System.Drawing.Size(40, 40);
            this.btnDuoId.TabIndex = 6;
            this.toolShow.SetToolTip(this.btnDuoId, "多帐号登录");
            this.btnDuoId.UseVisualStyleBackColor = false;
            // 
            // btnSandeng
            // 
            this.btnSandeng.BackColor = System.Drawing.Color.Transparent;
            this.btnSandeng.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSandeng.DownBack = global::QQ2013.Properties.Resources.corner_right_press;
            this.btnSandeng.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSandeng.Location = new System.Drawing.Point(338, 251);
            this.btnSandeng.Margin = new System.Windows.Forms.Padding(0);
            this.btnSandeng.MouseBack = global::QQ2013.Properties.Resources.corner_right_hover;
            this.btnSandeng.Name = "btnSandeng";
            this.btnSandeng.NormlBack = global::QQ2013.Properties.Resources.corner_right;
            this.btnSandeng.Size = new System.Drawing.Size(40, 40);
            this.btnSandeng.TabIndex = 7;
            this.toolShow.SetToolTip(this.btnSandeng, "QQ闪登");
            this.btnSandeng.UseVisualStyleBackColor = false;
            // 
            // btnDl
            // 
            this.btnDl.BackColor = System.Drawing.Color.Transparent;
            this.btnDl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDl.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnDl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDl.Create = true;
            this.btnDl.DownBack = global::QQ2013.Properties.Resources.button_press;
            this.btnDl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDl.ForeColor = System.Drawing.Color.Black;
            this.btnDl.Location = new System.Drawing.Point(72, 245);
            this.btnDl.Margin = new System.Windows.Forms.Padding(0);
            this.btnDl.MouseBack = global::QQ2013.Properties.Resources.button_hover;
            this.btnDl.Name = "btnDl";
            this.btnDl.NormlBack = global::QQ2013.Properties.Resources.button_normal;
            this.btnDl.Palace = true;
            this.btnDl.Size = new System.Drawing.Size(237, 48);
            this.btnDl.TabIndex = 5;
            this.btnDl.Text = "登        录";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.btnDl_Click);
            // 
            // chkZdLogin
            // 
            this.chkZdLogin.AutoSize = true;
            this.chkZdLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkZdLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkZdLogin.DefaultCheckButtonWidth = 15;
            this.chkZdLogin.DownBack = global::QQ2013.Properties.Resources.checkbox_pushed;
            this.chkZdLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkZdLogin.ForeColor = System.Drawing.Color.Black;
            this.chkZdLogin.LightEffect = false;
            this.chkZdLogin.Location = new System.Drawing.Point(193, 208);
            this.chkZdLogin.MouseBack = global::QQ2013.Properties.Resources.checkbox_hightlight;
            this.chkZdLogin.Name = "chkZdLogin";
            this.chkZdLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkZdLogin.NormlBack")));
            this.chkZdLogin.SelectedDownBack = global::QQ2013.Properties.Resources.checkbox_tick_pushed;
            this.chkZdLogin.SelectedMouseBack = global::QQ2013.Properties.Resources.checkbox_tick_highlight;
            this.chkZdLogin.SelectedNormlBack = global::QQ2013.Properties.Resources.checkbox_tick_normal;
            this.chkZdLogin.Size = new System.Drawing.Size(75, 21);
            this.chkZdLogin.TabIndex = 4;
            this.chkZdLogin.Text = "自动登录";
            this.chkZdLogin.UseVisualStyleBackColor = false;
            this.chkZdLogin.CheckedChanged += new System.EventHandler(this.chkZdLogin_CheckedChanged);
            // 
            // btnMima
            // 
            this.btnMima.BackColor = System.Drawing.Color.Transparent;
            this.btnMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnMima.Create = true;
            this.btnMima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMima.DownBack = global::QQ2013.Properties.Resources.mima_press;
            this.btnMima.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnMima.Location = new System.Drawing.Point(308, 180);
            this.btnMima.Margin = new System.Windows.Forms.Padding(0);
            this.btnMima.MouseBack = global::QQ2013.Properties.Resources.mima_hover;
            this.btnMima.Name = "btnMima";
            this.btnMima.NormlBack = global::QQ2013.Properties.Resources.mima;
            this.btnMima.Size = new System.Drawing.Size(51, 16);
            this.btnMima.TabIndex = 9;
            this.btnMima.UseVisualStyleBackColor = false;
            // 
            // btnZc
            // 
            this.btnZc.BackColor = System.Drawing.Color.Transparent;
            this.btnZc.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnZc.Create = true;
            this.btnZc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZc.DownBack = global::QQ2013.Properties.Resources.zhuce_press;
            this.btnZc.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnZc.Location = new System.Drawing.Point(309, 145);
            this.btnZc.Margin = new System.Windows.Forms.Padding(0);
            this.btnZc.MouseBack = global::QQ2013.Properties.Resources.zhuce_hover;
            this.btnZc.Name = "btnZc";
            this.btnZc.NormlBack = global::QQ2013.Properties.Resources.zhuce;
            this.btnZc.Size = new System.Drawing.Size(51, 16);
            this.btnZc.TabIndex = 8;
            this.btnZc.UseVisualStyleBackColor = false;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.BackgroundImage = global::QQ2013.Properties.Resources.frameBorderEffect_normalDraw;
            this.pnlId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.btnId);
            this.pnlId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlId.DownBack = global::QQ2013.Properties.Resources.frameBorderEffect_mouseDownDraw;
            this.pnlId.Location = new System.Drawing.Point(112, 139);
            this.pnlId.MouseBack = global::QQ2013.Properties.Resources.frameBorderEffect_mouseDownDraw;
            this.pnlId.Name = "pnlId";
            this.pnlId.NormlBack = global::QQ2013.Properties.Resources.frameBorderEffect_normalDraw;
            this.pnlId.Palace = true;
            this.pnlId.Size = new System.Drawing.Size(185, 28);
            this.pnlId.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtId.Location = new System.Drawing.Point(5, 5);
            this.txtId.Margin = new System.Windows.Forms.Padding(0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 18);
            this.txtId.TabIndex = 1;
            this.txtId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtId.WaterText = "QQ号码/手机/邮箱";
            this.txtId.WordWrap = false;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            this.txtId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.Transparent;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.DownBack = global::QQ2013.Properties.Resources.login_inputbtn_down;
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.Location = new System.Drawing.Point(161, 2);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = global::QQ2013.Properties.Resources.login_inputbtn_highlight;
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = global::QQ2013.Properties.Resources.login_inputbtn_normal;
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 13;
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            this.btnId.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.btnId.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPwd.Icon = global::QQ2013.Properties.Resources.imgRjp_BackgroundImage;
            this.txtPwd.IconIsButton = true;
            this.txtPwd.IsPasswordChat = '●';
            this.txtPwd.IsSystemPasswordChar = true;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(112, 174);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtPwd.MouseBack = null;
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.NormlBack = null;
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txtPwd.ReadOnly = false;
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.Size = new System.Drawing.Size(185, 28);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "密码";
            this.txtPwd.WordWrap = true;
            this.txtPwd.IconClick += new System.EventHandler(this.txtPwd_IconClick);
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTx.BackgroundImage")));
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.pnlImgTx);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = null;
            this.pnlTx.Location = new System.Drawing.Point(15, 140);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = null;
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = null;
            this.pnlTx.Size = new System.Drawing.Size(87, 87);
            this.pnlTx.TabIndex = 12;
            // 
            // pnlImgTx
            // 
            this.pnlImgTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgTx.BackgroundImage = global::QQ2013.Properties.Resources._1_100;
            this.pnlImgTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgTx.Controls.Add(this.btnState);
            this.pnlImgTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlImgTx.DownBack = null;
            this.pnlImgTx.Location = new System.Drawing.Point(1, 1);
            this.pnlImgTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImgTx.MouseBack = null;
            this.pnlImgTx.Name = "pnlImgTx";
            this.pnlImgTx.NormlBack = null;
            this.pnlImgTx.Radius = 3;
            this.pnlImgTx.Size = new System.Drawing.Size(85, 85);
            this.pnlImgTx.TabIndex = 11;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnState.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnState.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnState.DownBack = global::QQ2013.Properties.Resources.allbtn_down;
            this.btnState.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnState.Image = global::QQ2013.Properties.Resources.imonline__2_;
            this.btnState.ImageWidth = 12;
            this.btnState.Location = new System.Drawing.Point(67, 67);
            this.btnState.Margin = new System.Windows.Forms.Padding(0);
            this.btnState.MouseBack = global::QQ2013.Properties.Resources.allbtn_highlight;
            this.btnState.Name = "btnState";
            this.btnState.NormlBack = null;
            this.btnState.Size = new System.Drawing.Size(18, 18);
            this.btnState.TabIndex = 10;
            this.btnState.Tag = "1";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // tuopan
            // 
            this.tuopan.Icon = ((System.Drawing.Icon)(resources.GetObject("tuopan.Icon")));
            this.tuopan.Text = "QQ";
            this.tuopan.Visible = true;
            this.tuopan.DoubleClick += new System.EventHandler(this.tuopan_DoubleClick);
            // 
            // MenuState
            // 
            this.MenuState.Arrow = System.Drawing.Color.Black;
            this.MenuState.AutoSize = false;
            this.MenuState.Back = System.Drawing.Color.White;
            this.MenuState.BackRadius = 4;
            this.MenuState.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.MenuState.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Fore = System.Drawing.Color.Black;
            this.MenuState.HoverFore = System.Drawing.Color.White;
            this.MenuState.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.MenuState.ItemAnamorphosis = false;
            this.MenuState.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemBorderShow = false;
            this.MenuState.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.MenuState.ItemRadius = 4;
            this.MenuState.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.MenuState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemImonline,
            this.ItemQme,
            this.toolStripMenuItem1,
            this.ItemAway,
            this.ItemBusy,
            this.ItemMute,
            this.toolStripMenuItem2,
            this.ItemInVisble});
            this.MenuState.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MenuState.Name = "MenuState";
            this.MenuState.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.MenuState.Size = new System.Drawing.Size(106, 147);
            this.MenuState.TitleAnamorphosis = false;
            this.MenuState.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.MenuState.TitleRadius = 4;
            this.MenuState.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // ItemImonline
            // 
            this.ItemImonline.AutoSize = false;
            this.ItemImonline.Image = global::QQ2013.Properties.Resources.imonline__2_;
            this.ItemImonline.Name = "ItemImonline";
            this.ItemImonline.Size = new System.Drawing.Size(105, 22);
            this.ItemImonline.Tag = "2";
            this.ItemImonline.Text = "我在线上";
            this.ItemImonline.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemImonline.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemQme
            // 
            this.ItemQme.AutoSize = false;
            this.ItemQme.Image = global::QQ2013.Properties.Resources.Qme__2_;
            this.ItemQme.Name = "ItemQme";
            this.ItemQme.Size = new System.Drawing.Size(105, 22);
            this.ItemQme.Tag = "1";
            this.ItemQme.Text = "Q我把";
            this.ItemQme.ToolTipText = "表示希望好友主动联系您。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：自动弹出会话窗口\r\n";
            this.ItemQme.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemAway
            // 
            this.ItemAway.AutoSize = false;
            this.ItemAway.Image = global::QQ2013.Properties.Resources.away__2_;
            this.ItemAway.Name = "ItemAway";
            this.ItemAway.Size = new System.Drawing.Size(105, 22);
            this.ItemAway.Tag = "3";
            this.ItemAway.Text = "离开";
            this.ItemAway.ToolTipText = "表示离开，暂无法处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemAway.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemBusy
            // 
            this.ItemBusy.AutoSize = false;
            this.ItemBusy.Image = global::QQ2013.Properties.Resources.busy__2_;
            this.ItemBusy.Name = "ItemBusy";
            this.ItemBusy.Size = new System.Drawing.Size(105, 22);
            this.ItemBusy.Tag = "4";
            this.ItemBusy.Text = "忙碌";
            this.ItemBusy.ToolTipText = "表示忙碌，不会及时处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏显示气泡\r\n";
            this.ItemBusy.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemMute
            // 
            this.ItemMute.AutoSize = false;
            this.ItemMute.Image = global::QQ2013.Properties.Resources.mute__2_;
            this.ItemMute.Name = "ItemMute";
            this.ItemMute.Size = new System.Drawing.Size(105, 22);
            this.ItemMute.Tag = "5";
            this.ItemMute.Text = "请勿打扰";
            this.ItemMute.ToolTipText = "表示不想被打扰。\r\n声音：关闭\r\n消息提醒框：关闭\r\n会话消息：任务栏显示气泡\r\n\r\n";
            this.ItemMute.Click += new System.EventHandler(this.Item_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // ItemInVisble
            // 
            this.ItemInVisble.AutoSize = false;
            this.ItemInVisble.Image = global::QQ2013.Properties.Resources.invisible__2_;
            this.ItemInVisble.Name = "ItemInVisble";
            this.ItemInVisble.Size = new System.Drawing.Size(105, 22);
            this.ItemInVisble.Tag = "6";
            this.ItemInVisble.Text = "隐身";
            this.ItemInVisble.ToolTipText = "表示好友看到您是离线的。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemInVisble.Click += new System.EventHandler(this.Item_Click);
            // 
            // chkMima
            // 
            this.chkMima.AutoSize = true;
            this.chkMima.BackColor = System.Drawing.Color.Transparent;
            this.chkMima.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkMima.DefaultCheckButtonWidth = 15;
            this.chkMima.DownBack = global::QQ2013.Properties.Resources.checkbox_pushed;
            this.chkMima.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMima.ForeColor = System.Drawing.Color.Black;
            this.chkMima.LightEffect = false;
            this.chkMima.Location = new System.Drawing.Point(112, 208);
            this.chkMima.MouseBack = global::QQ2013.Properties.Resources.checkbox_hightlight;
            this.chkMima.Name = "chkMima";
            this.chkMima.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkMima.NormlBack")));
            this.chkMima.SelectedDownBack = global::QQ2013.Properties.Resources.checkbox_tick_pushed;
            this.chkMima.SelectedMouseBack = global::QQ2013.Properties.Resources.checkbox_tick_highlight;
            this.chkMima.SelectedNormlBack = global::QQ2013.Properties.Resources.checkbox_tick_normal;
            this.chkMima.Size = new System.Drawing.Size(75, 21);
            this.chkMima.TabIndex = 3;
            this.chkMima.Text = "记住密码";
            this.chkMima.UseVisualStyleBackColor = false;
            // 
            // imgLoadding
            // 
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(1, 242);
            this.imgLoadding.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(377, 2);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 17;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // timShow
            // 
            this.timShow.Interval = 500;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackPalace = global::QQ2013.Properties.Resources.texture;
            this.BackToColor = false;
            this.BorderPalace = global::QQ2013.Properties.Resources.BackPalace;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.CloseBoxSize = new System.Drawing.Size(39, 20);
            this.CloseDownBack = global::QQ2013.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::QQ2013.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::QQ2013.Properties.Resources.btn_close_disable;
            this.ControlBoxOffset = new System.Drawing.Point(0, -1);
            this.Controls.Add(this.imgLoadding);
            this.Controls.Add(this.chkMima);
            this.Controls.Add(this.chkZdLogin);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.btnMima);
            this.Controls.Add(this.btnZc);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.btnDuoId);
            this.Controls.Add(this.btnDl);
            this.Controls.Add(this.btnSandeng);
            this.Controls.Add(this.txtPwd);
            this.DropBack = false;
            this.EffectCaption = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::QQ2013.Properties.Resources.btn_max_down;
            this.MaximizeBox = false;
            this.MaxMouseBack = global::QQ2013.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::QQ2013.Properties.Resources.btn_max_normal;
            this.MaxSize = new System.Drawing.Size(28, 20);
            this.MiniDownBack = global::QQ2013.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::QQ2013.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::QQ2013.Properties.Resources.btn_mini_normal;
            this.MiniSize = new System.Drawing.Size(28, 20);
            this.Name = "FrmLogin";
            this.RestoreDownBack = global::QQ2013.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::QQ2013.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::QQ2013.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SysBottomDown = global::QQ2013.Properties.Resources.btn_set_press;
            this.SysBottomMouse = global::QQ2013.Properties.Resources.btn_set_hover;
            this.SysBottomNorml = global::QQ2013.Properties.Resources.btn_set_normal;
            this.SysBottomToolTip = "设置";
            this.SysBottomVisibale = true;
            this.Text = "QQ2013";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlTx.ResumeLayout(false);
            this.pnlImgTx.ResumeLayout(false);
            this.MenuState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButtom btnDuoId;
        private CCWin.SkinControl.SkinButtom btnSandeng;
        private CCWin.SkinControl.SkinButtom btnDl;
        private CCWin.SkinControl.SkinCheckBox chkZdLogin;
        private CCWin.SkinControl.SkinButtom btnMima;
        private CCWin.SkinControl.SkinButtom btnZc;
        private CCWin.SkinControl.SkinPanel pnlId;
        private CCWin.SkinControl.WaterTextBox txtId;
        private CCWin.SkinControl.SkinButtom btnId;
        private CCWin.SkinControl.SkinTextBox txtPwd;
        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinPanel pnlImgTx;
        private CCWin.SkinControl.SkinButtom btnState;
        private System.Windows.Forms.ToolTip toolShow;
        public System.Windows.Forms.NotifyIcon tuopan;
        private CCWin.SkinControl.SkinContextMenuStrip MenuState;
        private System.Windows.Forms.ToolStripMenuItem ItemImonline;
        private System.Windows.Forms.ToolStripMenuItem ItemQme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ItemAway;
        private System.Windows.Forms.ToolStripMenuItem ItemBusy;
        private System.Windows.Forms.ToolStripMenuItem ItemMute;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ItemInVisble;
        private CCWin.SkinControl.SkinCheckBox chkMima;
        private System.Windows.Forms.PictureBox imgLoadding;
        private System.Windows.Forms.Timer timShow;
    }
}