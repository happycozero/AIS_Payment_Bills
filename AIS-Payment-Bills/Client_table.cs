using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Payment_Bills
{
    public partial class Client_table : MetroForm
    {
        string ID = "";

        public Client_table()
        {
            InitializeComponent();
        }

        private void Client_table_Load(object sender, EventArgs e)
        {
            Mod.MaxLength = 40;
            Facial_Score.MaxLength = 9;
            Fam.MaxLength = 50;
            Ph.MaxLength = 11;
            Square_M.MaxLength = 4;

            textBox2.ReadOnly = true;
            textBox1.Enabled = false;
            fil();
            string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
            OleDbConnection oleDbConn1 = new OleDbConnection(con1);
            DataTable dt1 = new DataTable();
            oleDbConn1.Open();
            OleDbCommand sql1 = new OleDbCommand("SELECT * FROM Client_table;")
            {
                Connection = oleDbConn1
            };
            sql1.ExecuteNonQuery();
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
            da1.Fill(dt1);

            dt1.Columns["management"].ColumnName = "Управляющая компания";
            dt1.Columns["facial_score"].ColumnName = "Лицевой счет";
            dt1.Columns["full_name"].ColumnName = "ФИО";
            dt1.Columns["phone"].ColumnName = "Телефон";
            dt1.Columns["square"].ColumnName = "Площадь";


            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 110;

            oleDbConn1.Close();

            dataGridView1.AllowUserToAddRows = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mod.Text == "" || Facial_Score.Text == "" || Fam.Text == "" || Ph.Text == "" || Square_M.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение", MessageBoxButtons.OK);
            }
            else
            {
                string Organ = Mod.Text.ToString();
                string Own = Facial_Score.Text.ToString();
                string Activ = Fam.Text.ToString();
                string Addr = Ph.Text.ToString();
                string square = Square_M.Text.ToString();

                int id = 0;
                Random rnd = new Random();
                id = rnd.Next(8, 50000000);

                string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);
                oleDbConn.Open();
                OleDbCommand sql = new OleDbCommand("INSERT INTO Client_table (id, management, facial_score, full_name, phone, square) VALUES (" + id + ",'" + Organ + "','" + Own + "', '" + Activ + "', '" + Addr + "', '" + square + "');")
                {
                    Connection = oleDbConn
                };
                sql.ExecuteNonQuery();
                oleDbConn.Close();
                MessageBox.Show("Запись в базу добавлена", "Сообщение пользователю", MessageBoxButtons.OK);
                UpdatedataGridViewScore();
                Mod.Text = "";
                Facial_Score.Clear();
                Fam.Clear();
                Ph.Clear();
                Square_M.Clear();

            }
        }

        public void fil()
        {
            textBox2.Text = nuls.dat;
            string s = nuls.str;
            string con12 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;"; // строка подключения
            OleDbConnection oleDbConn12 = new OleDbConnection(con12); // создаем подключение
            DataTable dt12 = new DataTable(); // создаем таблицу
            oleDbConn12.Open(); // открываем подкл
            OleDbCommand sql = new OleDbCommand("SELECT full_name FROM Employee_table WHERE login = '" + s + "';");
            OleDbDataAdapter da12 = new OleDbDataAdapter(sql);
            sql.Connection = oleDbConn12; // привязываем запрос к конекту
            sql.ExecuteNonQuery(); //выполнение
            da12.Fill(dt12);
            textBox1.Text = Convert.ToString(dt12.Rows[0].ItemArray.GetValue(0));
            oleDbConn12.Close();

        }
        public void UpdatedataGridViewScore()
        {
            string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
            OleDbConnection oleDbConn1 = new OleDbConnection(con1);
            DataTable dt1 = new DataTable();
            oleDbConn1.Open();
            OleDbCommand sql1 = new OleDbCommand("SELECT * FROM Client_table;")
            {
                Connection = oleDbConn1
            };
            sql1.ExecuteNonQuery();
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
            da1.Fill(dt1);
            dt1.Columns["management"].ColumnName = "Управляющая компания";
            dt1.Columns["facial_score"].ColumnName = "Лицевой счет";
            dt1.Columns["full_name"].ColumnName = "ФИО";
            dt1.Columns["phone"].ColumnName = "Телефон";
            dt1.Columns["square"].ColumnName = "Площадь";


            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 110;
            oleDbConn1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mod.Text == "" || Facial_Score.Text == "" || Fam.Text == "" || Ph.Text == "" || Square_M.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение", MessageBoxButtons.OK);
            }
            else
            {
                string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);
                oleDbConn.Open();
                OleDbCommand sql = new OleDbCommand("UPDATE Client_table SET management='" + Mod.Text + "', facial_score = '" + Facial_Score.Text + "', full_name = '" + Fam.Text + "', phone = '" + Ph.Text + "', square = '" + Square_M.Text + "' Where id=" + Convert.ToInt32(ID) + ";")
                {
                    Connection = oleDbConn
                }; // создаем запрос
                sql.ExecuteNonQuery();

                oleDbConn.Close();

                UpdatedataGridViewScore();

                Mod.Text = "";
                Facial_Score.Text = "";
                Fam.Text = "";
                Ph.Text = "";
                Square_M.Text = "";

                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
            ID = dataGridView1.SelectedCells[0].Value.ToString();

            string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
            OleDbConnection oleDbConn1 = new OleDbConnection(con1);
            DataTable dt1 = new DataTable();

            oleDbConn1.Open();
            OleDbCommand sql1 = new OleDbCommand("SELECT * FROM Client_table Where id = " + Convert.ToInt32(ID) + ";");
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
            sql1.Connection = oleDbConn1;
            sql1.ExecuteNonQuery();

            da1.Fill(dt1);

            Mod.Text = dt1.Rows[0].ItemArray.GetValue(1).ToString();
            Facial_Score.Text = dt1.Rows[0].ItemArray.GetValue(2).ToString();
            Fam.Text = dt1.Rows[0].ItemArray.GetValue(3).ToString();
            Ph.Text = dt1.Rows[0].ItemArray.GetValue(4).ToString();
            Square_M.Text = dt1.Rows[0].ItemArray.GetValue(5).ToString();

            oleDbConn1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = false;
            ID = dataGridView1.SelectedCells[0].Value.ToString();

            string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
            OleDbConnection oleDbConn1 = new OleDbConnection(con1);
            DataTable dt1 = new DataTable();

            oleDbConn1.Open();
            OleDbCommand sql1 = new OleDbCommand("DELETE * FROM Client_table Where id = " + Convert.ToInt32(ID) + ";");
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
            sql1.Connection = oleDbConn1;
            sql1.ExecuteNonQuery();

            da1.Fill(dt1);

            oleDbConn1.Close();

            UpdatedataGridViewScore();

            Mod.Text = "";
            Facial_Score.Text = "";
            Fam.Text = "";
            Ph.Text = "";
            Square_M.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Visible = false;
            menu.ShowDialog();
        }

        private void Mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'а') && (e.KeyChar <= 'я')) || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) || (e.KeyChar == ' ') || (e.KeyChar == '.') || (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void Facial_Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void Fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 'а') && (e.KeyChar <= 'я')) || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) || (e.KeyChar == ' ') || (e.KeyChar == '.') || (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void Ph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void Square_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Facial_Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void Square_M_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Facial_Score.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните поле 'Лицевой счет'");
            }

            else
            {
                //dataGridView1.Rows.Clear();

                string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                OleDbConnection oleDbConn1 = new OleDbConnection(con1);
                DataTable dt1 = new DataTable();

                oleDbConn1.Open();
                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM Client_table Where facial_score = " + Convert.ToInt32(Facial_Score.Text) + ";");
                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
                sql1.Connection = oleDbConn1;
                sql1.ExecuteNonQuery();
                
                da1.Fill(dt1);


                dt1.Columns["management"].ColumnName = "Управляющая компания";
                dt1.Columns["facial_score"].ColumnName = "Лицевой счет";
                dt1.Columns["full_name"].ColumnName = "ФИО";
                dt1.Columns["phone"].ColumnName = "Телефон";
                dt1.Columns["square"].ColumnName = "Площадь";


                dataGridView1.DataSource = dt1;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 240;
                dataGridView1.Columns[4].Width = 140;
                dataGridView1.Columns[5].Width = 110;

                oleDbConn1.Close();

            }
        }
    }
}
