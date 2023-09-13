namespace WindowsFormApp
{
    partial class FormAlbums
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
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
            this.dataGridViewAlbums.Size = new System.Drawing.Size(412, 453);
            this.dataGridViewAlbums.TabIndex = 0;
            this.dataGridViewAlbums.SelectionChanged += new System.EventHandler(this.dataGridViewAlbums_SelectionChanged);
            // 
            // pictureBoxAlbumCoverImg
            // 
            this.pictureBoxAlbumCoverImg.Location = new System.Drawing.Point(489, 120);
            this.pictureBoxAlbumCoverImg.Name = "pictureBoxAlbumCoverImg";
            this.pictureBoxAlbumCoverImg.Size = new System.Drawing.Size(270, 250);
            this.pictureBoxAlbumCoverImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCoverImg.TabIndex = 1;
            this.pictureBoxAlbumCoverImg.TabStop = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(552, 404);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Edit";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(837, 526);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.pictureBoxAlbumCoverImg);
            this.Controls.Add(this.dataGridViewAlbums);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormAlbums";
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

