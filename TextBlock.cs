using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace WebPage
{
    class TextBlock : WebForm
    {
        public string Formatting { get; set; }

        public TextBlock(string location, int width, int length, string formatting) : base(location, width, length)
        {
            Formatting = formatting;
        }
    }
}
