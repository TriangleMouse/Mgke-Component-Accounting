namespace Mgke_Component_Accounting
{
    partial class Add
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.EditTab = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddTab = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelforBT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.addControl1 = new Mgke_Component_Accounting.AddControl();
            this.editControl1 = new Mgke_Component_Accounting.EditControl();
            this.panel1.SuspendLayout();
            this.PanelforBT.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditTab
            // 
            this.EditTab.ActiveBorderThickness = 1;
            this.EditTab.ActiveCornerRadius = 20;
            this.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.EditTab.ActiveForecolor = System.Drawing.Color.White;
            this.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.EditTab.BackColor = System.Drawing.Color.White;
            this.EditTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditTab.BackgroundImage")));
            this.EditTab.ButtonText = "Изменение данных";
            this.EditTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.EditTab.IdleBorderThickness = 1;
            this.EditTab.IdleCornerRadius = 20;
            this.EditTab.IdleFillColor = System.Drawing.Color.White;
            this.EditTab.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.EditTab.Location = new System.Drawing.Point(139, 0);
            this.EditTab.Margin = new System.Windows.Forms.Padding(5);
            this.EditTab.Name = "EditTab";
            this.EditTab.Size = new System.Drawing.Size(139, 60);
            this.EditTab.TabIndex = 3;
            this.EditTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditTab.Click += new System.EventHandler(this.EditTab_Click);
            // 
            // AddTab
            // 
            this.AddTab.ActiveBorderThickness = 1;
            this.AddTab.ActiveCornerRadius = 20;
            this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.AddTab.ActiveForecolor = System.Drawing.Color.White;
            this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.AddTab.BackColor = System.Drawing.Color.White;
            this.AddTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTab.BackgroundImage")));
            this.AddTab.ButtonText = "Добавление данных";
            this.AddTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.AddTab.IdleBorderThickness = 1;
            this.AddTab.IdleCornerRadius = 20;
            this.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.AddTab.IdleForecolor = System.Drawing.Color.White;
            this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.AddTab.Location = new System.Drawing.Point(0, 0);
            this.AddTab.Margin = new System.Windows.Forms.Padding(5);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(139, 60);
            this.AddTab.TabIndex = 4;
            this.AddTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelforBT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 67);
            this.panel1.TabIndex = 5;
            // 
            // PanelforBT
            // 
            this.PanelforBT.BackColor = System.Drawing.Color.White;
            this.PanelforBT.Controls.Add(this.EditTab);
            this.PanelforBT.Controls.Add(this.AddTab);
            this.PanelforBT.Location = new System.Drawing.Point(0, 0);
            this.PanelforBT.Name = "PanelforBT";
            this.PanelforBT.Size = new System.Drawing.Size(280, 56);
            this.PanelforBT.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(147)))), ((int)(((byte)(163)))));
            this.panel3.Controls.Add(this.MovePanel);
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 10);
            this.panel3.TabIndex = 6;
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(139, 10);
            this.MovePanel.TabIndex = 6;
            // 
            // addControl1
            // 
            this.addControl1.BackColor = System.Drawing.Color.White;
            this.addControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addControl1.Location = new System.Drawing.Point(0, 67);
            this.addControl1.Name = "addControl1";
            this.addControl1.Size = new System.Drawing.Size(940, 529);
            this.addControl1.TabIndex = 7;
            this.addControl1.Load += new System.EventHandler(this.addControl1_Load);
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.Color.White;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.Location = new System.Drawing.Point(0, 67);
            this.editControl1.Name = "editControl1";
            this.editControl1.Size = new System.Drawing.Size(940, 529);
            this.editControl1.TabIndex = 6;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addControl1);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(940, 596);
            this.panel1.ResumeLayout(false);
            this.PanelforBT.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel PanelforBT;
        public Bunifu.Framework.UI.BunifuThinButton2 EditTab;
        public Bunifu.Framework.UI.BunifuThinButton2 AddTab;
        private EditControl editControl1;
        private AddControl addControl1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel MovePanel;
    }
}
