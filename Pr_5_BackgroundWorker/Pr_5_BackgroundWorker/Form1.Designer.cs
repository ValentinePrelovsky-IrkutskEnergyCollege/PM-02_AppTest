namespace Pr_5_BackgroundWorker
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel = new System.Windows.Forms.Label();
            this.toolStripStatusLabelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripProgressBar = new System.Windows.Forms.ProgressBar();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.CountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 256);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(230, 24);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(311, 24);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Остановить";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = true;
            this.toolStripStatusLabel.Location = new System.Drawing.Point(188, 225);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(101, 13);
            this.toolStripStatusLabel.TabIndex = 3;
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.AutoSize = true;
            this.toolStripStatusLabelTime.Location = new System.Drawing.Point(308, 225);
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(124, 13);
            this.toolStripStatusLabelTime.TabIndex = 4;
            this.toolStripStatusLabelTime.Text = "toolStripStatusLabelTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во символов";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Location = new System.Drawing.Point(0, 225);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(164, 23);
            this.toolStripProgressBar.TabIndex = 6;
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(12, 12);
            this.ContainerTextBox.Multiline = true;
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContainerTextBox.Size = new System.Drawing.Size(193, 151);
            this.ContainerTextBox.TabIndex = 7;
            this.ContainerTextBox.Text = "ContainerTextBox";
            // 
            // CountNumber
            // 
            this.CountNumber.Location = new System.Drawing.Point(230, 107);
            this.CountNumber.Name = "CountNumber";
            this.CountNumber.Size = new System.Drawing.Size(100, 20);
            this.CountNumber.TabIndex = 8;
            this.CountNumber.Text = "CountNumber";
            this.CountNumber.Click += new System.EventHandler(this.CountNumber_Click);
            this.CountNumber.TextChanged += new System.EventHandler(this.CountNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 278);
            this.Controls.Add(this.CountNumber);
            this.Controls.Add(this.ContainerTextBox);
            this.Controls.Add(this.toolStripProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStripStatusLabelTime);
            this.Controls.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Генератор случайных чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label toolStripStatusLabel;
        private System.Windows.Forms.Label toolStripStatusLabelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar toolStripProgressBar;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.TextBox CountNumber;
    }
}

