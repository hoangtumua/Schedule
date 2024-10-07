namespace Group_8
{
    partial class Chat
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Send1_Button = new Button();
            Send2_Button = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(23, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(304, 398);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Info;
            richTextBox2.Location = new Point(347, 54);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(304, 398);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 480);
            textBox1.Margin = new Padding(6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 54);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 480);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 54);
            textBox2.TabIndex = 1;
            // 
            // Send1_Button
            // 
            Send1_Button.BackColor = SystemColors.MenuBar;
            Send1_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Send1_Button.ForeColor = Color.DodgerBlue;
            Send1_Button.Location = new Point(242, 480);
            Send1_Button.Name = "Send1_Button";
            Send1_Button.Size = new Size(85, 54);
            Send1_Button.TabIndex = 2;
            Send1_Button.Text = "Send";
            Send1_Button.UseVisualStyleBackColor = false;
            Send1_Button.Click += Send1_Button_Click;
            // 
            // Send2_Button
            // 
            Send2_Button.BackColor = SystemColors.MenuBar;
            Send2_Button.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold);
            Send2_Button.ForeColor = Color.DodgerBlue;
            Send2_Button.Location = new Point(566, 479);
            Send2_Button.Name = "Send2_Button";
            Send2_Button.Size = new Size(85, 55);
            Send2_Button.TabIndex = 2;
            Send2_Button.Text = "Send";
            Send2_Button.UseVisualStyleBackColor = false;
            Send2_Button.Click += Send2_Button_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 552);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 576);
            Controls.Add(Send2_Button);
            Controls.Add(Send1_Button);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Name = "Chat";
            Text = "Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Send1_Button;
        private Button Send2_Button;
        private GroupBox groupBox1;
    }
}