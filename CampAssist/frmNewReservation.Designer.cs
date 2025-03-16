namespace CampAssist
{
    partial class frmNewReservation
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
            this.dgvReservationGuestList = new System.Windows.Forms.DataGridView();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.cboAccommodations = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnPickOldGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationGuestList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservationGuestList
            // 
            this.dgvReservationGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationGuestList.Location = new System.Drawing.Point(40, 121);
            this.dgvReservationGuestList.Name = "dgvReservationGuestList";
            this.dgvReservationGuestList.Size = new System.Drawing.Size(730, 240);
            this.dgvReservationGuestList.TabIndex = 0;
            // 
            // cboTypes
            // 
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(40, 29);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(121, 21);
            this.cboTypes.TabIndex = 1;
            this.cboTypes.SelectedIndexChanged += new System.EventHandler(this.cboTypes_SelectedIndexChanged);
            // 
            // cboAccommodations
            // 
            this.cboAccommodations.FormattingEnabled = true;
            this.cboAccommodations.Location = new System.Drawing.Point(40, 85);
            this.cboAccommodations.Name = "cboAccommodations";
            this.cboAccommodations.Size = new System.Drawing.Size(121, 21);
            this.cboAccommodations.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(288, 86);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(522, 86);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(40, 390);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(150, 36);
            this.btnAddReservation.TabIndex = 5;
            this.btnAddReservation.Text = "Dodaj rezervaciju";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // btnPickOldGuest
            // 
            this.btnPickOldGuest.Location = new System.Drawing.Point(242, 390);
            this.btnPickOldGuest.Name = "btnPickOldGuest";
            this.btnPickOldGuest.Size = new System.Drawing.Size(150, 36);
            this.btnPickOldGuest.TabIndex = 6;
            this.btnPickOldGuest.Text = "Odaberi starog gosta";
            this.btnPickOldGuest.UseVisualStyleBackColor = true;
            this.btnPickOldGuest.Click += new System.EventHandler(this.btnPickOldGuest_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(436, 390);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(150, 36);
            this.btnAddGuest.TabIndex = 7;
            this.btnAddGuest.Text = "Dodaj gosta";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Location = new System.Drawing.Point(620, 390);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(150, 36);
            this.btnDeleteGuest.TabIndex = 8;
            this.btnDeleteGuest.Text = "Obriši gosta";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tip smještaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Smještajna jedinica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kraj rezervacije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Početak rezervacije";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(512, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnPickOldGuest);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cboAccommodations);
            this.Controls.Add(this.cboTypes);
            this.Controls.Add(this.dgvReservationGuestList);
            this.Name = "frmNewReservation";
            this.Text = "frmNewReservation";
            this.Load += new System.EventHandler(this.frmNewReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationGuestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservationGuestList;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.ComboBox cboAccommodations;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnPickOldGuest;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
    }
}