namespace CampAssist
{
    partial class frmAccommodationUnitGuestList
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
            this.dgvGuestList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuestList
            // 
            this.dgvGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestList.Location = new System.Drawing.Point(12, 55);
            this.dgvGuestList.Name = "dgvGuestList";
            this.dgvGuestList.Size = new System.Drawing.Size(242, 259);
            this.dgvGuestList.TabIndex = 0;
            // 
            // frmAccommodationUnitGuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 339);
            this.Controls.Add(this.dgvGuestList);
            this.Name = "frmAccommodationUnitGuestList";
            this.Text = "frmAccommodationUnitGuestList";
            this.Load += new System.EventHandler(this.frmAccommodationUnitGuestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuestList;
    }
}