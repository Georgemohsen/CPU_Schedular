namespace CPU_Schedular
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Scheduling_Algorithms = new System.Windows.Forms.GroupBox();
            this.Preemptive = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Round_Robin = new System.Windows.Forms.RadioButton();
            this.Priority = new System.Windows.Forms.RadioButton();
            this.SJB = new System.Windows.Forms.RadioButton();
            this.FIFO = new System.Windows.Forms.RadioButton();
            this.Simulate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Scheduling_Algorithms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(636, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(199, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Scheduling_Algorithms
            // 
            this.Scheduling_Algorithms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Scheduling_Algorithms.Controls.Add(this.Preemptive);
            this.Scheduling_Algorithms.Controls.Add(this.numericUpDown1);
            this.Scheduling_Algorithms.Controls.Add(this.Round_Robin);
            this.Scheduling_Algorithms.Controls.Add(this.Priority);
            this.Scheduling_Algorithms.Controls.Add(this.SJB);
            this.Scheduling_Algorithms.Controls.Add(this.FIFO);
            this.Scheduling_Algorithms.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scheduling_Algorithms.Location = new System.Drawing.Point(12, 293);
            this.Scheduling_Algorithms.Name = "Scheduling_Algorithms";
            this.Scheduling_Algorithms.Size = new System.Drawing.Size(354, 188);
            this.Scheduling_Algorithms.TabIndex = 7;
            this.Scheduling_Algorithms.TabStop = false;
            this.Scheduling_Algorithms.Text = "Scheduling Algorithms";
            // 
            // Preemptive
            // 
            this.Preemptive.AutoSize = true;
            this.Preemptive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preemptive.Location = new System.Drawing.Point(242, 75);
            this.Preemptive.Name = "Preemptive";
            this.Preemptive.Size = new System.Drawing.Size(103, 22);
            this.Preemptive.TabIndex = 5;
            this.Preemptive.Text = "Preemptive";
            this.Preemptive.UseVisualStyleBackColor = true;
            this.Preemptive.CheckedChanged += new System.EventHandler(this.Preemptive_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(242, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Round_Robin
            // 
            this.Round_Robin.AutoSize = true;
            this.Round_Robin.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_Robin.Location = new System.Drawing.Point(6, 152);
            this.Round_Robin.Name = "Round_Robin";
            this.Round_Robin.Size = new System.Drawing.Size(141, 21);
            this.Round_Robin.TabIndex = 3;
            this.Round_Robin.TabStop = true;
            this.Round_Robin.Text = "Round Robin (RR)";
            this.Round_Robin.UseVisualStyleBackColor = true;
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority.Location = new System.Drawing.Point(6, 114);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(72, 21);
            this.Priority.TabIndex = 2;
            this.Priority.TabStop = true;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            // 
            // SJB
            // 
            this.SJB.AutoSize = true;
            this.SJB.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJB.Location = new System.Drawing.Point(6, 75);
            this.SJB.Name = "SJB";
            this.SJB.Size = new System.Drawing.Size(173, 21);
            this.SJB.TabIndex = 1;
            this.SJB.TabStop = true;
            this.SJB.Text = "Shortest-Job-First (SJF)";
            this.SJB.UseVisualStyleBackColor = true;
            // 
            // FIFO
            // 
            this.FIFO.AutoSize = true;
            this.FIFO.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIFO.Location = new System.Drawing.Point(6, 39);
            this.FIFO.Name = "FIFO";
            this.FIFO.Size = new System.Drawing.Size(219, 21);
            this.FIFO.TabIndex = 0;
            this.FIFO.TabStop = true;
            this.FIFO.Text = "First Come ,First Served (FCFS)";
            this.FIFO.UseVisualStyleBackColor = true;
            // 
            // Simulate
            // 
            this.Simulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Simulate.Location = new System.Drawing.Point(386, 430);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(86, 47);
            this.Simulate.TabIndex = 4;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = false;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(277, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(744, 24);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(159, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU Workflow";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(668, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average Waiting Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.Scheduling_Algorithms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Schedular";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Scheduling_Algorithms.ResumeLayout(false);
            this.Scheduling_Algorithms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Scheduling_Algorithms;
        private System.Windows.Forms.RadioButton Round_Robin;
        private System.Windows.Forms.RadioButton Priority;
        private System.Windows.Forms.RadioButton SJB;
        private System.Windows.Forms.RadioButton FIFO;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox Preemptive;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}

