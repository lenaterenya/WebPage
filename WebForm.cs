using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
   abstract class WebForm
    {
        public string LeftUpperLocation { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }


        public WebForm(string location, int width, int length)
        {
            LeftUpperLocation = location;
            Width = width;
            Length = length;
        }

        

    }
}
