using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(<a target="_blank" href="https://www.w3schools.com/tags/tag_svg.asp">SVG</a>)
    public class SVG : HTMLElement, INest
    {
        public List<HTMLElement> NestedElements { get; set; }

        public HTMLFieldAttribute Width { get; set; }
        public HTMLFieldAttribute Height { get; set; }

        public SVG() : base("svg")
        {
            this.Width = new HTMLFieldAttribute("width");
            this.Height = new HTMLFieldAttribute("height");
            this.NestedElements = new List<HTMLElement>();
            this.InitAttributes();
        }

    }
    //@qdend
}
