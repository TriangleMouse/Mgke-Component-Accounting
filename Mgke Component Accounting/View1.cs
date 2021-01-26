using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite.EF6;
using System.Data.SQLite;
using System.IO;
using System.Speech.Synthesis;
namespace Mgke_Component_Accounting
{
    public partial class View1 : UserControl
    {
        
        public View1()
        {
        
            InitializeComponent();

            
        }
        public bool perehod;
        public string speak = "";
        public string checkspeak = "";
        public SpeechSynthesizer speechSynth1 = new SpeechSynthesizer();// создаём объект
        public int volume;
        public void Speaker_True()
        {


            speechSynth1.Volume = volume; // устанавливаем уровень звука
            speechSynth1.SpeakAsync(speak); // озвучиваем переданный текст

        }

        public bool check;
        public string Search_value="";
        public string Search_value1 = "";
        public string Search_value2 = "";
        //public string Search_value2;
        //ublic string Search_value3 = "";
        public string Korpus_value;
        public string Devices_value = " is NOT NULL ";
        public string Status_value = " is NOT NULL ";
        public string sql;
        public SQLiteConnection conn;
        int n = 1;
        public void View1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); //Создаем объект класса DataSet


            string path = "BD_College.db"; //Путь к файлу БД

            string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;"; //Строка соеденения (так хочет sqlite)

            conn = new SQLiteConnection(ConnectionString); //Создаем соеденение

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

            da.Fill(ds);//Заполняем DataSet cодержимым DataAdapter'a

            Table.DataSource = ds.Tables[0].DefaultView;//Заполняем созданный на форме dataGridView1

            conn.Close();//Закрываем соединение


        }


        public void ComboBoxDropdownDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxDropdownDevices.Text;
            
            if (g == "Устройства(Все*)") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Devices_value = "is NOT NULL";
                Inf.Visible = false;
                Inf.Enabled = false;
                Inf.Value = false;
                Podrobo.Visible = false;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); 
            }
            if (g == "Материнская плата") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Devices_value = " ='Материнская плата' ";
                Inf.Visible = true;
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); 
                 }
            if (g == "Видеокарта") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Devices_value = " ='Видеокарта' ";
                Inf.Visible = true;
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Процессор") {
                Inf.Visible = true; if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Devices_value = " ='Процессор' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Блок питания") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Visible = true;
                Devices_value = " ='Блок питания' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);
                }
            if (g == "Жесткий диск") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Visible = true;
                Devices_value = " ='Жесткий диск' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Монитор") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Visible = true;
                Devices_value = " ='Монитор' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Оперативная память") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Visible = true;
                Devices_value = " ='Оперативная память' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Периферийные устройства") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Visible = true;
                Devices_value = " ='Периферийные устройства' ";
                Inf.Enabled = true;
                Inf.Value = false;
                Podrobo.Visible = true;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
       
        }

        private void ComboBoxDropdownStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxDropdownStatus.Text;
            if (g == "Статус(Все*)") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Status_value = " is NOT NULL "; Inf.Value = false;
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null);  }
            if (g == "Эксплуатация") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Status_value = " ='Эксплуатация' "; Inf.Value = false; 
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            if (g == "Утилизация") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Value = false; Status_value = " ='Утилизация' "; 
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            if (g == "Ремонт") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Status_value = " ='Ремонт' "; Inf.Value = false; 
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            if (g == "Хранение") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Value = false; Status_value = " ='Хранение' ";
                if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
           
        }

        

public bool butt;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        private void Table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (butt == false)
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionBackColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionForeColor = Color.White;

                this.Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.Table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                this.Table.RowTemplate.Height = 30;
                this.Table.Size = new System.Drawing.Size(733, 459);
                this.Table.TabIndex = 12;
            }

            if (butt == true)
            {

                // 
                // Table
                // 

                e.CellStyle.BackColor= Color.FromArgb(45, 45, 48);
                e.CellStyle.ForeColor = Color.FromArgb(216, 20, 11);
                e.CellStyle.SelectionBackColor = Color.FromArgb(168, 0, 0);
                e.CellStyle.SelectionForeColor = Color.White;
               

                this.Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.Table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.Table.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                this.Table.RowTemplate.Height = 30;
                this.Table.Size = new System.Drawing.Size(733, 459);
                this.Table.TabIndex = 12;
            }
        }

        private void ComboBoxKorpusDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxKorpusDown.Text;
            if (g == "Корпуса(Все*)") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Value = false; Korpus_value = "is NOT NULL"; Dop_infa(); if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            if (g == "Казинца") {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Inf.Value = false; Korpus_value = " ='Казинца' "; Dop_infa(); if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            if (g == "Кнорина") { Inf.Value = false; Korpus_value = " ='Кнорина' "; if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = g;



                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                Dop_infa(); if (check == true)
                {
                    Inf_OnValueChange(null, null);
                }
                if (check == false)
                {
                    Dop_infa();
                }
                View1_Load(null, null); }
            
        }

        public void Inf_OnValueChange(object sender, EventArgs e)
        {
            
            if (Inf.Value == true)
            {
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Podrobo.Text;



                    if (speak != checkspeak)
                    {checkspeak = "";
                        Speaker_True(); 
                    }
                }
                check = true;
                string g = ComboBoxDropdownDevices.Text;
                if (g == "Материнская плата")
                {
                    conn.Close();
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Количество_слотов,g.Сокет,g.Объем_памяти,g.Поддержка_памяти,g.Поддержка_процессоров,g.Чипсет,g.Максимальный_объём_памяти,g.Максимальная_частота,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                    FROM Devices d
                    INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                    INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                    INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                    INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                    INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                    where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or  g.Количество_слотов like '%" + Search_value + "%' or  g.Сокет like '%" + Search_value + "%' or  g.Объем_памяти like '%" + Search_value + "%' or  g.Поддержка_памяти like '%" + Search_value + "%' or  g.Поддержка_процессоров like '%" + Search_value + "%' or  g.Чипсет like '%" + Search_value + "%' or  g.Максимальный_объём_памяти like '%" + Search_value + "%' or  g.Максимальная_частота like '%" + Search_value +
                          "%' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    
                    View1_Load(null, null);
                }

                if (g == "Видеокарта")
                {

                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Видеопамять,g.Тип_видеопамяти,g.Тип_охлаждения,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                        + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%" + Search_value + "%' or g.Максимальная_частота like '%" + Search_value + "%' or g.Базовая_тактовая_частота like '%" + Search_value + "%' or g.Видеопамять like '%" + Search_value + "%' or g.Тип_видеопамяти like '%" + Search_value + "%' or g.Тип_охлаждения like '%" + Search_value + "%' or g.Интерфейс_памяти like '%" + Search_value +
                        "%' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                        + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    View1_Load(null, null);


                }
                if (g == "Процессор")
                {
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Сокет,g.Количество_ядер,g.Техпроцесс,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Максимальное_количество_потоков,g.Напряжение_питания,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                        FROM Devices d
                        INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                        INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                        INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                        INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                        INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                        where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%" + Search_value +
                          "%' or g.Сокет like '%" + Search_value + "%' or g.Количество_ядер like '%" + Search_value + "%' or g.Техпроцесс like '%" + Search_value + "%' or g.Максимальная_частота like '%" + Search_value + "%' or g.Базовая_тактовая_частота like '%" + Search_value + "%' or g.Максимальное_количество_потоков like '%" + Search_value + "%' or g.Напряжение_питания like '%" + Search_value + "%' or g.Интерфейс_памяти like '%" + Search_value +
                          " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";

                    View1_Load(null, null);
                }
                if (g == "Блок питания")
                {
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Мощность,g.Тип_охлаждения,g.Напряжение_питания,g.Емкость_микросхем,g.Форм_фактор,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or  g.Мощность like '%" + Search_value + "%' or g.Тип_охлаждения like '%" + Search_value + "%' or g.Напряжение_питания like '%" + Search_value + "%' or g.Емкость_микросхем like '%" + Search_value + "%' or g.Форм_фактор like '%" + Search_value + " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    View1_Load(null, null);
                }
                if (g == "Жесткий диск")
                {

                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Объем_памяти,g.Напряжение_питания,g.Интерфейс_памяти,g.Скорость_вращения_шпинделя,g.Тип_накопителя,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                        + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                        + Search_value + "%' or g.Объем_памяти like '%" + Search_value + "%' or g.Напряжение_питания like '%" + Search_value + "%' or g.Интерфейс_памяти like '%" + Search_value + "%' or g.Скорость_вращения_шпинделя like '%" + Search_value + "%' or g.Тип_накопителя like '%" + Search_value + " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                        + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";

                    View1_Load(null, null);
                }
                if (g == "Монитор")
                {
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Разрешение,g.Диагональ,g.Соотношение_сторон,g.Матрица,g.Частота_обновления_экрана,g.Поверхность_экрана	,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or g.Разрешение like '%" + Search_value + "%' or g.Диагональ like '%" + Search_value + "%' or g.Соотношение_сторон  like '%" + Search_value + "%' or  g.Матрица like '%" + Search_value + "%' or g.Частота_обновления_экрана like '%" + Search_value + "%' or g.Поверхность_экрана  like '%" + Search_value + " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    View1_Load(null, null);
                }
                if (g == "Оперативная память")
                {
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Объем_памяти,g.Поддержка_памяти,g.Максимальный_объём_памяти,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Тип_памяти,g.Напряжение_питания,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or  g.Объем_памяти like '%" + Search_value + "%' or g.Поддержка_памяти like '%" + Search_value + "%' or g.Максимальный_объём_памяти like '%" + Search_value + "%' or g.Максимальная_частота like '%" + Search_value + "%' or g.Базовая_тактовая_частота like '%" + Search_value + "%' or g.Тип_памяти like '%" + Search_value + "%' or  like '%" + Search_value + "%' or g.Напряжение_питания like '%" + Search_value + " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    View1_Load(null, null);
                }
                if (g == "Периферийные устройства")
                {
                    sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Разъем,g.Разрешение,g.Емкость_микросхем,g.Форм_фактор,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or  g.Разъем like '%" + Search_value + "%' or g.Разрешение like '%" + Search_value + "%' or g.Емкость_микросхем like '%" + Search_value + "%' or g.Форм_фактор like '%" + Search_value + "%' or g.Интерфейс_памяти  like '%" + Search_value + " % ' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                    View1_Load(null, null);
                }
            }
            else
            {
                check = false;
                sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                           FROM Devices d
                           INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                           INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                           INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                           INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                           INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                           where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                View1_Load(null, null);
            }
            

        }

        public void Dop_infa()
        {
            string g = ComboBoxDropdownDevices.Text;


                sql = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                           FROM Devices d
                           INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                           INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                           INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                           INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                           INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                           where Корпус " + Korpus_value + " and Статус " + Status_value + " and  d.Устройство " + Devices_value + " and (c.ID like '%" + Search_value + "%'  or d.Устройство like '%" + Search_value + "%' or c.Название like '%"
                          + Search_value + "%' or c.Производитель like '%" + Search_value + "%' or c.Ширина like '%" + Search_value + "%' or c.Длина like '%"
                          + Search_value + "%' or l.Корпус like '%" + Search_value + "%' or l.Этаж like '%" + Search_value + "%' or l.Кабинет like '%"
                          + Search_value + "%' or l.Статус like '%" + Search_value + "%' or p.ФИО like '%" + Search_value + "%')";
                View1_Load(null, null);
            
            
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (perehod == true)
            {

                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = Table.CurrentCell.Value.ToString();



                if (speak != checkspeak)
                {checkspeak = "";
                    Speaker_True(); 
                }
            }
        }
    }
}
