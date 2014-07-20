namespace ThesisSystem
{
    partial class SlideLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideLogin));
            this.btn_si = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tb_uid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // btn_si
            // 
            this.btn_si.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_si.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_si.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_si.Location = new System.Drawing.Point(19, 318);
            this.btn_si.Name = "btn_si";
            this.btn_si.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_si.Size = new System.Drawing.Size(298, 30);
            this.btn_si.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btn_si.TabIndex = 17;
            this.btn_si.Text = "Sign in";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 173);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(298, 34);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Username";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 245);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(298, 34);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Password";
            // 
            // tb_uid
            // 
            this.tb_uid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_uid.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_uid.Border.Class = "TextBoxBorder";
            this.tb_uid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_uid.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightColor(this.tb_uid, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            this.highlighter.SetHighlightOnFocus(this.tb_uid, true);
            this.tb_uid.Location = new System.Drawing.Point(19, 212);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(298, 26);
            this.tb_uid.TabIndex = 14;
            this.tb_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pwd.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_pwd.Border.Class = "TextBoxBorder";
            this.tb_pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pwd.ForeColor = System.Drawing.Color.Black;
            this.highlighter.SetHighlightColor(this.tb_pwd, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            this.highlighter.SetHighlightOnFocus(this.tb_pwd, true);
            this.tb_pwd.Location = new System.Drawing.Point(19, 286);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(298, 26);
            this.tb_pwd.TabIndex = 15;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // link_help
            // 
            this.link_help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_help.AutoSize = true;
            this.link_help.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_help.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_help.Location = new System.Drawing.Point(242, 373);
            this.link_help.Name = "link_help";
            this.link_help.Size = new System.Drawing.Size(75, 16);
            this.link_help.TabIndex = 18;
            this.link_help.TabStop = true;
            this.link_help.Text = "Need Help?";
            // 
            // highlighter
            // 
            this.highlighter.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(60, 17);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(213, 189);
            this.reflectionImage1.TabIndex = 19;
            // 
            // SlideLogin
            // 
            this.AnimationTime = 500;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.link_help);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tb_uid);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.reflectionImage1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SlideLogin";
            this.Size = new System.Drawing.Size(333, 414);
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_si;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_uid;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pwd;
        private System.Windows.Forms.LinkLabel link_help;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;


    }
}