namespace ChickenorEgg
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadEgg = new System.Windows.Forms.RadioButton();
            this.RadChicken = new System.Windows.Forms.RadioButton();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "What as First?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadEgg);
            this.groupBox1.Controls.Add(this.RadChicken);
            this.groupBox1.Location = new System.Drawing.Point(40, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one";
            // 
            // RadEgg
            // 
            this.RadEgg.AutoSize = true;
            this.RadEgg.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadEgg.Location = new System.Drawing.Point(38, 103);
            this.RadEgg.Name = "RadEgg";
            this.RadEgg.Size = new System.Drawing.Size(42, 18);
            this.RadEgg.TabIndex = 1;
            this.RadEgg.TabStop = true;
            this.RadEgg.Text = "Egg";
            this.RadEgg.UseVisualStyleBackColor = true;
            this.RadEgg.CheckedChanged += new System.EventHandler(this.RadEgg_CheckedChanged);
            // 
            // RadChicken
            // 
            this.RadChicken.AutoSize = true;
            this.RadChicken.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadChicken.Location = new System.Drawing.Point(38, 69);
            this.RadChicken.Name = "RadChicken";
            this.RadChicken.Size = new System.Drawing.Size(63, 18);
            this.RadChicken.TabIndex = 0;
            this.RadChicken.TabStop = true;
            this.RadChicken.Text = "Chicken";
            this.RadChicken.UseVisualStyleBackColor = true;
            this.RadChicken.CheckedChanged += new System.EventHandler(this.RadChicken_CheckedChanged);
            // 
            // picAnswer
            // 
            this.picAnswer.Location = new System.Drawing.Point(248, 87);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(365, 161);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnswer.TabIndex = 2;
            this.picAnswer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(667, 316);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Wide Latin", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.Name = "Form1";
            this.Text = "Chicken or Egg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadEgg;
        private System.Windows.Forms.RadioButton RadChicken;
        private System.Windows.Forms.PictureBox picAnswer;
    }
}

