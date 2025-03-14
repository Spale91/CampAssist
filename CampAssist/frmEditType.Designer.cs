namespace CampAssist
{
    partial class frmEditType
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditType = new System.Windows.Forms.Button();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.numPriceOffSeason = new System.Windows.Forms.NumericUpDown();
            this.numPriceSeason = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceOffSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSeason)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditType
            // 
            this.btnEditType.Location = new System.Drawing.Point(137, 177);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(101, 23);
            this.btnEditType.TabIndex = 19;
            this.btnEditType.Text = "Uredi";
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(138, 140);
            this.numCapacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(100, 20);
            this.numCapacity.TabIndex = 18;
            // 
            // numPriceOffSeason
            // 
            this.numPriceOffSeason.Location = new System.Drawing.Point(138, 114);
            this.numPriceOffSeason.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceOffSeason.Name = "numPriceOffSeason";
            this.numPriceOffSeason.Size = new System.Drawing.Size(101, 20);
            this.numPriceOffSeason.TabIndex = 17;
            // 
            // numPriceSeason
            // 
            this.numPriceSeason.Location = new System.Drawing.Point(139, 85);
            this.numPriceSeason.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceSeason.Name = "numPriceSeason";
            this.numPriceSeason.Size = new System.Drawing.Size(100, 20);
            this.numPriceSeason.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cijena u sezoni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cijena izvan sezone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kapacitet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(139, 51);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtTypeName.TabIndex = 11;
            // 
            // frmEditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numPriceOffSeason);
            this.Controls.Add(this.numPriceSeason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Name = "frmEditType";
            this.Text = "frmEditType";
            this.Load += new System.EventHandler(this.frmEditType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceOffSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSeason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.NumericUpDown numPriceOffSeason;
        private System.Windows.Forms.NumericUpDown numPriceSeason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeName;
    }
}