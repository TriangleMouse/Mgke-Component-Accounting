using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mgke_Component_Accounting
{
    public partial class Authorization : Form
    {

        public Authorization()
        {

            InitializeComponent();


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public string Korpus_value { get; set; }
        private void transition_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second


            if (Login.Text == "AdminKnor1")
            {


                if (Pass.Text == "college1234567")
                {

                    Korpus_value = " ='Кнорина' ";
                    StreamWriter SW = new StreamWriter(new FileStream("Korpus.file", FileMode.Create, FileAccess.Write));

                    SW.Write(Korpus_value);
                    SW.Close();

                    counter = 1;
                    timer1.Start();




                }

                else
                {
                    Pass.Text = "";
                    Login.Text = "";
                    Error.Visible = true;
                    Pass.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                    Login.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Login.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Login.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                }
            }
            else if (Login.Text == "AdminKazin2")
            {
                if (Pass.Text == "college7654321")
                {
                    Korpus_value = " ='Казинца' ";

                    StreamWriter SW = new StreamWriter(new FileStream("Korpus.file", FileMode.Create, FileAccess.Write));

                    SW.Write(Korpus_value);
                    SW.Close();

                    counter = 1;
                    timer1.Start();


                }

                else
                {
                    Pass.Text = "";
                    Login.Text = "";
                    Error.Visible = true;
                    Pass.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                    Login.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Login.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Login.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                }
            }
            else if (Login.Text == "Admin")
            {
                if (Pass.Text == "admin")

                {

                    Korpus_value = " is NOT NULL ";

                    StreamWriter SW = new StreamWriter(new FileStream("Korpus.file", FileMode.Create, FileAccess.Write));

                    SW.Write(Korpus_value);
                    SW.Close();

                    counter = 1;
                    timer1.Start();

                }

                else
                {
                    Pass.Text = "";
                    Login.Text = "";
                    Error.Visible = true;
                    Pass.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Pass.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                    Login.BorderColorFocused = Color.FromArgb(168, 0, 0);
                    Login.BorderColorIdle = Color.FromArgb(168, 0, 0);
                    Login.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                }
            }
            else
            {
                Pass.Text = "";
                Login.Text = "";
                Error.Visible = true;
                Pass.BorderColorFocused = Color.FromArgb(168, 0, 0);
                Pass.BorderColorIdle = Color.FromArgb(168, 0, 0);
                Pass.BorderColorMouseHover = Color.FromArgb(168, 0, 0);
                Login.BorderColorFocused = Color.FromArgb(168, 0, 0);
                Login.BorderColorIdle = Color.FromArgb(168, 0, 0);
                Login.BorderColorMouseHover = Color.FromArgb(168, 0, 0);

            }







        }

        private void Login_OnValueChanged(object sender, EventArgs e)
        {
            while (Login.Text.Length > 16)
            {
                Login.Text = Login.Text.Remove(16);
            }
            Error.Visible = false;
            Pass.BorderColorFocused = Color.FromArgb(41, 57, 87);
            Pass.BorderColorIdle = Color.FromArgb(41, 57, 87);
            Pass.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
            Login.BorderColorFocused = Color.FromArgb(41, 57, 87);
            Login.BorderColorIdle = Color.FromArgb(41, 57, 87);
            Login.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
        }

        private void Pass_OnValueChanged(object sender, EventArgs e)
        {
            while (Pass.Text.Length > 16)
            {
                Pass.Text = Pass.Text.Remove(16);
            }
            Pass.isPassword = true;
            Error.Visible = false;
            Pass.BorderColorFocused = Color.FromArgb(41, 57, 87);
            Pass.BorderColorIdle = Color.FromArgb(41, 57, 87);
            Pass.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
            Login.BorderColorFocused = Color.FromArgb(41, 57, 87);
            Login.BorderColorIdle = Color.FromArgb(41, 57, 87);
            Login.BorderColorMouseHover = Color.FromArgb(41, 57, 87);
        }
        public int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            transition.Enabled = false;
              counter--;
            if (counter == 0)
            {
                
               Form1 f1 = new Form1();
                Authorization a = new Authorization();
                this.Hide();
                transition.Enabled = true; f1.ShowDialog();
                a.Close();

                this.Show();
                timer1.Stop();
            }

        }
    }
}
