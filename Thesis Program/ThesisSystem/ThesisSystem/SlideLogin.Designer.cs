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
            this.tb_uid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_login = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            this.tb_uid.Location = new System.Drawing.Point(12, 311);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(245, 26);
            this.tb_uid.TabIndex = 14;
            this.tb_uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_uid.WatermarkColor = System.Drawing.Color.DimGray;
            this.tb_uid.WatermarkText = "Username";
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
            this.tb_pwd.Location = new System.Drawing.Point(12, 343);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(245, 26);
            this.tb_pwd.TabIndex = 15;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pwd.UseSystemPasswordChar = true;
            this.tb_pwd.WatermarkColor = System.Drawing.Color.DimGray;
            this.tb_pwd.WatermarkText = "Password";
            // 
            // link_help
            // 
            this.link_help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_help.AutoSize = true;
            this.link_help.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_help.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_help.Location = new System.Drawing.Point(182, 441);
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
            this.reflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(12, 62);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(245, 288);
            this.reflectionImage1.TabIndex = 19;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(12, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(245, 43);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Sign In";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_login.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btn_login.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_login.Location = new System.Drawing.Point(217, 375);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(40, 40);
            this.btn_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btn_login.Symbol = "";
            this.btn_login.SymbolSize = 35F;
            this.btn_login.TabIndex = 21;
            // 
            // SlideLogin
            // 
            this.AnimationTime = 500;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.link_help);
            this.Controls.Add(this.tb_uid);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.reflectionImage1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SlideLogin";
            this.Size = new System.Drawing.Size(268, 519);
            this.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_uid;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pwd;
        private System.Windows.Forms.LinkLabel link_help;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_login;


    }
}