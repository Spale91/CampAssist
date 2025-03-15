namespace CampAssist
{
    partial class frmAdmin
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
            this.btnTypeList = new System.Windows.Forms.Button();
            this.btnAccommodationUnits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTypeList
            // 
            this.btnTypeList.Location = new System.Drawing.Point(52, 27);
            this.btnTypeList.Name = "btnTypeList";
            this.btnTypeList.Size = new System.Drawing.Size(145, 51);
            this.btnTypeList.TabIndex = 0;
            this.btnTypeList.Text = "Tipovi smještajnih jedinica";
            this.btnTypeList.UseVisualStyleBackColor = true;
            this.btnTypeList.Click += new System.EventHandler(this.btnTypeList_Click);
            // 
            // btnAccommodationUnits
            // 
            this.btnAccommodationUnits.Location = new System.Drawing.Point(286, 27);
            this.btnAccommodationUnits.Name = "btnAccommodationUnits";
            this.btnAccommodationUnits.Size = new System.Drawing.Size(145, 51);
            this.btnAccommodationUnits.TabIndex = 1;
            this.btnAccommodationUnits.Text = "Smještajne jedinice";
            this.btnAccommodationUnits.UseVisualStyleBackColor = true;
            this.btnAccommodationUnits.Click += new System.EventHandler(this.btnAccommodationUnits_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccommodationUnits);
            this.Controls.Add(this.btnTypeList);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTypeList;
        private System.Windows.Forms.Button btnAccommodationUnits;
    }
}