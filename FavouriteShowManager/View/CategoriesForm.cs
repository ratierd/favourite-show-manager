using FavouriteShowManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavouriteShowManager.View
{
    public partial class CategoriesForm : Form
    {
        private Show show;

        public CategoriesForm(Show showItem)
        {
            InitializeComponent();
            show = showItem;
            List<String> categories = new List<String>();
            Program.window.CategoriesListShowsButtons.ForEach(delegate (ListShowsButton b)
            {
                categories.Add(b.Title);
            });
            categoriesCheckedListBox.Items.AddRange(categories.ToArray());

            show.Categories.ForEach(delegate (String s)
            {
                categoriesCheckedListBox.SetItemChecked(categoriesCheckedListBox.Items.IndexOf(s), true);
            });
        }

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            show.Categories.Clear();
            List<String> categories = new List<String>();
            for(int i = 0; i < categoriesCheckedListBox.CheckedItems.Count; i++)
            {
                categories.Add((string)categoriesCheckedListBox.CheckedItems[i]);
            }
            show.Categories.AddRange(categories.ToArray());
            Window.controller.recordState();
        }
    }
}
