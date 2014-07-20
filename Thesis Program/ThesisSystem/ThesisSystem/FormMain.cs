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
    public partial class FormMain : MetroAppForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormMain_Load);
            this.Click += new EventHandler(FormMain_Click);
            slidePanel1.Click += new EventHandler(slidePanel1_Click);
        }

        void slidePanel1_Click(object sender, EventArgs e)
        {
            
            slidePanel1.IsOpen = false;
        }

        void FormMain_Click(object sender, EventArgs e)
        {
            //if (slideLogin1.IsOpen == false)
            //{
            //    slideLogin1.IsOpen = true;
            //}
            //else
            //{
            //    slideLogin1.IsOpen = false;
            //}
        }

        void FormMain_Load(object sender, EventArgs e)
        {
            //slideLogin1.Width = this.Width;
            //slideLogin1.Height = this.Height;
            //slideLogin1.Location = new Point(0, 0);
            ChangeSlideSide(eSlideSide.Left);
            
            pageSliderPage0.BackColor = Color.CornflowerBlue;
            slidePanel1.BackColor = Color.CornflowerBlue;
            Theme(Color.CornflowerBlue);
        }

        private void ChangeSlideSide(eSlideSide side)
        {
            //slidelogin1.slideside = side;
            //slidelogin1.isopen = false;
            slidePanel1.SlideSide = side;
        }

        void Theme(Color color)
        {
            pageSlider.BackColor = color;
            pageSliderPage1.BackColor = Color.Transparent;
            pageSliderPage0.BackColor = Color.Transparent;
            panel1.BackColor = color;
        }
    }
}
