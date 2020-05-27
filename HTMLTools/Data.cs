using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    class Data : HTMLElement, IGlobalAttributes, INest
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

        public HTMLFieldAttribute Value { get; set; }

        public Data() : base("data")
        {
            this.NestedElements = new List<HTMLElement>();
            Value = new HTMLFieldAttribute("value");
            this.InitAttributes();
        }

    }
}
