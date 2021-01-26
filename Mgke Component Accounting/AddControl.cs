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
    public partial class AddControl : UserControl
    {
        public AddControl()
        {
            InitializeComponent();
            this.ComboBoxAddDropdownDevices.Text = "Материнская плата";
            this.ComboBoxAddDropdownStatus.Text = "Эксплуатация";
            this.ComboBoxAddKorpusDown.Text = "Казинца";
        }
        public bool perehod;
        public string speak = "";
        public string checkspeak = "";
        public SpeechSynthesizer speechSynth1 = new SpeechSynthesizer();// создаём объект
        public int volume; public void Speaker_True()
        {


            speechSynth1.Volume = volume; // устанавливаем уровень звука
            speechSynth1.SpeakAsync(speak); // озвучиваем переданный текст

        }
        private void ComboBoxAddDropdownDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxAddDropdownDevices.Text;
            if (g == "Материнская плата")
            {
                Devices = "Материнская плата";
                ID_устройства = "6";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;
                    

                    if (speak != checkspeak)
                    {
                        Speaker_True();
                    }
                        
                }
                this.label11.Text = "Количество слотов";
                this.label22.Text = "Сокет";
                this.label33.Text = "Объем памяти";
                this.label44.Text = "Поддержка памяти";
                this.label55.Text = "Поддержка\nпроцессоров";
                this.label66.Text = "Чипсет";
                this.label77.Text = "Максимальный\nобъём памяти";
                this.label88.Text = "Максимальная\nчастота";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = true;
                label77.Visible = true;
                label88.Visible = true;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = true;
                Znach77.Visible = true;
                Znach88.Visible = true;
            }
            if (g == "Видеокарта")
            {
                Devices = "Видеокарта";
                ID_устройства = "7";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }

                this.label11.Text = "Максимальная\nчастота";
                this.label22.Text = "Базовая тактовая\nчастота";
                this.label33.Text = "Видеопамять";
                this.label44.Text = "Тип видеопамяти";
                this.label55.Text = "Тип охлаждения";
                this.label66.Text = "Интерфейс памяти";



                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = true;
                label77.Visible = false;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = true;
                Znach77.Visible = false;
                Znach88.Visible = false;
            }
            if (g == "Процессор")
            {
                Devices = "Процессор";
                ID_устройства = "8";

                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }
                this.label11.Text = "Сокет";
                this.label22.Text = "Количество ядер";
                this.label33.Text = "Техпроцесс";
                this.label44.Text = "Максимальная\nчастота";
                this.label55.Text = "Базовая\nтактовая частота";
                this.label66.Text = "Максимальное\nколичество потоков";
                this.label77.Text = "Напряжение питания";
                this.label88.Text = "Интерфейс памяти";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = true;
                label77.Visible = true;
                label88.Visible = true;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = true;
                Znach77.Visible = true;
                Znach88.Visible = true;
            }
            if (g == "Блок питания")
            {
                Devices = "Блок питания";
                ID_устройства = "9";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }

                this.label11.Text = "Мощность";
                this.label22.Text = "Тип охлаждения";
                this.label33.Text = "Напряжение питания";
                this.label44.Text = "Емкость микросхем";
                this.label55.Text = "Форм фактор";
                this.label66.Text = "";
                this.label77.Text = "";
                this.label88.Text = "";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = false;
                label77.Visible = false;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = false;
                Znach77.Visible = false;
                Znach88.Visible = false;
            }

            if (g == "Жесткий диск")
            {
                Devices = "Жесткий диск";
                ID_устройства = "11";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }

                this.label11.Text = "Объем памяти";
                this.label22.Text = "Напряжение питания";
                this.label33.Text = "Интерфейс памяти";
                this.label44.Text = "Скорость\nвращения шпинделя";
                this.label55.Text = "Тип накопителя";
                this.label66.Text = "";
                this.label77.Text = "";
                this.label88.Text = "";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = false;
                label77.Visible = false;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = false;
                Znach77.Visible = false;
                Znach88.Visible = false;
            }
            if (g == "Монитор")
            {
                Devices = "Монитор";
                ID_устройства = "12";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }


                this.label11.Text = "Разрешение";
                this.label22.Text = "Диагональ";
                this.label33.Text = "Соотношение сторон";
                this.label44.Text = "Матрица";
                this.label55.Text = "Частота\nобновления экрана";
                this.label66.Text = "Поверхность\nэкрана";
                this.label77.Text = "";
                this.label88.Text = "";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = true;
                label77.Visible = false;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = true;
                Znach77.Visible = false;
                Znach88.Visible = false;

            }
            if (g == "Оперативная память")
            {
                Devices = "Оперативная память";
                ID_устройства = "10";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }
                this.label11.Text = "Объем памяти";
                this.label22.Text = "Поддержка\nпамяти";
                this.label33.Text = "Максимальный\nобъём памяти";
                this.label44.Text = "Максимальная\nчастота";
                this.label55.Text = "Базовая\nтактовая частота";
                this.label66.Text = "Тип памяти";
                this.label77.Text = "Напряжение";
                this.label88.Text = "";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = true;
                label77.Visible = true;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = true;
                Znach77.Visible = true;
                Znach88.Visible = false;
            }
            if (g == "Периферийные устройства")
            {
                Devices = "Периферийные устройства";
                ID_устройства = "13";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Devices;


                    if (speak != checkspeak)
                        Speaker_True();
                }
                this.label11.Text = "Разъем";
                this.label22.Text = "Разрешение";
                this.label33.Text = "Емкость\nмикросхем";
                this.label44.Text = "Форм фактор";
                this.label55.Text = "Интерфейс\nпамяти";
                this.label66.Text = "";
                this.label77.Text = "";
                this.label88.Text = "";


                label11.Visible = true;
                label22.Visible = true;
                label33.Visible = true;
                label44.Visible = true;
                label55.Visible = true;
                label66.Visible = false;
                label77.Visible = false;
                label88.Visible = false;

                Znach11.Visible = true;
                Znach22.Visible = true;
                Znach33.Visible = true;
                Znach44.Visible = true;
                Znach55.Visible = true;
                Znach66.Visible = false;
                Znach77.Visible = false;
                Znach88.Visible = false;
            }
        }
        public string Devices;
        public string sql;
        public string sql1;
        public string ID_устройства;
        public int counter = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {

            counter--;
            if (counter == 0)
            {
                Warning.Text = "";
                timer1.Stop();
            }

        }
        private void BtAdd_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            if (Nazv.Text == "" || Proizv.Text == "" || Shirina.Text == ""  || Dlina.Text == ""  || Etazh.Text == ""  || Kabin.Text == ""  || FIOOO.Text == "" || Znach11.Text == ""  || Znach22.Text == "" ||  Znach33.Text == "" ||  Znach44.Text == "" ||  Znach55.Text == "" )
            {
                counter = 15;
                timer1.Start();
                Warning.Text = "Ошибка! Данные не были добавлены в\nбазу данных.Перепроверьте введенные вами значения.";
                Warning.ForeColor = Color.Red;
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
                counter = 15;
                timer1.Start();

                string path = "BD_College.db"; //Путь к файлу БД

                string ConnectionString = "Data Source=" + path + ";Version=3;New=True;Compress=True;";
                DataSet ds = new DataSet();
                sql = @"SELECT MAX(ID)  FROM  Charecter";
                SQLiteConnection conn = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

                da.Fill(ds);
                TestTable.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
                string ID = TestTable["MAX(ID)", TestTable.CurrentRow.Index].Value.ToString();
                int id = Convert.ToInt32(ID);
                id = id + 1;
                ID = Convert.ToString(id);


                DataSet ds1 = new DataSet();
                sql = @"SELECT MAX(ID_характеристики_устройств)  FROM  Charecter";
                SQLiteConnection conn1 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da1 = new SQLiteDataAdapter(sql, conn1);

                da1.Fill(ds1);
                TestTable.DataSource = ds1.Tables[0].DefaultView;
                conn1.Close();
                string ID_характеристики_устройств = TestTable["MAX(ID_характеристики_устройств)", TestTable.CurrentRow.Index].Value.ToString();
                int ID_характеристики_устройств1 = Convert.ToInt32(ID_характеристики_устройств);
                ID_характеристики_устройств1 = ID_характеристики_устройств1 + 1;
                ID_характеристики_устройств = Convert.ToString(ID_характеристики_устройств1);


                DataSet ds2 = new DataSet();
                sql = @"SELECT MAX(ID_статуса)  FROM  GlobalCharecter";
                SQLiteConnection conn2 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql, conn2);

                da2.Fill(ds2);
                TestTable.DataSource = ds2.Tables[0].DefaultView;
                conn2.Close();
                string ID_статуса = TestTable["MAX(ID_статуса)", TestTable.CurrentRow.Index].Value.ToString();
                int ID_статуса1 = Convert.ToInt32(ID_статуса);
                ID_статуса1 = ID_статуса1 + 1;
                ID_статуса = Convert.ToString(ID_статуса1);


                DataSet ds3 = new DataSet();
                sql = @"SELECT MAX(ID_хранение)  FROM  Status";
                SQLiteConnection conn3 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da3 = new SQLiteDataAdapter(sql, conn3);

                da3.Fill(ds3);
                TestTable.DataSource = ds3.Tables[0].DefaultView;
                conn3.Close();
                string ID_хранение = TestTable["MAX(ID_хранение)", TestTable.CurrentRow.Index].Value.ToString();
                int ID_хранение1 = Convert.ToInt32(ID_хранение);
                ID_хранение1 = ID_хранение1 + 1;
                ID_хранение = Convert.ToString(ID_хранение1);


                DataSet ds4 = new DataSet();
                sql = @"SELECT MAX(ID_ответственный)  FROM  Location";
                SQLiteConnection conn4 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da4 = new SQLiteDataAdapter(sql, conn4);

                da4.Fill(ds4);
                TestTable.DataSource = ds4.Tables[0].DefaultView;
                conn4.Close();
                string ID_ответственный = TestTable["MAX(ID_ответственный)", TestTable.CurrentRow.Index].Value.ToString();
                int ID_ответственный1 = Convert.ToInt32(ID_ответственный);
                ID_ответственный1 = ID_ответственный1 + 1;
                ID_ответственный = Convert.ToString(ID_ответственный1);


                DataSet ds5 = new DataSet();
                sql = @"SELECT MAX(ID)  FROM  People";
                SQLiteConnection conn5 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da5 = new SQLiteDataAdapter(sql, conn5);

                da5.Fill(ds5);
                TestTable.DataSource = ds5.Tables[0].DefaultView;
                conn5.Close();
                string IDpeople = TestTable["MAX(ID)", TestTable.CurrentRow.Index].Value.ToString();
                int IDpeople1 = Convert.ToInt32(IDpeople);
                IDpeople1 = IDpeople1 + 1;
                IDpeople = Convert.ToString(IDpeople1);





                DataSet ds6 = new DataSet();
                sql = @"INSERT INTO Charecter ('ID_устройства','ID','Устройство','Название','Производитель','ID_характеристики_устройств','Ширина','Длина'	)
                    VALUES ('" + ID_устройства + "', '" + ID + "','" + Devices + "', '" + Nazvanie + "', '" + Proizvoditel + "', '" + ID_характеристики_устройств + "', '" + Shirin + "', '" + Dlin + "')";
                SQLiteConnection conn6 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da6 = new SQLiteDataAdapter(sql, conn6);

                da6.Fill(ds6);
                conn6.Close();


                DataSet ds7 = new DataSet();
                sql = @"INSERT INTO Status ('ID_статуса','ID_хранение','Утилизация') VALUES ('" + ID_статуса + "', '" + ID_хранение + "','Null')";
                SQLiteConnection conn7 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da7 = new SQLiteDataAdapter(sql, conn7);

                da7.Fill(ds7);
                conn7.Close();

                DataSet ds8 = new DataSet();
                sql = @"INSERT INTO Location ('ID_хранение','Корпус','Этаж','Кабинет','Статус','ID_ответственный') VALUES ('" + ID_хранение + "', '" + Korpus + "','" + Etazhc + "','" + Kabinet + "', '" + Status + "','" + ID_ответственный + "')";
                SQLiteConnection conn8 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da8 = new SQLiteDataAdapter(sql, conn8);

                da8.Fill(ds8);
                conn8.Close();

                DataSet ds9 = new DataSet();
                sql = @"INSERT INTO People ('ID','ID_ответственный'	,'ФИО') VALUES ('" + IDpeople + "', '" + ID_ответственный + "','" + FIO + "')";
                SQLiteConnection conn9 = new SQLiteConnection(ConnectionString);

                SQLiteDataAdapter da9 = new SQLiteDataAdapter(sql, conn9);

                da9.Fill(ds9);
                conn9.Close();


                DataSet ds10 = new DataSet();
                SQLiteConnection conn10 = new SQLiteConnection(ConnectionString);
                string g = ComboBoxAddDropdownDevices.Text;
                if (g == "Материнская плата")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','" + znach1 + "','" + znach2 + "','" + znach3 + "','Null','Null','Null','Null','Null','Null','" + znach4 + "','" + znach5 + "','" + znach6 + "','" + znach7 + "','" + znach8 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null')";


                }
                if (g == "Видеокарта")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','" + znach1 + "','" + znach2 + "','Null','" + znach3 + "','" + znach4 + "','" + znach5 + "','Null','Null','Null','Null','" + znach6 + "','Null','Null','Null','Null','Null','Null','Null')";

                }
                if (g == "Процессор")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','" + znach1 + "','Null','Null','Null','Null','" + znach2 + "','" + znach3 + "','Null','Null','Null','Null','Null','" + znach4 + "','" + znach5 + "','" + znach6 + "','Null','Null','Null','Null','" + znach7 + "','Null','Null','" + znach8 + "','Null','Null','Null','Null','Null','Null','Null')";



                }
                if (g == "Блок питания")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','Null','Null','Null','Null','Null','Null','" + znach1 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','" + znach2 + "','Null','" + znach3 + "','" + znach4 + "','" + znach5 + "','Null','Null','Null','Null','Null','Null','Null','Null')";

                }

                if (g == "Жесткий диск")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','" + znach1 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','" + znach2 + "','Null','Null','" + znach3 + "','" + znach4 + "','" + znach5 + "','Null','Null','Null','Null','Null')";

                }
                if (g == "Монитор")
                {



                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','Null','Null','Null','" + znach1 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','" + znach2 + "','" + znach3 + "','" + znach4 + "','" + znach5 + "','" + znach6 + "')";


                }
                if (g == "Оперативная память")
                {


                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','" + znach1 + "','Null','Null','Null','Null','Null','Null','" + znach2 + "','Null','Null','" + znach3 + "','" + znach4 + "','" + znach5 + "','Null','Null','Null','Null','" + znach6 + "','" + znach7 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null')";




                }
                if (g == "Периферийные устройства")
                {

                    sql1 = @"INSERT INTO GlobalCharecter ('ID_статуса','ID_характеристики_устройств','Количество_слотов','Сокет',
                        'Объем_памяти','Разъем','Частота','Разрешение','Количество_ядер','Техпроцесс','Мощность','Поддержка_памяти',
                        'Поддержка_процессоров','Чипсет','Максимальный_объём_памяти','Максимальная_частота','Базовая_тактовая_частота',
                        'Максимальное_количество_потоков','Видеопамять','Тип_видеопамяти','Тип_охлаждения','Тип_памяти','Напряжение_питания',
                        'Емкость_микросхем','Форм_фактор','Интерфейс_памяти','Скорость_вращения_шпинделя','Тип_накопителя','Диагональ','Соотношение_сторон',
                        'Матрица','Частота_обновления_экрана','Поверхность_экрана') VALUES ('" + ID_статуса + "','" + ID_характеристики_устройств + "','Null','Null','Null','" + znach1 + "','Null','" + znach2 + "','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','Null','" + znach3 + "','" + znach4 + "','" + znach5 + "','Null','Null','Null','Null','Null','Null','Null')";


                }
                SQLiteDataAdapter da10 = new SQLiteDataAdapter(sql1, conn10);

                da10.Fill(ds10);
                conn10.Close();

                Warning.Text = "Запись успешно добавлена\nв базу данных!";
                Warning.ForeColor = Color.FromArgb(71, 202, 94);

                Znach11.Text = "";
                Znach22.Text = "";
                Znach33.Text = "";
                Znach44.Text = "";
                Znach55.Text = "";
                Znach66.Text = "";
                Znach77.Text = "";
                Znach88.Text = "";

                Nazv.Text = "";
                Proizv.Text = "";
                Shirina.Text = "";
                Dlina.Text = "";
                Etazh.Text = "";
                Kabin.Text = "";
                FIOOO.Text = "";
                if (perehod == true)
                {

                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Warning.Text;


                    if (speak != checkspeak)
                    {
                        Speaker_True();checkspeak = "";
                    }
                }
            }

        }
        public string Nazvanie;
        public string Proizvoditel;
        public string Shirin;
        public string Dlin;
        public string Etazhc;
        public string Kabinet;
        public string Korpus;
        public string Status;
        public string FIO;
        // public string ID_статуса;
        //  public string ID_характеристики_устройств;

        public string znach1;
        public string znach2;
        public string znach3;
        public string znach4;
        public string znach5;
        public string znach6;
        public string znach7;
        public string znach8;
        private void Nazv_OnValueChanged(object sender, EventArgs e)
        {
            Nazvanie = Nazv.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label1.Text;
                
                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Proizv_OnValueChanged(object sender, EventArgs e)
        {
            Proizvoditel = Proizv.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label2.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Dlina_OnValueChanged(object sender, EventArgs e)
        {
            Dlin = Dlina.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label4.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Shirina_OnValueChanged(object sender, EventArgs e)
        {
            Shirin = Shirina.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label3.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Etazh_OnValueChanged(object sender, EventArgs e)
        {
            Etazhc = Etazh.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label5.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Kabin_OnValueChanged(object sender, EventArgs e)
        {
            Kabinet = Kabin.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label6.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void ComboBoxAddDropdownStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxAddDropdownStatus.Text;
            if (g == "Эксплуатация")
            {
                Status = "Эксплуатация";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Status;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
            if (g == "Утилизация")
            {
                Status = "Утилизация";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Status;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
            if (g == "Ремонт")
            {
                Status = "Ремонт";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Status;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
            if (g == "Хранение")
            {
                Status = "Хранение";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Status;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
        }

        private void ComboBoxAddKorpusDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string g = ComboBoxAddKorpusDown.Text;
            if (g == "Казинца")
            {
                Korpus = "Казинца";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Korpus;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
            if (g == "Кнорина")
            {
                Korpus = "Кнорина";
                if (perehod == true)
                {
                    speechSynth1.SpeakAsyncCancelAll();
                    checkspeak = speak;
                    speak = Korpus;


                    if (speak != checkspeak)
                        Speaker_True();
                }
            }
        }

        private void FIOOO_OnValueChanged(object sender, EventArgs e)
        {
            FIO = FIOOO.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label7.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach11_OnValueChanged(object sender, EventArgs e)
        {
            znach1 = Znach11.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label11.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach22_OnValueChanged(object sender, EventArgs e)
        {
            znach2 = Znach22.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label22.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach33_OnValueChanged(object sender, EventArgs e)
        {
            znach3 = Znach33.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label33.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach44_OnValueChanged(object sender, EventArgs e)
        {
            znach4 = Znach44.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label44.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach55_OnValueChanged(object sender, EventArgs e)
        {
            znach5 = Znach55.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label55.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach66_OnValueChanged(object sender, EventArgs e)
        {
            znach6 = Znach66.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label66.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }

        private void Znach77_OnValueChanged(object sender, EventArgs e)
        {
            znach7 = Znach77.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label77.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();

                }

            }
        }

        private void Znach88_OnValueChanged(object sender, EventArgs e)
        {
            znach8 = Znach88.Text;
            if (perehod == true)
            {
                speechSynth1.SpeakAsyncCancelAll();
                checkspeak = speak;
                speak = label88.Text;

                if (speak != checkspeak)
                {
                    Speaker_True();
                }

            }
        }


    }

}
