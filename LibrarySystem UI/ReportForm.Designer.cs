namespace LibrarySystem_UI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnActiveBorrows = new System.Windows.Forms.Button();
            this.btnMostBorrowed = new System.Windows.Forms.Button();
            this.btnLateBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(800, 177);
            this.dgvReport.TabIndex = 0;
            // 
            // btnActiveBorrows
            // 
            this.btnActiveBorrows.BackColor = System.Drawing.Color.RosyBrown;
            this.btnActiveBorrows.Location = new System.Drawing.Point(476, 245);
            this.btnActiveBorrows.Name = "btnActiveBorrows";
            this.btnActiveBorrows.Size = new System.Drawing.Size(136, 96);
            this.btnActiveBorrows.TabIndex = 1;
            this.btnActiveBorrows.Text = "Aktif Ödünçler";
            this.btnActiveBorrows.UseVisualStyleBackColor = false;
            this.btnActiveBorrows.Click += new System.EventHandler(this.btnActiveBorrows_Click);
            // 
            // btnMostBorrowed
            // 
            this.btnMostBorrowed.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMostBorrowed.Location = new System.Drawing.Point(85, 245);
            this.btnMostBorrowed.Name = "btnMostBorrowed";
            this.btnMostBorrowed.Size = new System.Drawing.Size(152, 96);
            this.btnMostBorrowed.TabIndex = 2;
            this.btnMostBorrowed.Text = "En Çok Ödünç Alınanlar ";
            this.btnMostBorrowed.UseVisualStyleBackColor = false;
            this.btnMostBorrowed.Click += new System.EventHandler(this.btnMostBorrowed_Click);
            // 
            // btnLateBooks
            // 
            this.btnLateBooks.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLateBooks.Location = new System.Drawing.Point(292, 245);
            this.btnLateBooks.Name = "btnLateBooks";
            this.btnLateBooks.Size = new System.Drawing.Size(131, 96);
            this.btnLateBooks.TabIndex = 3;
            this.btnLateBooks.Text = "Geciken Kitaplar ";
            this.btnLateBooks.UseVisualStyleBackColor = false;
            this.btnLateBooks.Click += new System.EventHandler(this.btnLateBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(646, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLateBooks);
            this.Controls.Add(this.btnMostBorrowed);
            this.Controls.Add(this.btnActiveBorrows);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnActiveBorrows;
        private System.Windows.Forms.Button btnMostBorrowed;
        private System.Windows.Forms.Button btnLateBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}