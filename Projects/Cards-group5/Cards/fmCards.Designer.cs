namespace Cards
{
    partial class fmCards
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
            this.btnShowCards = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lbDeck = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowCards
            // 
            this.btnShowCards.Location = new System.Drawing.Point(12, 12);
            this.btnShowCards.Name = "btnShowCards";
            this.btnShowCards.Size = new System.Drawing.Size(96, 38);
            this.btnShowCards.TabIndex = 0;
            this.btnShowCards.Text = "Show Cards";
            this.btnShowCards.UseVisualStyleBackColor = true;
            this.btnShowCards.Click += new System.EventHandler(this.btnShowCards_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(12, 56);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(96, 38);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lbDeck
            // 
            this.lbDeck.FormattingEnabled = true;
            this.lbDeck.Location = new System.Drawing.Point(145, 15);
            this.lbDeck.Name = "lbDeck";
            this.lbDeck.Size = new System.Drawing.Size(245, 485);
            this.lbDeck.TabIndex = 2;
            // 
            // fmCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 571);
            this.Controls.Add(this.lbDeck);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnShowCards);
            this.Name = "fmCards";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.fmCards_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCards;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ListBox lbDeck;
    }
}

