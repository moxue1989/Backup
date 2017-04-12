namespace CoinMachine
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
            this.components = new System.ComponentModel.Container();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToonie = new System.Windows.Forms.TextBox();
            this.txtLoonie = new System.Windows.Forms.TextBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.txtDime = new System.Windows.Forms.TextBox();
            this.txtNickel = new System.Windows.Forms.TextBox();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMoney.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMoney.Location = new System.Drawing.Point(202, 68);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(85, 20);
            this.txtMoney.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Money Amount";
            // 
            // txtToonie
            // 
            this.txtToonie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtToonie.Location = new System.Drawing.Point(44, 167);
            this.txtToonie.Name = "txtToonie";
            this.txtToonie.Size = new System.Drawing.Size(65, 20);
            this.txtToonie.TabIndex = 2;
            // 
            // txtLoonie
            // 
            this.txtLoonie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLoonie.Location = new System.Drawing.Point(153, 167);
            this.txtLoonie.Name = "txtLoonie";
            this.txtLoonie.Size = new System.Drawing.Size(65, 20);
            this.txtLoonie.TabIndex = 3;
            // 
            // txtQuarter
            // 
            this.txtQuarter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQuarter.Location = new System.Drawing.Point(266, 167);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.Size = new System.Drawing.Size(65, 20);
            this.txtQuarter.TabIndex = 4;
            // 
            // txtDime
            // 
            this.txtDime.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDime.Location = new System.Drawing.Point(44, 223);
            this.txtDime.Name = "txtDime";
            this.txtDime.Size = new System.Drawing.Size(65, 20);
            this.txtDime.TabIndex = 5;
            // 
            // txtNickel
            // 
            this.txtNickel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNickel.Location = new System.Drawing.Point(153, 223);
            this.txtNickel.Name = "txtNickel";
            this.txtNickel.Size = new System.Drawing.Size(65, 20);
            this.txtNickel.TabIndex = 6;
            // 
            // txtPenny
            // 
            this.txtPenny.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPenny.Location = new System.Drawing.Point(266, 223);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.Size = new System.Drawing.Size(65, 20);
            this.txtPenny.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(46, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tonnie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(162, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loonie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(58, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(275, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quarter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(162, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nickel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(275, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Penny";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalc.Location = new System.Drawing.Point(47, 96);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 25);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(202, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate No Penny";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(106, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 43);
            this.label8.TabIndex = 15;
            this.label8.Text = "Coin Machine";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(87, 132);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(208, 13);
            this.progress.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.txtNickel);
            this.Controls.Add(this.txtDime);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.txtLoonie);
            this.Controls.Add(this.txtToonie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Name = "Form1";
            this.Text = "Coin Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToonie;
        private System.Windows.Forms.TextBox txtLoonie;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.TextBox txtDime;
        private System.Windows.Forms.TextBox txtNickel;
        private System.Windows.Forms.TextBox txtPenny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progress;
    }
}

