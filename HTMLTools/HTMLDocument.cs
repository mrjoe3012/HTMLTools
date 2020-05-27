using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HTMLTools
{
    public class HTMLDocument : INest, IStringLinesConvertable
    {
        public List<HTMLElement> NestedElements
        {
            get;
            set;
        }

        public HTMLDocument()
        {
            NestedElements = new List<HTMLElement>();
        }

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
}
