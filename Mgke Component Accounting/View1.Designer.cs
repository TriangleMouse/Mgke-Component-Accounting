namespace Mgke_Component_Accounting
{
    partial class View1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View1));
            this.Table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Podrobo = new System.Windows.Forms.Label();
            this.ComboBoxDropdownDevices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxDropdownStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxKorpusDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Inf = new Bunifu.Framework.UI.BunifuiOSSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Table.DoubleBuffered = false;
            this.Table.EnableHeadersVisualStyles = false;
            this.Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
            this.Table.HeaderForeColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(181, 26);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            this.Table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
            this.Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Table.RowTemplate.Height = 30;
            this.Table.Size = new System.Drawing.Size(745, 498);
            this.Table.TabIndex = 12;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            this.Table.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Table_CellFormatting);
            // 
            // Podrobo
            // 
            this.Podrobo.AutoSize = true;
            this.Podrobo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Podrobo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.Podrobo.Location = new System.Drawing.Point(5, 459);
            this.Podrobo.Name = "Podrobo";
            this.Podrobo.Size = new System.Drawing.Size(98, 34);
            this.Podrobo.TabIndex = 20;
            this.Podrobo.Text = " Подробная\r\nинформация";
            // 
            // ComboBoxDropdownDevices
            // 
            this.ComboBoxDropdownDevices.BackColor = System.Drawing.Color.White;
            this.ComboBoxDropdownDevices.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxDropdownDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxDropdownDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDropdownDevices.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxDropdownDevices.FocusedState.Parent = this.ComboBoxDropdownDevices;
            this.ComboBoxDropdownDevices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxDropdownDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxDropdownDevices.FormattingEnabled = true;
            this.ComboBoxDropdownDevices.HoverState.Parent = this.ComboBoxDropdownDevices;
            this.ComboBoxDropdownDevices.ItemHeight = 30;
            this.ComboBoxDropdownDevices.Items.AddRange(new object[] {
            "Устройства(Все*)",
            "Материнская плата",
            "Видеокарта",
            "Процессор",
            "Блок питания",
            "Жесткий диск",
            "Монитор",
            "Оперативная память",
            "Периферийные устройства"});
            this.ComboBoxDropdownDevices.ItemsAppearance.BackColor = System.Drawing.Color.Gray;
            this.ComboBoxDropdownDevices.ItemsAppearance.Parent = this.ComboBoxDropdownDevices;
            this.ComboBoxDropdownDevices.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Red;
            this.ComboBoxDropdownDevices.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Lime;
            this.ComboBoxDropdownDevices.Location = new System.Drawing.Point(8, 78);
            this.ComboBoxDropdownDevices.Name = "ComboBoxDropdownDevices";
            this.ComboBoxDropdownDevices.ShadowDecoration.Parent = this.ComboBoxDropdownDevices;
            this.ComboBoxDropdownDevices.Size = new System.Drawing.Size(167, 36);
            this.ComboBoxDropdownDevices.TabIndex = 22;
            this.ComboBoxDropdownDevices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDropdownDevices_SelectedIndexChanged);
            // 
            // ComboBoxDropdownStatus
            // 
            this.ComboBoxDropdownStatus.BackColor = System.Drawing.Color.White;
            this.ComboBoxDropdownStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxDropdownStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxDropdownStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDropdownStatus.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxDropdownStatus.FocusedState.Parent = this.ComboBoxDropdownStatus;
            this.ComboBoxDropdownStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ComboBoxDropdownStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxDropdownStatus.FormattingEnabled = true;
            this.ComboBoxDropdownStatus.HoverState.Parent = this.ComboBoxDropdownStatus;
            this.ComboBoxDropdownStatus.ItemHeight = 30;
            this.ComboBoxDropdownStatus.Items.AddRange(new object[] {
            "Статус(Все*)",
            "Эксплуатация",
            "Утилизация",
            "Ремонт",
            "Хранение"});
            this.ComboBoxDropdownStatus.ItemsAppearance.Parent = this.ComboBoxDropdownStatus;
            this.ComboBoxDropdownStatus.Location = new System.Drawing.Point(8, 36);
            this.ComboBoxDropdownStatus.Name = "ComboBoxDropdownStatus";
            this.ComboBoxDropdownStatus.ShadowDecoration.Parent = this.ComboBoxDropdownStatus;
            this.ComboBoxDropdownStatus.Size = new System.Drawing.Size(167, 36);
            this.ComboBoxDropdownStatus.TabIndex = 23;
            this.ComboBoxDropdownStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDropdownStatus_SelectedIndexChanged);
            // 
            // ComboBoxKorpusDown
            // 
            this.ComboBoxKorpusDown.BackColor = System.Drawing.Color.White;
            this.ComboBoxKorpusDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxKorpusDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxKorpusDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKorpusDown.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxKorpusDown.FocusedState.Parent = this.ComboBoxKorpusDown;
            this.ComboBoxKorpusDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxKorpusDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(87)))));
            this.ComboBoxKorpusDown.FormattingEnabled = true;
            this.ComboBoxKorpusDown.HoverState.Parent = this.ComboBoxKorpusDown;
            this.ComboBoxKorpusDown.ItemHeight = 30;
            this.ComboBoxKorpusDown.Items.AddRange(new object[] {
            "Корпуса(Все*)",
            "Казинца",
            "Кнорина"});
            this.ComboBoxKorpusDown.ItemsAppearance.Parent = this.ComboBoxKorpusDown;
            this.ComboBoxKorpusDown.Location = new System.Drawing.Point(8, 120);
            this.ComboBoxKorpusDown.Name = "ComboBoxKorpusDown";
            this.ComboBoxKorpusDown.ShadowDecoration.Parent = this.ComboBoxKorpusDown;
            this.ComboBoxKorpusDown.Size = new System.Drawing.Size(167, 36);
            this.ComboBoxKorpusDown.TabIndex = 24;
            this.ComboBoxKorpusDown.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKorpusDown_SelectedIndexChanged);
            // 
            // Inf
            // 
            this.Inf.BackColor = System.Drawing.Color.Transparent;
            this.Inf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inf.BackgroundImage")));
            this.Inf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inf.Location = new System.Drawing.Point(109, 466);
            this.Inf.Name = "Inf";
            this.Inf.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.Inf.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(89)))));
            this.Inf.Size = new System.Drawing.Size(35, 20);
            this.Inf.TabIndex = 16;
            this.Inf.Value = false;
            this.Inf.OnValueChange += new System.EventHandler(this.Inf_OnValueChange);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ComboBoxKorpusDown);
            this.Controls.Add(this.ComboBoxDropdownStatus);
            this.Controls.Add(this.ComboBoxDropdownDevices);
            this.Controls.Add(this.Podrobo);
            this.Controls.Add(this.Inf);
            this.Controls.Add(this.Table);
            this.Name = "View1";
            this.Size = new System.Drawing.Size(940, 596);
            this.Load += new System.EventHandler(this.View1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid Table;
        public Bunifu.Framework.UI.BunifuiOSSwitch Inf;
        public System.Windows.Forms.Label Podrobo;
        public Guna.UI2.WinForms.Guna2ComboBox ComboBoxDropdownStatus;
        public Guna.UI2.WinForms.Guna2ComboBox ComboBoxKorpusDown;
        public Guna.UI2.WinForms.Guna2ComboBox ComboBoxDropdownDevices;
    }
}
