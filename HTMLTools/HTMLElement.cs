using System.Collections.Generic;

namespace HTMLTools
{
    //@qdclass(A base class for HTML tags)
    public abstract class HTMLElement : IStringLinesConvertable
    {
        //@qdmfield(The name of the tag as shown in HTML syntax.)
        public readonly string name;

        protected List<HTMLAttribute> _attributes;
        //@qdmfunction(Initialises attributes in the class, must be called at the end of the constructor.*void)
        protected void InitAttributes()
        {
            if (typeof(IGlobalAttributes).IsAssignableFrom(this.GetType()))
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

        //@qdmfunction(The constructor.*Constructor)
        //@qdparam(name*The name of the tag as seen in HTML syntax.*string)
        public HTMLElement(string name)
        {
            this.name = name;
        }

        public virtual List<string> GetLines()
        {
            List<string> lines = new List<string>();

            string topLine = string.Format("<{0}", this.name);

            foreach (HTMLAttribute attribute in this._attributes)
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

            foreach (HTMLAttribute attribute in _attributes)
            {
                attributeDeclarations += attribute.GetLine();
            }

            line += string.Format("<{0}{1}>", name, attributeDeclarations);

            line += HTMLTools.GetNestedLine(this);

            return line;
        }
    }
    //@qdend
}
