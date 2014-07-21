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

namespace ThesisSystem
{
    public partial class SlideLogin : SlidePanel
    {
        public SlideLogin()
        {
            InitializeComponent();
            tb_pwd.GotFocus += new EventHandler(tb_pwd_GotFocus);
            tb_uid.GotFocus += new EventHandler(tb_uid_GotFocus);
            this.Click += new EventHandler(SlideLogin_Click);
            this.Load += new EventHandler(SlideLogin_Load);
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
            this.BackColor = Color.CornflowerBlue;
            labelX1.BackColor = color;
            labelX2.BackColor = color;
            labelX3.BackColor = color;
            reflectionImage1.BackColor = color;
            link_help.BackColor = color;
        }
    }
}
