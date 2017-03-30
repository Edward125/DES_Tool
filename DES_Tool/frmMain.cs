using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DES_Tool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            if (string.IsNullOrEmpty(txtOri.Text))
                return;
            if (string.IsNullOrEmpty(txtKey1.Text ))
                return;
            if (this.txtKey1.Text.Length != 8)
                return;
            //一次加密
            this.txtEncrypt1.Text = DES.DesEncrypt(this.txtOri.Text.Trim(), this.txtKey1.Text.Trim());
            //temp = this.txtEncrypt1.Text;
            //if (string.IsNullOrEmpty(txtKey2.Text))
            //    return;
            //if (this.txtKey2.Text.Length != 8)
            //    return;

            //this.txtEncrypt2.Text = DES.DesEncrypt(temp, this.txtKey2.Text.Trim());
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            if (string.IsNullOrEmpty(txtKey1.Text ))
                return;
            if (this.txtKey1.Text.Length != 8)
                return;
            if (!string.IsNullOrEmpty(this.txtEncrypt1.Text))
            {
                this.txtDecrypt1.Text = DES.DesDecrypt(this.txtEncrypt1.Text, this.txtKey1.Text);
                temp = this.txtDecrypt1.Text;

            }

            


            //if (string.IsNullOrEmpty(this.txtKey2.Text))
            //    return;
            //if (this.txtKey2.Text.Length != 8)
            //    return;
            //if (string.IsNullOrEmpty(this.txtEncrypt2.Text))
            //    return;
            //this.txtDecrypt2.Text = DES.DesDecrypt(temp, this.txtKey2.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "DES Tool,Ver:" + Application.ProductVersion + ",Author:Edward Song";
        }
    }
}
