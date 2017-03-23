namespace WindowsDebugApplication
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
            this.FirstVariable = new System.Windows.Forms.TextBox();
            this.SecondVariable = new System.Windows.Forms.TextBox();
            this.SymbolcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstVariable
            // 
            this.FirstVariable.Location = new System.Drawing.Point(13, 30);
            this.FirstVariable.Name = "FirstVariable";
            this.FirstVariable.Size = new System.Drawing.Size(100, 20);
            this.FirstVariable.TabIndex = 0;
            // 
            // SecondVariable
            // 
            this.SecondVariable.Location = new System.Drawing.Point(205, 30);
            this.SecondVariable.Name = "SecondVariable";
            this.SecondVariable.Size = new System.Drawing.Size(100, 20);
            this.SecondVariable.TabIndex = 1;
            // 
            // SymbolcomboBox
            // 
            this.SymbolcomboBox.FormattingEnabled = true;
            this.SymbolcomboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.SymbolcomboBox.Location = new System.Drawing.Point(119, 29);
            this.SymbolcomboBox.Name = "SymbolcomboBox";
            this.SymbolcomboBox.Size = new System.Drawing.Size(80, 21);
            this.SymbolcomboBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SymbolcomboBox);
            this.Controls.Add(this.SecondVariable);
            this.Controls.Add(this.FirstVariable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstVariable;
        private System.Windows.Forms.TextBox SecondVariable;
        private System.Windows.Forms.ComboBox SymbolcomboBox;
        private System.Windows.Forms.Button button1;
    }
}

