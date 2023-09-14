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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCoverImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlbums
            // 
            this.dataGridViewAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbums.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewAlbums.Name = "dataGridViewAlbums";
            this.dataGridViewAlbums.Size = new System.Drawing.Size(520, 457);
            this.dataGridViewAlbums.TabIndex = 0;
            this.dataGridViewAlbums.SelectionChanged += new System.EventHandler(this.dataGridViewAlbums_SelectionChanged);
            // 
            // pictureBoxAlbumCoverImg
            // 
            this.pictureBoxAlbumCoverImg.Location = new System.Drawing.Point(579, 122);
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
            this.AddAlbumBtn.Location = new System.Drawing.Point(579, 405);
            this.AddAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAlbumBtn.Name = "AddAlbumBtn";
            this.AddAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddAlbumBtn.Size = new System.Drawing.Size(103, 36);
            this.AddAlbumBtn.TabIndex = 2;
            this.AddAlbumBtn.Text = "Add Album";
            this.AddAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddAlbumBtn.UseAccentColor = false;
            this.AddAlbumBtn.UseVisualStyleBackColor = true;
            this.AddAlbumBtn.Click += new System.EventHandler(this.AddAlbumBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.AddAlbumBtn);
            this.Controls.Add(this.pictureBoxAlbumCoverImg);
            this.Controls.Add(this.dataGridViewAlbums);
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
    }
}

