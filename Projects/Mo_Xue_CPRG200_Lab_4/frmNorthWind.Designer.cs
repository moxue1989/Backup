namespace Mo_Xue_CPRG200_Lab_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.tbRequiredDate = new System.Windows.Forms.TextBox();
            this.tbShippedDate = new System.Windows.Forms.TextBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbOrderTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearShippedDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Required Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shipped Date:";
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Enabled = false;
            this.tbOrderDate.Location = new System.Drawing.Point(331, 30);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.Size = new System.Drawing.Size(117, 20);
            this.tbOrderDate.TabIndex = 8;
            // 
            // tbRequiredDate
            // 
            this.tbRequiredDate.Enabled = false;
            this.tbRequiredDate.Location = new System.Drawing.Point(331, 65);
            this.tbRequiredDate.Name = "tbRequiredDate";
            this.tbRequiredDate.Size = new System.Drawing.Size(117, 20);
            this.tbRequiredDate.TabIndex = 9;
            // 
            // tbShippedDate
            // 
            this.tbShippedDate.Enabled = false;
            this.tbShippedDate.Location = new System.Drawing.Point(560, 30);
            this.tbShippedDate.Name = "tbShippedDate";
            this.tbShippedDate.Size = new System.Drawing.Size(117, 20);
            this.tbShippedDate.TabIndex = 10;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(683, 30);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(18, 20);
            this.dtpShippedDate.TabIndex = 11;
            this.dtpShippedDate.ValueChanged += new System.EventHandler(this.dtpShippedDate_ValueChanged);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(249, 94);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.Size = new System.Drawing.Size(452, 213);
            this.dgvOrderDetails.TabIndex = 12;
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(16, 30);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(219, 303);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(612, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbOrderTotal
            // 
            this.tbOrderTotal.Enabled = false;
            this.tbOrderTotal.Location = new System.Drawing.Point(457, 313);
            this.tbOrderTotal.Name = "tbOrderTotal";
            this.tbOrderTotal.Size = new System.Drawing.Size(117, 20);
            this.tbOrderTotal.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order Total:";
            // 
            // btnClearShippedDate
            // 
            this.btnClearShippedDate.Enabled = false;
            this.btnClearShippedDate.Location = new System.Drawing.Point(482, 59);
            this.btnClearShippedDate.Name = "btnClearShippedDate";
            this.btnClearShippedDate.Size = new System.Drawing.Size(92, 23);
            this.btnClearShippedDate.TabIndex = 18;
            this.btnClearShippedDate.Text = "Clear";
            this.btnClearShippedDate.UseVisualStyleBackColor = true;
            this.btnClearShippedDate.Click += new System.EventHandler(this.btnClearShippedDate_Click);
            // 
            // frmNorthWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 344);
            this.Controls.Add(this.btnClearShippedDate);
            this.Controls.Add(this.tbOrderTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.tbShippedDate);
            this.Controls.Add(this.tbRequiredDate);
            this.Controls.Add(this.tbOrderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrders);
            this.Name = "frmNorthWind";
            this.Text = "North Wind";
            this.Load += new System.EventHandler(this.frmNorthWind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.TextBox tbRequiredDate;
        private System.Windows.Forms.TextBox tbShippedDate;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbOrderTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.Button btnClearShippedDate;
    }
}

