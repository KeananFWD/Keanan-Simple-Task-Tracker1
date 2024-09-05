using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace Keanan_s_Modern_Task_Tracker
{
    public partial class Form3 : Form
    {

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\f\\source\\repos\\Keanan's Modern Task Tracker\\Database1.mdf\";Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void altoTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FindTaskbtn_Click(object sender, EventArgs e)
        {
            int Taskid = int.Parse(TaskIDBox.Text);

            //looking up the id in the database 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Test WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", Taskid);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                DA.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //This should fill the textboxes with right info, i hope so this took way to long
                    DataRow row = dt.Rows[0];
                    TaskNameBox.Text = row["Task"].ToString();
                    PriorityBox.Text = row["Priority"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row["DueDate"]);
                    CompletedBox.Text = row["Completed"].ToString(); //just realising now I should of used a yes no check box or something lol
                }
                else
                {
                    MessageBox.Show("That task can not be found recheck task name id");
                }



            }

        }

        private void FinishEdit_Click(object sender, EventArgs e)
        {

            string task = TaskNameBox.Text;
            int name = int.Parse(TaskIDBox.Text);
            string priority = PriorityBox.Text;
            DateTime DueDate = dateTimePicker1.Value;
            string completed = CompletedBox.Text;
            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Test SET Task = @Task, Priority = @Priority, DueDate = @DueDate, Completed = @Completed WHERE Name = @Name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Task", task);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@DueDate", DueDate);
                    cmd.Parameters.AddWithValue("@Completed", completed);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task has been updated");
                    Application.Restart();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
