using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Controls;

namespace ThesisSystem
{
    public partial class SlideControlPanel : SlidePanel
    {
        public SlideControlPanel()
        {
            InitializeComponent();
            this.Load += new EventHandler(SlideControlPanel_Load);
        }

        void SlideControlPanel_Load(object sender, EventArgs e)
        {
            this.SlideSide = eSlideSide.Left;
            Theme(Color.CornflowerBlue);
        }

        private void Theme(Color color)
        {
            pageSlider1.BackColor = color;
            pageSliderPage1.BackColor = Color.Transparent;
            slidePanel1.BackColor = color;
            this.BackColor = color;
        }
    }
}
