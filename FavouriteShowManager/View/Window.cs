using FavouriteShowManager.Controller;
using FavouriteShowManager.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FavouriteShowManager
{
    public partial class Window : Form
    {
        public static ShowController controller;

        private Dropshadow shadow;
        private WindowTopBar topBar;
        private Panel sidePanel;
        public Panel SidePanel { get { return sidePanel; } }
        private List<ListShowsButton> allListShowsButtons;
        public List<ListShowsButton> AllListShowsButtons { get { return allListShowsButtons; } }
        private List<ListShowsButton> categoriesListShowsButtons;
        public List<ListShowsButton> CategoriesListShowsButtons { get { return categoriesListShowsButtons; } }
        private ListShowsButtonGroup filtersGroup1;
        private ListShowsButtonGroup filtersGroup2;
        private Splitter splitter;
        private Panel contentPanel;
        public Panel ContentPanel { get { return contentPanel; } }
        public StatusStrip StatusStrip { get { return statusStrip; } }
        public ToolStripStatusLabel ToolStripStatusLabel { get { return toolStripStatusLabel; } }

        public Window()
        {
            InitializeComponent();
            topBar = new WindowTopBar(this);
            statusStrip.BackColor = System.Drawing.ColorTranslator.FromHtml("#3d4755");

            splitter = new Splitter();
            splitter.BorderStyle = BorderStyle.None;
            splitter.BackColor = System.Drawing.ColorTranslator.FromHtml("#434d5b");
            splitter.Width = 1;
            splitter.Enabled = false;

            sidePanel = new Panel();
            sidePanel.Dock = DockStyle.Left;
            sidePanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#242931");
            
            ListShowsButton searchbutton = new ListShowsButton(BasicActions.SEARCH);
            searchbutton.Dock = DockStyle.Top;

            Splitter groupSplitter = new Splitter();
            groupSplitter.Dock = DockStyle.Top;
            groupSplitter.BorderStyle = BorderStyle.None;
            groupSplitter.BackColor = System.Drawing.ColorTranslator.FromHtml("#434d5b");
            groupSplitter.Width = 1;
            groupSplitter.Enabled = false;

            List<ListShowsButton> commonActionButtons = new List<ListShowsButton>();
            ListShowsButton allShows = new ListShowsButton(BasicActions.ALL);
            commonActionButtons.Add(allShows);
            filtersGroup1 = new ListShowsButtonGroup("Basic", commonActionButtons, false);
            filtersGroup1.Dock = DockStyle.Top;

            List<ListShowsButton> categoryButtons = new List<ListShowsButton>();
            try
            {
                string text = System.IO.File.ReadAllText(@".\categories.txt");
                foreach (String s in text.Split(','))
                {
                    ListShowsButton b = new ListShowsButton(s);
                    categoryButtons.Add(b);
                }
            }
            catch { }
            filtersGroup2 = new ListShowsButtonGroup("Categories", categoryButtons, true);
            filtersGroup2.Dock = DockStyle.Top;
            filtersGroup2.ButtonAdded += filtersGroup2_ButtonAdded;
            categoriesListShowsButtons = categoryButtons;
            foreach (ListShowsButton b in categoriesListShowsButtons)
            {
                b.MouseClick += categoryButton_rightClick;
            }

            sidePanel.Controls.Add(filtersGroup2);
            sidePanel.Controls.Add(filtersGroup1);
            sidePanel.Controls.Add(groupSplitter);
            sidePanel.Controls.Add(searchbutton);

            allListShowsButtons = new List<ListShowsButton>();
            allListShowsButtons.Add(searchbutton);
            allListShowsButtons.AddRange(commonActionButtons);
            allListShowsButtons.AddRange(categoryButtons.ToArray());
            foreach(ListShowsButton b in allListShowsButtons)
            {
                b.Selected += listShowsButton_Selected;
            }

            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#2c333e");

            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(splitter);
            mainPanel.Controls.Add(sidePanel);

            if (!DesignMode)
            {
                shadow = new Dropshadow(this)
                {
                    ShadowBlur = 2,
                    ShadowSpread = 1,
                    ShadowColor = Color.FromArgb(80, 40, 40, 40)
                };
            }
            
            controller = new ShowController();
        }

        private void filtersGroup2_ButtonAdded(object sender, ListShowsButtonGroup.ButtonAddedEventArgs e)
        {
            allListShowsButtons.Add(e.Button);
            e.Button.MouseClick += categoryButton_rightClick;
            e.Button.Selected += listShowsButton_Selected;
            recordCategories();
        }

        private void categoryButton_rightClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                categoriesListShowsButtons.Remove((ListShowsButton)sender);
                allListShowsButtons.Remove((ListShowsButton)sender);
                filtersGroup2.removeItem((ListShowsButton)sender);
                filtersGroup2.Invalidate();
                recordCategories();
            }
        }

        private void recordCategories()
        {
            String recordCategories = "";
            foreach (ListShowsButton b in categoriesListShowsButtons)
            {
                recordCategories += b.Title;
                if (categoriesListShowsButtons.IndexOf(b) < categoriesListShowsButtons.Count - 1)
                {
                    recordCategories += ",";
                }
            }
            System.IO.File.WriteAllText(@".\categories.txt", recordCategories);
        }

        private const int WM_NCHITTEST = 0x0084;
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    m.Result = (IntPtr)2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void Window_Load(object sender, EventArgs e)
        {
            shadow.RefreshShadow();
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            shadow.RefreshShadow();
        }

        private void listShowsButton_Selected(object sender, ListShowsButton.SelectedEventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.AddRange(e.Controls.ToArray());
            foreach (ListShowsButton b in allListShowsButtons)
            {
                if (b != sender)
                {
                    b.IsSelected = false;
                }
            }
            Program.window.ToolStripStatusLabel.Text = "";
            Program.window.StatusStrip.Refresh();
        }
    }
}
