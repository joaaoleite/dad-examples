using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameList
{
    public partial class ListWindow : Form
    {
        public ListWindow(String list)
        {
            InitializeComponent();
            names.Text = list;
        }
    }
}
