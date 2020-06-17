using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(<a target="_blank" href="https://www.w3schools.com/tags/tag_comment.asp">Comment</a>)
    public class Comment : HTMLElement
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
    //@qdend
}
