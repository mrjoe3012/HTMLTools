using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    class Comment : HTMLElement
    {
        public string commentText = "";

        public Comment() : base("htmlcomment")
        {

        }

        public Comment(string text) : this()
        {
            commentText = text;
        }

        public override string GetLine()
        {
            string line = string.Format("<!--{0}-->", commentText);
            return line;
        }

        public override List<string> GetLines()
        {
            string line = GetLine();
            return line.Split('\n').ToList();
        }
    }
}
