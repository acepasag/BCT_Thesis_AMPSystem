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

using System.Ace.Database;
using System.Ace.UserManagement;

namespace ThesisSystem
{
    public partial class FormMain : MetroAppForm
    {
        #region Controls
        SlideLogin slide_Login = null;
        #endregion

        #region Classes
        ClassUserManagement ClassUM = new ClassUserManagement();
        #endregion

        public FormMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormMain_Load);
            btn_SignIn.Click += new EventHandler(btn_SignIn_Click);
            lnk_SignIn.Click += new EventHandler(lnk_SignIn_Click);
            GarbageCollector.Tick += new EventHandler(GarbageCollector_Tick);
        }

        void GarbageCollector_Tick(object sender, EventArgs e)
        {
            GC.Collect(1000, GCCollectionMode.Optimized);
        }

        void lnk_SignIn_Click(object sender, EventArgs e)
        {
            btn_SignIn_Click(null, null);
        }

        void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (slide_Login.IsOpen)
            {
                slide_Login.IsOpen = false;
            }
            else
            {
                slide_Login.IsOpen = true;
            }
        }

        void FormMain_Load(object sender, EventArgs e)
        {
            Control_Login();
            GarbageCollector.Start();
            Theme(Color.CornflowerBlue);
        }

        private void ChangeSlideSide(eSlideSide side)
        {

        }

        private void Theme(Color color)
        {
            pageSlider1.BackColor = color;
            pageSliderPage1.BackColor = Color.Transparent;
            pageSliderPage2.BackColor = Color.Transparent;
            lnk_SignIn.BackColor = color;
            linkLabel2.BackColor = color;
            panel1.BackColor = color;
            this.BackColor = color;
        }

        #region ControlProperty
        public void Control_Login()
        {
            slide_Login = new SlideLogin(this, ClassUM);
            slide_Login.Location = new Point(this.Width - slide_Login.Width, pageSlider1.Height + 1);
            slide_Login.AnimationTime = 500;
            slide_Login.Hide();
            this.Controls.Add(slide_Login);
            slide_Login.IsOpen = false;
            slide_Login.Show();
        }
        #endregion

    }
}
