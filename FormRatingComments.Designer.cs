namespace Astellas_Pharma
{
    partial class FrmRatingComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRatingComments));
            this.lblRDocTitle = new System.Windows.Forms.Label();
            this.numUpDownRatings = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRDocTitle
            // 
            this.lblRDocTitle.AutoSize = true;
            this.lblRDocTitle.Location = new System.Drawing.Point(27, 43);
            this.lblRDocTitle.Name = "lblRDocTitle";
            this.lblRDocTitle.Size = new System.Drawing.Size(67, 13);
            this.lblRDocTitle.TabIndex = 0;
            this.lblRDocTitle.Text = "RDoc Title : ";
            // 
            // numUpDownRatings
            // 
            this.numUpDownRatings.Location = new System.Drawing.Point(646, 187);
            this.numUpDownRatings.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownRatings.Name = "numUpDownRatings";
            this.numUpDownRatings.Size = new System.Drawing.Size(120, 20);
            this.numUpDownRatings.TabIndex = 1;
            this.numUpDownRatings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmRatingComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUpDownRatings);
            this.Controls.Add(this.lblRDocTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRatingComments";
            this.Text = "Rate Comments";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRatings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRDocTitle;
        private System.Windows.Forms.NumericUpDown numUpDownRatings;
    }
}