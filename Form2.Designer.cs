namespace Keanan_s_Modern_Task_Tracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.altoTextBox2 = new AltoControls.AltoTextBox();
            this.TaskNameText = new AltoControls.AltoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriorityText = new AltoControls.AltoTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Completedlbl = new System.Windows.Forms.Label();
            this.CompletedTextbox = new AltoControls.AltoTextBox();
            this.AddTaskbtn2 = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Enabled = false;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(124, 12);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(135, 33);
            this.altoTextBox1.TabIndex = 0;
            this.altoTextBox1.Text = "Add Tasks";
            // 
            // altoTextBox2
            // 
            this.altoTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox2.Br = System.Drawing.Color.White;
            this.altoTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox2.Location = new System.Drawing.Point(152, 72);
            this.altoTextBox2.Name = "altoTextBox2";
            this.altoTextBox2.Size = new System.Drawing.Size(9, 8);
            this.altoTextBox2.TabIndex = 1;
            this.altoTextBox2.Text = "altoTextBox2";
            // 
            // TaskNameText
            // 
            this.TaskNameText.BackColor = System.Drawing.Color.Transparent;
            this.TaskNameText.Br = System.Drawing.Color.White;
            this.TaskNameText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameText.ForeColor = System.Drawing.Color.DimGray;
            this.TaskNameText.Location = new System.Drawing.Point(12, 86);
            this.TaskNameText.Name = "TaskNameText";
            this.TaskNameText.Size = new System.Drawing.Size(135, 33);
            this.TaskNameText.TabIndex = 2;
            this.TaskNameText.Text = "Task Name";
            this.TaskNameText.Click += new System.EventHandler(this.altoTextBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority High, Med, Low";
            // 
            // PriorityText
            // 
            this.PriorityText.BackColor = System.Drawing.Color.Transparent;
            this.PriorityText.Br = System.Drawing.Color.White;
            this.PriorityText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityText.ForeColor = System.Drawing.Color.DimGray;
            this.PriorityText.Location = new System.Drawing.Point(12, 150);
            this.PriorityText.Name = "PriorityText";
            this.PriorityText.Size = new System.Drawing.Size(135, 33);
            this.PriorityText.TabIndex = 5;
            this.PriorityText.Text = "Priority";
            this.PriorityText.Click += new System.EventHandler(this.Priority_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Due Date?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Completedlbl
            // 
            this.Completedlbl.AutoSize = true;
            this.Completedlbl.Location = new System.Drawing.Point(23, 247);
            this.Completedlbl.Name = "Completedlbl";
            this.Completedlbl.Size = new System.Drawing.Size(109, 13);
            this.Completedlbl.TabIndex = 8;
            this.Completedlbl.Text = "Completed? Yes / No";
            // 
            // CompletedTextbox
            // 
            this.CompletedTextbox.BackColor = System.Drawing.Color.Transparent;
            this.CompletedTextbox.Br = System.Drawing.Color.White;
            this.CompletedTextbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.CompletedTextbox.Location = new System.Drawing.Point(12, 263);
            this.CompletedTextbox.Name = "CompletedTextbox";
            this.CompletedTextbox.Size = new System.Drawing.Size(135, 33);
            this.CompletedTextbox.TabIndex = 9;
            this.CompletedTextbox.Text = "Completed? ";
            this.CompletedTextbox.Click += new System.EventHandler(this.altoTextBox3_Click_1);
            // 
            // AddTaskbtn2
            // 
            this.AddTaskbtn2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.AddTaskbtn2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.AddTaskbtn2.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskbtn2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddTaskbtn2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.AddTaskbtn2.ForeColor = System.Drawing.Color.Black;
            this.AddTaskbtn2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.AddTaskbtn2.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.AddTaskbtn2.Location = new System.Drawing.Point(152, 319);
            this.AddTaskbtn2.Name = "AddTaskbtn2";
            this.AddTaskbtn2.Radius = 10;
            this.AddTaskbtn2.Size = new System.Drawing.Size(84, 30);
            this.AddTaskbtn2.Stroke = false;
            this.AddTaskbtn2.StrokeColor = System.Drawing.Color.Gray;
            this.AddTaskbtn2.TabIndex = 10;
            this.AddTaskbtn2.Text = "Add Task";
            this.AddTaskbtn2.Transparency = false;
            this.AddTaskbtn2.Click += new System.EventHandler(this.AddTaskbtn2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.AddTaskbtn2);
            this.Controls.Add(this.CompletedTextbox);
            this.Controls.Add(this.Completedlbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskNameText);
            this.Controls.Add(this.altoTextBox2);
            this.Controls.Add(this.altoTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoTextBox altoTextBox2;
        private AltoControls.AltoTextBox TaskNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox PriorityText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Completedlbl;
        private AltoControls.AltoTextBox CompletedTextbox;
        private AltoControls.AltoButton AddTaskbtn2;
    }
}