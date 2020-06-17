using System;
using HTMLTools;

class Program
{
    static void Main(string[] args)
    {

        Paragraph p = new Paragraph(); // <p></p>
        p.NestedElements.Add(new PlainText("Hello World!")); // <p>Hello World!</p>

        Division div = new Division(); // <div></div>
        div.NestedElements.Add(p); // <div><p>Hello World</p></div>

        Comment htmlcomment = new Comment("You can do comments too!"); // <!--You can do comments too!-->

        HTMLDocument document = new HTMLDocument(); // <html></html>
        document.NestedElements.Add(htmlcomment); // <html><!--...--></html>
        document.NestedElements.Add(div); // <html><!--...--><div><p>...</p></div></html>

        Console.WriteLine(p.NestedElements[0].GetLine());
        Console.WriteLine(p.GetLine());
        Console.WriteLine(div.GetLine());
        Console.WriteLine(document.GetLine());
        Console.WriteLine();

        System.Collections.Generic.List<string> lines = document.GetLines(); // Line by line

        foreach (string line in lines)
            Console.WriteLine(line);

        Console.Read();
    }

}

