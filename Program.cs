using System;
using System.Reflection.Metadata.Ecma335;

namespace WebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button("1px", 100, 50, "active");
            Button button2 = new Button("3px", 70, 50, "active");
            Button button3 = new Button("5px", 120, 100, "active");
            EditBox editBox1 = new EditBox("9px", 45, 50, "yes");
            EditBox editBox2 = new EditBox("12px", 45, 80, "yes");
            EditBox editBox3 = new EditBox("18px", 90, 70, "yes");
            Image image1 = new Image("35px", 165, 185, "jpeg");
            Image image2 = new Image("47px", 65, 113, "jpeg");
            Image image3 = new Image("64px", 45, 155, "png");
            Link link1 = new Link("55px", 10, 100, "visible");
            Link link2 = new Link("70px", 10, 100, "visible");
            Link link3 = new Link("75px", 10, 100, "visible");
            Menu menu1 = new Menu("93px", 150, 140);
            Menu menu2 = new Menu("107px", 150, 140);
            Menu menu3 = new Menu("124px", 150, 140);
            Selector selector1 = new Selector("156px", 10, 140, "CSS");
            Selector selector2 = new Selector("213px", 10, 140, "X-Path");
            Selector selector3 = new Selector("260px", 10, 140, "ID");
            TextBlock textBlock1 = new TextBlock("315px", 300, 300, "yes");
            TextBlock textBlock2 = new TextBlock("707px", 300, 300, "yes");
            TextBlock textBlock3 = new TextBlock("1005px", 300, 300, "yes");


            WebForm[] webforms = new WebForm[]
            {
                button1,
                button2,
                button3,
                editBox1,
                editBox2,
                editBox3,
                image1,
                image2,
                image3,
                link1,
                link2,
                link3,
                menu1,
                menu2,
                menu3,
                selector1,
                selector2,
                selector3,
                textBlock1,
                textBlock2,
                textBlock3
                };

            foreach (WebForm element in webforms)
            {
                if (element is IClickable)
                {
                    IClickable clickElement = (IClickable) element;
                    clickElement.ClickElement("The element is clickable");
                }

                if (element is IColorChangeable)
                {
                    IColorChangeable changecolorElement = (IColorChangeable) element;
                    changecolorElement.ColorChangeElement("The color of the element can be changed");
                }

                if (element is IHighlightable)
                {
                    IHighlightable highlightElement = (IHighlightable) element;
                    highlightElement.HighlightElement("The element can be highlighted");
                }
            }








        }
    }
}
