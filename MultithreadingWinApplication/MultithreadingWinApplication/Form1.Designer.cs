namespace MultithreadingWinApplication
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartThreadingButton = new System.Windows.Forms.Button();
            this.FirstMethodButton = new System.Windows.Forms.Button();
            this.SecondMethodButton = new System.Windows.Forms.Button();
            this.ThirdMethodButton = new System.Windows.Forms.Button();
            this.RandomNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 237);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(218, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 237);
            this.panel2.TabIndex = 1;
            // 
            // StartThreadingButton
            // 
            this.StartThreadingButton.Location = new System.Drawing.Point(363, 300);
            this.StartThreadingButton.Name = "StartThreadingButton";
            this.StartThreadingButton.Size = new System.Drawing.Size(75, 23);
            this.StartThreadingButton.TabIndex = 2;
            this.StartThreadingButton.Text = "StartThreading";
            this.StartThreadingButton.UseVisualStyleBackColor = true;
            this.StartThreadingButton.Click += new System.EventHandler(this.StartThreadingButton_Click_1);
            // 
            // FirstMethodButton
            // 
            this.FirstMethodButton.Location = new System.Drawing.Point(78, 264);
            this.FirstMethodButton.Name = "FirstMethodButton";
            this.FirstMethodButton.Size = new System.Drawing.Size(75, 23);
            this.FirstMethodButton.TabIndex = 3;
            this.FirstMethodButton.Text = "FirstMethodButton";
            this.FirstMethodButton.UseVisualStyleBackColor = true;
            this.FirstMethodButton.Click += new System.EventHandler(this.FirstMethodButton_Click_1);
            // 
            // SecondMethodButton
            // 
            this.SecondMethodButton.Location = new System.Drawing.Point(281, 264);
            this.SecondMethodButton.Name = "SecondMethodButton";
            this.SecondMethodButton.Size = new System.Drawing.Size(75, 23);
            this.SecondMethodButton.TabIndex = 4;
            this.SecondMethodButton.Text = "SecondMethod";
            this.SecondMethodButton.UseVisualStyleBackColor = true;
            this.SecondMethodButton.Click += new System.EventHandler(this.SecondMethodButton_Click_1);
            // 
            // ThirdMethodButton
            // 
            this.ThirdMethodButton.Location = new System.Drawing.Point(518, 264);
            this.ThirdMethodButton.Name = "ThirdMethodButton";
            this.ThirdMethodButton.Size = new System.Drawing.Size(75, 23);
            this.ThirdMethodButton.TabIndex = 5;
            this.ThirdMethodButton.Text = "ThirdMethodButton";
            this.ThirdMethodButton.UseVisualStyleBackColor = true;
            this.ThirdMethodButton.Click += new System.EventHandler(this.ThirdMethodButton_Click_1);
            // 
            // RandomNumberTextBox
            // 
            this.RandomNumberTextBox.Location = new System.Drawing.Point(424, 12);
            this.RandomNumberTextBox.Multiline = true;
            this.RandomNumberTextBox.Name = "RandomNumberTextBox";
            this.RandomNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RandomNumberTextBox.Size = new System.Drawing.Size(273, 237);
            this.RandomNumberTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RandomNumberTextBox);
            this.Controls.Add(this.ThirdMethodButton);
            this.Controls.Add(this.SecondMethodButton);
            this.Controls.Add(this.FirstMethodButton);
            this.Controls.Add(this.StartThreadingButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StartThreadingButton;
        private System.Windows.Forms.Button FirstMethodButton;
        private System.Windows.Forms.Button SecondMethodButton;
        private System.Windows.Forms.Button ThirdMethodButton;
        private System.Windows.Forms.TextBox RandomNumberTextBox;
        private System.Windows.Forms.Button button1;
    }
}

