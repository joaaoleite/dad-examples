using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListNames
{
    public partial class FormAddName : Form
    {
        private Names _namesObj;

        public Names getNamesObj()
        {
            return _namesObj;
        }

        public void setNamesObj(Names obj)
        {
            _namesObj = obj;
        }

        public FormAddName(Names obj)
        {
            InitializeComponent();
            setNamesObj(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getNamesObj().addName(textBox1.Text);
            MessageBox.Show("Name added!");
            this.Close();
        }
    }
}
