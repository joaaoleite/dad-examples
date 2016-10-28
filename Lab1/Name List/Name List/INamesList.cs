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

namespace Name_List
{
    public partial class INamesList : Form
    {
        private ArrayList name_arr;
        public INamesList()
        {
            InitializeComponent();
            name_arr = new ArrayList();
        }

        private void INamesList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_arr.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String list = "";
            foreach (String item in name_arr)
            {
                list = list + "\n" + item;
            }
            label1.Text = list;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            name_arr.Clear();
        }
    }
}
