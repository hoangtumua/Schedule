namespace Group_8
{
    partial class FormThread
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
            buttonSingleTadhr = new Button();
            panelSingleTread = new Panel();
            panelMultithreading = new Panel();
            buttonMultiThread = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSingleTadhr
            // 
            buttonSingleTadhr.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSingleTadhr.ForeColor = SystemColors.MenuHighlight;
            buttonSingleTadhr.Location = new Point(108, 514);
            buttonSingleTadhr.Margin = new Padding(4, 5, 4, 5);
            buttonSingleTadhr.Name = "buttonSingleTadhr";
            buttonSingleTadhr.Size = new Size(244, 48);
            buttonSingleTadhr.TabIndex = 1;
            buttonSingleTadhr.Text = "Run";
            buttonSingleTadhr.UseVisualStyleBackColor = true;
            buttonSingleTadhr.Click += buttonSingleThread_Click;
            // 
            // panelSingleTread
            // 
            panelSingleTread.BackColor = Color.PapayaWhip;
            panelSingleTread.Location = new Point(13, 58);
            panelSingleTread.Margin = new Padding(4, 5, 4, 5);
            panelSingleTread.Name = "panelSingleTread";
            panelSingleTread.Size = new Size(333, 385);
            panelSingleTread.TabIndex = 15;
            // 
            // panelMultithreading
            // 
            panelMultithreading.BackColor = Color.LemonChiffon;
            panelMultithreading.Location = new Point(367, 58);
            panelMultithreading.Margin = new Padding(4, 5, 4, 5);
            panelMultithreading.Name = "panelMultithreading";
            panelMultithreading.Size = new Size(333, 385);
            panelMultithreading.TabIndex = 16;
            // 
            // buttonMultiThread
            // 
            buttonMultiThread.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMultiThread.ForeColor = SystemColors.MenuHighlight;
            buttonMultiThread.Location = new Point(462, 514);
            buttonMultiThread.Margin = new Padding(4, 5, 4, 5);
            buttonMultiThread.Name = "buttonMultiThread";
            buttonMultiThread.Size = new Size(244, 48);
            buttonMultiThread.TabIndex = 17;
            buttonMultiThread.Text = "Run";
            buttonMultiThread.UseVisualStyleBackColor = true;
            buttonMultiThread.Click += buttonMultiThread_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(110, 456);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 48);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(462, 456);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 48);
            panel2.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(buttonMultiThread);
            groupBox1.Controls.Add(buttonSingleTadhr);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(-6, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 587);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 463);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(474, 23);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 0;
            label4.Text = "Multi-Thread";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(36, 468);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 0;
            label7.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(397, 468);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 0;
            label6.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(117, 23);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 0;
            label3.Text = "Single Thread";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 576);
            Controls.Add(panelSingleTread);
            Controls.Add(panelMultithreading);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(728, 623);
            MinimumSize = new Size(728, 623);
            Name = "Form1";
            Text = "Thread Simulation";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonSingleTadhr;
        private System.Windows.Forms.Panel panelSingleTread;
        private System.Windows.Forms.Panel panelMultithreading;
        private System.Windows.Forms.Button buttonMultiThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}

