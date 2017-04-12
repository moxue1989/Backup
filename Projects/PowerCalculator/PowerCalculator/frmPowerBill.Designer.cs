namespace PowerCalculator
{
    partial class frmPowerBill
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
            this.btnResidential = new System.Windows.Forms.Button();
            this.btnCommercial = new System.Windows.Forms.Button();
            this.btnIndustrial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPeak = new System.Windows.Forms.Label();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResidential = new System.Windows.Forms.TextBox();
            this.txtCommercial = new System.Windows.Forms.TextBox();
            this.txtIndustrial = new System.Windows.Forms.TextBox();
            this.txtTotalCust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResidential
            // 
            this.btnResidential.Location = new System.Drawing.Point(22, 47);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(78, 21);
            this.btnResidential.TabIndex = 0;
            this.btnResidential.Text = "Residential";
            this.btnResidential.UseVisualStyleBackColor = true;
            this.btnResidential.Click += new System.EventHandler(this.btnResidential_Click);
            // 
            // btnCommercial
            // 
            this.btnCommercial.Location = new System.Drawing.Point(128, 47);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(78, 21);
            this.btnCommercial.TabIndex = 1;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.UseVisualStyleBackColor = true;
            this.btnCommercial.Click += new System.EventHandler(this.btnCommercial_Click);
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.Location = new System.Drawing.Point(235, 47);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(78, 21);
            this.btnIndustrial.TabIndex = 2;
            this.btnIndustrial.Text = "Industrial";
            this.btnIndustrial.UseVisualStyleBackColor = true;
            this.btnIndustrial.Click += new System.EventHandler(this.btnIndustrial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Type:";
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(187, 108);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(96, 20);
            this.txtOffPeak.TabIndex = 6;
            this.txtOffPeak.Tag = "Off Peak Usage";
            this.txtOffPeak.Visible = false;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(187, 163);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(96, 20);
            this.txtPeak.TabIndex = 7;
            this.txtPeak.Tag = "Peak Usage";
            this.txtPeak.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 261);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 24);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(137, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 24);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(260, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 24);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit (Save)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Location = new System.Drawing.Point(185, 145);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(98, 13);
            this.lblPeak.TabIndex = 9;
            this.lblPeak.Text = "Peak Usage (kWh)";
            this.lblPeak.Visible = false;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(176, 89);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(115, 13);
            this.lblOffPeak.TabIndex = 10;
            this.lblOffPeak.Text = "Off-Peak Usage (kWh)";
            this.lblOffPeak.Visible = false;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(199, 117);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(70, 13);
            this.lblUsage.TabIndex = 12;
            this.lblUsage.Text = "Usage (kWh)";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(187, 136);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(96, 20);
            this.txtUsage.TabIndex = 5;
            this.txtUsage.Tag = "Usage";
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(141, 213);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(130, 20);
            this.txtBill.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Charge Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Account Number:";
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(19, 108);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(96, 20);
            this.txtAct.TabIndex = 3;
            this.txtAct.Tag = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 164);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Tag = "Customer Name";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(336, 34);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(374, 160);
            this.lstCustomers.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Customers:";
            // 
            // txtResidential
            // 
            this.txtResidential.Enabled = false;
            this.txtResidential.Location = new System.Drawing.Point(379, 240);
            this.txtResidential.Name = "txtResidential";
            this.txtResidential.Size = new System.Drawing.Size(83, 20);
            this.txtResidential.TabIndex = 21;
            // 
            // txtCommercial
            // 
            this.txtCommercial.Enabled = false;
            this.txtCommercial.Location = new System.Drawing.Point(502, 240);
            this.txtCommercial.Name = "txtCommercial";
            this.txtCommercial.Size = new System.Drawing.Size(83, 20);
            this.txtCommercial.TabIndex = 22;
            // 
            // txtIndustrial
            // 
            this.txtIndustrial.Enabled = false;
            this.txtIndustrial.Location = new System.Drawing.Point(626, 240);
            this.txtIndustrial.Name = "txtIndustrial";
            this.txtIndustrial.Size = new System.Drawing.Size(83, 20);
            this.txtIndustrial.TabIndex = 23;
            // 
            // txtTotalCust
            // 
            this.txtTotalCust.Enabled = false;
            this.txtTotalCust.Location = new System.Drawing.Point(380, 291);
            this.txtTotalCust.Name = "txtTotalCust";
            this.txtTotalCust.Size = new System.Drawing.Size(125, 20);
            this.txtTotalCust.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Power Charge:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Residential:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Commercial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Industrial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Customer Total:";
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Enabled = false;
            this.txtTotalCharge.Location = new System.Drawing.Point(584, 291);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(125, 20);
            this.txtTotalCharge.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Total Charge:";
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.label1);
            this.gbForm.Controls.Add(this.label11);
            this.gbForm.Controls.Add(this.btnResidential);
            this.gbForm.Controls.Add(this.txtTotalCharge);
            this.gbForm.Controls.Add(this.btnCommercial);
            this.gbForm.Controls.Add(this.label10);
            this.gbForm.Controls.Add(this.btnIndustrial);
            this.gbForm.Controls.Add(this.label9);
            this.gbForm.Controls.Add(this.label5);
            this.gbForm.Controls.Add(this.label8);
            this.gbForm.Controls.Add(this.lstCustomers);
            this.gbForm.Controls.Add(this.label7);
            this.gbForm.Controls.Add(this.lblOffPeak);
            this.gbForm.Controls.Add(this.label6);
            this.gbForm.Controls.Add(this.txtOffPeak);
            this.gbForm.Controls.Add(this.txtTotalCust);
            this.gbForm.Controls.Add(this.txtPeak);
            this.gbForm.Controls.Add(this.txtIndustrial);
            this.gbForm.Controls.Add(this.btnCalculate);
            this.gbForm.Controls.Add(this.txtCommercial);
            this.gbForm.Controls.Add(this.btnReset);
            this.gbForm.Controls.Add(this.txtResidential);
            this.gbForm.Controls.Add(this.btnExit);
            this.gbForm.Controls.Add(this.label4);
            this.gbForm.Controls.Add(this.lblPeak);
            this.gbForm.Controls.Add(this.txtName);
            this.gbForm.Controls.Add(this.txtUsage);
            this.gbForm.Controls.Add(this.label3);
            this.gbForm.Controls.Add(this.lblUsage);
            this.gbForm.Controls.Add(this.txtAct);
            this.gbForm.Controls.Add(this.txtBill);
            this.gbForm.Controls.Add(this.label2);
            this.gbForm.Location = new System.Drawing.Point(-9, -28);
            this.gbForm.Margin = new System.Windows.Forms.Padding(0);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(0);
            this.gbForm.Size = new System.Drawing.Size(741, 360);
            this.gbForm.TabIndex = 32;
            this.gbForm.TabStop = false;
            // 
            // frmPowerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(726, 324);
            this.Controls.Add(this.gbForm);
            this.Name = "frmPowerBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Electric Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResidential;
        private System.Windows.Forms.Button btnCommercial;
        private System.Windows.Forms.Button btnIndustrial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResidential;
        private System.Windows.Forms.TextBox txtCommercial;
        private System.Windows.Forms.TextBox txtIndustrial;
        private System.Windows.Forms.TextBox txtTotalCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbForm;
    }
}

