using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class Selector:WebForm,IHighlightable
    {
        public string SelectorType { get; set; }

        public Selector(string location, int width, int length, string selectorType) : base(location, width, length)
        {
            SelectorType = selectorType;
        }

        public void HighlightElement(string element)
        {
         Console.WriteLine(element);   
        }
    }
}
