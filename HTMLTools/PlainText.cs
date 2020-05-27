using System.Collections.Generic;
using System.Linq;

namespace HTMLTools
{
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
}
