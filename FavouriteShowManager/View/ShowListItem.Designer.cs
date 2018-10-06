namespace FavouriteShowManager.View
{
    partial class ShowListItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.showTitle = new System.Windows.Forms.Label();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.showDescription = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showTitle
            // 
            this.showTitle.AutoSize = true;
            this.showTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTitle.Location = new System.Drawing.Point(82, 12);
            this.showTitle.Name = "showTitle";
            this.showTitle.Size = new System.Drawing.Size(69, 15);
            this.showTitle.TabIndex = 0;
            this.showTitle.Text = "showTitle";
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.Location = new System.Drawing.Point(10, 5);
            this.posterPictureBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(59, 74);
            this.posterPictureBox.TabIndex = 1;
            this.posterPictureBox.TabStop = false;
            // 
            // showDescription
            // 
            this.showDescription.AutoSize = true;
            this.showDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDescription.Location = new System.Drawing.Point(82, 34);
            this.showDescription.MaximumSize = new System.Drawing.Size(700, 30);
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(100, 15);
            this.showDescription.TabIndex = 2;
            this.showDescription.Text = "showDescription";
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailsButton.Location = new System.Drawing.Point(804, 53);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(72, 26);
            this.detailsButton.TabIndex = 4;
            this.detailsButton.Text = "Details";
            this.detailsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(722, 53);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 26);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.AutoSize = true;
            this.labelAdditionalInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalInfo.Location = new System.Drawing.Point(82, 64);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(0, 15);
            this.labelAdditionalInfo.TabIndex = 6;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(719, 12);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(40, 15);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "state";
            // 
            // ShowListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.labelAdditionalInfo);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.posterPictureBox);
            this.Controls.Add(this.showTitle);
            this.Name = "ShowListItem";
            this.Size = new System.Drawing.Size(886, 84);
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showTitle;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label showDescription;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.Label stateLabel;
    }
}
