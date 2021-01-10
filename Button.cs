using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class Button:WebForm, IClickable
    {
        public string ButtonActivity { get; set; }

        public Button(string location, int width, int length, string buttonActivity) : base(location, width, length)
        {
            ButtonActivity = buttonActivity;
        }

        public void ClickElement(string element)
        {
            
            Console.WriteLine(element);
        }
    }
}
