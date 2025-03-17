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
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnGuestList = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
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
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(552, 27);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(145, 51);
            this.btnAddReservation.TabIndex = 2;
            this.btnAddReservation.Text = "Nova rezervacija";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnGuestList
            // 
            this.btnGuestList.Location = new System.Drawing.Point(52, 126);
            this.btnGuestList.Name = "btnGuestList";
            this.btnGuestList.Size = new System.Drawing.Size(145, 51);
            this.btnGuestList.TabIndex = 3;
            this.btnGuestList.Text = "Popis gostiju";
            this.btnGuestList.UseVisualStyleBackColor = true;
            this.btnGuestList.Click += new System.EventHandler(this.btnGuestList_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(286, 126);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(145, 51);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Popis zaposlenika";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(692, 391);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label1";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnGuestList);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnAccommodationUnits);
            this.Controls.Add(this.btnTypeList);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTypeList;
        private System.Windows.Forms.Button btnAccommodationUnits;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnGuestList;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label lblUser;
    }
}