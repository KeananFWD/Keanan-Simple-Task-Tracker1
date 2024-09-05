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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Keanan_s_Modern_Task_Tracker
{
    public partial class Form4 : Form
    {

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\f\\source\\repos\\Keanan's Modern Task Tracker\\Database1.mdf\";Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void TaskNameBox_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Task Found"); //Finds new task
                }
                else
                {
                    MessageBox.Show("That task can not be found recheck task name id");
                }
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
        //finish

        }
    }
}


 
                    
