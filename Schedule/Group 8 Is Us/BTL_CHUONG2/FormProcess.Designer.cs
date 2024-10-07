namespace Group_8
{
    partial class FormProcess
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
            dataGridView1 = new DataGridView();
            Process_ID = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Open_Button = new Button();
            Close_Button = new Button();
            Refresh_Button = new Button();
            TextBox_EnterName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Disk_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Process_ID, Process_Name });
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(558, 441);
            dataGridView1.TabIndex = 0;
            // 
            // Process_ID
            // 
            Process_ID.HeaderText = "ID";
            Process_ID.MinimumWidth = 6;
            Process_ID.Name = "Process_ID";
            Process_ID.Width = 125;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Name Of Process";
            Process_Name.MinimumWidth = 6;
            Process_Name.Name = "Process_Name";
            Process_Name.Width = 380;
            // 
            // Open_Button
            // 
            Open_Button.BackColor = Color.MistyRose;
            Open_Button.Location = new Point(593, 110);
            Open_Button.Name = "Open_Button";
            Open_Button.Size = new Size(151, 61);
            Open_Button.TabIndex = 1;
            Open_Button.Text = "Open";
            Open_Button.UseVisualStyleBackColor = false;
            Open_Button.Click += Open_Button_Click;
            // 
            // Close_Button
            // 
            Close_Button.BackColor = Color.MistyRose;
            Close_Button.Location = new Point(593, 204);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(151, 61);
            Close_Button.TabIndex = 1;
            Close_Button.Text = "Close";
            Close_Button.UseVisualStyleBackColor = false;
            Close_Button.Click += Close_Button_Click_1;
            // 
            // Refresh_Button
            // 
            Refresh_Button.BackColor = Color.MistyRose;
            Refresh_Button.Location = new Point(593, 293);
            Refresh_Button.Name = "Refresh_Button";
            Refresh_Button.Size = new Size(151, 61);
            Refresh_Button.TabIndex = 1;
            Refresh_Button.Text = "Refresh";
            Refresh_Button.UseVisualStyleBackColor = false;
            Refresh_Button.Click += Refresh_Button_Click_1;
            // 
            // TextBox_EnterName
            // 
            TextBox_EnterName.Location = new Point(593, 58);
            TextBox_EnterName.Name = "TextBox_EnterName";
            TextBox_EnterName.Size = new Size(151, 32);
            TextBox_EnterName.TabIndex = 2;
            TextBox_EnterName.TextChanged += TextBox_EnterName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 3;
            label1.Text = "Process";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 3;
            label2.Text = "List Processes";
            // 
            // Disk_Button
            // 
            Disk_Button.BackColor = Color.MistyRose;
            Disk_Button.Location = new Point(593, 389);
            Disk_Button.Name = "Disk_Button";
            Disk_Button.Size = new Size(151, 61);
            Disk_Button.TabIndex = 4;
            Disk_Button.Text = "Disk Storage";
            Disk_Button.UseVisualStyleBackColor = false;
            Disk_Button.Click += Disk_Button_Click;
            // 
            // FormProcess
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(765, 490);
            Controls.Add(Disk_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBox_EnterName);
            Controls.Add(Refresh_Button);
            Controls.Add(Close_Button);
            Controls.Add(Open_Button);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            MaximumSize = new Size(783, 537);
            MinimumSize = new Size(783, 537);
            Name = "FormProcess";
            Text = "Process Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Open_Button;
        private Button Close_Button;
        private Button Refresh_Button;
        private TextBox TextBox_EnterName;
        private Label label1;
        private DataGridViewTextBoxColumn Process_ID;
        private DataGridViewTextBoxColumn Process_Name;
        private Label label2;
        private Button Disk_Button;
    }
}