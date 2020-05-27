using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    public class Script : HTMLElement, IGlobalAttributes, INest
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
        public List<HTMLElement> NestedElements { get; set; }

        public HTMLFieldAttribute Async { get; set; }
        public HTMLFieldAttribute CharSet { get; set; }
        public HTMLFieldAttribute Defer { get; set; }
        public HTMLFieldAttribute Source { get; set; }
        public HTMLFieldAttribute Type { get; set; }

        public Script() : base("script")
        {
            Async = new HTMLFieldAttribute("async");
            CharSet = new HTMLFieldAttribute("charset");
            Defer = new HTMLFieldAttribute("defer");
            Source = new HTMLFieldAttribute("src");
            Type = new HTMLFieldAttribute("type");

            NestedElements = new List<HTMLElement>();

            InitAttributes();
        }

    }
}
