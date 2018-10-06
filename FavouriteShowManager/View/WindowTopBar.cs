using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FavouriteShowManager.View
{
    public partial class WindowTopBar : UserControl
    {
        private Form parent;

        private System.Drawing.Imaging.Metafile reduceIcon;
        private System.Drawing.Imaging.Metafile selectedReduceIcon;
        private System.Drawing.Imaging.Metafile clickedReduceIcon;

        private System.Drawing.Imaging.Metafile minimizeIcon;
        private System.Drawing.Imaging.Metafile selectedMinimizeIcon;
        private System.Drawing.Imaging.Metafile clickedMinimizeIcon;

        private System.Drawing.Imaging.Metafile maximizeIcon;
        private System.Drawing.Imaging.Metafile selectedMaximizeIcon;
        private System.Drawing.Imaging.Metafile clickedMaximizeIcon;

        private System.Drawing.Imaging.Metafile closeIcon;
        private System.Drawing.Imaging.Metafile selectedCloseIcon;
        private System.Drawing.Imaging.Metafile clickedCloseIcon;

        private System.Drawing.Imaging.Metafile reduceMetafile;
        private System.Drawing.Imaging.Metafile minimizeMetafile;
        private System.Drawing.Imaging.Metafile maximizeMetafile;
        private System.Drawing.Imaging.Metafile closeMetafile;

        private bool mouseDown;
        private Point lastLocation;

        public WindowTopBar(Form parent)
        {
            InitializeComponent();

            this.Dock = DockStyle.Top;

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#242931");
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#acb0b7");

            this.parent = parent;

            reduceIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.reduce));
            selectedReduceIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.reduce_selected));
            clickedReduceIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.reduce_clicked));

            minimizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.minimize));
            selectedMinimizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.minimize_selected));
            clickedMinimizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.minimize_clicked));

            maximizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.maximize));
            selectedMaximizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.maximize_selected));
            clickedMaximizeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.maximize_clicked));

            closeIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.close));
            selectedCloseIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.close_selected));
            clickedCloseIcon = new System.Drawing.Imaging.Metafile(new System.IO.MemoryStream(Properties.Resources.close_clicked));

            reduceMetafile = reduceIcon;
            minimizeMetafile = minimizeIcon;
            maximizeMetafile = maximizeIcon;
            closeMetafile = closeIcon;

            mouseDown = false;
            lastLocation = Point.Empty;

            parent.Controls.Add(this);
        }

        //Reduce control

        private void reduce_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(reduceMetafile, new Rectangle(Point.Empty, reduce.ClientSize));
        }

        private void reduce_Resize(object sender, EventArgs e)
        {
            reduce.Invalidate();
        }

        private void reduce_MouseEnter(object sender, EventArgs e)
        {
            reduceMetafile = selectedReduceIcon;
            reduce.Invalidate();
        }

        private void reduce_MouseLeave(object sender, EventArgs e)
        {
            reduceMetafile = reduceIcon;
            reduce.Invalidate();
        }

        private void reduce_MouseDown(object sender, MouseEventArgs e)
        {
            reduceMetafile = clickedReduceIcon;
            reduce.Invalidate();
        }

        private void reduce_MouseUp(object sender, MouseEventArgs e)
        {
            reduceMetafile = selectedReduceIcon;
            reduce.Invalidate();
            parent.WindowState = FormWindowState.Minimized;
        }

        //Minimize_Maximize control

        private void minimize_maximize_Paint(object sender, PaintEventArgs e)
        {
            if(parent.WindowState == FormWindowState.Normal)
            {
                e.Graphics.DrawImage(maximizeMetafile, new Rectangle(Point.Empty, reduce.ClientSize));
            }
            else if (parent.WindowState == FormWindowState.Maximized)
            {
                e.Graphics.DrawImage(minimizeMetafile, new Rectangle(Point.Empty, reduce.ClientSize));
            }
        }

        private void minimize_maximize_Resize(object sender, EventArgs e)
        {
            minimize_maximize.Invalidate();
        }

        private void minimize_maximize_MouseEnter(object sender, EventArgs e)
        {
            minimizeMetafile = selectedMinimizeIcon;
            maximizeMetafile = selectedMaximizeIcon;
            minimize_maximize.Invalidate();
        }

        private void minimize_maximize_MouseLeave(object sender, EventArgs e)
        {
            minimizeMetafile = minimizeIcon;
            maximizeMetafile = maximizeIcon;
            minimize_maximize.Invalidate();
        }

        private void minimize_maximize_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeMetafile = clickedMinimizeIcon;
            maximizeMetafile = clickedMaximizeIcon;
            minimize_maximize.Invalidate();
        }

        private void minimize_maximize_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeMetafile = selectedMinimizeIcon;
            maximizeMetafile = selectedMaximizeIcon;
            minimize_maximize.Invalidate();
            if (parent.WindowState == FormWindowState.Normal)
            {
                parent.WindowState = FormWindowState.Maximized;
            }
            else if (parent.WindowState == FormWindowState.Maximized)
            {
                parent.WindowState = FormWindowState.Normal;
            }
        }

        //Close control

        private void close_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(closeMetafile, new Rectangle(Point.Empty, reduce.ClientSize));
        }

        private void close_Resize(object sender, EventArgs e)
        {
            close.Invalidate();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            closeMetafile = selectedCloseIcon;
            close.Invalidate();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            closeMetafile = closeIcon;
            close.Invalidate();
        }

        private void close_MouseDown(object sender, MouseEventArgs e)
        {
            closeMetafile = clickedCloseIcon;
            close.Invalidate();
        }

        private void close_MouseUp(object sender, MouseEventArgs e)
        {
            closeMetafile = selectedCloseIcon;
            close.Invalidate();
            parent.Close();
        }

        //Drag window

        private void WindowTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void WindowTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if(parent.WindowState == FormWindowState.Maximized)
                {
                    parent.WindowState = FormWindowState.Normal;
                }
                this.Parent.Location = new Point(
                    (this.Parent.Location.X - lastLocation.X) + e.X, (this.Parent.Location.Y - lastLocation.Y) + e.Y);

                this.Parent.Update();
            }
        }

        private void WindowTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
