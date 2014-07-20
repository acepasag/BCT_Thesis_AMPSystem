using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThesisSystem
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            this.Load += new EventHandler(StartScreen_Load);
        }

        void StartScreen_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Black;
            this.BackColor = Color.Black;
        }
    }
}
