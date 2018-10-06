namespace FavouriteShowManager.View
{
    partial class ShowDetails
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
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.showTitle = new System.Windows.Forms.Label();
            this.showDescription = new System.Windows.Forms.Label();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.commentHeaderLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.Location = new System.Drawing.Point(58, 38);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(159, 225);
            this.posterPictureBox.TabIndex = 0;
            this.posterPictureBox.TabStop = false;
            // 
            // showTitle
            // 
            this.showTitle.AutoSize = true;
            this.showTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTitle.Location = new System.Drawing.Point(241, 47);
            this.showTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.showTitle.Name = "showTitle";
            this.showTitle.Size = new System.Drawing.Size(52, 24);
            this.showTitle.TabIndex = 1;
            this.showTitle.Text = "title";
            // 
            // showDescription
            // 
            this.showDescription.AutoSize = true;
            this.showDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showDescription.Location = new System.Drawing.Point(242, 101);
            this.showDescription.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.showDescription.MaximumSize = new System.Drawing.Size(700, 30);
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(56, 15);
            this.showDescription.TabIndex = 2;
            this.showDescription.Text = "synopsis";
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actorsLabel.Location = new System.Drawing.Point(242, 142);
            this.actorsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(42, 15);
            this.actorsLabel.TabIndex = 3;
            this.actorsLabel.Text = "actors";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.languageLabel.Location = new System.Drawing.Point(242, 162);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(59, 15);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "language";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(240, 237);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 26);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // commentHeaderLabel
            // 
            this.commentHeaderLabel.AutoSize = true;
            this.commentHeaderLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentHeaderLabel.Location = new System.Drawing.Point(53, 286);
            this.commentHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.commentHeaderLabel.Name = "commentHeaderLabel";
            this.commentHeaderLabel.Size = new System.Drawing.Size(187, 26);
            this.commentHeaderLabel.TabIndex = 8;
            this.commentHeaderLabel.Text = "commentHeader";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.commentTextBox.Location = new System.Drawing.Point(58, 315);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(1109, 266);
            this.commentTextBox.TabIndex = 9;
            this.commentTextBox.Text = "";
            this.commentTextBox.TextChanged += new System.EventHandler(this.commentTextBox_TextChanged);
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.AutoSize = true;
            this.labelAdditionalInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAdditionalInfo.Location = new System.Drawing.Point(242, 182);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(85, 15);
            this.labelAdditionalInfo.TabIndex = 10;
            this.labelAdditionalInfo.Text = "additionalInfo";
            // 
            // buttonCategories
            // 
            this.buttonCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCategories.Location = new System.Drawing.Point(1071, 38);
            this.buttonCategories.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(96, 26);
            this.buttonCategories.TabIndex = 11;
            this.buttonCategories.Text = "Categories +";
            this.buttonCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.categoriesLabel.Location = new System.Drawing.Point(242, 75);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(77, 16);
            this.categoriesLabel.TabIndex = 12;
            this.categoriesLabel.Text = "categories";
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(1046, 70);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 13;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // ShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.labelAdditionalInfo);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentHeaderLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.showTitle);
            this.Controls.Add(this.posterPictureBox);
            this.Name = "ShowDetails";
            this.Size = new System.Drawing.Size(1221, 596);
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label showTitle;
        private System.Windows.Forms.Label showDescription;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label commentHeaderLabel;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
    }
}
