using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;

namespace Mgke_Component_Accounting
{
    public partial class Add : UserControl
    {
        public string Korpus;
        public Add()
        {
            //Form1 f = new Form1();
            InitializeComponent();
            this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
            this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
            this.AddTab.ActiveForecolor = System.Drawing.Color.White;
            this.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
            this.AddTab.IdleForecolor = System.Drawing.Color.White;
            this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

        }
        // public Form1 f = new Form1();
        public bool butt;
        public bool butt1;
        public bool butt2; public bool perehod;
        public string speak = "";
        public string checkspeak = "";
        public SpeechSynthesizer speechSynth1 = new SpeechSynthesizer();// создаём объект
        public int volume;
  
        private void AddTab_Click(object sender, EventArgs e)
        {
           
            if (perehod == true)
            {
                
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
               speak = AddTab.ButtonText;
                addControl1.perehod = perehod;
               addControl1.volume = volume;
                addControl1.speak = speak;
                addControl1.checkspeak = checkspeak;
                if (speak != checkspeak)
                    Speaker_True();
            }
            editControl1.Hide();
            addControl1.Show();
            MovePanel.Location = new Point(0, 0);
            if (butt == false)
            {
                butt2 = false;
                this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.ActiveForecolor = System.Drawing.Color.White;
                this.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.IdleForecolor = System.Drawing.Color.White;
                this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                this.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.ActiveForecolor = System.Drawing.Color.White;
                this.EditTab.IdleFillColor = System.Drawing.Color.White;
                this.EditTab.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
            }
            if (butt == true)
            {
                butt1 = false;
                this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.ActiveForecolor = System.Drawing.Color.White;
                this.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.IdleForecolor = System.Drawing.Color.White;
                this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);

                this.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.ActiveForecolor = System.Drawing.Color.White;
                this.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.EditTab.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
            }

        }

        private void EditTab_Click(object sender, EventArgs e)
        {
            
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = EditTab.ButtonText;
                editControl1.volume = volume;
                editControl1.speak = speak;
                editControl1.checkspeak = checkspeak;
                editControl1.perehod = perehod;
                if (speak != checkspeak)
                {
                    Speaker_True();
                }
                    
            }
            addControl1.Hide();
            editControl1.Show();
            MovePanel.Location = new Point(141, 0);
            if (butt == false)
            {
                butt2 = true;
                this.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.ActiveForecolor = System.Drawing.Color.White;
                this.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.EditTab.IdleForecolor = System.Drawing.Color.White;
                this.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.ActiveForecolor = System.Drawing.Color.White;
                this.AddTab.IdleFillColor = System.Drawing.Color.White;
                this.AddTab.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
            }
            if (butt == true)
            {
                butt1 = true;
                this.EditTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.ActiveForecolor = System.Drawing.Color.White;
                this.EditTab.IdleFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.EditTab.IdleForecolor = System.Drawing.Color.White;
                this.EditTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);

                this.AddTab.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.ActiveForecolor = System.Drawing.Color.White;
                this.AddTab.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.AddTab.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.AddTab.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
            }

        }

        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        int n = 1;
        public void Switch()
        {
            
            if (butt == false)
            {if (n == 1) { 
                if (Korpus == " ='Кнорина' ")
                {
                    addControl1.ComboBoxAddKorpusDown.Text = "Кнорина";
                    addControl1.ComboBoxAddKorpusDown.Visible = false;
                    addControl1.Korpus = "Кнорина";
                    editControl1.Korpus = " ='Кнорина' ";
                }
                else if (Korpus == " ='Казинца' ")
                {
                    addControl1.ComboBoxAddKorpusDown.Text = "Казинца";
                    addControl1.ComboBoxAddKorpusDown.Visible = false;
                    addControl1.Korpus = "Казинца";
                    editControl1.Korpus = " ='Казинца' ";
                }
                else if (Korpus == " is NOT NULL ")
                {
                    addControl1.ComboBoxAddKorpusDown.Text = "Казинца";
                    addControl1.ComboBoxAddKorpusDown.Visible = true;
                    editControl1.Korpus = " is NOT NULL ";
                }
                    n++;
                }
                editControl1.butt = false;

                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.EditTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
                this.editControl1.EditTable.BackgroundColor = System.Drawing.Color.White;


                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.EditTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
                this.editControl1.EditTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.editControl1.EditTable.DefaultCellStyle = dataGridViewCellStyle3;

                this.editControl1.EditTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
                this.editControl1.EditTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                this.editControl1.EditTable.HeaderForeColor = System.Drawing.Color.White;


                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.EditTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.EditTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;





                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.TableDelete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
                this.editControl1.TableDelete.BackgroundColor = System.Drawing.Color.White;

                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.TableDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.editControl1.TableDelete.DefaultCellStyle = dataGridViewCellStyle3;

                this.editControl1.TableDelete.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
                this.editControl1.TableDelete.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                this.editControl1.TableDelete.HeaderForeColor = System.Drawing.Color.White;

                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(116)))));
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.TableDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.TableDelete.RowsDefaultCellStyle = dataGridViewCellStyle5;
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;



                this.editControl1.BackColor = Color.White;
                this.addControl1.BackColor = Color.White;
                this.editControl1.SearcherDeleteZapis.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherDeleteZapis.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherDeleteZapis.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.SearcherDeleteZapis.IdleFillColor = System.Drawing.Color.White;
                this.editControl1.SearcherDeleteZapis.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherDeleteZapis.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                this.editControl1.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                this.editControl1.SearcherEditZapis.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherEditZapis.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherEditZapis.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.SearcherEditZapis.IdleFillColor = System.Drawing.Color.White;
                this.editControl1.SearcherEditZapis.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.SearcherEditZapis.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);

                this.editControl1.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.editControl1.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);


                this.editControl1.Textdel.ForeColor = Color.FromArgb(42, 59, 89);
                this.editControl1.Textedit.ForeColor = Color.FromArgb(42, 59, 89);



                this.editControl1.SearcherDelete.BackColor = Color.White;
                this.editControl1.SearcherDelete.ForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.FillColor = Color.White;
                this.editControl1.SearcherDelete.FocusedState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.HoverState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.PlaceholderForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.IconLeft = Properties.Resources.search_blue;

                this.editControl1.SearcherDelete.DisabledState.FillColor = Color.White;
                this.editControl1.SearcherDelete.DisabledState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.DisabledState.ForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherDelete.DisabledState.PlaceholderForeColor = Color.FromArgb(54, 75, 116);

                this.editControl1.SearcherEdit.BackColor = Color.White;
                this.editControl1.SearcherEdit.ForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.FillColor = Color.White;
                this.editControl1.SearcherEdit.FocusedState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.HoverState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.PlaceholderForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.IconLeft = Properties.Resources.search_blue;

                this.editControl1.SearcherEdit.DisabledState.FillColor = Color.White;
                this.editControl1.SearcherEdit.DisabledState.BorderColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.DisabledState.ForeColor = Color.FromArgb(54, 75, 116);
                this.editControl1.SearcherEdit.DisabledState.PlaceholderForeColor = Color.FromArgb(54, 75, 116);


                this.addControl1.BtAdd.ActiveFillColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.addControl1.BtAdd.ActiveLineColor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.addControl1.BtAdd.ActiveForecolor = System.Drawing.Color.White;
                this.addControl1.BtAdd.IdleFillColor = System.Drawing.Color.White;
                this.addControl1.BtAdd.IdleForecolor = System.Drawing.Color.FromArgb(42, 59, 89);
                this.addControl1.BtAdd.IdleLineColor = System.Drawing.Color.FromArgb(42, 59, 89);




                this.addControl1.label1.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label2.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label3.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label4.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label5.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label6.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label7.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label11.ForeColor = Color.FromArgb(42, 59, 89);

                this.addControl1.label22.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label33.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label44.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label55.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label66.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label77.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.label88.ForeColor = Color.FromArgb(42, 59, 89);

                this.addControl1.Nazv.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Nazv.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Nazv.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Nazv.ForeColor = Color.FromArgb(41, 57, 87);

                this.addControl1.Proizv.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Proizv.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Proizv.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Proizv.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Shirina.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Shirina.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Shirina.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Shirina.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Dlina.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Dlina.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Dlina.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Dlina.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Etazh.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Etazh.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Etazh.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Etazh.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Kabin.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Kabin.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Kabin.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Kabin.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.FIOOO.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.FIOOO.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.FIOOO.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.FIOOO.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach11.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach11.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach11.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach11.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach22.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach22.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach22.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach22.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach33.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach33.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach33.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach33.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach44.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach44.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach44.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach44.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach55.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach55.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach55.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach55.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach66.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach66.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach66.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach66.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach77.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach77.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach77.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach77.ForeColor = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach88.BorderColorFocused = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach88.BorderColorIdle = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach88.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
                this.addControl1.Znach88.ForeColor = Color.FromArgb(41, 57, 87);

                this.addControl1.ComboBoxAddDropdownDevices.BackColor = Color.White;
                this.addControl1.ComboBoxAddDropdownDevices.FillColor = Color.White;
                this.addControl1.ComboBoxAddDropdownDevices.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownDevices.BorderColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.BackColor = Color.White;
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.SelectedForeColor = Color.White;

                this.addControl1.ComboBoxAddKorpusDown.BackColor = Color.White;
                this.addControl1.ComboBoxAddKorpusDown.FillColor = Color.White;
                this.addControl1.ComboBoxAddKorpusDown.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddKorpusDown.BorderColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.BackColor = Color.White;
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.SelectedForeColor = Color.White;

                this.addControl1.ComboBoxAddDropdownStatus.BackColor = Color.White;
                this.addControl1.ComboBoxAddDropdownStatus.FillColor = Color.White;
                this.addControl1.ComboBoxAddDropdownStatus.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownStatus.BorderColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.BackColor = Color.White;
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.ForeColor = Color.FromArgb(42, 59, 89);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.SelectedBackColor = Color.FromArgb(57, 72, 100);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.SelectedForeColor = Color.White;

            }
            if (butt == true)
            {

                if (n == 1)
                {
                    if (Korpus == " ='Кнорина' ")
                    {
                        addControl1.ComboBoxAddKorpusDown.Text = "Кнорина";
                        addControl1.ComboBoxAddKorpusDown.Visible = false;
                        addControl1.Korpus = "Кнорина";
                        editControl1.Korpus = " ='Кнорина' ";
                    }
                    else if (Korpus == " ='Казинца' ")
                    {
                        addControl1.ComboBoxAddKorpusDown.Text = "Казинца";
                        addControl1.ComboBoxAddKorpusDown.Visible = false;
                        addControl1.Korpus = "Казинца";
                        editControl1.Korpus = " ='Казинца' ";
                    }
                    else if (Korpus == " is NOT NULL ")
                    {
                        addControl1.ComboBoxAddKorpusDown.Text = "Казинца";
                        addControl1.ComboBoxAddKorpusDown.Visible = true;
                        editControl1.Korpus = " is NOT NULL ";
                    }
                    n++;
                }

                editControl1.butt = true;

                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.EditTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

                this.editControl1.EditTable.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 48);


                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.EditTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;



                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.editControl1.EditTable.DefaultCellStyle = dataGridViewCellStyle3;

                this.editControl1.EditTable.GridColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.editControl1.EditTable.HeaderBgColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.editControl1.EditTable.HeaderForeColor = System.Drawing.Color.White;



                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(128, 0, 0);
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.EditTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;

                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.EditTable.RowsDefaultCellStyle = dataGridViewCellStyle5;

                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.editControl1.EditTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;










                dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.TableDelete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

                this.editControl1.TableDelete.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 48);



                dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.TableDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

                dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                this.editControl1.TableDelete.DefaultCellStyle = dataGridViewCellStyle3;

                this.editControl1.TableDelete.GridColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.editControl1.TableDelete.HeaderBgColor = System.Drawing.Color.FromArgb(128, 0, 0);
                this.editControl1.TableDelete.HeaderForeColor = System.Drawing.Color.White;



                dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(128, 0, 0);
                dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.editControl1.TableDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;

                dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
                dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
                dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
                this.editControl1.TableDelete.RowsDefaultCellStyle = dataGridViewCellStyle5;

                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.editControl1.TableDelete.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;


                this.editControl1.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.BackColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherDeleteZapis.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDeleteZapis.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDeleteZapis.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.SearcherDeleteZapis.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherDeleteZapis.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDeleteZapis.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);


                this.editControl1.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);


                this.editControl1.SearcherEditZapis.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEditZapis.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEditZapis.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.SearcherEditZapis.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherEditZapis.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEditZapis.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);


                this.editControl1.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
                this.editControl1.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.editControl1.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.editControl1.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);


                this.addControl1.BtAdd.ActiveFillColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.addControl1.BtAdd.ActiveLineColor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.addControl1.BtAdd.ActiveForecolor = System.Drawing.Color.White;
                this.addControl1.BtAdd.IdleFillColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.addControl1.BtAdd.IdleForecolor = System.Drawing.Color.FromArgb(200, 0, 25);
                this.addControl1.BtAdd.IdleLineColor = System.Drawing.Color.FromArgb(200, 0, 25);



                this.editControl1.Textdel.ForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.Textedit.ForeColor = Color.FromArgb(200, 0, 25);
              

                this.editControl1.SearcherDelete.BackColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherDelete.ForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.FillColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherDelete.FocusedState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.HoverState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.PlaceholderForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.IconLeft = Properties.Resources.search_red;
                this.editControl1.SearcherDelete.DisabledState.FillColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherDelete.DisabledState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.DisabledState.ForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherDelete.DisabledState.PlaceholderForeColor = Color.FromArgb(200, 0, 25);

                this.editControl1.SearcherEdit.BackColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherEdit.ForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.FillColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherEdit.FocusedState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.HoverState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.PlaceholderForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.IconLeft = Properties.Resources.search_red;
                this.editControl1.SearcherEdit.DisabledState.FillColor = Color.FromArgb(45, 45, 48);
                this.editControl1.SearcherEdit.DisabledState.BorderColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.DisabledState.ForeColor = Color.FromArgb(200, 0, 25);
                this.editControl1.SearcherEdit.DisabledState.PlaceholderForeColor = Color.FromArgb(200, 0, 25);


                this.addControl1.label1.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label2.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label3.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label4.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label5.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label6.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label7.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label11.ForeColor = Color.FromArgb(200, 0, 25);

                this.addControl1.label22.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label33.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label44.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label55.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label66.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label77.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.label88.ForeColor = Color.FromArgb(200, 0, 25);

                this.addControl1.Nazv.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Nazv.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Nazv.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Nazv.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Proizv.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Proizv.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Proizv.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Proizv.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Shirina.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Shirina.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Shirina.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Shirina.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Dlina.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Dlina.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Dlina.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Dlina.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Etazh.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Etazh.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Etazh.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Etazh.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Kabin.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Kabin.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Kabin.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Kabin.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.FIOOO.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.FIOOO.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.FIOOO.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.FIOOO.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach11.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach11.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach11.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach11.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach22.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach22.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach22.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach22.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach33.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach33.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach33.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach33.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach44.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach44.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach44.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach44.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach55.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach55.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach55.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach55.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach66.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach66.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach66.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach66.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach77.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach77.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach77.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach77.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach88.BorderColorFocused = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach88.BorderColorIdle = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach88.BorderColorMouseHover = Color.FromArgb(200, 0, 25);
                this.addControl1.Znach88.ForeColor = Color.FromArgb(200, 0, 25);

                this.addControl1.ComboBoxAddDropdownDevices.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownDevices.FillColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownDevices.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownDevices.BorderColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.addControl1.ComboBoxAddDropdownDevices.ItemsAppearance.SelectedForeColor = Color.White;

                this.addControl1.ComboBoxAddKorpusDown.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddKorpusDown.FillColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddKorpusDown.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddKorpusDown.BorderColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.addControl1.ComboBoxAddKorpusDown.ItemsAppearance.SelectedForeColor = Color.White;

                this.addControl1.ComboBoxAddDropdownStatus.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownStatus.FillColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownStatus.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownStatus.BorderColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.BackColor = Color.FromArgb(45, 45, 48);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.ForeColor = Color.FromArgb(200, 0, 25);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.SelectedBackColor = Color.FromArgb(236, 7, 27);
                this.addControl1.ComboBoxAddDropdownStatus.ItemsAppearance.SelectedForeColor = Color.White;
            }
        }
        public void Speaker_True()
        {


            speechSynth1.Volume = volume; // устанавливаем уровень звука
            speechSynth1.SpeakAsync(speak); // озвучиваем переданный текст

        }

        private void addControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
