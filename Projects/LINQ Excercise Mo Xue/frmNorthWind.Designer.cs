namespace LINQ_Practice
{
    partial class frmNorthWind
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
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.tbContactTitle = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(70, 12);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 0;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(70, 85);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyName.TabIndex = 1;
            // 
            // tbContactName
            // 
            this.tbContactName.Location = new System.Drawing.Point(70, 111);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(100, 20);
            this.tbContactName.TabIndex = 2;
            // 
            // tbContactTitle
            // 
            this.tbContactTitle.Location = new System.Drawing.Point(70, 137);
            this.tbContactTitle.Name = "tbContactTitle";
            this.tbContactTitle.Size = new System.Drawing.Size(100, 20);
            this.tbContactTitle.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(70, 163);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 4;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(70, 189);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 5;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(70, 319);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(100, 20);
            this.tbFax.TabIndex = 6;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(70, 215);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(100, 20);
            this.tbRegion.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(70, 293);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 8;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(70, 267);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(100, 20);
            this.tbCountry.TabIndex = 9;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(70, 241);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(100, 20);
            this.tbPostalCode.TabIndex = 10;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(176, 43);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(637, 410);
            this.dgvOrders.TabIndex = 11;
            // 
            // frmNorthWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 465);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbContactTitle);
            this.Controls.Add(this.tbContactName);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.cbCustomer);
            this.Name = "frmNorthWind";
            this.Text = "NorthWind";
            this.Load += new System.EventHandler(this.frmNorthWind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.TextBox tbContactTitle;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}

