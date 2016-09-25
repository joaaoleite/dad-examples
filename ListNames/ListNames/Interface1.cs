using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNames
{
        interface IListaNomes
        {
            void addName(string s);
            //Adds new name to the list
            string getAllNames();
            //Return all names in the list in a string
            void eraseNames();
            //Erase list's content 
        }
}
