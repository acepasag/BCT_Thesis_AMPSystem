﻿using System;
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

namespace ThesisSystem
{
    public partial class FormMain : MetroAppForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormMain_Load);
            btn_SignIn.Click += new EventHandler(btn_SignIn_Click);
            lnk_SignIn.Click += new EventHandler(lnk_SignIn_Click);
        }

        void lnk_SignIn_Click(object sender, EventArgs e)
        {
            ClassDatabase cd = new ClassDatabase();
            cd.SetConnection();
        }

        void btn_SignIn_Click(object sender, EventArgs e)
        {
            //if (slideLogin1.IsOpen)
            //{
            //    slideLogin1.IsOpen = false;
            //}
            //else
            //{
            //    slideLogin1.IsOpen = true;
            //}
            
        }

        void FormMain_Load(object sender, EventArgs e)
        {
            Login();
            Theme(Color.CornflowerBlue);
        }

        private void ChangeSlideSide(eSlideSide side)
        {
            //slidePanel1.SlideSide = side;
        }

        private void Theme(Color color)
        {
            pageSlider1.BackColor = color;
            pageSliderPage1.BackColor = Color.Transparent;
            pageSliderPage2.BackColor = Color.Transparent;
            lnk_SignIn.BackColor = color;
            linkLabel2.BackColor = color;
        }

        private void Login()
        {
            //slideLogin1.Hide();
            //slideLogin1.IsOpen = false;
            //slideLogin1.Show();
        }
    }
}
