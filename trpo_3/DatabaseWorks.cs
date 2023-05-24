using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace trpo_3
{
    internal class DatabaseWorks
    {
        public SqlConnection connection;

        public DatabaseWorks(string credentials)
        {
            connection = new SqlConnection(credentials);
            connection.Open();
        }

        public DataSet ReturnTable(string Columns, string TablesName, string Arguments)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {TablesName} {Arguments}", connection);
            DataSet dataset = new DataSet();
            sqlData.Fill(dataset);
            return dataset;
        }

        public string AddClass(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO trpo_4.dbo.GuideClass (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddObject(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO trpo_4.dbo.GuideObject (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }


        public string AddEstimation(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO trpo_4.dbo.GuideEstimation (name) values ('{name}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }


        public string AddLearner(string surname, string name, string patronymic, string clas, string obect, string estimation, string Data)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO trpo_4.dbo.Learner (surname, name, patronymic, classId, objectId, estimationId, data) values ('{surname}', '{name}', '{patronymic}', '{clas}', '{obect}', '{estimation}', '{Data}');", connection);
                return $"comand complete: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }


    }


}
