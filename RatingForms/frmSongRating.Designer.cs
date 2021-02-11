namespace liriksi.WinUI.RatingForms
{
    partial class frmSongRating
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
            this.dgvSongRating = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRating)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongRating
            // 
            this.dgvSongRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.AvgRate});
            this.dgvSongRating.Location = new System.Drawing.Point(12, 31);
            this.dgvSongRating.Name = "dgvSongRating";
            this.dgvSongRating.RowHeadersWidth = 51;
            this.dgvSongRating.RowTemplate.Height = 24;
            this.dgvSongRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongRating.Size = new System.Drawing.Size(776, 311);
            this.dgvSongRating.TabIndex = 0;
            this.dgvSongRating.DoubleClick += new System.EventHandler(this.dgvSongRating_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song ratings";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AvgRate
            // 
            this.AvgRate.DataPropertyName = "AvgRate";
            this.AvgRate.HeaderText = "AvgRate";
            this.AvgRate.MinimumWidth = 6;
            this.AvgRate.Name = "AvgRate";
            this.AvgRate.ReadOnly = true;
            this.AvgRate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AvgRate.Width = 125;
            // 
            // frmSongRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSongRating);
            this.Name = "frmSongRating";
            this.Text = "frmSongRating";
            this.Load += new System.EventHandler(this.frmSongRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgRate;
    }
}