using System;
using System.Collections.Generic;
using System.Text;

namespace WebPage
{
    class Image:WebForm
    {
        public string ImageType { get; set; }

        public Image(string location, int width, int length, string imageType) : base(location, width, length)
        {
            ImageType = imageType;
        }
    }
}
