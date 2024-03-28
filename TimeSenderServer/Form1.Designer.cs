namespace TimeSenderServer
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
            numericUpDownSeconds = new NumericUpDown();
            numericUpDownMinutes = new NumericUpDown();
            numericUpDownHours = new NumericUpDown();
            buttonSend = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(263, 25);
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(102, 23);
            numericUpDownSeconds.TabIndex = 5;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(144, 25);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(102, 23);
            numericUpDownMinutes.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(26, 25);
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(102, 23);
            numericUpDownHours.TabIndex = 3;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(151, 88);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(90, 31);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send Time";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 72);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 140);
            Controls.Add(label1);
            Controls.Add(buttonSend);
            Controls.Add(numericUpDownSeconds);
            Controls.Add(numericUpDownMinutes);
            Controls.Add(numericUpDownHours);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSeconds;
        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownHours;
        private Button buttonSend;
        private Label label1;
    }
}
