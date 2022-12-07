using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Properties
    {

        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
