namespace CampAssist
{
    partial class frmEmployeeList
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 83);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersVisible = false;
            this.dgvEmployeeList.Size = new System.Drawing.Size(307, 294);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.dgvEmployeeList);
            this.Name = "frmEmployeeList";
            this.Text = "frmEmployeeList";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
    }
}