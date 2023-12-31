﻿namespace WindowsFormApp.forms
{
    partial class NewAlbumForm
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
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.authorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.urlCoverImgLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.coverImageUrlTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.confirmAddAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.cancelAddAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.genreComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.genreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.releasedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.releaseDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.amountTracksTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.amountTracksLabel = new MaterialSkin.Controls.MaterialLabel();
            this.previewImgPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewImgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(124, 100);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Depth = 0;
            this.authorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorLabel.Location = new System.Drawing.Point(108, 145);
            this.authorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(48, 19);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // urlCoverImgLabel
            // 
            this.urlCoverImgLabel.AutoSize = true;
            this.urlCoverImgLabel.Depth = 0;
            this.urlCoverImgLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.urlCoverImgLabel.Location = new System.Drawing.Point(44, 236);
            this.urlCoverImgLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlCoverImgLabel.Name = "urlCoverImgLabel";
            this.urlCoverImgLabel.Size = new System.Drawing.Size(112, 19);
            this.urlCoverImgLabel.TabIndex = 2;
            this.urlCoverImgLabel.Text = "Cover Image Url";
            // 
            // titleTextBox
            // 
            this.titleTextBox.AnimateReadOnly = false;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Depth = 0;
            this.titleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleTextBox.LeadingIcon = null;
            this.titleTextBox.Location = new System.Drawing.Point(162, 96);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 120);
            this.titleTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 30);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "";
            this.titleTextBox.TrailingIcon = null;
            this.titleTextBox.UseTallSize = false;
            // 
            // coverImageUrlTextBox
            // 
            this.coverImageUrlTextBox.AnimateReadOnly = false;
            this.coverImageUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coverImageUrlTextBox.Depth = 0;
            this.coverImageUrlTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.coverImageUrlTextBox.LeadingIcon = null;
            this.coverImageUrlTextBox.Location = new System.Drawing.Point(162, 232);
            this.coverImageUrlTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.MaxLength = 400;
            this.coverImageUrlTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.coverImageUrlTextBox.Multiline = false;
            this.coverImageUrlTextBox.Name = "coverImageUrlTextBox";
            this.coverImageUrlTextBox.Size = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.TabIndex = 3;
            this.coverImageUrlTextBox.Text = "";
            this.coverImageUrlTextBox.TrailingIcon = null;
            this.coverImageUrlTextBox.UseTallSize = false;
            this.coverImageUrlTextBox.Leave += new System.EventHandler(this.coverImageUrlTextBox_Leave);
            // 
            // authorTextBox
            // 
            this.authorTextBox.AnimateReadOnly = false;
            this.authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorTextBox.Depth = 0;
            this.authorTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorTextBox.LeadingIcon = null;
            this.authorTextBox.Location = new System.Drawing.Point(162, 141);
            this.authorTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.authorTextBox.MaxLength = 50;
            this.authorTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.authorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorTextBox.Multiline = false;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(220, 30);
            this.authorTextBox.TabIndex = 1;
            this.authorTextBox.Text = "";
            this.authorTextBox.TrailingIcon = null;
            this.authorTextBox.UseTallSize = false;
            // 
            // confirmAddAlbumBtn
            // 
            this.confirmAddAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmAddAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.confirmAddAlbumBtn.Depth = 0;
            this.confirmAddAlbumBtn.HighEmphasis = true;
            this.confirmAddAlbumBtn.Icon = null;
            this.confirmAddAlbumBtn.Location = new System.Drawing.Point(296, 391);
            this.confirmAddAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmAddAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmAddAlbumBtn.Name = "confirmAddAlbumBtn";
            this.confirmAddAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.confirmAddAlbumBtn.Size = new System.Drawing.Size(86, 36);
            this.confirmAddAlbumBtn.TabIndex = 6;
            this.confirmAddAlbumBtn.Text = "Confirm";
            this.confirmAddAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirmAddAlbumBtn.UseAccentColor = false;
            this.confirmAddAlbumBtn.UseVisualStyleBackColor = true;
            this.confirmAddAlbumBtn.Click += new System.EventHandler(this.confirmAddAlbumBtn_Click);
            // 
            // cancelAddAlbumBtn
            // 
            this.cancelAddAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelAddAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelAddAlbumBtn.Depth = 0;
            this.cancelAddAlbumBtn.HighEmphasis = true;
            this.cancelAddAlbumBtn.Icon = null;
            this.cancelAddAlbumBtn.Location = new System.Drawing.Point(412, 391);
            this.cancelAddAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelAddAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelAddAlbumBtn.Name = "cancelAddAlbumBtn";
            this.cancelAddAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelAddAlbumBtn.Size = new System.Drawing.Size(77, 36);
            this.cancelAddAlbumBtn.TabIndex = 7;
            this.cancelAddAlbumBtn.Text = "Cancel";
            this.cancelAddAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelAddAlbumBtn.UseAccentColor = false;
            this.cancelAddAlbumBtn.UseVisualStyleBackColor = true;
            this.cancelAddAlbumBtn.Click += new System.EventHandler(this.cancelAddAlbumBtn_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.AutoResize = false;
            this.genreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genreComboBox.Depth = 0;
            this.genreComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genreComboBox.DropDownHeight = 292;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.DropDownWidth = 121;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genreComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.IntegralHeight = false;
            this.genreComboBox.ItemHeight = 29;
            this.genreComboBox.Location = new System.Drawing.Point(162, 279);
            this.genreComboBox.MaxDropDownItems = 10;
            this.genreComboBox.MaximumSize = new System.Drawing.Size(220, 0);
            this.genreComboBox.MinimumSize = new System.Drawing.Size(220, 0);
            this.genreComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(220, 35);
            this.genreComboBox.StartIndex = 0;
            this.genreComboBox.TabIndex = 4;
            this.genreComboBox.UseTallSize = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Depth = 0;
            this.genreLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genreLabel.Location = new System.Drawing.Point(108, 285);
            this.genreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(42, 19);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre";
            // 
            // releasedDateTimePicker
            // 
            this.releasedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.releasedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releasedDateTimePicker.Location = new System.Drawing.Point(162, 329);
            this.releasedDateTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.releasedDateTimePicker.MaximumSize = new System.Drawing.Size(220, 30);
            this.releasedDateTimePicker.MinimumSize = new System.Drawing.Size(220, 30);
            this.releasedDateTimePicker.Name = "releasedDateTimePicker";
            this.releasedDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.releasedDateTimePicker.Size = new System.Drawing.Size(220, 30);
            this.releasedDateTimePicker.TabIndex = 5;
            this.releasedDateTimePicker.Value = new System.DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Depth = 0;
            this.releaseDateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.releaseDateLabel.Location = new System.Drawing.Point(54, 334);
            this.releaseDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(102, 19);
            this.releaseDateLabel.TabIndex = 12;
            this.releaseDateLabel.Text = "Released Date";
            // 
            // amountTracksTextBox
            // 
            this.amountTracksTextBox.AnimateReadOnly = false;
            this.amountTracksTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTracksTextBox.Depth = 0;
            this.amountTracksTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.amountTracksTextBox.LeadingIcon = null;
            this.amountTracksTextBox.Location = new System.Drawing.Point(162, 186);
            this.amountTracksTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 120);
            this.amountTracksTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.amountTracksTextBox.MaxLength = 50;
            this.amountTracksTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.amountTracksTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.amountTracksTextBox.Multiline = false;
            this.amountTracksTextBox.Name = "amountTracksTextBox";
            this.amountTracksTextBox.Size = new System.Drawing.Size(220, 30);
            this.amountTracksTextBox.TabIndex = 2;
            this.amountTracksTextBox.Text = "";
            this.amountTracksTextBox.TrailingIcon = null;
            this.amountTracksTextBox.UseTallSize = false;
            // 
            // amountTracksLabel
            // 
            this.amountTracksLabel.AutoSize = true;
            this.amountTracksLabel.Depth = 0;
            this.amountTracksLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.amountTracksLabel.Location = new System.Drawing.Point(47, 189);
            this.amountTracksLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.amountTracksLabel.Name = "amountTracksLabel";
            this.amountTracksLabel.Size = new System.Drawing.Size(109, 19);
            this.amountTracksLabel.TabIndex = 13;
            this.amountTracksLabel.Text = "Amount Tracks";
            // 
            // previewImgPictureBox
            // 
            this.previewImgPictureBox.Location = new System.Drawing.Point(412, 96);
            this.previewImgPictureBox.Name = "previewImgPictureBox";
            this.previewImgPictureBox.Size = new System.Drawing.Size(286, 263);
            this.previewImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewImgPictureBox.TabIndex = 15;
            this.previewImgPictureBox.TabStop = false;
            // 
            // NewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 470);
            this.Controls.Add(this.previewImgPictureBox);
            this.Controls.Add(this.amountTracksTextBox);
            this.Controls.Add(this.amountTracksLabel);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.releasedDateTimePicker);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.cancelAddAlbumBtn);
            this.Controls.Add(this.confirmAddAlbumBtn);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.coverImageUrlTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.urlCoverImgLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 470);
            this.MinimumSize = new System.Drawing.Size(740, 470);
            this.Name = "NewAlbumForm";
            this.Text = "New Album";
            this.Load += new System.EventHandler(this.AddAlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialLabel authorLabel;
        private MaterialSkin.Controls.MaterialLabel urlCoverImgLabel;
        private MaterialSkin.Controls.MaterialTextBox titleTextBox;
        private MaterialSkin.Controls.MaterialTextBox coverImageUrlTextBox;
        private MaterialSkin.Controls.MaterialTextBox authorTextBox;
        private MaterialSkin.Controls.MaterialButton confirmAddAlbumBtn;
        private MaterialSkin.Controls.MaterialButton cancelAddAlbumBtn;
        private MaterialSkin.Controls.MaterialComboBox genreComboBox;
        private MaterialSkin.Controls.MaterialLabel genreLabel;
        private System.Windows.Forms.DateTimePicker releasedDateTimePicker;
        private MaterialSkin.Controls.MaterialLabel releaseDateLabel;
        private MaterialSkin.Controls.MaterialTextBox amountTracksTextBox;
        private MaterialSkin.Controls.MaterialLabel amountTracksLabel;
        private System.Windows.Forms.PictureBox previewImgPictureBox;
    }
}