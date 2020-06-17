using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HTMLTools
{
    //@qdclass(A class that can be used to contain HTML tags and write them to a file. HTML Tags are written in the order that they are nested.)
    public class HTMLDocument : INest, IStringLinesConvertable
    {
        //@qdmfield(The tags nested within this document.*)
        public List<HTMLElement> NestedElements
        {
            get;
            set;
        }

        public HTMLDocument()
        {
            NestedElements = new List<HTMLElement>();
        }

        //@qdmfunction(Implementation of <a href="#class-IStringLineConvertable">IStringLineConvertable<a/>. Returns the document as one string.*string)
        public string GetLine()
        {
            string line = "";

            line += "<html>";

            foreach(HTMLElement nestedElement in NestedElements)
            {
                line += nestedElement.GetLine();
            }

            line += "</html>";

            return line;
        }

        //@qdmfunction(Implementation of <a href="#class-IStringLinesConvertable">IStringLinesConvertable</a>. Returns the document as a list of strings.*List<sting>)
        public List<string> GetLines()
        {
            List<string> lines = new List<string>();

            lines.Add("<!DOCTYPE html>");
            lines.Add("<html>");

            foreach(HTMLElement nestedElement in NestedElements)
            {
                lines = lines.Add(nestedElement.GetLines());
            }

            lines.Add("</html>");

            return lines;
        }

        //@qdmfunction(Writes the document to a file at the provided path. If a file exists it will be overwritten.*void)
        //@qdparam(path*The path and filename of the desired output destination. (.html will not be added automatically)*string)
        public void ExportToFile(string path)
        {

            List<string> lines = this.GetLines();

            FileMode fileMode = !File.Exists(path) ? FileMode.Create : FileMode.Truncate;

            using (FileStream outputFile = File.Open(path, fileMode))
            {
                byte[] line = null;

                foreach(string l in lines)
                {
                    string thisLine = l;
                    thisLine += "\n";
                    line = Encoding.UTF8.GetBytes(thisLine);
                    outputFile.Write(line, 0, line.Length);
                }

            }

        }

    }
    //@qdend
}
