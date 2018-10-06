namespace FavouriteShowManager.View
{
    partial class StateFilter
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
            this.filterLabel = new System.Windows.Forms.Label();
            this.toSeeCheckBox = new System.Windows.Forms.CheckBox();
            this.seenCheckBox = new System.Windows.Forms.CheckBox();
            this.consideredCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(8, 10);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(8, 10, 5, 10);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(73, 20);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Filters :";
            // 
            // toSeeCheckBox
            // 
            this.toSeeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.toSeeCheckBox.AutoSize = true;
            this.toSeeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toSeeCheckBox.Location = new System.Drawing.Point(89, 10);
            this.toSeeCheckBox.Name = "toSeeCheckBox";
            this.toSeeCheckBox.Size = new System.Drawing.Size(52, 23);
            this.toSeeCheckBox.TabIndex = 1;
            this.toSeeCheckBox.Text = "To See";
            this.toSeeCheckBox.UseVisualStyleBackColor = true;
            this.toSeeCheckBox.CheckStateChanged += new System.EventHandler(this.toSeeCheckBox_CheckStateChanged);
            // 
            // seenCheckBox
            // 
            this.seenCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.seenCheckBox.AutoSize = true;
            this.seenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seenCheckBox.Location = new System.Drawing.Point(147, 10);
            this.seenCheckBox.Name = "seenCheckBox";
            this.seenCheckBox.Size = new System.Drawing.Size(42, 23);
            this.seenCheckBox.TabIndex = 2;
            this.seenCheckBox.Text = "Seen";
            this.seenCheckBox.UseVisualStyleBackColor = true;
            this.seenCheckBox.CheckStateChanged += new System.EventHandler(this.seenCheckBox_CheckStateChanged);
            // 
            // consideredCheckBox
            // 
            this.consideredCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.consideredCheckBox.AutoSize = true;
            this.consideredCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consideredCheckBox.Location = new System.Drawing.Point(195, 10);
            this.consideredCheckBox.Name = "consideredCheckBox";
            this.consideredCheckBox.Size = new System.Drawing.Size(70, 23);
            this.consideredCheckBox.TabIndex = 3;
            this.consideredCheckBox.Text = "Considered";
            this.consideredCheckBox.UseVisualStyleBackColor = true;
            this.consideredCheckBox.CheckStateChanged += new System.EventHandler(this.consideredCheckBox_CheckStateChanged);
            // 
            // StateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.consideredCheckBox);
            this.Controls.Add(this.seenCheckBox);
            this.Controls.Add(this.toSeeCheckBox);
            this.Controls.Add(this.filterLabel);
            this.Name = "StateFilter";
            this.Size = new System.Drawing.Size(346, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.CheckBox toSeeCheckBox;
        private System.Windows.Forms.CheckBox seenCheckBox;
        private System.Windows.Forms.CheckBox consideredCheckBox;
    }
}
