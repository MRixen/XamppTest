using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace XamppTest
{
    public partial class Form1 : Form
    {                   
        string conString = "Server=192.168.0.22;Database=moveforward;Uid=root;Pwd=rbc;";

        public Form1()
        {
            InitializeComponent();            
        }

        private void buttonSubmitClicked_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(conString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO s1(x,y,z,timestamp)VALUES(@x,@y,@z,@timestamp)";
                cmd.Parameters.AddWithValue("@x", int.Parse(txt_x.Text));
                cmd.Parameters.AddWithValue("@y", int.Parse(txt_y.Text));
                cmd.Parameters.AddWithValue("@z", int.Parse(txt_z.Text));
                cmd.Parameters.AddWithValue("@timestamp", int.Parse(txt_timestamp.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM s1";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
