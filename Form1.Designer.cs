namespace reverse
{
    partial class Reverse
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
            this.txtPlays = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlays
            // 
            this.txtPlays.Location = new System.Drawing.Point(13, 13);
            this.txtPlays.Multiline = true;
            this.txtPlays.Name = "txtPlays";
            this.txtPlays.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlays.Size = new System.Drawing.Size(591, 180);
            this.txtPlays.TabIndex = 0;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(13, 200);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(107, 59);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Reverse Plays";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(568, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 2;
            // 
            // Reverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 310);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtPlays);
            this.Name = "Reverse";
            this.Text = "Reverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlays;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblStatus;
    }
}

