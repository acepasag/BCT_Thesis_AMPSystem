using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

using System.Ace.UserManagement;
using System.Ace.Database;

namespace ThesisSystem
{
    public partial class SlideLogin : SlidePanel
    {
        FormMain FormMain;
        ClassUserManagement ClassUM;

        public SlideLogin(FormMain FormMain,ClassUserManagement ClassUM)
        {
            this.FormMain = FormMain;
            this.ClassUM = ClassUM;
            InitializeComponent();
            tb_pwd.GotFocus += new EventHandler(tb_pwd_GotFocus);
            tb_uid.GotFocus += new EventHandler(tb_uid_GotFocus);
            this.Click += new EventHandler(SlideLogin_Click);
            this.Load += new EventHandler(SlideLogin_Load);
            btn_login.Click += new EventHandler(btn_login_Click);
            link_help.Click += new EventHandler(link_help_Click);

        }

        void link_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Click for Help");
        }

        void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                ClassUM = new ClassUserManagement();
                ClassUM.UserLogin(new UserInformation { Username = tb_uid.Text, Password = tb_pwd.Text });
            }
            catch (Exception ex) { MessageBox.Show(ex+""); }
        }

        void SlideLogin_Load(object sender, EventArgs e)
        {
            this.SlideSide = eSlideSide.Right;
            Theme(Color.Transparent);
        }

        void SlideLogin_Click(object sender, EventArgs e)
        {
            this.IsOpen = false;
        }

        void tb_uid_GotFocus(object sender, EventArgs e)
        {
            tb_uid.FocusHighlightEnabled = true;
        }

        void tb_pwd_GotFocus(object sender, EventArgs e)
        {
            tb_pwd.FocusHighlightEnabled = true;
        }

        void Theme(Color color)
        {
            this.BackColor = color;
            labelX3.BackColor = color;
            reflectionImage1.BackColor = color;
            link_help.BackColor = color;
        }
    }
}
