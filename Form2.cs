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
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Keanan_s_Modern_Task_Tracker
{
    public partial class Form2 : Form
    {

       
        public Form2()
        {

            int ID;
            string Taskname;
            string[] prioritystrings = { "High", "Med", "Low" }; //Different Priority Values
            int Date;
            string[] Completed = { "Yes", "No" }; //Compelted Yes or no Values
            
            InitializeComponent();
            
        }

        

        private void altoTextBox3_Click(object sender, EventArgs e)
        {
            //Task Name Textbox
        }

        private void altoTextBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void AddTaskbtn2_Click(object sender, EventArgs e)
        {
            string Taskname = TaskNameText.Text;
            Random random = new Random();
            int ID = random.Next(100, 10000); //So tasks ids will have lower chance of having same number, shit way to do this
            string Priority = PriorityText.Text; //Fix this at later date to make sure cant put anything else other than high med low
            string  date = dateTimePicker1.Value.ToString("dd -MM-yyyy");
            string completed = CompletedTextbox.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\f\\source\\repos\\Keanan's Modern Task Tracker\\Database1.mdf\";Integrated Security=True");
            
            SqlCommand cmd = new SqlCommand("insert into Test VALUES (@Name,@Task,@Priority,@DueDate,@Completed)", con);
            cmd.Parameters.AddWithValue("@Name", SqlDbType.Int).Value = ID;
            cmd.Parameters.AddWithValue("@Task", SqlDbType.NVarChar).Value = Taskname;
            cmd.Parameters.AddWithValue("@Priority", SqlDbType.NChar).Value = Priority;
            cmd.Parameters.AddWithValue("@DueDate", SqlDbType.DateTime).Value = date;
            cmd.Parameters.AddWithValue("@Completed", SqlDbType.NChar).Value = completed;
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Task added");
            this.Close();
            Application.Restart(); //Updates Datagrid, had issues updating datagrid and binding etc

            



            













        }
        
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Priority_Click(object sender, EventArgs e)
        {

        }

        
    }
}
