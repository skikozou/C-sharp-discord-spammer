namespace spammer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            checkBox1 = new CheckBox();
            channelid = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 60);
            label1.TabIndex = 0;
            label1.Text = "Discord Spammer";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(958, 403);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "text";
            // 
            // button1
            // 
            button1.Location = new Point(906, 515);
            button1.Name = "button1";
            button1.Size = new Size(64, 27);
            button1.TabIndex = 2;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += spamming;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(163, 514);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 516);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 5;
            label2.Text = "send message count";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(329, 517);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "infinity";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += check_chenged;
            // 
            // channelid
            // 
            channelid.Location = new Point(12, 72);
            channelid.Name = "channelid";
            channelid.Size = new Size(393, 27);
            channelid.TabIndex = 7;
            channelid.Text = "Channel Id";
            // 
            // button2
            // 
            button2.Location = new Point(836, 515);
            button2.Name = "button2";
            button2.Size = new Size(64, 27);
            button2.TabIndex = 8;
            button2.Text = "stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(button2);
            Controls.Add(channelid);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Discord Spammer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox channelid;
        private Button button2;
    }
}