using System.Collections.Generic;
using System.Linq;

namespace HTMLTools
{
    //@qdclass(This represents text without a tag within an HTML document. For example, the inner HTML of a <a href="#class-Paragraph">"p"</a> tag may often contain plain text within it.)
    class PlainText : HTMLElement
    {

        public string text;

        public PlainText() : base("plaintext")
        {

        }

        public PlainText(string text) : this()
        {
            this.text = text;
        }

        public override string GetLine()
        {
            return text;
        }

        public override List<string> GetLines()
        {
            return text.Split('\n').ToList();
        }

    }
    //@qdend
}
