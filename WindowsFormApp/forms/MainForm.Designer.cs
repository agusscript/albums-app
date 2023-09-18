namespace WindowsFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAlbums = new System.Windows.Forms.DataGridView();
            this.pictureBoxAlbumCoverImg = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.editAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.deleteAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.totalAlbumsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.filterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlbums
            // 
            this.dataGridViewAlbums.AllowUserToAddRows = false;
            this.dataGridViewAlbums.AllowUserToDeleteRows = false;
            this.dataGridViewAlbums.AllowUserToResizeColumns = false;
            this.dataGridViewAlbums.AllowUserToResizeRows = false;
            this.dataGridViewAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlbums.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlbums.ColumnHeadersHeight = 30;
            this.dataGridViewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAlbums.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAlbums.Location = new System.Drawing.Point(6, 128);
            this.dataGridViewAlbums.MultiSelect = false;
            this.dataGridViewAlbums.Name = "dataGridViewAlbums";
            this.dataGridViewAlbums.RowHeadersVisible = false;
            this.dataGridViewAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlbums.ShowEditingIcon = false;
            this.dataGridViewAlbums.ShowRowErrors = false;
            this.dataGridViewAlbums.Size = new System.Drawing.Size(520, 397);
            this.dataGridViewAlbums.TabIndex = 0;
            this.dataGridViewAlbums.SelectionChanged += new System.EventHandler(this.dataGridViewAlbums_SelectionChanged);
            // 
            // pictureBoxAlbumCoverImg
            // 
            this.pictureBoxAlbumCoverImg.Location = new System.Drawing.Point(572, 150);
            this.pictureBoxAlbumCoverImg.Name = "pictureBoxAlbumCoverImg";
            this.pictureBoxAlbumCoverImg.Size = new System.Drawing.Size(270, 250);
            this.pictureBoxAlbumCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCoverImg.TabIndex = 1;
            this.pictureBoxAlbumCoverImg.TabStop = false;
            // 
            // AddAlbumBtn
            // 
            this.AddAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddAlbumBtn.Depth = 0;
            this.AddAlbumBtn.HighEmphasis = true;
            this.AddAlbumBtn.Icon = null;
            this.AddAlbumBtn.Location = new System.Drawing.Point(572, 433);
            this.AddAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAlbumBtn.Name = "AddAlbumBtn";
            this.AddAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddAlbumBtn.Size = new System.Drawing.Size(64, 36);
            this.AddAlbumBtn.TabIndex = 2;
            this.AddAlbumBtn.Text = "Add";
            this.AddAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddAlbumBtn.UseAccentColor = false;
            this.AddAlbumBtn.UseVisualStyleBackColor = true;
            this.AddAlbumBtn.Click += new System.EventHandler(this.AddAlbumBtn_Click);
            // 
            // editAlbumBtn
            // 
            this.editAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editAlbumBtn.Depth = 0;
            this.editAlbumBtn.HighEmphasis = true;
            this.editAlbumBtn.Icon = null;
            this.editAlbumBtn.Location = new System.Drawing.Point(672, 433);
            this.editAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editAlbumBtn.Name = "editAlbumBtn";
            this.editAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editAlbumBtn.Size = new System.Drawing.Size(64, 36);
            this.editAlbumBtn.TabIndex = 3;
            this.editAlbumBtn.Text = "Edit";
            this.editAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editAlbumBtn.UseAccentColor = false;
            this.editAlbumBtn.UseVisualStyleBackColor = true;
            this.editAlbumBtn.Click += new System.EventHandler(this.editAlbumBtn_Click);
            // 
            // deleteAlbumBtn
            // 
            this.deleteAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteAlbumBtn.Depth = 0;
            this.deleteAlbumBtn.HighEmphasis = true;
            this.deleteAlbumBtn.Icon = null;
            this.deleteAlbumBtn.Location = new System.Drawing.Point(769, 433);
            this.deleteAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteAlbumBtn.Name = "deleteAlbumBtn";
            this.deleteAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteAlbumBtn.Size = new System.Drawing.Size(73, 36);
            this.deleteAlbumBtn.TabIndex = 4;
            this.deleteAlbumBtn.Text = "Delete";
            this.deleteAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteAlbumBtn.UseAccentColor = false;
            this.deleteAlbumBtn.UseVisualStyleBackColor = true;
            this.deleteAlbumBtn.Click += new System.EventHandler(this.deleteAlbumBtn_Click_1);
            // 
            // totalAlbumsLabel
            // 
            this.totalAlbumsLabel.AutoSize = true;
            this.totalAlbumsLabel.Depth = 0;
            this.totalAlbumsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalAlbumsLabel.Location = new System.Drawing.Point(569, 93);
            this.totalAlbumsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalAlbumsLabel.Name = "totalAlbumsLabel";
            this.totalAlbumsLabel.Size = new System.Drawing.Size(100, 19);
            this.totalAlbumsLabel.TabIndex = 5;
            this.totalAlbumsLabel.Text = "Total Albums:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Depth = 0;
            this.filterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filterLabel.Location = new System.Drawing.Point(82, 87);
            this.filterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(36, 19);
            this.filterLabel.TabIndex = 7;
            this.filterLabel.Text = "Filter";
            // 
            // searchTextBox
            // 
            this.searchTextBox.AnimateReadOnly = false;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Depth = 0;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.LeadingIcon = null;
            this.searchTextBox.Location = new System.Drawing.Point(128, 82);
            this.searchTextBox.MaximumSize = new System.Drawing.Size(246, 30);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.MinimumSize = new System.Drawing.Size(246, 30);
            this.searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 30);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.Text = "";
            this.searchTextBox.TrailingIcon = null;
            this.searchTextBox.UseTallSize = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.totalAlbumsLabel);
            this.Controls.Add(this.deleteAlbumBtn);
            this.Controls.Add(this.editAlbumBtn);
            this.Controls.Add(this.AddAlbumBtn);
            this.Controls.Add(this.pictureBoxAlbumCoverImg);
            this.Controls.Add(this.dataGridViewAlbums);
            this.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(880, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCoverImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumCoverImg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton AddAlbumBtn;
        private MaterialSkin.Controls.MaterialButton editAlbumBtn;
        private MaterialSkin.Controls.MaterialButton deleteAlbumBtn;
        private MaterialSkin.Controls.MaterialLabel totalAlbumsLabel;
        private MaterialSkin.Controls.MaterialLabel filterLabel;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
    }
}

