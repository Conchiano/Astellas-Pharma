namespace Astellas_Pharma
{
    partial class FrmReviewTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReviewTasks));
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.tabCtrlBox = new System.Windows.Forms.TabControl();
            this.TabStatusAll = new System.Windows.Forms.TabPage();
            this.dGridStatusAll = new System.Windows.Forms.DataGridView();
            this.tabStatusAwaiting = new System.Windows.Forms.TabPage();
            this.dGridStatusAwaiting = new System.Windows.Forms.DataGridView();
            this.tabStatusOpen = new System.Windows.Forms.TabPage();
            this.dGridStatusOpen = new System.Windows.Forms.DataGridView();
            this.tabStatusLocked = new System.Windows.Forms.TabPage();
            this.dGridStatusLocked = new System.Windows.Forms.DataGridView();
            this.tabStatusClosed = new System.Windows.Forms.TabPage();
            this.dGridStatusClosed = new System.Windows.Forms.DataGridView();
            this.BtnExitReviewTasks = new System.Windows.Forms.Button();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.btnSubmitComments = new System.Windows.Forms.Button();
            this.txtBxComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtrlBox.SuspendLayout();
            this.TabStatusAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusAll)).BeginInit();
            this.tabStatusAwaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusAwaiting)).BeginInit();
            this.tabStatusOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusOpen)).BeginInit();
            this.tabStatusLocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusLocked)).BeginInit();
            this.tabStatusClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusClosed)).BeginInit();
            this.pnlComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(540, 445);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(134, 44);
            this.btnExitApplication.TabIndex = 6;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            // 
            // tabCtrlBox
            // 
            this.tabCtrlBox.Controls.Add(this.TabStatusAll);
            this.tabCtrlBox.Controls.Add(this.tabStatusAwaiting);
            this.tabCtrlBox.Controls.Add(this.tabStatusOpen);
            this.tabCtrlBox.Controls.Add(this.tabStatusLocked);
            this.tabCtrlBox.Controls.Add(this.tabStatusClosed);
            this.tabCtrlBox.Location = new System.Drawing.Point(2, 2);
            this.tabCtrlBox.Name = "tabCtrlBox";
            this.tabCtrlBox.SelectedIndex = 0;
            this.tabCtrlBox.Size = new System.Drawing.Size(704, 327);
            this.tabCtrlBox.TabIndex = 7;
            // 
            // TabStatusAll
            // 
            this.TabStatusAll.Controls.Add(this.dGridStatusAll);
            this.TabStatusAll.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabStatusAll.Location = new System.Drawing.Point(4, 22);
            this.TabStatusAll.Name = "TabStatusAll";
            this.TabStatusAll.Padding = new System.Windows.Forms.Padding(3);
            this.TabStatusAll.Size = new System.Drawing.Size(696, 301);
            this.TabStatusAll.TabIndex = 0;
            this.TabStatusAll.Text = "Status All";
            this.TabStatusAll.UseVisualStyleBackColor = true;
            // 
            // dGridStatusAll
            // 
            this.dGridStatusAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStatusAll.Location = new System.Drawing.Point(19, 24);
            this.dGridStatusAll.Name = "dGridStatusAll";
            this.dGridStatusAll.Size = new System.Drawing.Size(648, 258);
            this.dGridStatusAll.TabIndex = 0;
            // 
            // tabStatusAwaiting
            // 
            this.tabStatusAwaiting.Controls.Add(this.dGridStatusAwaiting);
            this.tabStatusAwaiting.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatusAwaiting.Location = new System.Drawing.Point(4, 22);
            this.tabStatusAwaiting.Name = "tabStatusAwaiting";
            this.tabStatusAwaiting.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusAwaiting.Size = new System.Drawing.Size(696, 301);
            this.tabStatusAwaiting.TabIndex = 1;
            this.tabStatusAwaiting.Text = "Status Awaiting";
            this.tabStatusAwaiting.UseVisualStyleBackColor = true;
            // 
            // dGridStatusAwaiting
            // 
            this.dGridStatusAwaiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStatusAwaiting.Location = new System.Drawing.Point(17, 20);
            this.dGridStatusAwaiting.Name = "dGridStatusAwaiting";
            this.dGridStatusAwaiting.Size = new System.Drawing.Size(659, 266);
            this.dGridStatusAwaiting.TabIndex = 0;
            this.dGridStatusAwaiting.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridStatusAwaiting_CellMouseClick);
            // 
            // tabStatusOpen
            // 
            this.tabStatusOpen.Controls.Add(this.dGridStatusOpen);
            this.tabStatusOpen.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatusOpen.Location = new System.Drawing.Point(4, 22);
            this.tabStatusOpen.Name = "tabStatusOpen";
            this.tabStatusOpen.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusOpen.Size = new System.Drawing.Size(696, 301);
            this.tabStatusOpen.TabIndex = 2;
            this.tabStatusOpen.Text = "Status Open";
            this.tabStatusOpen.UseVisualStyleBackColor = true;
            // 
            // dGridStatusOpen
            // 
            this.dGridStatusOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStatusOpen.Location = new System.Drawing.Point(12, 17);
            this.dGridStatusOpen.Name = "dGridStatusOpen";
            this.dGridStatusOpen.Size = new System.Drawing.Size(665, 264);
            this.dGridStatusOpen.TabIndex = 0;
            // 
            // tabStatusLocked
            // 
            this.tabStatusLocked.Controls.Add(this.dGridStatusLocked);
            this.tabStatusLocked.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatusLocked.Location = new System.Drawing.Point(4, 22);
            this.tabStatusLocked.Name = "tabStatusLocked";
            this.tabStatusLocked.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusLocked.Size = new System.Drawing.Size(696, 301);
            this.tabStatusLocked.TabIndex = 3;
            this.tabStatusLocked.Text = "Status Locked";
            this.tabStatusLocked.UseVisualStyleBackColor = true;
            // 
            // dGridStatusLocked
            // 
            this.dGridStatusLocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStatusLocked.Location = new System.Drawing.Point(18, 17);
            this.dGridStatusLocked.Name = "dGridStatusLocked";
            this.dGridStatusLocked.Size = new System.Drawing.Size(659, 266);
            this.dGridStatusLocked.TabIndex = 0;
            // 
            // tabStatusClosed
            // 
            this.tabStatusClosed.Controls.Add(this.dGridStatusClosed);
            this.tabStatusClosed.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatusClosed.Location = new System.Drawing.Point(4, 22);
            this.tabStatusClosed.Name = "tabStatusClosed";
            this.tabStatusClosed.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusClosed.Size = new System.Drawing.Size(696, 301);
            this.tabStatusClosed.TabIndex = 4;
            this.tabStatusClosed.Text = "Status Closed";
            this.tabStatusClosed.UseVisualStyleBackColor = true;
            // 
            // dGridStatusClosed
            // 
            this.dGridStatusClosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStatusClosed.Location = new System.Drawing.Point(18, 21);
            this.dGridStatusClosed.Name = "dGridStatusClosed";
            this.dGridStatusClosed.Size = new System.Drawing.Size(650, 258);
            this.dGridStatusClosed.TabIndex = 0;
            // 
            // BtnExitReviewTasks
            // 
            this.BtnExitReviewTasks.Location = new System.Drawing.Point(24, 445);
            this.BtnExitReviewTasks.Name = "BtnExitReviewTasks";
            this.BtnExitReviewTasks.Size = new System.Drawing.Size(134, 44);
            this.BtnExitReviewTasks.TabIndex = 9;
            this.BtnExitReviewTasks.Text = "Exit Review Tasks";
            this.BtnExitReviewTasks.UseVisualStyleBackColor = true;
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.btnSubmitComments);
            this.pnlComments.Controls.Add(this.txtBxComments);
            this.pnlComments.Controls.Add(this.label1);
            this.pnlComments.Location = new System.Drawing.Point(14, 342);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(687, 84);
            this.pnlComments.TabIndex = 10;
            // 
            // btnSubmitComments
            // 
            this.btnSubmitComments.Font = new System.Drawing.Font("Calibri", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitComments.Location = new System.Drawing.Point(582, 31);
            this.btnSubmitComments.Name = "btnSubmitComments";
            this.btnSubmitComments.Size = new System.Drawing.Size(97, 28);
            this.btnSubmitComments.TabIndex = 2;
            this.btnSubmitComments.Text = "Submit Comments";
            this.btnSubmitComments.UseVisualStyleBackColor = true;
            // 
            // txtBxComments
            // 
            this.txtBxComments.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxComments.Location = new System.Drawing.Point(189, 3);
            this.txtBxComments.Multiline = true;
            this.txtBxComments.Name = "txtBxComments";
            this.txtBxComments.Size = new System.Drawing.Size(385, 78);
            this.txtBxComments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, input your comments :";
            // 
            // FrmReviewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 494);
            this.Controls.Add(this.pnlComments);
            this.Controls.Add(this.BtnExitReviewTasks);
            this.Controls.Add(this.tabCtrlBox);
            this.Controls.Add(this.btnExitApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReviewTasks";
            this.Text = "Review Tasks";
            this.Load += new System.EventHandler(this.FrmReviewTasks_Load);
            this.tabCtrlBox.ResumeLayout(false);
            this.TabStatusAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusAll)).EndInit();
            this.tabStatusAwaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusAwaiting)).EndInit();
            this.tabStatusOpen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusOpen)).EndInit();
            this.tabStatusLocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusLocked)).EndInit();
            this.tabStatusClosed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridStatusClosed)).EndInit();
            this.pnlComments.ResumeLayout(false);
            this.pnlComments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.TabControl tabCtrlBox;
        private System.Windows.Forms.TabPage TabStatusAll;
        private System.Windows.Forms.TabPage tabStatusAwaiting;
        private System.Windows.Forms.TabPage tabStatusOpen;
        private System.Windows.Forms.TabPage tabStatusLocked;
        private System.Windows.Forms.TabPage tabStatusClosed;
        private System.Windows.Forms.DataGridView dGridStatusClosed;
        private System.Windows.Forms.Button BtnExitReviewTasks;
        private System.Windows.Forms.DataGridView dGridStatusAll;
        private System.Windows.Forms.DataGridView dGridStatusAwaiting;
        private System.Windows.Forms.DataGridView dGridStatusOpen;
        private System.Windows.Forms.DataGridView dGridStatusLocked;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitComments;
        private System.Windows.Forms.TextBox txtBxComments;
    }
}