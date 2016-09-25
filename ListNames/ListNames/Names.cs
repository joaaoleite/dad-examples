using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNames
{
    public class Names : IListaNomes
    {
        private ArrayList _list;

        public Names()
        {
            ArrayList list = new ArrayList();
            setList(list);
        }
        public void setList(ArrayList newList)
        {
            _list = newList;
        }
        public ArrayList getList()
        {
            return _list;
        }

        public void addName(string s)
        {//Adds new name to the list
            getList().Add(s);
        }
        
        
        public string getAllNames()
        {
            //Return all names in the list

            string resultString = "";
            foreach (string s in getList())
            {
                if (resultString.Equals(""))
                {
                    resultString = s;
                }
                else
                {
                    resultString = resultString + " ; " + s;
                }
            }
            return resultString;
        }

        public void eraseNames()
        {//Erase list's content 
            getList().Clear();
        }
    }
}
