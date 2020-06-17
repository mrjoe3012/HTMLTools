using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(<a target="_blank" href="https://www.w3schools.com/tags/tag_meta.asp">Meta</a>)
    public class Meta : HTMLElement, IGlobalAttributes
    {
        public HTMLFieldAttribute ID { get; set; }
        public HTMLFieldAttribute Class { get; set; }
        public HTMLFieldAttribute Style { get; set; }
        public HTMLFieldAttribute AccessKey { get; set; }
        public HTMLFieldAttribute ContentEditable { get; set; }
        public HTMLFieldAttribute Dir { get; set; }
        public HTMLFieldAttribute Draggable { get; set; }
        public HTMLFieldAttribute DropZone { get; set; }
        public HTMLFieldAttribute Lang { get; set; }
        public HTMLFieldAttribute SpellCheck { get; set; }
        public HTMLFieldAttribute TabIndex { get; set; }
        public HTMLFieldAttribute Title { get; set; }
        public HTMLFieldAttribute Translate { get; set; }
        public HTMLBooleanAttribute Hidden { get; set; }

        public HTMLFieldAttribute CharSet { get; set; }
        public HTMLFieldAttribute Content { get; set; }
        public HTMLFieldAttribute HTTPEquiv { get; set; }
        public HTMLFieldAttribute Name { get; set; }

        public Meta() : base("meta")
        {

            CharSet = new HTMLFieldAttribute("charset");
            Content = new HTMLFieldAttribute("content");
            HTTPEquiv = new HTMLFieldAttribute("httpequiv");
            Name = new HTMLFieldAttribute("name");

            this.InitAttributes();
        }

    }
    //@qdend
}
