namespace FavouriteShowManager.View
{
    partial class WindowTopBar
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
            this.windowTitle = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize_maximize = new System.Windows.Forms.PictureBox();
            this.reduce = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reduce)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Location = new System.Drawing.Point(11, 9);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(126, 13);
            this.windowTitle.TabIndex = 0;
            this.windowTitle.Text = "Favourite Show Manager";
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Location = new System.Drawing.Point(415, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(48, 32);
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Paint += new System.Windows.Forms.PaintEventHandler(this.close_Paint);
            this.close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.close_MouseDown);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.close_MouseUp);
            this.close.Resize += new System.EventHandler(this.close_Resize);
            // 
            // minimize_maximize
            // 
            this.minimize_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_maximize.Location = new System.Drawing.Point(367, 0);
            this.minimize_maximize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize_maximize.Name = "minimize_maximize";
            this.minimize_maximize.Size = new System.Drawing.Size(48, 32);
            this.minimize_maximize.TabIndex = 2;
            this.minimize_maximize.TabStop = false;
            this.minimize_maximize.Paint += new System.Windows.Forms.PaintEventHandler(this.minimize_maximize_Paint);
            this.minimize_maximize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimize_maximize_MouseDown);
            this.minimize_maximize.MouseEnter += new System.EventHandler(this.minimize_maximize_MouseEnter);
            this.minimize_maximize.MouseLeave += new System.EventHandler(this.minimize_maximize_MouseLeave);
            this.minimize_maximize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimize_maximize_MouseUp);
            this.minimize_maximize.Resize += new System.EventHandler(this.minimize_maximize_Resize);
            // 
            // reduce
            // 
            this.reduce.Dock = System.Windows.Forms.DockStyle.Right;
            this.reduce.Location = new System.Drawing.Point(319, 0);
            this.reduce.Margin = new System.Windows.Forms.Padding(0);
            this.reduce.Name = "reduce";
            this.reduce.Size = new System.Drawing.Size(48, 32);
            this.reduce.TabIndex = 3;
            this.reduce.TabStop = false;
            this.reduce.Paint += new System.Windows.Forms.PaintEventHandler(this.reduce_Paint);
            this.reduce.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reduce_MouseDown);
            this.reduce.MouseEnter += new System.EventHandler(this.reduce_MouseEnter);
            this.reduce.MouseLeave += new System.EventHandler(this.reduce_MouseLeave);
            this.reduce.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reduce_MouseUp);
            this.reduce.Resize += new System.EventHandler(this.reduce_Resize);
            // 
            // WindowTopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reduce);
            this.Controls.Add(this.minimize_maximize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.windowTitle);
            this.Name = "WindowTopBar";
            this.Size = new System.Drawing.Size(463, 32);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowTopBar_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reduce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize_maximize;
        private System.Windows.Forms.PictureBox reduce;
    }
}
