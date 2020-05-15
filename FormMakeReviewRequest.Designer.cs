namespace Astellas_Pharma
{
    partial class FrmMakeReviewRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMakeReviewRequest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelminGrade = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.dGridViewMinGrade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBxTitle = new System.Windows.Forms.TextBox();
            this.TxtBxLink = new System.Windows.Forms.TextBox();
            this.ChkLstBxSpecialisms = new System.Windows.Forms.CheckedListBox();
            this.BtnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelminGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 66);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Submit your Research Document";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelminGrade
            // 
            this.panelminGrade.Controls.Add(this.BtnCancel);
            this.panelminGrade.Controls.Add(this.BtnSubmit);
            this.panelminGrade.Controls.Add(this.dGridViewMinGrade);
            this.panelminGrade.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panelminGrade.Location = new System.Drawing.Point(12, 137);
            this.panelminGrade.Name = "panelminGrade";
            this.panelminGrade.Size = new System.Drawing.Size(360, 380);
            this.panelminGrade.TabIndex = 9;
            this.panelminGrade.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(232, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(47, 347);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dGridViewMinGrade
            // 
            this.dGridViewMinGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGridViewMinGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewMinGrade.Location = new System.Drawing.Point(19, 21);
            this.dGridViewMinGrade.Name = "dGridViewMinGrade";
            this.dGridViewMinGrade.Size = new System.Drawing.Size(327, 286);
            this.dGridViewMinGrade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "RDoc Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Link:";
            // 
            // TxtBxTitle
            // 
            this.TxtBxTitle.Location = new System.Drawing.Point(130, 147);
            this.TxtBxTitle.Name = "TxtBxTitle";
            this.TxtBxTitle.Size = new System.Drawing.Size(189, 27);
            this.TxtBxTitle.TabIndex = 7;
            // 
            // TxtBxLink
            // 
            this.TxtBxLink.Location = new System.Drawing.Point(130, 189);
            this.TxtBxLink.Name = "TxtBxLink";
            this.TxtBxLink.Size = new System.Drawing.Size(189, 27);
            this.TxtBxLink.TabIndex = 8;
            // 
            // ChkLstBxSpecialisms
            // 
            this.ChkLstBxSpecialisms.FormattingEnabled = true;
            this.ChkLstBxSpecialisms.Location = new System.Drawing.Point(20, 235);
            this.ChkLstBxSpecialisms.Name = "ChkLstBxSpecialisms";
            this.ChkLstBxSpecialisms.Size = new System.Drawing.Size(299, 224);
            this.ChkLstBxSpecialisms.TabIndex = 2;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.LightGray;
            this.BtnNext.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(74, 465);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(124, 34);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FrmMakeReviewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(373, 529);
            this.Controls.Add(this.panelminGrade);
            this.Controls.Add(this.ChkLstBxSpecialisms);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.TxtBxLink);
            this.Controls.Add(this.TxtBxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMakeReviewRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Review Request";
            this.Load += new System.EventHandler(this.FrmMakeReviewRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelminGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewMinGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelminGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBxTitle;
        private System.Windows.Forms.TextBox TxtBxLink;
        private System.Windows.Forms.CheckedListBox ChkLstBxSpecialisms;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DataGridView dGridViewMinGrade;
        private System.Windows.Forms.Button BtnCancel;
    }
}