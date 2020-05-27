using System;
using HTMLTools;

class Program
{
    static void Main(string[] args)
    {

        HTMLDocument document = new HTMLDocument();

        Comment comment = new Comment("This\n is\n a\n comment");
        document.NestedElements.Add(comment);

        Head head = new Head();

        Link link = new Link();

        link.Rel.Value = "stylesheet";
        link.HREF.Value = "../static/styles.css";
        link.Type.Value = "text/css";

        Title title = new Title();

        PlainText text = new PlainText();
        text.text = "This is a title.\ntitle";

        title.NestedElements.Add(text);

        Style style = new Style();

        style.NestedElements.Add(new PlainText(".outlined\n{\noutline: solid black 2px;\n}"));

        head.NestedElements.Add(link);
        head.NestedElements.Add(title);
        head.NestedElements.Add(style);

        Body body = new Body();

        Divider div1 = new Divider();
        div1.Class.Value = "outlined";

        Paragraph paragraph1 = new Paragraph();
        PlainText plainText = new PlainText("This is a normal paragraph!");

        paragraph1.NestedElements.Add(plainText);

        Paragraph paragraph2 = new Paragraph();
        paragraph2.NestedElements.Add(new PlainText("This is a red paragraph!"));
        paragraph2.NestedElements.Add(new LineBreak());
        paragraph2.NestedElements.Add(new PlainText("Pretty cool huh?"));
        paragraph2.Style.Value = "color: red";

        HyperLink hlink = new HyperLink("https://www.google.co.uk");
        hlink.Target.Value = "_blank";
        hlink.NestedElements.Add(new PlainText("This is a link"));

        div1.NestedElements.Add(paragraph1);
        div1.NestedElements.Add(paragraph2);
        div1.NestedElements.Add(hlink);

        body.NestedElements.Add(div1);

        document.NestedElements.Add(head);
        document.NestedElements.Add(body);

        document.ExportToFile("export.html");
    }
}

