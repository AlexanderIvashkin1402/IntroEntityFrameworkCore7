namespace TaskManager
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
            groupBox1 = new GroupBox();
            cmdCancel = new Button();
            cmdDeleteTask = new Button();
            cmdUpdateTask = new Button();
            cmdCreateTask = new Button();
            label3 = new Label();
            cboStatus = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtTask = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmdCancel);
            groupBox1.Controls.Add(cmdDeleteTask);
            groupBox1.Controls.Add(cmdUpdateTask);
            groupBox1.Controls.Add(cmdCreateTask);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTask);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(583, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(327, 82);
            cmdCancel.Margin = new Padding(4, 3, 4, 3);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(88, 27);
            cmdCancel.TabIndex = 9;
            cmdCancel.Text = "Cancel";
            cmdCancel.UseVisualStyleBackColor = true;
            cmdCancel.Click += cmdCancel_Click;
            // 
            // cmdDeleteTask
            // 
            cmdDeleteTask.Location = new Point(421, 50);
            cmdDeleteTask.Margin = new Padding(4, 3, 4, 3);
            cmdDeleteTask.Name = "cmdDeleteTask";
            cmdDeleteTask.Size = new Size(88, 27);
            cmdDeleteTask.TabIndex = 8;
            cmdDeleteTask.Text = "Delete";
            cmdDeleteTask.UseVisualStyleBackColor = true;
            cmdDeleteTask.Click += cmdDeleteTask_Click;
            // 
            // cmdUpdateTask
            // 
            cmdUpdateTask.Location = new Point(327, 50);
            cmdUpdateTask.Margin = new Padding(4, 3, 4, 3);
            cmdUpdateTask.Name = "cmdUpdateTask";
            cmdUpdateTask.Size = new Size(88, 27);
            cmdUpdateTask.TabIndex = 7;
            cmdUpdateTask.Text = "Update";
            cmdUpdateTask.UseVisualStyleBackColor = true;
            cmdUpdateTask.Click += cmdUpdateTask_Click;
            // 
            // cmdCreateTask
            // 
            cmdCreateTask.Location = new Point(232, 50);
            cmdCreateTask.Margin = new Padding(4, 3, 4, 3);
            cmdCreateTask.Name = "cmdCreateTask";
            cmdCreateTask.Size = new Size(88, 27);
            cmdCreateTask.TabIndex = 6;
            cmdCreateTask.Text = "Create";
            cmdCreateTask.UseVisualStyleBackColor = true;
            cmdCreateTask.Click += cmdCreateTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(71, 52);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(153, 23);
            cboStatus.TabIndex = 4;
            cboStatus.Text = "Please Select...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Task:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(432, 22);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(71, 22);
            txtTask.Margin = new Padding(4, 3, 4, 3);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(269, 23);
            txtTask.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 136);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(583, 232);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += cmdSelection_Changed;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 382);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(627, 421);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdUpdateTask;
        private System.Windows.Forms.Button cmdCreateTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

