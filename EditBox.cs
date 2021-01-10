using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class EditBox:WebForm,IColorChangeable
    {
       public string Editable{ get; set; }
        
        public EditBox(string location, int width, int length, string editable) : base(location, width, length)
        {
            Editable = editable;
        }

        public void ColorChangeElement(string element)
        {
            Console.WriteLine();
        }
    }
}
