using System.Collections.Generic;

namespace HTMLTools
{
    public abstract class HTMLElement : IStringLinesConvertable
    {
        public readonly string name;
        protected List<HTMLAttribute> _attributes;
        
        protected void InitAttributes()
        {
            if(typeof(IGlobalAttributes).IsAssignableFrom(this.GetType()))
            {
                IGlobalAttributes globalAtt = (IGlobalAttributes)this;

                HTMLTools.InitGlobalAttributes(ref globalAtt);
            }

            if (typeof(IEventAttributes).IsAssignableFrom(this.GetType()))
            {
                IEventAttributes eventAtt = (IEventAttributes)this;

                HTMLTools.InitEventAttributes(ref eventAtt);
            }

            _attributes = HTMLTools.GetAttributes(this);
        }

        public HTMLElement(string name)
        {
            this.name = name;
        }

        public virtual List<string> GetLines()
        {
            List<string> lines = new List<string>();

            string topLine = string.Format("<{0}", this.name);

            foreach(HTMLAttribute attribute in this._attributes)
            {
                topLine += attribute.GetLine();
            }

            topLine += '>';

            lines.Add(topLine);

            lines = lines.Add(HTMLTools.GetNestedLines(this));

            return lines;

        }

        public virtual string GetLine()
        {
            string line = "", attributeDeclarations = "";

            foreach(HTMLAttribute attribute in _attributes)
            {
                attributeDeclarations += attribute.GetLine();
            }

            line += string.Format("<{0}{1}>", name, attributeDeclarations);

            line += HTMLTools.GetNestedLine(this);

            return line;
        }
    }
}
