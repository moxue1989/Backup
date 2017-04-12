namespace WindowsFormsApplication2
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
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtCentimeters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToMetric = new System.Windows.Forms.Button();
            this.btnToImperial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(40, 41);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(88, 20);
            this.txtFeet.TabIndex = 0;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(39, 112);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(88, 20);
            this.txtInches.TabIndex = 1;
            // 
            // txtCentimeters
            // 
            this.txtCentimeters.Location = new System.Drawing.Point(245, 75);
            this.txtCentimeters.Name = "txtCentimeters";
            this.txtCentimeters.Size = new System.Drawing.Size(88, 20);
            this.txtCentimeters.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Centimeters";
            // 
            // btnToMetric
            // 
            this.btnToMetric.Location = new System.Drawing.Point(163, 59);
            this.btnToMetric.Name = "btnToMetric";
            this.btnToMetric.Size = new System.Drawing.Size(41, 31);
            this.btnToMetric.TabIndex = 6;
            this.btnToMetric.Text = ">";
            this.btnToMetric.UseVisualStyleBackColor = true;
            this.btnToMetric.Click += new System.EventHandler(this.btnToMetric_Click);
            // 
            // btnToImperial
            // 
            this.btnToImperial.Location = new System.Drawing.Point(162, 115);
            this.btnToImperial.Name = "btnToImperial";
            this.btnToImperial.Size = new System.Drawing.Size(41, 31);
            this.btnToImperial.TabIndex = 7;
            this.btnToImperial.Text = "<";
            this.btnToImperial.UseVisualStyleBackColor = true;
            this.btnToImperial.Click += new System.EventHandler(this.btnToImperial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.btnToImperial);
            this.Controls.Add(this.btnToMetric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCentimeters);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtFeet);
            this.Name = "Form1";
            this.Text = "Metric Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtCentimeters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToMetric;
        private System.Windows.Forms.Button btnToImperial;
    }
}

