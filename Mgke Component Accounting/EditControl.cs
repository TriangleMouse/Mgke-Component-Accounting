using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Bunifu.Framework.UI;
using System.Speech.Synthesis;

namespace Mgke_Component_Accounting
{
    public partial class EditControl : UserControl
    {

        public EditControl()
        {
            InitializeComponent();
        }

        public string Korpus;

        public string id_delete;
        public bool perehod;
        public string speak = "";
        public string checkspeak = "";
        public SpeechSynthesizer speechSynth1 = new SpeechSynthesizer();// создаём объект
        public int volume; public void Speaker_True()
        {


            speechSynth1.Volume = volume; // устанавливаем уровень звука
            speechSynth1.SpeakAsync(speak); // озвучиваем переданный текст

        }
        private void SearcherDelete_OnTextChange(object sender, EventArgs e)
        {

            id_delete = SearcherDelete.Text;
        }
        DataSet dsesarch = new DataSet();
        DataSet dsesarch1 = new DataSet();
        private void SearcherDeleteZapis_Click(object sender, EventArgs e)
        {dsesarch1.Clear();
                    dsesarch.Clear();
            if (SearcherDelete.Text == "")
            {
                counter = 15;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();

                Warning.ForeColor = Color.Red;
                Warning.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warning.Text;

                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                   
                }
            }
            else
            {
              

                    

                    string sqldelete;
                    //   
                    //Создаем объект класса DataSet
                    //DataSet dsesarch = new DataSet();
                    sqldelete = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                           FROM Devices d
                           INNER JOIN Charecter c ON d.ID_устройства = c.ID_устройства
                           INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств = g.ID_характеристики_устройств
                           INNER JOIN Status s ON g.ID_статуса = s.ID_статуса
                           INNER JOIN Location l ON s.ID_хранение = l.ID_хранение
                           INNER JOIN People p ON l.ID_ответственный = p.ID_ответственный
                           where Корпус" + Korpus + " and c.ID='" + id_delete + "'";
                    string path = "BD_College.db"; //Путь к файлу БД

                    string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;"; //Строка соеденения (так хочет sqlite)

                    SQLiteConnection conn = new SQLiteConnection(ConnectionString); //Создаем соеденение

                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqldelete, conn);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da.Fill(dsesarch);//Заполняем DataSet cодержимым DataAdapter'a
                    TableDelete.DataSource = dsesarch.Tables[0].DefaultView;
                    conn.Close();

                    //  DataSet dsesarch1 = new DataSet();
                    //Заполняем созданный на форме dataGridView1
                    string sqldeletetest = @"SELECT c.ID, g.ID_характеристики_устройств,s.ID_статуса,l.ID_хранение,p.ID_ответственный
                           FROM Devices d
                           INNER JOIN Charecter c ON d.ID_устройства = c.ID_устройства
                           INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств = g.ID_характеристики_устройств
                           INNER JOIN Status s ON g.ID_статуса = s.ID_статуса
                           INNER JOIN Location l ON s.ID_хранение = l.ID_хранение
                           INNER JOIN People p ON l.ID_ответственный = p.ID_ответственный
                           where Корпус" + Korpus + " and c.ID='" + id_delete + "'";
                    SQLiteConnection conn1 = new SQLiteConnection(ConnectionString); //Создаем соеденение

                    SQLiteDataAdapter da1 = new SQLiteDataAdapter(sqldeletetest, conn1);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da1.Fill(dsesarch1);//Заполняем DataSet cодержимым DataAdapter'a
                    TestDelete.DataSource = dsesarch1.Tables[0].DefaultView;
                    conn1.Close();
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = "Найти запись по ID "+id_delete;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
                if (TestDelete.Rows.Count == 0)
                {
                    counter = 15;
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000; // 1 second
                    timer1.Start();

                    Warning.ForeColor = Color.Red;
                    Warning.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warning.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (SearcherDelete.Text == "")
            {
                counter = 15;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();

                Warning.ForeColor = Color.Red;
                Warning.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warning.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
            }
            else
            {

                //column1, column2, column3 - Названия столбцов
             
                if (TestDelete.Rows.Count == 0)
                {
                    counter = 15;
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000; // 1 second
                    timer1.Start();

                    Warning.ForeColor = Color.Red;
                    Warning.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warning.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
                if (TestDelete.Rows.Count != 0)
                {
                    string ID = TestDelete["ID", TestDelete.CurrentRow.Index].Value.ToString();
                    if (ID != null)
                    {
                        string ID_характеристики_устройств = TestDelete["ID_характеристики_устройств", TestDelete.CurrentRow.Index].Value.ToString();
                        string ID_статуса = TestDelete["ID_статуса", TestDelete.CurrentRow.Index].Value.ToString();
                        string ID_хранение = TestDelete["ID_хранение", TestDelete.CurrentRow.Index].Value.ToString();
                        string ID_ответственный = TestDelete["ID_ответственный", TestDelete.CurrentRow.Index].Value.ToString();
                        //Вывод значении в Лабел

                        string path = "BD_College.db";

                        string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;";






                        DataSet ds = new DataSet();

                        string sqldelete = @"DELETE FROM Charecter WHERE ID='" + ID + "'";


                        SQLiteConnection conn = new SQLiteConnection(ConnectionString);

                        SQLiteDataAdapter da = new SQLiteDataAdapter(sqldelete, conn);

                        da.Fill(ds);
                        conn.Close();

                        DataSet ds1 = new DataSet();
                        string sqldelete1 = @"DELETE FROM GlobalCharecter WHERE ID_характеристики_устройств='" + ID_характеристики_устройств + "'";
                        SQLiteConnection conn1 = new SQLiteConnection(ConnectionString);
                        SQLiteDataAdapter da1 = new SQLiteDataAdapter(sqldelete1, conn1);
                        da1.Fill(ds1);
                        conn1.Close();


                        DataSet ds2 = new DataSet();
                        string sqldelete2 = @"DELETE FROM Status WHERE ID_статуса='" + ID_статуса + "'";
                        SQLiteConnection conn2 = new SQLiteConnection(ConnectionString);
                        SQLiteDataAdapter da2 = new SQLiteDataAdapter(sqldelete2, conn2);
                        da2.Fill(ds2);
                        conn2.Close();


                        DataSet ds3 = new DataSet();
                        string sqldelete3 = @"DELETE FROM Location WHERE ID_хранение='" + ID_хранение + "'";
                        SQLiteConnection conn3 = new SQLiteConnection(ConnectionString);
                        SQLiteDataAdapter da3 = new SQLiteDataAdapter(sqldelete3, conn3);
                        da3.Fill(ds3);
                        conn3.Close();

                        counter = 15;
                        DataSet ds4 = new DataSet();
                        string sqldelete4 = @"DELETE FROM People WHERE ID_ответственный='" + ID_ответственный + "'";
                        SQLiteConnection conn4 = new SQLiteConnection(ConnectionString);
                        SQLiteDataAdapter da4 = new SQLiteDataAdapter(sqldelete4, conn4);
                        da4.Fill(ds4);
                        conn4.Close();
                        timer1 = new System.Windows.Forms.Timer();
                        timer1.Tick += new EventHandler(timer1_Tick);
                        timer1.Interval = 1000; // 1 second
                        timer1.Start();
                        Warning.Text = "Запись удалена!";

                        SearcherDelete.Text = "";
                        Warning.ForeColor = Color.FromArgb(71, 202, 94);
                        dsesarch.Clear();
                        dsesarch1.Clear();
                        //TableDelete.Rows.Clear(); 
                        TableDelete.Refresh();
                        if (perehod == true)
                        {

                            speechSynth1.SpeakAsyncCancelAll();
                            checkspeak = speak;
                            speak = Warning.Text;


                            if (speak != checkspeak)
                            {
                                Speaker_True(); checkspeak = "";
                            }
                        }
                    }
                }
            }
        }

        public string id_edit;
        bool check=false;
        private void SearcherEdit_OnTextChange(object sender, EventArgs e)
        {
          
            id_edit = SearcherEdit.Text;
        }
        public string SqlEdit1;
        public void TypeSqlSeacherForTableEdit()
        {
            if (SearcherEdit.Text == "")
            {
                counter1 = 15;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();

                Warn.ForeColor = Color.Red;
                Warn.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warn.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
            }
            else
            {
                if (TestEditTable.Rows.Count == 0)
                {
                    counter1 = 15;
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();

                    Warn.ForeColor = Color.Red;
                    Warn.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warn.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
                check = false;
                if (TestEditTable.Rows.Count != 0)
                {
                    string device = TestEditTable["Устройство", TestEditTable.CurrentRow.Index].Value.ToString();
                    check=true;
                    if (device == "Материнская плата")
                    {

                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Количество_слотов,g.Сокет,g.Объем_памяти,g.Поддержка_памяти,g.Поддержка_процессоров,g.Чипсет,g.Максимальный_объём_памяти,g.Максимальная_частота,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                    FROM Devices d
                    INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                    INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                    INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                    INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                    INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                    where Корпус" + Korpus + " and c.ID='" + id_edit + "'";

                    }

                    if (device == "Видеокарта")
                    {

                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Видеопамять,g.Тип_видеопамяти,g.Тип_охлаждения,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and c.ID='" + id_edit + "'";



                    }
                    if (device == "Процессор")
                    {
                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Сокет,g.Количество_ядер,g.Техпроцесс,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Максимальное_количество_потоков,g.Напряжение_питания,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                        FROM Devices d
                        INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                        INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                        INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                        INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                        INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                       where Корпус" + Korpus + " and c.ID='" + id_edit + "'";


                    }
                    if (device == "Блок питания")
                    {
                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Мощность,g.Тип_охлаждения,g.Напряжение_питания,g.Емкость_микросхем,g.Форм_фактор,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and  c.ID='" + id_edit + "'";

                    }
                    if (device == "Жесткий диск")
                    {

                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Объем_памяти,g.Напряжение_питания,g.Интерфейс_памяти,g.Скорость_вращения_шпинделя,g.Тип_накопителя,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and  c.ID='" + id_edit + "'";


                    }
                    if (device == "Монитор")
                    {
                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Разрешение,g.Диагональ,g.Соотношение_сторон,g.Матрица,g.Частота_обновления_экрана,g.Поверхность_экрана	,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and  c.ID='" + id_edit + "'";

                    }
                    if (device == "Оперативная память")
                    {
                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Объем_памяти,g.Поддержка_памяти,g.Максимальный_объём_памяти,g.Максимальная_частота,g.Базовая_тактовая_частота,g.Тип_памяти,g.Напряжение_питания,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and  c.ID='" + id_edit + "'";

                    }
                    if (device == "Периферийные устройства")
                    {
                        SqlEdit1 = @"SELECT c.ID,d.Устройство,c.Название,c.Производитель,c.Ширина,c.Длина,g.Разъем,g.Разрешение,g.Емкость_микросхем,g.Форм_фактор,g.Интерфейс_памяти,l.Корпус,l.Этаж,l.Кабинет,l.Статус,p.ФИО
                            FROM Devices d
                            INNER JOIN Charecter c ON d.ID_устройства=c.ID_устройства
                            INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств=g.ID_характеристики_устройств
                            INNER JOIN Status s ON g.ID_статуса=s.ID_статуса
                            INNER JOIN Location l ON s.ID_хранение=l.ID_хранение
                            INNER JOIN People p ON l.ID_ответственный=p.ID_ответственный
                            where Корпус" + Korpus + " and  c.ID='" + id_edit + "'";

                     } 


                }           
            }
        }

       

        private void SearcherEditZapis_Click(object sender, EventArgs e)
       { //dsearch3.Clear();
        //        dsearch2.Clear();
        //        dsearch4.Clear();
            if (SearcherEdit.Text == "")
            {
                counter1 = 15;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();

                Warn.ForeColor = Color.Red;
                Warn.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warn.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
            }
            else
            {
                
                string SqlEdit;
                //   
 DataSet dsearch3 = new DataSet();
        DataSet dsearch2 = new DataSet();
        DataSet dsearch4 = new DataSet();
                //Создаем объект класса DataSet

                SqlEdit = @"SELECT ID,Устройство
                           FROM Charecter                    
                           where ID='" + id_edit + "'";
                string path = "BD_College.db"; //Путь к файлу БД

                string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;"; //Строка соеденения (так хочет sqlite)

                SQLiteConnection conn = new SQLiteConnection(ConnectionString); //Создаем соеденение

                SQLiteDataAdapter da = new SQLiteDataAdapter(SqlEdit, conn);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)
                
                da.Fill(dsearch3);//Заполняем DataSet cодержимым DataAdapter'a
                TestEditTable.DataSource = dsearch3.Tables[0].DefaultView;
                conn.Close();

                TypeSqlSeacherForTableEdit();


                if (check == true) {
                SQLiteConnection conn1 = new SQLiteConnection(ConnectionString); //Создаем соеденение

                SQLiteDataAdapter da1 = new SQLiteDataAdapter(SqlEdit1, conn1);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)
               // SQLiteCommandBuilder bulder = new SQLiteCommandBuilder(da1);
                //  da1.UpdateCommand = bulder.GetUpdateCommand();
                da1.Fill(dsearch2);//Заполняем DataSet cодержимым DataAdapter'a
                EditTable.DataSource = dsearch2.Tables[0].DefaultView;

                conn1.Close();

                string SqlEdit2;
                //   

               // DataSet ds2 = new DataSet(); //Создаем объект класса DataSet

                SqlEdit2 = @"SELECT c.ID, g.ID_характеристики_устройств,s.ID_статуса,l.ID_хранение,p.ID_ответственный
                           FROM Devices d
                           INNER JOIN Charecter c ON d.ID_устройства = c.ID_устройства
                           INNER JOIN GlobalCharecter g ON c.ID_характеристики_устройств = g.ID_характеристики_устройств
                           INNER JOIN Status s ON g.ID_статуса = s.ID_статуса
                           INNER JOIN Location l ON s.ID_хранение = l.ID_хранение
                           INNER JOIN People p ON l.ID_ответственный = p.ID_ответственный
                           where Корпус" + Korpus + " and c.ID='" + id_edit + "'";
                string path2 = "BD_College.db"; //Путь к файлу БД

                string ConnectionString2 = "Data Source=" + path2 + ";Version=3;New=True;Compress=True;"; //Строка соеденения (так хочет sqlite)

                SQLiteConnection conn2 = new SQLiteConnection(ConnectionString); //Создаем соеденение

                SQLiteDataAdapter da2 = new SQLiteDataAdapter(SqlEdit2, conn2);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                da2.Fill(dsearch4);//Заполняем DataSet cодержимым DataAdapter'a
                TestEdit2.DataSource = dsearch4.Tables[0].DefaultView;
                conn2.Close();

                EditTable.Columns[0].ReadOnly = true;
                EditTable.Columns[1].ReadOnly = true;
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = "Найти запись по ID " + id_edit;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
                else
                {

                    counter1 = 15;
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();

                    Warn.ForeColor = Color.Red;
                    Warn.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warn.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
            }
        }
        string ID_характеристики_устройств1;






        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (SearcherEdit.Text == "")
            {
                counter1 = 15;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();

                Warn.ForeColor = Color.Red;
                Warn.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warn.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
            }
            else
            {
            
             
                if (TestEdit2.Rows.Count == 0)
                {
                    counter1 = 15;
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();

                    Warn.ForeColor = Color.Red;
                    Warn.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warn.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }
                
                if (TestEdit2.Rows.Count != 0)
                {
                    string ID = TestEdit2["ID", TestEdit2.CurrentRow.Index].Value.ToString();
                    ID_характеристики_устройств1 = TestEdit2["ID_характеристики_устройств", TestEdit2.CurrentRow.Index].Value.ToString();
                    string ID_хранение = TestEdit2["ID_хранение", TestEdit2.CurrentRow.Index].Value.ToString();
                    string ID_ответственный = TestEdit2["ID_ответственный", TestEdit2.CurrentRow.Index].Value.ToString();

                    string Название = EditTable["Название", EditTable.CurrentRow.Index].Value.ToString();
                    string Производитель = EditTable["Производитель", EditTable.CurrentRow.Index].Value.ToString();
                    string Ширина = EditTable["Ширина", EditTable.CurrentRow.Index].Value.ToString();
                    string Длина = EditTable["Длина", EditTable.CurrentRow.Index].Value.ToString();
                    string Корпус = EditTable["Корпус", EditTable.CurrentRow.Index].Value.ToString();
                    string Этаж = EditTable["Этаж", EditTable.CurrentRow.Index].Value.ToString();
                    string Кабинет = EditTable["Кабинет", EditTable.CurrentRow.Index].Value.ToString();
                    string Статус = EditTable["Статус", EditTable.CurrentRow.Index].Value.ToString();
                    string ФИО = EditTable["ФИО", EditTable.CurrentRow.Index].Value.ToString();

                    if((Корпус== "Казинца" || Корпус== "Кнорина") && (Статус== "Эксплуатация" || Статус == "Утилизация" || Статус == "Ремонт" || Статус == "Хранение")) {
                    string path = "BD_College.db"; //Путь к файлу БД

                    string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;";
                    DataSet ds = new DataSet();
                    sql1 = @"UPDATE Charecter SET Название='" + Название + "' ,  Производитель='" + Производитель + "' , Ширина='" + Ширина + "' , Длина='" + Длина + "'  WHERE ID='" + ID + "'";
                    SQLiteConnection conn = new SQLiteConnection(ConnectionString);

                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql1, conn);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da.Fill(ds);//Заполняем DataSet cодержимым DataAdapter'a
                    conn.Close();


                    DataSet ds1 = new DataSet();
                    sql2 = @"UPDATE Location SET Корпус='" + Корпус + "' ,  Этаж='" + Этаж + "' , Кабинет='" + Кабинет + "' , Статус='" + Статус + "'  WHERE ID_хранение='" + ID_хранение + "'";
                    SQLiteConnection conn1 = new SQLiteConnection(ConnectionString);

                    SQLiteDataAdapter da1 = new SQLiteDataAdapter(sql2, conn1);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da1.Fill(ds1);//Заполняем DataSet cодержимым DataAdapter'a
                    conn1.Close();

                    DataSet ds2 = new DataSet();
                    sql3 = @"UPDATE People SET  ФИО='" + ФИО + "'  WHERE ID_ответственный='" + ID_ответственный + "'";
                    SQLiteConnection conn2 = new SQLiteConnection(ConnectionString);

                    SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql3, conn2);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da2.Fill(ds2);//Заполняем DataSet cодержимым DataAdapter'a
                    conn2.Close();

                    DataSet ds3 = new DataSet();
                    SwitchEdit();
                    SQLiteConnection conn3 = new SQLiteConnection(ConnectionString);

                    SQLiteDataAdapter da3 = new SQLiteDataAdapter(sql4, conn3);//Создаем объект класса DataAdapter (тут мы передаем наш запрос и получаем ответ)

                    da3.Fill(ds3);//Заполняем DataSet cодержимым DataAdapter'a
                    conn3.Close();

                    counter1 = 15;

                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();


                    Warn.ForeColor = Color.FromArgb(71, 202, 94);

                    Warn.Text = "Запись изменена!";
                    SearcherEdit.Text = "";
                        //dsearch3.Clear();
                        //dsearch2.Clear();
                        //dsearch4.Clear();
                        if (perehod == true)
                        {

                            speechSynth1.SpeakAsyncCancelAll();
                            checkspeak = speak;
                            speak = Warn.Text;


                            if (speak != checkspeak)
                            {
                                Speaker_True(); checkspeak = "";
                            }
                        }
                    }
                }
                else
                {
                    counter1 = 15;
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();

                    Warn.ForeColor = Color.Red;
                    Warn.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warn.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                    //dsearch3.Clear();
                    //dsearch2.Clear();
                    //dsearch4.Clear();
                }
            }
        }



        public string sql1;
        public string sql2;
        public string sql3;
        public string sql4;

        public void SwitchEdit()
        {
            if (SearcherEdit.Text == "")
            {
                counter1 = 15;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();

                Warn.ForeColor = Color.Red;
                Warn.Text = "Ошибка! ID не было введено.";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warn.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True(); checkspeak = "";
                    }
                }
            }
            else
            {


                if (TestEdit2.Rows.Count == 0)
                {
                    counter1 = 15;
                    timer2 = new System.Windows.Forms.Timer();
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Interval = 1000; // 1 second
                    timer2.Start();

                    Warn.ForeColor = Color.Red;
                    Warn.Text = "Ошибка! Проверьте значение введенное в поле.";
                    if (perehod == true)
                    {

                        speechSynth1.SpeakAsyncCancelAll();
                        checkspeak = speak;
                        speak = Warn.Text;


                        if (speak != checkspeak)
                        {
                            Speaker_True(); checkspeak = "";
                        }
                    }
                }

                if (TestEdit2.Rows.Count != 0)
                {
                    string device = EditTable["Устройство", EditTable.CurrentRow.Index].Value.ToString();

                    if (device == "Материнская плата")
                    {
                        string Количество_слотов = EditTable["Количество_слотов", EditTable.CurrentRow.Index].Value.ToString();
                        string Сокет = EditTable["Сокет", EditTable.CurrentRow.Index].Value.ToString();
                        string Объем_памяти = EditTable["Объем_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Поддержка_памяти = EditTable["Поддержка_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Поддержка_процессоров = EditTable["Поддержка_процессоров", EditTable.CurrentRow.Index].Value.ToString();
                        string Чипсет = EditTable["Чипсет", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальный_объём_памяти = EditTable["Максимальный_объём_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальная_частота = EditTable["Максимальная_частота", EditTable.CurrentRow.Index].Value.ToString();
                        sql4 = @"UPDATE GlobalCharecter
                        SET Количество_слотов='" + Количество_слотов + "' ,Сокет='" + Сокет + "' ,Объем_памяти='" + Объем_памяти + "' ,Поддержка_памяти='" + Поддержка_памяти + "' ,Поддержка_процессоров='" + Поддержка_процессоров + "' ,Чипсет='" + Чипсет + "' ,Максимальный_объём_памяти='" + Максимальный_объём_памяти + "' ,Максимальная_частота='" + Максимальная_частота + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";

                    }

                    if (device == "Видеокарта")
                    {
                        string Максимальная_частота = EditTable["Максимальная_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Базовая_тактовая_частота = EditTable["Базовая_тактовая_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Видеопамять = EditTable["Видеопамять", EditTable.CurrentRow.Index].Value.ToString();
                        string Тип_видеопамяти = EditTable["Тип_видеопамяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Тип_охлаждения = EditTable["Тип_охлаждения", EditTable.CurrentRow.Index].Value.ToString();
                        string Интерфейс_памяти = EditTable["Интерфейс_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        sql4 = @"UPDATE GlobalCharecter SET Максимальная_частота='" + Максимальная_частота + "' ,Базовая_тактовая_частота='" + Базовая_тактовая_частота + "' ,Видеопамять='" + Видеопамять + "' ,Тип_видеопамяти='" + Тип_видеопамяти + "' ,Тип_охлаждения='" + Тип_охлаждения + "' ,Интерфейс_памяти='" + Интерфейс_памяти + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";



                    }
                    if (device == "Процессор")
                    {
                        string Количество_ядер = EditTable["Количество_ядер", EditTable.CurrentRow.Index].Value.ToString();
                        string Сокет = EditTable["Сокет", EditTable.CurrentRow.Index].Value.ToString();
                        string Техпроцесс = EditTable["Техпроцесс", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальная_частота = EditTable["Максимальная_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Базовая_тактовая_частота = EditTable["Базовая_тактовая_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальное_количество_потоков = EditTable["Максимальное_количество_потоков", EditTable.CurrentRow.Index].Value.ToString();
                        string Интерфейс_памяти = EditTable["Интерфейс_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Напряжение_питания = EditTable["Напряжение_питания", EditTable.CurrentRow.Index].Value.ToString();

                        sql4 = @"UPDATE GlobalCharecter SET Сокет='" + Сокет + "' ,Количество_ядер='" + Количество_ядер + "' ,Техпроцесс='" + Техпроцесс + "' ,Максимальная_частота='" + Максимальная_частота + "' ,Базовая_тактовая_частота='" + Базовая_тактовая_частота + "' ,Максимальное_количество_потоков='" + Максимальное_количество_потоков + "' ,Напряжение_питания='" + Напряжение_питания + "' ,Интерфейс_памяти='" + Интерфейс_памяти + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";


                    }
                    if (device == "Блок питания")
                    {
                        string Мощность = EditTable["Мощность", EditTable.CurrentRow.Index].Value.ToString();
                        string Тип_охлаждения = EditTable["Тип_охлаждения", EditTable.CurrentRow.Index].Value.ToString();
                        string Напряжение_питания = EditTable["Напряжение_питания", EditTable.CurrentRow.Index].Value.ToString();
                        string Емкость_микросхем = EditTable["Емкость_микросхем", EditTable.CurrentRow.Index].Value.ToString();
                        string Форм_фактор = EditTable["Форм_фактор", EditTable.CurrentRow.Index].Value.ToString();

                        sql4 = @"UPDATE GlobalCharecter SET Мощность='" + Мощность + "' ,Тип_охлаждения='" + Тип_охлаждения + "' ,Напряжение_питания='" + Напряжение_питания + "' ,Емкость_микросхем='" + Емкость_микросхем + "' ,Форм_фактор='" + Форм_фактор + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";

                    }
                    if (device == "Жесткий диск")
                    {
                        string Объем_памяти = EditTable["Объем_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Интерфейс_памяти = EditTable["Интерфейс_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Напряжение_питания = EditTable["Напряжение_питания", EditTable.CurrentRow.Index].Value.ToString();
                        string Скорость_вращения_шпинделя = EditTable["Скорость_вращения_шпинделя", EditTable.CurrentRow.Index].Value.ToString();
                        string Тип_накопителя = EditTable["Тип_накопителя", EditTable.CurrentRow.Index].Value.ToString();

                        sql4 = @"UPDATE GlobalCharecter SET Объем_памяти='" + Объем_памяти + "' ,Напряжение_питания='" + Напряжение_питания + "' ,Интерфейс_памяти='" + Интерфейс_памяти + "' ,Скорость_вращения_шпинделя='" + Скорость_вращения_шпинделя + "' ,Тип_накопителя='" + Тип_накопителя + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";




                    }
                    if (device == "Монитор")

                    {

                        string Разрешение = EditTable["Разрешение", EditTable.CurrentRow.Index].Value.ToString();
                        string Диагональ = EditTable["Диагональ", EditTable.CurrentRow.Index].Value.ToString();
                        string Соотношение_сторон = EditTable["Соотношение_сторон", EditTable.CurrentRow.Index].Value.ToString();
                        string Матрица = EditTable["Матрица", EditTable.CurrentRow.Index].Value.ToString();
                        string Частота_обновления_экрана = EditTable["Частота_обновления_экрана", EditTable.CurrentRow.Index].Value.ToString();
                        string Поверхность_экрана = EditTable["Поверхность_экрана", EditTable.CurrentRow.Index].Value.ToString();
                        sql4 = @"UPDATE GlobalCharecter SET Разрешение='" + Разрешение + "' ,Диагональ='" + Диагональ + "' ,Соотношение_сторон='" + Соотношение_сторон + "' ,Матрица='" + Матрица + "' ,Частота_обновления_экрана='" + Частота_обновления_экрана + "' ,Поверхность_экрана='" + Поверхность_экрана + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";


                    }
                    if (device == "Оперативная память")
                    {

                        string Объем_памяти = EditTable["Объем_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Поддержка_памяти = EditTable["Поддержка_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальный_объём_памяти = EditTable["Максимальный_объём_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Максимальная_частота = EditTable["Максимальная_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Базовая_тактовая_частота = EditTable["Базовая_тактовая_частота", EditTable.CurrentRow.Index].Value.ToString();
                        string Тип_памяти = EditTable["Тип_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        string Напряжение_питания = EditTable["Напряжение_питания", EditTable.CurrentRow.Index].Value.ToString();
                        sql4 = @"UPDATE GlobalCharecter SET Объем_памяти='" + Объем_памяти + "' ,Поддержка_памяти='" + Поддержка_памяти + "' ,Максимальный_объём_памяти='" + Максимальный_объём_памяти + "' ,Максимальная_частота='" + Максимальная_частота + "' ,Базовая_тактовая_частота='" + Базовая_тактовая_частота + "' ,Тип_памяти='" + Тип_памяти + "' ,Напряжение_питания='" + Напряжение_питания + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";



                    }
                    if (device == "Периферийные устройства")
                    {

                        string Разъем = EditTable["Разъем", EditTable.CurrentRow.Index].Value.ToString();
                        string Разрешение = EditTable["Разрешение", EditTable.CurrentRow.Index].Value.ToString();
                        string Емкость_микросхем = EditTable["Емкость_микросхем", EditTable.CurrentRow.Index].Value.ToString();
                        string Форм_фактор = EditTable["Форм_фактор", EditTable.CurrentRow.Index].Value.ToString();
                        string Интерфейс_памяти = EditTable["Интерфейс_памяти", EditTable.CurrentRow.Index].Value.ToString();
                        sql4 = @"UPDATE GlobalCharecter SET Разъем='" + Разъем + "' ,Разрешение='" + Разрешение + "' ,Емкость_микросхем='" + Емкость_микросхем + "' ,Форм_фактор='" + Форм_фактор + "' ,Интерфейс_памяти='" + Интерфейс_памяти + "' WHERE ID_характеристики_устройств='" + ID_характеристики_устройств1 + "'";


                    }
                }
            }
        }

        private void TableDelete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (butt == false)
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionBackColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionForeColor = Color.White;

                this.TableDelete.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.TableDelete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.TableDelete.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.TableDelete.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.TableDelete.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            }

            if (butt == true)
            {

                // 
                // Table
                // 

                e.CellStyle.BackColor = Color.FromArgb(45, 45, 48);
                e.CellStyle.ForeColor = Color.FromArgb(216, 20, 11);
                e.CellStyle.SelectionBackColor = Color.FromArgb(168, 0, 0);
                e.CellStyle.SelectionForeColor = Color.White;


                this.TableDelete.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.TableDelete.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.TableDelete.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.TableDelete.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.TableDelete.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;


            }
        }
        public bool butt;
        private void EditTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (butt == false)
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionBackColor = Color.FromArgb(57, 72, 100);
                e.CellStyle.SelectionForeColor = Color.White;

                this.EditTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                this.EditTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.EditTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.EditTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(100)))));
                this.EditTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            }

            if (butt == true)
            {

                // 
                // Table
                // 

                e.CellStyle.BackColor = Color.FromArgb(45, 45, 48);
                e.CellStyle.ForeColor = Color.FromArgb(216, 20, 11);
                e.CellStyle.SelectionBackColor = Color.FromArgb(168, 0, 0);
                e.CellStyle.SelectionForeColor = Color.White;


                this.EditTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                this.EditTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.EditTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(216, 20, 11);
                this.EditTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(168, 0, 0);
                this.EditTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            }
        }
        public int counter = 15;
        public int counter1 = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                Warning.Text = "";
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            counter1--;
            if (counter1 == 0)
            {
                Warn.Text = "";
                timer2.Stop();
            }
        }

        private void SearcherDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void SearcherEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        public string use;
        public string use1;
        private void EditTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = EditTable.CurrentCell.Value.ToString();


                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void EditTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string titleText;
           
                titleText = EditTable.Columns["Корпус"].HeaderText;
            if (titleText.Equals("Корпус"))
            {
                  
                    TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    autoText.AutoCompleteCustomSource = DataCollection;
                  
                }
            }


            titleText = EditTable.Columns["Статус"].HeaderText;
                if (titleText.Equals("Статус"))
                {
                    TextBox autoText = e.Control as TextBox;
                    if (autoText != null)
                    {
                        autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                        autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                        addItems(DataCollection);
                        autoText.AutoCompleteCustomSource = DataCollection; 
                    }
                }
             
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("Казинца");
            col.Add("Кнорина");
            col.Add("Эксплуатация");
            col.Add("Утилизация");
            col.Add("Ремонт");
            col.Add("Хранение");
        }

        private void TableDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = TableDelete.CurrentCell.Value.ToString();


                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }
    }
}
