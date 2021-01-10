using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class Menu:WebForm, IClickable
    {
        public Menu(string location, int width, int length) : base(location, width, length)
        {

        }

        public void ClickElement(string element)
        {
           Console.WriteLine(element);
        }
    }
}
