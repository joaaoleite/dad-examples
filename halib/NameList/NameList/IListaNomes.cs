using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NameList
{
    public partial class IListaNomes : Form
    {

        private ArrayList names;

        public IListaNomes()
        {
            names = new ArrayList();
            InitializeComponent();
        }

        private void IListaNomes_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            names.Add(textbox.Text);
            textbox.Text = "";
            MessageBox.Show("Name added!");
        }

        private void show_Click(object sender, EventArgs e)
        {
            String list = "";
            foreach(String item in names)
            {
                list = list + "\n" + item;
            }
            ListWindow listWindow = new ListWindow(list);
            listWindow.Show();
        }

        private void erase_Click(object sender, EventArgs e)
        {
            names.Clear();
            MessageBox.Show("List erased!");
        }
    }
}
