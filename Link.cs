using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class Link:WebForm,IClickable
    {
        public string LinkType { get; set; }

        public Link(string location, int width, int length, string linkType) : base(location, width, length)
        {
            LinkType = linkType;
        }

        public void ClickElement(string element)
        {
            Console.WriteLine(element);
        }
    }
}
