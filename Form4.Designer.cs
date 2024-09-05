namespace Keanan_s_Modern_Task_Tracker
{
    partial class Form4
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
            this.FindTaskbtn = new AltoControls.AltoButton();
            this.TaskIDBox = new AltoControls.AltoTextBox();
            this.altoButton1 = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Enabled = false;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(91, 12);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(175, 34);
            this.altoTextBox1.TabIndex = 1;
            this.altoTextBox1.Text = "Remove Task";
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
            this.FindTaskbtn.Location = new System.Drawing.Point(211, 63);
            this.FindTaskbtn.Name = "FindTaskbtn";
            this.FindTaskbtn.Radius = 10;
            this.FindTaskbtn.Size = new System.Drawing.Size(119, 30);
            this.FindTaskbtn.Stroke = false;
            this.FindTaskbtn.StrokeColor = System.Drawing.Color.Gray;
            this.FindTaskbtn.TabIndex = 10;
            this.FindTaskbtn.Text = "FindTask";
            this.FindTaskbtn.Transparency = false;
            this.FindTaskbtn.Click += new System.EventHandler(this.FindTaskbtn_Click);
            // 
            // TaskIDBox
            // 
            this.TaskIDBox.BackColor = System.Drawing.Color.Transparent;
            this.TaskIDBox.Br = System.Drawing.Color.White;
            this.TaskIDBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskIDBox.ForeColor = System.Drawing.Color.DimGray;
            this.TaskIDBox.Location = new System.Drawing.Point(12, 63);
            this.TaskIDBox.Name = "TaskIDBox";
            this.TaskIDBox.Size = new System.Drawing.Size(175, 34);
            this.TaskIDBox.TabIndex = 9;
            this.TaskIDBox.Text = "Task ID";
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton1.ForeColor = System.Drawing.Color.Black;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.altoButton1.Location = new System.Drawing.Point(135, 103);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(119, 30);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 11;
            this.altoButton1.Text = "Remove Task";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.FindTaskbtn);
            this.Controls.Add(this.TaskIDBox);
            this.Controls.Add(this.altoTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoButton FindTaskbtn;
        private AltoControls.AltoTextBox TaskIDBox;
        private AltoControls.AltoButton altoButton1;
    }
}