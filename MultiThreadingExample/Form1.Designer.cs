namespace MultiThreadingExample
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
            this.BtnTimeConsuming = new System.Windows.Forms.Button();
            this.BtnPrintNumber = new System.Windows.Forms.Button();
            this.List_Of_Numbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTimeConsuming
            // 
            this.BtnTimeConsuming.Location = new System.Drawing.Point(297, 71);
            this.BtnTimeConsuming.Name = "BtnTimeConsuming";
            this.BtnTimeConsuming.Size = new System.Drawing.Size(162, 41);
            this.BtnTimeConsuming.TabIndex = 0;
            this.BtnTimeConsuming.Text = "Do Time Consuming Work";
            this.BtnTimeConsuming.UseVisualStyleBackColor = true;
            this.BtnTimeConsuming.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPrintNumber
            // 
            this.BtnPrintNumber.Location = new System.Drawing.Point(297, 134);
            this.BtnPrintNumber.Name = "BtnPrintNumber";
            this.BtnPrintNumber.Size = new System.Drawing.Size(162, 39);
            this.BtnPrintNumber.TabIndex = 1;
            this.BtnPrintNumber.Text = "Print Numbers";
            this.BtnPrintNumber.UseVisualStyleBackColor = true;
            this.BtnPrintNumber.Click += new System.EventHandler(this.BtnPrintNumber_Click);
            // 
            // List_Of_Numbers
            // 
            this.List_Of_Numbers.FormattingEnabled = true;
            this.List_Of_Numbers.ItemHeight = 15;
            this.List_Of_Numbers.Location = new System.Drawing.Point(297, 201);
            this.List_Of_Numbers.Name = "List_Of_Numbers";
            this.List_Of_Numbers.Size = new System.Drawing.Size(162, 199);
            this.List_Of_Numbers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Of_Numbers);
            this.Controls.Add(this.BtnPrintNumber);
            this.Controls.Add(this.BtnTimeConsuming);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnTimeConsuming;
        private Button BtnPrintNumber;
        private ListBox List_Of_Numbers;
    }
}