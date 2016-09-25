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
    public partial class Form1 : Form
    {
        private Names _namesObj;

        public Form1()
        {
            InitializeComponent();
            setNamesObj(new Names());
            

        }

        public Names getNamesObj()
        { 
                return _namesObj;
        }

        public void setNamesObj(Names obj)
        {
                _namesObj = obj;
        }
        

        private void button1_Click(object sender, EventArgs e)
        { //Add Name
            FormAddName form = new FormAddName(getNamesObj());
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { //Get All Names Button
            string result = getNamesObj().getAllNames();
            MessageBox.Show("Names present in the list: "+result);
        }

        private void button3_Click(object sender, EventArgs e)
        {  //Erase Everything Button
            getNamesObj().eraseNames();
            MessageBox.Show("All Names Erased!");
        }

        private void button4_Click(object sender, EventArgs e)
        { //Exit Button
            MessageBox.Show("Goodbye");
            Application.Exit();
        }


    }
}
