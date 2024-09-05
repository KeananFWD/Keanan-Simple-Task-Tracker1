using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Keanan_s_Modern_Task_Tracker
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\f\\source\\repos\\Keanan's Modern Task Tracker\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Test", sqlCon);
                DataTable dtbl1 = new DataTable();
                sqlDa.Fill(dtbl1);

                dataGridView1.DataSource = dtbl1;
            }







        }

        private void AddTaskbtn_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show(); //Will open form2 when pressed, allowing users to add tasks
            dataGridView1.Update();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\f\\source\\repos\\Keanan's Modern Task Tracker\\Database1.mdf\";Integrated Security=True";
            DialogResult result = MessageBox.Show("This will delete all the tasks",
                                              "Yes No",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    try
                    {
                        sqlCon.Open();
                        string query = "DELETE FROM Test";
                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();
                        Application.Restart();
                        //all rows are deleted now so it should be clear
                    }
                    catch (Exception ex)
                    {
                     //program succesfully cleared all rows so hopefully no issues in future but this is here incase
                    }
                }
            }
        }

        private void EditTaskbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void RemoveTaskbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}


