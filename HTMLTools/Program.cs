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

        Base b = new Base();
        b.HREF.Value = "https://www.google.co.uk";

        Style style = new Style();

        style.NestedElements.Add(new PlainText(".outlined\n{\noutline: solid black 2px;\n}"));

        Meta meta = new Meta();

        meta.CharSet.Value = "UTF-8";

        head.NestedElements.Add(meta);
        head.NestedElements.Add(link);
        head.NestedElements.Add(title);
        head.NestedElements.Add(style);
        head.NestedElements.Add(b);

        Navigation nav = new Navigation();

        Body body = new Body();

        Division div1 = new Division();
        div1.Class.Value = "outlined";

        Heading heading1 = new Heading(1), heading2 = new Heading(3);

        heading1.NestedElements.Add(new PlainText("This is a big heading."));

        heading1.ID.Value = "clickable-heading";
        heading1.OnMouseDown.Value = "make_green(this.id);";

        heading2.NestedElements.Add(new PlainText("This is a smaller heading."));

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

        div1.NestedElements.Add(heading2);
        div1.NestedElements.Add(paragraph1);
        div1.NestedElements.Add(paragraph2);
        div1.NestedElements.Add(hlink);

        Division div2 = new Division();

        Embed embed = new Embed();
        embed.Source.Value = "./best_clips.mp4";
        embed.Height.Value = "300px";
        embed.Width.Value = "300px";
        embed.Type.Value = "video/webm";

        Audio audio = new Audio("./audio.mp3");
        audio.Controls.Value = true;

        Video video = new Video("best_clips.mp4");
        video.Width.Value = "400";
        video.Width.Value = "400";
        video.Controls.Value = true;

        div2.NestedElements.Add(video);
        div2.NestedElements.Add(embed);
        div2.NestedElements.Add(audio);

        body.NestedElements.Add(heading1);
        body.NestedElements.Add(new HorizontalRule());
        body.NestedElements.Add(div1);
        body.NestedElements.Add(div2);

        Script script = new Script();

        NoScript noscript = new NoScript();

        noscript.NestedElements.Add(new PlainText("No javascript!"));

        string javascript = System.IO.File.ReadAllText("javascript_template.txt");

        script.NestedElements.Add(new PlainText(javascript));

        Main main = new Main();
        main.NestedElements.Add(body);

        document.NestedElements.Add(head);
        document.NestedElements.Add(nav);
        document.NestedElements.Add(main);
        document.NestedElements.Add(script);
        document.NestedElements.Add(noscript);

        document.ExportToFile("export.html");
    }
}

