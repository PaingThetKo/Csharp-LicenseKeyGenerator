namespace License_Key_Generator
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
            txtDay = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnGenerate = new Button();
            txtSerial = new TextBox();
            label3 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            btnValid = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Day:";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(101, 47);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(65, 27);
            txtDay.TabIndex = 1;
            txtDay.Text = "30";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(264, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 3;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(430, 145);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(105, 37);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(101, 100);
            txtSerial.Name = "txtSerial";
            txtSerial.ReadOnly = true;
            txtSerial.Size = new Size(434, 27);
            txtSerial.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 103);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Serial:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(101, 209);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(434, 167);
            txtStatus.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 209);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Status:";
            // 
            // btnValid
            // 
            btnValid.Location = new Point(430, 391);
            btnValid.Name = "btnValid";
            btnValid.Size = new Size(105, 37);
            btnValid.TabIndex = 7;
            btnValid.Text = "Valid";
            btnValid.UseVisualStyleBackColor = true;
            btnValid.Click += btnValid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 462);
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(btnValid);
            Controls.Add(txtSerial);
            Controls.Add(label3);
            Controls.Add(btnGenerate);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtDay);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "License Key Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDay;
        private TextBox txtPassword;
        private Label label2;
        private Button btnGenerate;
        private TextBox txtSerial;
        private Label label3;
        private TextBox txtStatus;
        private Label label4;
        private Button btnValid;
    }
}
