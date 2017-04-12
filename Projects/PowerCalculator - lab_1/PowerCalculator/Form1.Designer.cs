namespace PowerCalculator
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnResidential
            // 
            this.btnResidential.Location = new System.Drawing.Point(36, 42);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(78, 21);
            this.btnResidential.TabIndex = 0;
            this.btnResidential.Text = "Residential";
            this.btnResidential.UseVisualStyleBackColor = true;
            this.btnResidential.Click += new System.EventHandler(this.btnResidential_Click);
            // 
            // btnCommercial
            // 
            this.btnCommercial.Location = new System.Drawing.Point(36, 69);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(78, 21);
            this.btnCommercial.TabIndex = 1;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.UseVisualStyleBackColor = true;
            this.btnCommercial.Click += new System.EventHandler(this.btnCommercial_Click);
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.Location = new System.Drawing.Point(36, 96);
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
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Type:";
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(184, 42);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(96, 20);
            this.txtOffPeak.TabIndex = 4;
            this.txtOffPeak.Tag = "Off Peak Usage";
            this.txtOffPeak.Visible = false;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(184, 97);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(96, 20);
            this.txtPeak.TabIndex = 5;
            this.txtPeak.Tag = "Peak Usage";
            this.txtPeak.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 195);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 24);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(133, 195);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 24);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(256, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 24);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Location = new System.Drawing.Point(185, 82);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(98, 13);
            this.lblPeak.TabIndex = 9;
            this.lblPeak.Text = "Peak Usage (kWh)";
            this.lblPeak.Visible = false;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(176, 26);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(115, 13);
            this.lblOffPeak.TabIndex = 10;
            this.lblOffPeak.Text = "Off-Peak Usage (kWh)";
            this.lblOffPeak.Visible = false;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(199, 54);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(70, 13);
            this.lblUsage.TabIndex = 12;
            this.lblUsage.Text = "Usage (kWh)";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(184, 70);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(96, 20);
            this.txtUsage.TabIndex = 11;
            this.txtUsage.Tag = "Usage";
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(169, 147);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(130, 20);
            this.txtBill.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Charge Amount:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.lblOffPeak);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.txtOffPeak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIndustrial);
            this.Controls.Add(this.btnCommercial);
            this.Controls.Add(this.btnResidential);
            this.Name = "Form1";
            this.Text = "Your Electric Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

