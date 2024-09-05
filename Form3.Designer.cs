namespace Keanan_s_Modern_Task_Tracker
{
    partial class Form3
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
            this.TaskIDBox = new AltoControls.AltoTextBox();
            this.FindTaskbtn = new AltoControls.AltoButton();
            this.TaskNameBox = new AltoControls.AltoTextBox();
            this.PriorityBox = new AltoControls.AltoTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CompletedBox = new AltoControls.AltoTextBox();
            this.FinishEdit = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Enabled = false;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(151, 12);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(175, 34);
            this.altoTextBox1.TabIndex = 0;
            this.altoTextBox1.Text = "Edit Task";
            this.altoTextBox1.Click += new System.EventHandler(this.altoTextBox1_Click);
            // 
            // altoTextBox2
            // 
            this.altoTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox2.Br = System.Drawing.Color.White;
            this.altoTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox2.Location = new System.Drawing.Point(429, 235);
            this.altoTextBox2.Name = "altoTextBox2";
            this.altoTextBox2.Size = new System.Drawing.Size(8, 8);
            this.altoTextBox2.TabIndex = 1;
            this.altoTextBox2.Text = "altoTextBox2";
            // 
            // TaskIDBox
            // 
            this.TaskIDBox.BackColor = System.Drawing.Color.Transparent;
            this.TaskIDBox.Br = System.Drawing.Color.White;
            this.TaskIDBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskIDBox.ForeColor = System.Drawing.Color.DimGray;
            this.TaskIDBox.Location = new System.Drawing.Point(12, 52);
            this.TaskIDBox.Name = "TaskIDBox";
            this.TaskIDBox.Size = new System.Drawing.Size(175, 34);
            this.TaskIDBox.TabIndex = 2;
            this.TaskIDBox.Text = "Task ID";
            // 
            // FindTaskbtn
            // 
            this.FindTaskbtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.FindTaskbtn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.FindTaskbtn.BackColor = System.Drawing.Color.Transparent;
            this.FindTaskbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FindTaskbtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.FindTaskbtn.ForeColor = System.Drawing.Color.Black;
            this.FindTaskbtn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.FindTaskbtn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.FindTaskbtn.Location = new System.Drawing.Point(193, 52);
            this.FindTaskbtn.Name = "FindTaskbtn";
            this.FindTaskbtn.Radius = 10;
            this.FindTaskbtn.Size = new System.Drawing.Size(119, 30);
            this.FindTaskbtn.Stroke = false;
            this.FindTaskbtn.StrokeColor = System.Drawing.Color.Gray;
            this.FindTaskbtn.TabIndex = 3;
            this.FindTaskbtn.Text = "FindTask";
            this.FindTaskbtn.Transparency = false;
            this.FindTaskbtn.Click += new System.EventHandler(this.FindTaskbtn_Click);
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.BackColor = System.Drawing.Color.Transparent;
            this.TaskNameBox.Br = System.Drawing.Color.White;
            this.TaskNameBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.TaskNameBox.Location = new System.Drawing.Point(12, 120);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(175, 34);
            this.TaskNameBox.TabIndex = 4;
            this.TaskNameBox.Text = "TaskName";
            // 
            // PriorityBox
            // 
            this.PriorityBox.BackColor = System.Drawing.Color.Transparent;
            this.PriorityBox.Br = System.Drawing.Color.White;
            this.PriorityBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityBox.ForeColor = System.Drawing.Color.DimGray;
            this.PriorityBox.Location = new System.Drawing.Point(12, 160);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(175, 34);
            this.PriorityBox.TabIndex = 5;
            this.PriorityBox.Text = "Priority";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // CompletedBox
            // 
            this.CompletedBox.BackColor = System.Drawing.Color.Transparent;
            this.CompletedBox.Br = System.Drawing.Color.White;
            this.CompletedBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedBox.ForeColor = System.Drawing.Color.DimGray;
            this.CompletedBox.Location = new System.Drawing.Point(12, 226);
            this.CompletedBox.Name = "CompletedBox";
            this.CompletedBox.Size = new System.Drawing.Size(175, 34);
            this.CompletedBox.TabIndex = 7;
            this.CompletedBox.Text = "Completed";
            // 
            // FinishEdit
            // 
            this.FinishEdit.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.FinishEdit.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.FinishEdit.BackColor = System.Drawing.Color.Transparent;
            this.FinishEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FinishEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishEdit.ForeColor = System.Drawing.Color.Black;
            this.FinishEdit.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.FinishEdit.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.FinishEdit.Location = new System.Drawing.Point(12, 275);
            this.FinishEdit.Name = "FinishEdit";
            this.FinishEdit.Radius = 10;
            this.FinishEdit.Size = new System.Drawing.Size(175, 30);
            this.FinishEdit.Stroke = false;
            this.FinishEdit.StrokeColor = System.Drawing.Color.Gray;
            this.FinishEdit.TabIndex = 8;
            this.FinishEdit.Text = "Finish Task Edit";
            this.FinishEdit.Transparency = false;
            this.FinishEdit.Click += new System.EventHandler(this.FinishEdit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.FinishEdit);
            this.Controls.Add(this.CompletedBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.TaskNameBox);
            this.Controls.Add(this.FindTaskbtn);
            this.Controls.Add(this.TaskIDBox);
            this.Controls.Add(this.altoTextBox2);
            this.Controls.Add(this.altoTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoTextBox altoTextBox2;
        private AltoControls.AltoTextBox TaskIDBox;
        private AltoControls.AltoButton FindTaskbtn;
        private AltoControls.AltoTextBox TaskNameBox;
        private AltoControls.AltoTextBox PriorityBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private AltoControls.AltoTextBox CompletedBox;
        private AltoControls.AltoButton FinishEdit;
    }
}