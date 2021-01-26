using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Speech.Synthesis;

namespace Mgke_Component_Accounting
{
    public partial class Form1 : Form
    {
  


        public Form1()
        {
            InitializeComponent();
            
            bunifuiOSSwitch1.Value = false;
            help1.Hide();
            add1.Hide();
            view11.Show();
            view11.BringToFront();
            Right_PullOut_Panel.BringToFront();
            this.view11.ComboBoxDropdownDevices.Text = "Устройства(Все*)";
            this.view11.ComboBoxDropdownStatus.Text = "Статус(Все*)";
            Speaker.Value = false;



        }

        private bool isCollapsed = true;
        
            private void timer1_Tick(object sender, EventArgs e)
            {
                if (isCollapsed)
                {
                Right_PullOut_Panel.Width += 15;
                    if (Right_PullOut_Panel.Size == Right_PullOut_Panel.MaximumSize)
                    {

                        timer1.Stop();
                     this.MoveMenu.Iconimage = Properties.Resources.back_64px;
                    isCollapsed = false;
                    }

                }
                else
                {
                    Right_PullOut_Panel.Width -= 10;
                    if (Right_PullOut_Panel.Size == Right_PullOut_Panel.MinimumSize)
                    {
                    this.MoveMenu.Iconimage = Properties.Resources.menu_64px;
                    timer1.Stop();
                        isCollapsed = true;

                    }
                }
            }
        
        private void MoveMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Right_PullOut_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool but { get; set; }

        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();

        public string korpus;
        public string KorpusName;
        public string Name;
        public int n = 1;
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            
            if (bunifuiOSSwitch1.Value==false)
            {
                if (n == 1)
                {
                    n++;
                    StreamReader f = new StreamReader("Korpus.file");
                    while (!f.EndOfStream)
                    {
                        string s = f.ReadLine();
                        korpus = s;
                    }
                    f.Close();
                    
                    
                    if (korpus == " ='Кнорина' ")
                    {
                        
                        view11.ComboBoxKorpusDown.Visible = false;
                        view11.Korpus_value = " ='Кнорина' ";
                        add1.Korpus = " ='Кнорина' ";
                        this.view11.ComboBoxKorpusDown.Text = "Кнорина";
                        Korpus_NameTXT.Text = "Кнорина";
                        NameTXT.Text = "AdminKnor1";
                        KorpusTXT.Visible = true;
                        Korpus_NameTXT.Visible = true;
                    }
                    else if (korpus == " ='Казинца' ")
                    {
                        view11.ComboBoxKorpusDown.Visible = false;
                        view11.Korpus_value = " ='Казинца' ";
                        add1.Korpus = " ='Казинца' ";
                        this.view11.ComboBoxKorpusDown.Text = "Казинца";
                        Korpus_NameTXT.Text = "Казинца";
                        NameTXT.Text = "AdminKazin2";
                        KorpusTXT.Visible = true;
                        Korpus_NameTXT.Visible = true;
                    }
                    else if (korpus == " is NOT NULL ")
                    {
                        view11.ComboBoxKorpusDown.Visible = true;
                        view11.Korpus_value = " is NOT NULL ";
                        add1.Korpus = " is NOT NULL ";
                        this.view11.ComboBoxKorpusDown.Text = "Корпуса(Все*)";
                        Korpus_NameTXT.Visible = false;
                        NameTXT.Text = "Admin";
                        KorpusTXT.Visible = false;
                        Korpus_NameTXT.Visible = false;
                    }


                }

                add1.butt = false;
                view11.butt = false;
                add1.Switch();
                help1.BackColor = Color.White;
                this.help1.bunifuCustomTextbox1.BackColor = Color.White;
                this.help1.bunifuCustomTextbox1.ForeColor = Color.FromArgb(41, 57, 87);
                this.help1.label1.ForeColor = Color.White;

                this.TopPanel.BackColor = Color.White;
                
                this.panel9.BackColor = Color.White;
                this.Right_PullOut_Panel.BackColor = Color.FromArgb(42, 59, 89);
                this.Right_PullOut_TopPanel.BackColor = Color.FromArgb(42, 59, 89);
                this.Right_PullOut_Panel_For_Image.BackColor = Color.FromArgb(42, 59, 89);
                this.PictureName.Image = Properties.Resources.Blue1;

                this.Searcher.BackColor = Color.White;
                this.Searcher.ForeColor = Color.FromArgb(54, 75, 116);
                this.Searcher.BorderColor = Color.FromArgb(54, 75, 116);
                this.Searcher.FillColor = Color.White;
                this.Searcher.FocusedState.BorderColor = Color.FromArgb(54, 75, 116);
                this.Searcher.HoverState.BorderColor = Color.FromArgb(54, 75, 116);
                this.Searcher.PlaceholderForeColor = Color.FromArgb(54, 75, 116);
                this.Searcher.IconLeft = Properties.Resources.search_blue;

                this.Searcher.DisabledState.FillColor= Color.White;
                this.Searcher.DisabledState.BorderColor = Color.FromArgb(54, 75, 116);
                this.Searcher.DisabledState.ForeColor = Color.FromArgb(54, 75, 116);
                this.Searcher.DisabledState.PlaceholderForeColor = Color.FromArgb(54, 75, 116);

                this.BT_View_Divices.BackColor = Color.FromArgb(42, 59, 89);
                this.BT_View_Divices.DisabledColor = Color.FromArgb(42, 59, 89);
                this.BT_View_Divices.Activecolor = Color.FromArgb(42, 59, 89);
                this.BT_View_Divices.Normalcolor = Color.FromArgb(42, 59, 89);
                this.BT_View_Divices.OnHovercolor = Color.FromArgb(54, 75, 116);

                this.BT_Add_Devices.BackColor = Color.FromArgb(42, 59, 89);
                this.BT_Add_Devices.DisabledColor = Color.FromArgb(42, 59, 89);
                this.BT_Add_Devices.Activecolor = Color.FromArgb(42, 59, 89);
                this.BT_Add_Devices.Normalcolor = Color.FromArgb(42, 59, 89);
                this.BT_Add_Devices.OnHovercolor = Color.FromArgb(54, 75, 116);

                this.help.BackColor = Color.FromArgb(42, 59, 89);
                this.help.DisabledColor = Color.FromArgb(42, 59, 89);
                this.help.Activecolor = Color.FromArgb(42, 59, 89);
                this.help.Normalcolor = Color.FromArgb(42, 59, 89);
                this.help.OnHovercolor = Color.FromArgb(54, 75, 116);

                this.Logout.BackColor = Color.FromArgb(42, 59, 89);
                this.Logout.DisabledColor = Color.FromArgb(42, 59, 89);
                this.Logout.Activecolor = Color.FromArgb(42, 59, 89);
                this.Logout.Normalcolor = Color.FromArgb(42, 59, 89);
                this.Logout.OnHovercolor = Color.FromArgb(54, 75, 116);

                this.MoveMenu.BackColor = Color.FromArgb(42, 59, 89);
                this.MoveMenu.DisabledColor = Color.FromArgb(42, 59, 89);
                this.MoveMenu.Activecolor = Color.FromArgb(42, 59, 89);
                this.MoveMenu.Normalcolor = Color.FromArgb(42, 59, 89);
                this.MoveMenu.OnHovercolor = Color.FromArgb(54, 75, 116);

                this.bunifuFlatButton1.BackColor = Color.White;
                this.bunifuFlatButton1.DisabledColor = Color.White;
                this.bunifuFlatButton1.Activecolor = Color.White;
                this.bunifuFlatButton1.Normalcolor = Color.White;
                this.bunifuFlatButton1.OnHovercolor = Color.FromArgb(234, 233, 227);
                this.bunifuFlatButton1.Iconimage = Properties.Resources.subtract_64pxBlue;


                this.bunifuFlatButton2.BackColor = Color.White;
                this.bunifuFlatButton2.DisabledColor = Color.White;
                this.bunifuFlatButton2.Activecolor = Color.White;
                this.bunifuFlatButton2.Normalcolor = Color.White;
                this.bunifuFlatButton2.OnHovercolor = Color.FromArgb(234, 233, 227);
                this.bunifuFlatButton2.Iconimage = Properties.Resources.delete_64pxBlue;

                //add1.TabControl.Style = MetroFramework.MetroColorStyle.Blue;
                add1.BackColor = Color.White;
                
                add1.PanelforBT.BackColor = Color.White;
                add1.AddTab.BackColor = Color.White;
                add1.EditTab.BackColor = Color.White;
                add1.butt2 = add1.butt1;
                if (add1.butt2==false)
                {
                    
                    this.add1.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.IdleForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                    this.add1.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleFillColor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                }
                if (add1.butt2 == true)
                {
                    
                    this.add1.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.EditTab.IdleForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                    this.add1.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleFillColor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                    this.add1.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                }

                this.view11.BackColor = Color.White;


               this.view11.ComboBoxDropdownDevices.BackColor=Color.White;
                this.view11.ComboBoxDropdownDevices.FillColor = Color.White;
                this.view11.ComboBoxDropdownDevices.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownDevices.BorderColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.BackColor = Color.White;
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.SelectedForeColor = Color.White;

                this.view11.ComboBoxKorpusDown.BackColor = Color.White;
                this.view11.ComboBoxKorpusDown.FillColor = Color.White;
                this.view11.ComboBoxKorpusDown.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxKorpusDown.BorderColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.BackColor = Color.White;
                this.view11.ComboBoxKorpusDown.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.SelectedForeColor = Color.White;

                this.view11.ComboBoxDropdownStatus.BackColor = Color.White;
                this.view11.ComboBoxDropdownStatus.FillColor = Color.White;
                this.view11.ComboBoxDropdownStatus.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownStatus.BorderColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.BackColor = Color.White;
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.SelectedForeColor = Color.White;
                


                // 
                // Table
                // 

                this.view11.Table.AllowUserToAddRows = false;
                this.view11.Table.AllowUserToDeleteRows = false;
                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
                this.view11.Table.BackgroundColor = System.Drawing.Color.White;
                this.view11.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.view11.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.view11.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
                this.view11.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.view11.Table.DefaultCellStyle = dataGridViewCellStyle3;
                this.view11.Table.DoubleBuffered = false;
                this.view11.Table.EnableHeadersVisualStyles = false;
                this.view11.Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
                this.view11.Table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                this.view11.Table.HeaderForeColor = System.Drawing.Color.White;
                this.view11.Table.Location = new System.Drawing.Point(181, 26);
                this.view11.Table.Name = "Table";
                this.view11.Table.ReadOnly = true;
                this.view11.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
                dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.view11.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
                this.view11.Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.view11.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.view11.Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.view11.Table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.view11.Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.RowTemplate.Height = 30;
                this.view11.Table.Size = new System.Drawing.Size(733, 459);
                this.view11.Table.TabIndex = 12;


                this.view11.Inf.OnColor = Color.FromArgb(42, 59, 89);

                this.add1.MovePanel.BackColor = Color.FromArgb(42, 59, 89);
                this.add1.panel3.BackColor = Color.FromArgb(138, 147, 163);
                this.view11.Podrobo.ForeColor = Color.FromArgb(42, 59, 89);
                HelloTxt.ForeColor = Color.FromArgb(54, 75, 116);
                NameTXT.ForeColor = Color.FromArgb(54, 75, 116);
                KorpusTXT.ForeColor = Color.FromArgb(54, 75, 116);
                Korpus_NameTXT.ForeColor = Color.FromArgb(54, 75, 116);
            }
            if (bunifuiOSSwitch1.Value == true)
            {

                add1.butt = true;
                view11.butt = true; add1.Switch();
                this.help1.BackColor = Color.FromArgb(45, 45, 48);
                this.help1.bunifuCustomTextbox1.BackColor = Color.FromArgb(45, 45, 48);
                this.help1.bunifuCustomTextbox1.ForeColor = Color.FromArgb(216, 20, 11);
                this.help1.label1.ForeColor = Color.FromArgb(45, 45, 48);

                this.TopPanel.BackColor = Color.FromArgb(45, 45, 48);
                this.panel9.BackColor = Color.FromArgb(45, 45, 48);
                this.Right_PullOut_Panel.BackColor = Color.FromArgb(200, 0, 25);
                this.Right_PullOut_TopPanel.BackColor = Color.FromArgb(200, 0, 25);
                this.Right_PullOut_Panel_For_Image.BackColor = Color.FromArgb(200, 0, 25);
                this.PictureName.Image = Properties.Resources.Red11;
                
               
                this.Searcher.BackColor = Color.FromArgb(45, 45, 48);
                this.Searcher.ForeColor = Color.FromArgb(200, 0, 25);
                this.Searcher.BorderColor = Color.FromArgb(200, 0, 25);
                this.Searcher.FillColor = Color.FromArgb(45, 45, 48);
                this.Searcher.FocusedState.BorderColor = Color.FromArgb(200, 0, 25);
                this.Searcher.HoverState.BorderColor = Color.FromArgb(200, 0, 25);
                this.Searcher.PlaceholderForeColor = Color.FromArgb(200, 0, 25);
                this.Searcher.IconLeft = Properties.Resources.search_red;
                this.Searcher.DisabledState.FillColor = Color.FromArgb(45, 45, 48);
                this.Searcher.DisabledState.BorderColor = Color.FromArgb(200, 0, 25);
                this.Searcher.DisabledState.ForeColor = Color.FromArgb(200, 0, 25);
                this.Searcher.DisabledState.PlaceholderForeColor = Color.FromArgb(200, 0, 25);

                this.MoveMenu.BackColor = Color.FromArgb(200, 0, 25);
                this.MoveMenu.DisabledColor = Color.FromArgb(200, 0, 25);
                this.MoveMenu.Activecolor = Color.FromArgb(200, 0, 25);
                this.MoveMenu.Normalcolor = Color.FromArgb(200, 0, 25);
                this.MoveMenu.OnHovercolor = Color.FromArgb(168, 0, 0);

                this.BT_View_Divices.BackColor = Color.FromArgb(200, 0, 25);
                this.BT_View_Divices.DisabledColor = Color.FromArgb(200, 0, 25);
                this.BT_View_Divices.Activecolor = Color.FromArgb(200, 0, 25);
                this.BT_View_Divices.Normalcolor = Color.FromArgb(200, 0, 25);
                this.BT_View_Divices.OnHovercolor = Color.FromArgb(168, 0, 0);

                this.BT_Add_Devices.BackColor = Color.FromArgb(200, 0, 25);
                this.BT_Add_Devices.DisabledColor = Color.FromArgb(200, 0, 25);
                this.BT_Add_Devices.Activecolor = Color.FromArgb(200, 0, 25);
                this.BT_Add_Devices.Normalcolor = Color.FromArgb(200, 0, 25);
                this.BT_Add_Devices.OnHovercolor = Color.FromArgb(168, 0, 0);

                this.help.BackColor = Color.FromArgb(200, 0, 25);
                this.help.DisabledColor = Color.FromArgb(200, 0, 25);
                this.help.Activecolor = Color.FromArgb(200, 0, 25);
                this.help.Normalcolor = Color.FromArgb(200, 0, 25);
                this.help.OnHovercolor = Color.FromArgb(168, 0, 0);

                this.Logout.BackColor = Color.FromArgb(200, 0, 25);
                this.Logout.DisabledColor = Color.FromArgb(200, 0, 25);
                this.Logout.Activecolor = Color.FromArgb(200, 0, 25);
                this.Logout.Normalcolor = Color.FromArgb(200, 0, 25);
                this.Logout.OnHovercolor = Color.FromArgb(168, 0, 0);

                this.bunifuFlatButton1.BackColor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton1.DisabledColor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton1.Activecolor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton1.Normalcolor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton1.OnHovercolor = Color.FromArgb(30, 30, 32);
                this.bunifuFlatButton1.Iconimage = Properties.Resources.subtract_64px;

                this.bunifuFlatButton2.BackColor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton2.DisabledColor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton2.Activecolor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton2.Normalcolor = Color.FromArgb(45, 45, 48);
                this.bunifuFlatButton2.OnHovercolor = Color.FromArgb(30, 30, 32);
                this.bunifuFlatButton2.Iconimage = Properties.Resources.delete_64px;

                add1.BackColor = Color.FromArgb(45, 45, 48);
                add1.PanelforBT.BackColor = Color.FromArgb(45, 45, 48);
                add1.AddTab.BackColor = Color.FromArgb(45, 45, 48);
                add1.EditTab.BackColor = Color.FromArgb(45, 45, 48);
               add1.butt1 = add1.butt2;
                if (add1.butt1 == false)
                {
                    
                    this.add1.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.IdleForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);

                    this.add1.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                    this.add1.EditTab.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                }
                if (add1.butt1 == true)
                {
                    
                    this.add1.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.EditTab.IdleForecolor = System.Drawing.Color.White;
                    this.add1.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);

                    this.add1.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.ActiveForecolor = System.Drawing.Color.White;
                    this.add1.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                    this.add1.AddTab.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                    this.add1.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                }

                this.view11.BackColor = Color.FromArgb(45, 45, 48);

                this.view11.ComboBoxDropdownDevices.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownDevices.FillColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownDevices.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownDevices.BorderColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.view11.ComboBoxDropdownDevices.ItemsAppearance.SelectedForeColor = Color.White;

                this.view11.ComboBoxKorpusDown.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxKorpusDown.FillColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxKorpusDown.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxKorpusDown.BorderColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.view11.ComboBoxKorpusDown.ItemsAppearance.SelectedForeColor = Color.White;

                this.view11.ComboBoxDropdownStatus.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownStatus.FillColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownStatus.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownStatus.BorderColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.view11.ComboBoxDropdownStatus.ItemsAppearance.SelectedForeColor = Color.White;



                // 
                // Table
                // 
                this.view11.Table.AllowUserToAddRows = false;
                this.view11.Table.AllowUserToDeleteRows = false;

                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

                this.view11.Table.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.view11.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.view11.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

                dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.view11.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

                this.view11.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.view11.Table.DefaultCellStyle = dataGridViewCellStyle3;

                this.view11.Table.DoubleBuffered = false;
                this.view11.Table.EnableHeadersVisualStyles = false;
                this.view11.Table.GridColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.view11.Table.HeaderBgColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.view11.Table.HeaderForeColor = System.Drawing.Color.White;
                this.view11.Table.Location = new System.Drawing.Point(181, 26);
                this.view11.Table.Name = "Table";
                this.view11.Table.ReadOnly = true;
                this.view11.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

                dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(128, 0, 0);
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.view11.Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;

                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.RowsDefaultCellStyle = dataGridViewCellStyle5;

                this.view11.Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.view11.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.view11.Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.view11.Table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.view11.Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                this.view11.Table.RowTemplate.Height = 30;
                this.view11.Table.Size = new System.Drawing.Size(733, 459);
                this.view11.Table.TabIndex = 12;


                this.view11.Inf.OnColor = Color.FromArgb(168, 0, 0);


                this.add1.MovePanel.BackColor = Color.FromArgb(168, 0, 0);
                this.add1.panel3.BackColor = Color.FromArgb(62, 62, 66);
                this.view11.Podrobo.ForeColor = Color.FromArgb(200, 0, 25);
                HelloTxt.ForeColor = Color.FromArgb(200, 0, 25);
                NameTXT.ForeColor = Color.FromArgb(200, 0, 25);
                KorpusTXT.ForeColor = Color.FromArgb(200, 0, 25);
                Korpus_NameTXT.ForeColor = Color.FromArgb(200, 0, 25);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_View_Divices_Click(object sender, EventArgs e)
        {
            if (Speaker.Value == true)
            {
                speechSynth.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = BT_View_Divices.Text;
                view11.volume = TrackBar.Value;
                view11.speak = speak;
                view11.checkspeak = checkspeak;

                if (speak != checkspeak)
                    Speaker_True();
            }
            Searcher.Enabled =true;
            help1.Hide();
            add1.Hide();
            view11.Show();
            view11.BringToFront();
            Searcher.Text = "";view11.View1_Load(null, null);
            view11.Table.Refresh();
            if (bunifuiOSSwitch1.Value == false) {
                BT_Add_Devices.Normalcolor = Color.FromArgb(42, 59, 89);
                BT_View_Divices.Normalcolor = Color.FromArgb(54, 75, 116);
                help.Normalcolor = Color.FromArgb(42, 59, 89);
            }
            if (bunifuiOSSwitch1.Value == true) {
                BT_Add_Devices.Normalcolor = Color.FromArgb(200, 0, 25);
                BT_View_Divices.Normalcolor = Color.FromArgb(168, 0, 0);
                help.Normalcolor = Color.FromArgb(200, 0, 25);
            }
           


        }

        private void BT_Add_Devices_Click(object sender, EventArgs e)
        {
           if (Speaker.Value == true)
            {
                
                speechSynth.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = BT_Add_Devices.Text;
                if(speak!= checkspeak)
                {
                    Speaker_True();
                    add1.volume = TrackBar.Value;
                    add1.speak = speak; 
                    add1.checkspeak = checkspeak;
                }
                
            }
            Searcher.Text = "";
            Searcher.Enabled = false;
            help1.Hide();
            view11.Hide();
            add1.Show();
            add1.BringToFront();

            if (bunifuiOSSwitch1.Value == false)
            {
                BT_Add_Devices.Normalcolor = Color.FromArgb(54, 75, 116);
                BT_View_Divices.Normalcolor = Color.FromArgb(42, 59, 89);
                help.Normalcolor = Color.FromArgb(42, 59, 89);
            }
            if (bunifuiOSSwitch1.Value == true)
            {
                BT_Add_Devices.Normalcolor = Color.FromArgb(168, 0, 0);
                BT_View_Divices.Normalcolor = Color.FromArgb(200, 0, 25);
                help.Normalcolor = Color.FromArgb(200, 0, 25);
            }
            

        }

        private void help_Click(object sender, EventArgs e)
        {
           if (Speaker.Value == true)
            {
                speechSynth.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = help.Text; 
                
               
                if (speak != checkspeak)
                    Speaker_True();
            }
            Searcher.Text = "";
            Searcher.Enabled = false;
            view11.Hide();
            add1.Hide();
            help1.Show();
            help1.BringToFront();

            if (bunifuiOSSwitch1.Value == false)
            {
                BT_Add_Devices.Normalcolor = Color.FromArgb(42, 59, 89);
                BT_View_Divices.Normalcolor = Color.FromArgb(42, 59, 89);
                help.Normalcolor = Color.FromArgb(54, 75, 116);
            }
            if (bunifuiOSSwitch1.Value == true)
            {
                BT_Add_Devices.Normalcolor = Color.FromArgb(200, 0, 25);
                BT_View_Divices.Normalcolor = Color.FromArgb(200, 0, 25);
                help.Normalcolor = Color.FromArgb(168, 0, 0);
            }
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Searcher.Text = "";
            Authorization authorization = new Authorization();
            this.Hide();
            Form1 f1 = new Form1();

            f1.Close();
            authorization.ShowDialog();
            this.Show();
        }

     


    
        private void Searcher_TextChanged(object sender, EventArgs e)
        {
            view11.Search_value = Searcher.Text;
            if (perehod == true)
            {

                speechSynth.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = Searcher.PlaceholderText;



                if (speak != checkspeak)
                {
                    checkspeak = "";
                    Speaker_True();
                }
            }
            if (view11.check == true)
            {
                view11.Inf_OnValueChange(null, null);
            }
            if (view11.check == false)
            {
                view11.Dop_infa();
            }
        }
        public string speak = "Режим для людей с ограниченным зрением включён";
        public string checkspeak = "";
        public SpeechSynthesizer speechSynth = new SpeechSynthesizer();// создаём объект
        public bool perehod;
        public void Speaker_True()
        {
             
            speechSynth.Volume = TrackBar.Value; // устанавливаем уровень звука

            speechSynth.SpeakAsync(speak); // озвучиваем переданный текст
            
        }
        public void Speaker_OnValueChange(object sender, EventArgs e)
        {
            if (Speaker.Value == false)
            {
                TrackBar.Visible = false;add1.perehod = false; view11.perehod = false;
            }
            if (Speaker.Value == true)
            {
                TrackBar.Visible = true; Speaker_True();
                add1.perehod = true;
                view11.perehod = true;
            }
        }
    }
}
