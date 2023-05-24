using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpo_3
{
    public partial class Form1 : Form
    {
        string Connection = "Server=AORUS;Integrated Security=true;";

        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection connection;



        private void button1_Click(object sender, EventArgs e) // добавление класса
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.AddClass(ClassTB.Text);
            dataGridViewClass.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideClass", null).Tables[0].DefaultView;

        }


        private void tabControlGuide_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            switch (tabControlGuide.SelectedIndex)
            {
                case 0:
                    dataGridViewClass.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideClass", null).Tables[0].DefaultView;
                    break;


                case 1:
                    dataGridViewObject.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideObject", null).Tables[0].DefaultView;
                    break;


                case 2:
                    dataGridViewEstimation.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideEstimation", null).Tables[0].DefaultView;
                    break;

            }
            database.connection.Close();
        }

        private void tabControlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            switch(tabControlMenu.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    database = new DatabaseWorks(Connection);
                    dataGridViewBuffer.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideClass", null).Tables[0].DefaultView;
                    comboBoxObject.Items.Clear();
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxClass.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
                    }

                    database = new DatabaseWorks(Connection);
                    dataGridViewBuffer.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideObject", null).Tables[0].DefaultView;
                    comboBoxObject.Items.Clear();
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxObject.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
                    }
                    database.connection.Close();

                    database = new DatabaseWorks(Connection);
                    dataGridViewBuffer.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideEstimation", null).Tables[0].DefaultView;
                    comboBoxEstimation.Items.Clear();
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxEstimation.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
                    }
                    database.connection.Close();
                    database = new DatabaseWorks(Connection);
                    dataGridViewLearner.DataSource = database.ReturnTable("*", "trpo_4.dbo.Learner", null).Tables[0].DefaultView;
                    break;
                case 2:
                    dataGridViewJournal.DataSource = database.ReturnTable("a.id as id, a.name as Имя, a.surname as Фамилия, a.patronymic as Отчество, a.data as Дата, b.name as Класс, c.name as Оценка, d.name as Предмет",
                "trpo_4.dbo.Learner as a, trpo_4.dbo.GuideClass as b, trpo_4.dbo.GuideEstimation as c, trpo_4.dbo.GuideObject as d",
                $"WHERE a.classId = b.id AND a.objectId = d.id AND a.estimationId = c.id").Tables[0].DefaultView;
                    break;
            }
            database.connection.Close();
        }

        private void ClassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            dataGridViewClass.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideClass", null).Tables[0].DefaultView;
            dataGridViewObject.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideObject", null).Tables[0].DefaultView;
            dataGridViewEstimation.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideEstimation", null).Tables[0].DefaultView;

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            string sql = "SELECT * FROM [trpo_4].[dbo].[GuideClass]";
            DatabaseWorks connection = new DatabaseWorks(Connection);
            using (SqlCommand cmd = new SqlCommand(sql, connection.connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBoxClass.DisplayMember = "Learner";
                comboBoxClass.ValueMember = "id";
                comboBoxClass.DataSource = table;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.AddObject(ObjectTB.Text);
            dataGridViewObject.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideObject", null).Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.AddEstimation(estimationTB.Text);
            dataGridViewEstimation.DataSource = database.ReturnTable("*", "trpo_4.dbo.GuideEstimation", null).Tables[0].DefaultView;
        }

        private void estimationTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            
            string Date = DataTimeD.Value.ToString("dd.MM.yyyy");
            database.AddLearner(surnameTB.Text, nameTB.Text, patronymicTB.Text, comboBoxClass.Text.Split(' ')[0], comboBoxObject.Text.Split(' ')[0], comboBoxEstimation.Text.Split(' ')[0], Date);
            dataGridViewLearner.DataSource = database.ReturnTable("*", "trpo_4.dbo.Learner", null).Tables[0].DefaultView;
            database.connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new DatabaseWorks(Connection);
            dataGridViewJournal.DataSource = db.ReturnTable(
                "a.id as id, a.name as Имя, a.surname as Фамилия, a.patronymic as Отчество, a.data as Дата, b.name as Класс, c.name as Оценка, d.name as Предмет", 
                "trpo_4.dbo.Learner as a, trpo_4.dbo.GuideClass as b, trpo_4.dbo.GuideEstimation as c, trpo_4.dbo.GuideObject as d", 
                $"WHERE surname = '{textBoxFilter.Text}' AND a.classId = b.id AND a.objectId = d.id AND a.estimationId = c.id").Tables[0].DefaultView;
        }
    }
}
