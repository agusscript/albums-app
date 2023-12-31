﻿namespace WindowsFormApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAlbums = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.editAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.deleteAlbumBtn = new MaterialSkin.Controls.MaterialButton();
            this.totalAlbumsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.filterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.searchBtn = new MaterialSkin.Controls.MaterialButton();
            this.viewDetailsBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlbums
            // 
            this.dataGridViewAlbums.AllowUserToAddRows = false;
            this.dataGridViewAlbums.AllowUserToDeleteRows = false;
            this.dataGridViewAlbums.AllowUserToResizeColumns = false;
            this.dataGridViewAlbums.AllowUserToResizeRows = false;
            this.dataGridViewAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlbums.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlbums.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlbums.ColumnHeadersHeight = 30;
            this.dataGridViewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAlbums.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAlbums.EnableHeadersVisualStyles = false;
            this.dataGridViewAlbums.Location = new System.Drawing.Point(6, 121);
            this.dataGridViewAlbums.MultiSelect = false;
            this.dataGridViewAlbums.Name = "dataGridViewAlbums";
            this.dataGridViewAlbums.ReadOnly = true;
            this.dataGridViewAlbums.RowHeadersVisible = false;
            this.dataGridViewAlbums.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlbums.ShowEditingIcon = false;
            this.dataGridViewAlbums.ShowRowErrors = false;
            this.dataGridViewAlbums.Size = new System.Drawing.Size(594, 453);
            this.dataGridViewAlbums.TabIndex = 0;
            // 
            // AddAlbumBtn
            // 
            this.AddAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddAlbumBtn.Depth = 0;
            this.AddAlbumBtn.HighEmphasis = true;
            this.AddAlbumBtn.Icon = null;
            this.AddAlbumBtn.Location = new System.Drawing.Point(629, 277);
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
            // editAlbumBtn
            // 
            this.editAlbumBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editAlbumBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editAlbumBtn.Depth = 0;
            this.editAlbumBtn.HighEmphasis = true;
            this.editAlbumBtn.Icon = null;
            this.editAlbumBtn.Location = new System.Drawing.Point(629, 343);
            this.editAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editAlbumBtn.Name = "editAlbumBtn";
            this.editAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editAlbumBtn.Size = new System.Drawing.Size(106, 36);
            this.editAlbumBtn.TabIndex = 3;
            this.editAlbumBtn.Text = "Edit Album";
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
            this.deleteAlbumBtn.Location = new System.Drawing.Point(629, 409);
            this.deleteAlbumBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteAlbumBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteAlbumBtn.Name = "deleteAlbumBtn";
            this.deleteAlbumBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteAlbumBtn.Size = new System.Drawing.Size(126, 36);
            this.deleteAlbumBtn.TabIndex = 4;
            this.deleteAlbumBtn.Text = "Delete Album";
            this.deleteAlbumBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteAlbumBtn.UseAccentColor = false;
            this.deleteAlbumBtn.UseVisualStyleBackColor = true;
            this.deleteAlbumBtn.Click += new System.EventHandler(this.deleteAlbumBtn_Click_1);
            // 
            // totalAlbumsLabel
            // 
            this.totalAlbumsLabel.AutoSize = true;
            this.totalAlbumsLabel.Depth = 0;
            this.totalAlbumsLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.totalAlbumsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.totalAlbumsLabel.Location = new System.Drawing.Point(420, 80);
            this.totalAlbumsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalAlbumsLabel.Name = "totalAlbumsLabel";
            this.totalAlbumsLabel.Size = new System.Drawing.Size(124, 24);
            this.totalAlbumsLabel.TabIndex = 5;
            this.totalAlbumsLabel.Text = "Total Albums:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Depth = 0;
            this.filterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.filterLabel.Location = new System.Drawing.Point(14, 82);
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
            this.searchTextBox.Location = new System.Drawing.Point(60, 77);
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
            // searchBtn
            // 
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchBtn.Depth = 0;
            this.searchBtn.HighEmphasis = true;
            this.searchBtn.Icon = null;
            this.searchBtn.Location = new System.Drawing.Point(313, 77);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBtn.MaximumSize = new System.Drawing.Size(78, 30);
            this.searchBtn.MinimumSize = new System.Drawing.Size(78, 30);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchBtn.Size = new System.Drawing.Size(78, 30);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchBtn.UseAccentColor = false;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // viewDetailsBtn
            // 
            this.viewDetailsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewDetailsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.viewDetailsBtn.Depth = 0;
            this.viewDetailsBtn.HighEmphasis = true;
            this.viewDetailsBtn.Icon = null;
            this.viewDetailsBtn.Location = new System.Drawing.Point(629, 213);
            this.viewDetailsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewDetailsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.viewDetailsBtn.Name = "viewDetailsBtn";
            this.viewDetailsBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.viewDetailsBtn.Size = new System.Drawing.Size(118, 36);
            this.viewDetailsBtn.TabIndex = 10;
            this.viewDetailsBtn.Text = "View Details";
            this.viewDetailsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.viewDetailsBtn.UseAccentColor = false;
            this.viewDetailsBtn.UseVisualStyleBackColor = true;
            this.viewDetailsBtn.Click += new System.EventHandler(this.viewDetailsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 580);
            this.Controls.Add(this.viewDetailsBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.totalAlbumsLabel);
            this.Controls.Add(this.deleteAlbumBtn);
            this.Controls.Add(this.editAlbumBtn);
            this.Controls.Add(this.AddAlbumBtn);
            this.Controls.Add(this.dataGridViewAlbums);
            this.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 580);
            this.MinimumSize = new System.Drawing.Size(780, 580);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlbums;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton AddAlbumBtn;
        private MaterialSkin.Controls.MaterialButton editAlbumBtn;
        private MaterialSkin.Controls.MaterialButton deleteAlbumBtn;
        private MaterialSkin.Controls.MaterialLabel totalAlbumsLabel;
        private MaterialSkin.Controls.MaterialLabel filterLabel;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private MaterialSkin.Controls.MaterialButton searchBtn;
        private MaterialSkin.Controls.MaterialButton viewDetailsBtn;
    }
}

