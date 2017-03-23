using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pr_5_BackgroundWorker
{
    public partial class Form1 : Form
    {
        DateTime startDate = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            clearBoxes();
        }

        private void clearBoxes()
        {
            CountNumber.Text = "";
            ContainerTextBox.Text = "";
            toolStripStatusLabel.Text = "";
            toolStripStatusLabelTime.Text = ""; 
        }
        private int randNumber()
        {
            

            Random rnd = new Random();
            return rnd.Next(0, 100);
        } 

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < Convert.ToInt32(CountNumber.Text); i++)
                {
                    System.Threading.Thread.Sleep(100);  //замораживаем  поток  на 100 мс.   
                    backgroundWorker.ReportProgress(((i * 100) / (Convert.ToInt32(CountNumber.Text) - 1)));
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    } // end if
                } // end for
            } // end try
            catch (Exception exc)
            { 
                MessageBox.Show("Ошибка: "+exc); 
            } // end catch       
        } // end void
        

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
            ContainerTextBox.AppendText(randNumber().ToString() + " ");
            toolStripStatusLabel.Text = "Обработка...  " +
            e.ProgressPercentage.ToString() + "%";
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Задача была отменена");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("В  ходе  выполнения  возникла  ошибка:  " +  (e.Error as Exception).ToString());
            }
            else
            {
                timer.Stop();//  останавливаем  таймер  в  случае  штатного завершения программы.   
                toolStripStatusLabel.Text = "Обработка завершена";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(startDate);
            string sTime = "  ..." + ts.Minutes.ToString("00") +
               ":" + ts.Seconds.ToString("00") +
               ":" + ts.Milliseconds.ToString("000");
            toolStripStatusLabelTime.Text = sTime; 
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            timer.Stop(); 
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (CountNumber.Text == "")
            {
                MessageBox.Show("Не введено количество чисел для генерации");
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
                timer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CountNumber_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void CountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
