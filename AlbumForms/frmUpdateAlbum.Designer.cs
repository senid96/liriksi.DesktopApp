﻿namespace liriksi.WinUI.AlbumForms
{
    partial class frmUpdateAlbum
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.picboxAlbum = new System.Windows.Forms.PictureBox();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.cmbPerformer = new System.Windows.Forms.ComboBox();
            this.lblCoverPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(113, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(266, 22);
            this.txtTitle.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Title";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(14, 63);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(89, 17);
            this.Genre.TabIndex = 55;
            this.Genre.Text = "Year release";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Genre";
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(113, 93);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(266, 24);
            this.cmbGenre.TabIndex = 57;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(304, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Finish";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(113, 60);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(266, 24);
            this.cmbYear.TabIndex = 60;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(304, 298);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(75, 24);
            this.btnOpenFileDialog.TabIndex = 61;
            this.btnOpenFileDialog.Text = "Upload img";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // picboxAlbum
            // 
            this.picboxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxAlbum.Location = new System.Drawing.Point(237, 164);
            this.picboxAlbum.Name = "picboxAlbum";
            this.picboxAlbum.Size = new System.Drawing.Size(142, 128);
            this.picboxAlbum.TabIndex = 64;
            this.picboxAlbum.TabStop = false;
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(14, 129);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(71, 17);
            this.lblPerformer.TabIndex = 65;
            this.lblPerformer.Text = "Performer";
            this.lblPerformer.Click += new System.EventHandler(this.lblPerformer_Click);
            // 
            // cmbPerformer
            // 
            this.cmbPerformer.FormattingEnabled = true;
            this.cmbPerformer.Location = new System.Drawing.Point(113, 126);
            this.cmbPerformer.Name = "cmbPerformer";
            this.cmbPerformer.Size = new System.Drawing.Size(266, 24);
            this.cmbPerformer.TabIndex = 66;
            this.cmbPerformer.SelectedIndexChanged += new System.EventHandler(this.cmbPerformer_SelectedIndexChanged);
            // 
            // lblCoverPhoto
            // 
            this.lblCoverPhoto.AutoSize = true;
            this.lblCoverPhoto.Location = new System.Drawing.Point(14, 164);
            this.lblCoverPhoto.Name = "lblCoverPhoto";
            this.lblCoverPhoto.Size = new System.Drawing.Size(85, 17);
            this.lblCoverPhoto.TabIndex = 67;
            this.lblCoverPhoto.Text = "Cover photo";
            // 
            // frmUpdateAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 385);
            this.Controls.Add(this.lblCoverPhoto);
            this.Controls.Add(this.cmbPerformer);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.picboxAlbum);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmUpdateAlbum";
            this.Text = "frmUpdateAlbum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateAlbum_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateAlbum_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.PictureBox picboxAlbum;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.ComboBox cmbPerformer;
        private System.Windows.Forms.Label lblCoverPhoto;
    }
}