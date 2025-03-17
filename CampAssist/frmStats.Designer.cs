namespace CampAssist
{
    partial class frmStats
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageGuestNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYearlyIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFillYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prosječan broj gostiju po rezervaciji:";
            // 
            // lblAverageGuestNumber
            // 
            this.lblAverageGuestNumber.AutoSize = true;
            this.lblAverageGuestNumber.Location = new System.Drawing.Point(235, 75);
            this.lblAverageGuestNumber.Name = "lblAverageGuestNumber";
            this.lblAverageGuestNumber.Size = new System.Drawing.Size(35, 13);
            this.lblAverageGuestNumber.TabIndex = 1;
            this.lblAverageGuestNumber.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukupni prihod u tekućoj godini:";
            // 
            // lblYearlyIncome
            // 
            this.lblYearlyIncome.AutoSize = true;
            this.lblYearlyIncome.Location = new System.Drawing.Point(235, 118);
            this.lblYearlyIncome.Name = "lblYearlyIncome";
            this.lblYearlyIncome.Size = new System.Drawing.Size(35, 13);
            this.lblYearlyIncome.TabIndex = 3;
            this.lblYearlyIncome.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Popunjenost tijekom godine: ";
            // 
            // lblFillYear
            // 
            this.lblFillYear.AutoSize = true;
            this.lblFillYear.Location = new System.Drawing.Point(235, 162);
            this.lblFillYear.Name = "lblFillYear";
            this.lblFillYear.Size = new System.Drawing.Size(35, 13);
            this.lblFillYear.TabIndex = 5;
            this.lblFillYear.Text = "label2";
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFillYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYearlyIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAverageGuestNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmStats";
            this.Text = "frmStats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAverageGuestNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYearlyIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFillYear;
    }
}