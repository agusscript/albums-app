namespace WindowsFormApp.forms
{
    partial class DetailsForm
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
            this.detailsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.detailsAuthorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.detailsReleasedDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.detailsAmountTracksLabel = new MaterialSkin.Controls.MaterialLabel();
            this.detailsCoverImagePictureBox = new System.Windows.Forms.PictureBox();
            this.detailsGenreLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.detailsCoverImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsTitleLabel
            // 
            this.detailsTitleLabel.AutoSize = true;
            this.detailsTitleLabel.Depth = 0;
            this.detailsTitleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.detailsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.detailsTitleLabel.Location = new System.Drawing.Point(22, 76);
            this.detailsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsTitleLabel.Name = "detailsTitleLabel";
            this.detailsTitleLabel.Size = new System.Drawing.Size(48, 29);
            this.detailsTitleLabel.TabIndex = 0;
            this.detailsTitleLabel.Text = "Title";
            // 
            // detailsAuthorLabel
            // 
            this.detailsAuthorLabel.AutoSize = true;
            this.detailsAuthorLabel.Depth = 0;
            this.detailsAuthorLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.detailsAuthorLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.detailsAuthorLabel.Location = new System.Drawing.Point(22, 434);
            this.detailsAuthorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsAuthorLabel.Name = "detailsAuthorLabel";
            this.detailsAuthorLabel.Size = new System.Drawing.Size(73, 29);
            this.detailsAuthorLabel.TabIndex = 1;
            this.detailsAuthorLabel.Text = "Author";
            // 
            // detailsReleasedDateLabel
            // 
            this.detailsReleasedDateLabel.AutoSize = true;
            this.detailsReleasedDateLabel.Depth = 0;
            this.detailsReleasedDateLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.detailsReleasedDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.detailsReleasedDateLabel.Location = new System.Drawing.Point(23, 488);
            this.detailsReleasedDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsReleasedDateLabel.Name = "detailsReleasedDateLabel";
            this.detailsReleasedDateLabel.Size = new System.Drawing.Size(119, 24);
            this.detailsReleasedDateLabel.TabIndex = 2;
            this.detailsReleasedDateLabel.Text = "Release Date";
            // 
            // detailsAmountTracksLabel
            // 
            this.detailsAmountTracksLabel.AutoSize = true;
            this.detailsAmountTracksLabel.Depth = 0;
            this.detailsAmountTracksLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.detailsAmountTracksLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.detailsAmountTracksLabel.Location = new System.Drawing.Point(263, 538);
            this.detailsAmountTracksLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsAmountTracksLabel.Name = "detailsAmountTracksLabel";
            this.detailsAmountTracksLabel.Size = new System.Drawing.Size(136, 24);
            this.detailsAmountTracksLabel.TabIndex = 3;
            this.detailsAmountTracksLabel.Text = "Amount Tracks";
            // 
            // detailsCoverImagePictureBox
            // 
            this.detailsCoverImagePictureBox.Location = new System.Drawing.Point(19, 111);
            this.detailsCoverImagePictureBox.Name = "detailsCoverImagePictureBox";
            this.detailsCoverImagePictureBox.Size = new System.Drawing.Size(380, 310);
            this.detailsCoverImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.detailsCoverImagePictureBox.TabIndex = 4;
            this.detailsCoverImagePictureBox.TabStop = false;
            // 
            // detailsGenreLabel
            // 
            this.detailsGenreLabel.AutoSize = true;
            this.detailsGenreLabel.Depth = 0;
            this.detailsGenreLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.detailsGenreLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.detailsGenreLabel.Location = new System.Drawing.Point(23, 538);
            this.detailsGenreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsGenreLabel.Name = "detailsGenreLabel";
            this.detailsGenreLabel.Size = new System.Drawing.Size(55, 24);
            this.detailsGenreLabel.TabIndex = 5;
            this.detailsGenreLabel.Text = "Genre";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 580);
            this.Controls.Add(this.detailsGenreLabel);
            this.Controls.Add(this.detailsCoverImagePictureBox);
            this.Controls.Add(this.detailsAmountTracksLabel);
            this.Controls.Add(this.detailsReleasedDateLabel);
            this.Controls.Add(this.detailsAuthorLabel);
            this.Controls.Add(this.detailsTitleLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 580);
            this.MinimumSize = new System.Drawing.Size(418, 580);
            this.Name = "DetailsForm";
            this.Text = "Album Details";
            ((System.ComponentModel.ISupportInitialize)(this.detailsCoverImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel detailsTitleLabel;
        private MaterialSkin.Controls.MaterialLabel detailsAuthorLabel;
        private MaterialSkin.Controls.MaterialLabel detailsReleasedDateLabel;
        private MaterialSkin.Controls.MaterialLabel detailsAmountTracksLabel;
        private System.Windows.Forms.PictureBox detailsCoverImagePictureBox;
        private MaterialSkin.Controls.MaterialLabel detailsGenreLabel;
    }
}