using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
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
}
