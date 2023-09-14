namespace WindowsFormApp.forms
{
    partial class AddAlbumForm
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
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.Location = new System.Drawing.Point(130, 116);
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
            this.authorLabel.Location = new System.Drawing.Point(114, 169);
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
            this.urlCoverImgLabel.Location = new System.Drawing.Point(50, 220);
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
            this.titleTextBox.Location = new System.Drawing.Point(168, 114);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 120);
            this.titleTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.titleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 30);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.Text = "";
            this.titleTextBox.TrailingIcon = null;
            this.titleTextBox.UseTallSize = false;
            // 
            // coverImageUrlTextBox
            // 
            this.coverImageUrlTextBox.AnimateReadOnly = false;
            this.coverImageUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coverImageUrlTextBox.Depth = 0;
            this.coverImageUrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.coverImageUrlTextBox.LeadingIcon = null;
            this.coverImageUrlTextBox.Location = new System.Drawing.Point(168, 217);
            this.coverImageUrlTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.MaxLength = 50;
            this.coverImageUrlTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.coverImageUrlTextBox.Multiline = false;
            this.coverImageUrlTextBox.Name = "coverImageUrlTextBox";
            this.coverImageUrlTextBox.Size = new System.Drawing.Size(220, 30);
            this.coverImageUrlTextBox.TabIndex = 4;
            this.coverImageUrlTextBox.Text = "";
            this.coverImageUrlTextBox.TrailingIcon = null;
            this.coverImageUrlTextBox.UseTallSize = false;
            // 
            // authorTextBox
            // 
            this.authorTextBox.AnimateReadOnly = false;
            this.authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorTextBox.Depth = 0;
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorTextBox.LeadingIcon = null;
            this.authorTextBox.Location = new System.Drawing.Point(168, 166);
            this.authorTextBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.authorTextBox.MaxLength = 50;
            this.authorTextBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.authorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorTextBox.Multiline = false;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(220, 30);
            this.authorTextBox.TabIndex = 5;
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
            this.confirmAddAlbumBtn.Location = new System.Drawing.Point(146, 330);
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
            this.cancelAddAlbumBtn.Location = new System.Drawing.Point(257, 330);
            this.cancelAddAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelAddAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelAddAlbumBtn.Name = "cancelAddAlbumBtn";
            this.cancelAddAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelAddAlbumBtn.Size = new System.Drawing.Size(86, 36);
            this.cancelAddAlbumBtn.TabIndex = 7;
            this.cancelAddAlbumBtn.Text = "Cancel";
            this.cancelAddAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelAddAlbumBtn.UseAccentColor = false;
            this.cancelAddAlbumBtn.UseVisualStyleBackColor = true;
            this.cancelAddAlbumBtn.Click += new System.EventHandler(this.cancelAddAlbumBtn_Click);
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.cancelAddAlbumBtn);
            this.Controls.Add(this.confirmAddAlbumBtn);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.coverImageUrlTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.urlCoverImgLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddAlbumForm";
            this.Text = "Add New Album";
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
    }
}