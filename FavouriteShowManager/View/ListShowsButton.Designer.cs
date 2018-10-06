namespace FavouriteShowManager.View
{
    partial class ListShowsButton
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.textOffset = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(30, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "titlelabel";
            this.titleLabel.Click += new System.EventHandler(this.ListShowsButton_Click);
            // 
            // textOffset
            // 
            this.textOffset.Location = new System.Drawing.Point(0, 5);
            this.textOffset.Name = "textOffset";
            this.textOffset.Size = new System.Drawing.Size(30, 13);
            this.textOffset.TabIndex = 0;
            this.textOffset.TabStop = false;
            this.textOffset.Click += new System.EventHandler(this.ListShowsButton_Click);
            // 
            // ListShowsButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textOffset);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListShowsButton";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(249, 23);
            this.Click += new System.EventHandler(this.ListShowsButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Splitter textOffset;
    }
}
