namespace Mgke_Component_Accounting
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Login = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 329);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mgke_Component_Accounting.Properties.Resources.Blue1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Error);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Pass);
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.transition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(376, 329);
            this.panel2.MinimumSize = new System.Drawing.Size(364, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 329);
            this.panel2.TabIndex = 1;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error.Location = new System.Drawing.Point(92, 205);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(263, 13);
            this.Error.TabIndex = 15;
            this.Error.Text = "Неверный Пароль или Логин. Повторите попытку.";
            this.Error.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 1);
            this.panel7.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 1);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(375, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 329);
            this.panel3.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 1);
            this.panel5.TabIndex = 7;
            // 
            // Pass
            // 
            this.Pass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Pass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Pass.BorderThickness = 3;
            this.Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Pass.isPassword = false;
            this.Pass.Location = new System.Drawing.Point(90, 154);
            this.Pass.Margin = new System.Windows.Forms.Padding(4);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(262, 45);
            this.Pass.TabIndex = 11;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pass.OnValueChanged += new System.EventHandler(this.Pass_OnValueChanged);
            // 
            // Login
            // 
            this.Login.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Login.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Login.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Login.BorderThickness = 3;
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.Login.isPassword = false;
            this.Login.Location = new System.Drawing.Point(90, 98);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(262, 45);
            this.Login.TabIndex = 10;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login.OnValueChanged += new System.EventHandler(this.Login_OnValueChanged);
            // 
            // Exit
            // 
            this.Exit.Activecolor = System.Drawing.Color.White;
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.BorderRadius = 0;
            this.Exit.ButtonText = "";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DisabledColor = System.Drawing.Color.White;
            this.Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit.Iconimage = global::Mgke_Component_Accounting.Properties.Resources.delete_64pxBlue;
            this.Exit.Iconimage_right = null;
            this.Exit.Iconimage_right_Selected = null;
            this.Exit.Iconimage_Selected = null;
            this.Exit.IconMarginLeft = 0;
            this.Exit.IconMarginRight = 0;
            this.Exit.IconRightVisible = true;
            this.Exit.IconRightZoom = 0D;
            this.Exit.IconVisible = true;
            this.Exit.IconZoom = 60D;
            this.Exit.IsTab = false;
            this.Exit.Location = new System.Drawing.Point(317, 8);
            this.Exit.Name = "Exit";
            this.Exit.Normalcolor = System.Drawing.Color.White;
            this.Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit.selected = false;
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 9;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Textcolor = System.Drawing.Color.White;
            this.Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // transition
            // 
            this.transition.Activecolor = System.Drawing.Color.White;
            this.transition.BackColor = System.Drawing.Color.White;
            this.transition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.BorderRadius = 0;
            this.transition.ButtonText = "Войти";
            this.transition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.transition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.transition.Iconcolor = System.Drawing.Color.Transparent;
            this.transition.Iconimage = null;
            this.transition.Iconimage_right = null;
            this.transition.Iconimage_right_Selected = null;
            this.transition.Iconimage_Selected = null;
            this.transition.IconMarginLeft = 0;
            this.transition.IconMarginRight = 0;
            this.transition.IconRightVisible = true;
            this.transition.IconRightZoom = 0D;
            this.transition.IconVisible = true;
            this.transition.IconZoom = 90D;
            this.transition.IsTab = false;
            this.transition.Location = new System.Drawing.Point(218, 260);
            this.transition.Name = "transition";
            this.transition.Normalcolor = System.Drawing.Color.White;
            this.transition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.transition.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.transition.selected = false;
            this.transition.Size = new System.Drawing.Size(134, 57);
            this.transition.TabIndex = 6;
            this.transition.Text = "Войти";
            this.transition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transition.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.transition.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transition.Click += new System.EventHandler(this.transition_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pictureBox1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(617, 329);
            this.MinimumSize = new System.Drawing.Size(617, 329);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton transition;
        private Bunifu.Framework.UI.BunifuFlatButton Exit;
        private Bunifu.Framework.UI.BunifuMetroTextbox Pass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label Error;
        public Bunifu.Framework.UI.BunifuMetroTextbox Login;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}