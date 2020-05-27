using System.Collections.Generic;
using System.Reflection;

namespace HTMLTools
{
    public static class HTMLTools
    {
        public const string VERSION = "1.0";

        public static void InitGlobalAttributes(ref IGlobalAttributes attributes)
        {
            attributes.AccessKey = new HTMLFieldAttribute("accesskey");
            attributes.Class = new HTMLFieldAttribute("class");
            attributes.ContentEditable = new HTMLFieldAttribute("contenteditable");
            attributes.Dir = new HTMLFieldAttribute("dir");
            attributes.Draggable = new HTMLFieldAttribute("draggable");
            attributes.DropZone = new HTMLFieldAttribute("dropzone");
            attributes.Hidden = new HTMLBooleanAttribute("hidden");
            attributes.ID = new HTMLFieldAttribute("id");
            attributes.Lang = new HTMLFieldAttribute("lang");
            attributes.SpellCheck = new HTMLFieldAttribute("spellcheck");
            attributes.Style = new HTMLFieldAttribute("style");
            attributes.TabIndex = new HTMLFieldAttribute("tabindex");
            attributes.Title = new HTMLFieldAttribute("title");
            attributes.Translate = new HTMLFieldAttribute("translate");

       }

        public static void InitEventAttributes(ref IEventAttributes attributes)
        {
            attributes.OnAbort = new HTMLFieldAttribute("onabort");
            attributes.OnAfterPrint = new HTMLFieldAttribute("onafterprint");
            attributes.OnBeforePrint = new HTMLFieldAttribute("onbeforeprint");
            attributes.OnBeforeUnload = new HTMLFieldAttribute("onbeforeunload");
            attributes.OnBlur = new HTMLFieldAttribute("onblur");
            attributes.OnCanPlay = new HTMLFieldAttribute("oncanplay");
            attributes.OnCanPlayThrough = new HTMLFieldAttribute("oncanplaythrough");
            attributes.OnChange = new HTMLFieldAttribute("onchange");
            attributes.OnClick = new HTMLFieldAttribute("onclick");
            attributes.OnContextMenu = new HTMLFieldAttribute("oncontextmenu");
            attributes.OnCopy = new HTMLFieldAttribute("oncopy");
            attributes.OnCueChange = new HTMLFieldAttribute("oncuechange");
            attributes.OnCut = new HTMLFieldAttribute("oncut");
            attributes.OnDblClick = new HTMLFieldAttribute("ondblclick");
            attributes.OnDrag = new HTMLFieldAttribute("ondrag");
            attributes.OnDragEnd = new HTMLFieldAttribute("ondragend");
            attributes.OnDragEnter = new HTMLFieldAttribute("ondragenter");
            attributes.OnDragLeave = new HTMLFieldAttribute("ondragleave");
            attributes.OnDragOver = new HTMLFieldAttribute("ondragover");
            attributes.OnDragStart = new HTMLFieldAttribute("ondragstart");
            attributes.OnDrop = new HTMLFieldAttribute("ondrop");
            attributes.OnDurationChange = new HTMLFieldAttribute("ondurationchange");
            attributes.OnEmptied = new HTMLFieldAttribute("onemptied");
            attributes.OnEnded = new HTMLFieldAttribute("onended");
            attributes.OnError = new HTMLFieldAttribute("onerror");
            attributes.OnFocus = new HTMLFieldAttribute("onfocus");
            attributes.OnHashChange = new HTMLFieldAttribute("onhashchange");
            attributes.OnInput = new HTMLFieldAttribute("oninput");
            attributes.OnInvalid = new HTMLFieldAttribute("oninvalid");
            attributes.OnKeyDown = new HTMLFieldAttribute("onkeydown");
            attributes.OnKeyPress = new HTMLFieldAttribute("onkeypress");
            attributes.OnKeyUp = new HTMLFieldAttribute("onkeyup");
            attributes.OnLoad = new HTMLFieldAttribute("onload");
            attributes.OnLoadedData = new HTMLFieldAttribute("onloadeddata");
            attributes.OnLoadedMetadata = new HTMLFieldAttribute("onloadedmetadata");
            attributes.OnLoadStart = new HTMLFieldAttribute("onloadstart");
            attributes.OnMessage = new HTMLFieldAttribute("onmessage");
            attributes.OnMouseDown = new HTMLFieldAttribute("onmousedown");
            attributes.OnMouseMove = new HTMLFieldAttribute("onmousemove");
            attributes.OnMouseOut = new HTMLFieldAttribute("onmouseout");
            attributes.OnMouseOver = new HTMLFieldAttribute("onmouseover");
            attributes.OnMouseUp = new HTMLFieldAttribute("onmouseup");
            attributes.OnMouseWheel = new HTMLFieldAttribute("onmousewheel");
            attributes.OnOffline = new HTMLFieldAttribute("onoffline");
            attributes.OnOnline = new HTMLFieldAttribute("ononline");
            attributes.OnPageHide = new HTMLFieldAttribute("onpagehide");
            attributes.OnPageShow = new HTMLFieldAttribute("onpageshow");
            attributes.OnPaste = new HTMLFieldAttribute("onpaste");
            attributes.OnPause = new HTMLFieldAttribute("onpause");
            attributes.OnPlay = new HTMLFieldAttribute("onplay");
            attributes.OnPlaying = new HTMLFieldAttribute("onplaying");
            attributes.OnPopState = new HTMLFieldAttribute("onpopstate");
            attributes.OnProgress = new HTMLFieldAttribute("onprogress");
            attributes.OnRateChange = new HTMLFieldAttribute("onratechange");
            attributes.OnReset = new HTMLFieldAttribute("onreset");
            attributes.OnResize = new HTMLFieldAttribute("onresize");
            attributes.OnScroll = new HTMLFieldAttribute("onscroll");
            attributes.OnSearch = new HTMLFieldAttribute("onsearch");
            attributes.OnSeeked = new HTMLFieldAttribute("onseeked");
            attributes.OnSeeking = new HTMLFieldAttribute("onseeking");
            attributes.OnSelect = new HTMLFieldAttribute("onselect");
            attributes.OnStalled = new HTMLFieldAttribute("onstalled");
            attributes.OnStorage = new HTMLFieldAttribute("onstorage");
            attributes.OnSubmit = new HTMLFieldAttribute("onsubmit");
            attributes.OnSuspend = new HTMLFieldAttribute("onsuspend");
            attributes.OnTimeUpdate = new HTMLFieldAttribute("ontimeupdate");
            attributes.OnToggle = new HTMLFieldAttribute("ontoggle");
            attributes.OnUnload = new HTMLFieldAttribute("onunload");
            attributes.OnVolumeChange = new HTMLFieldAttribute("onvolumechange");
            attributes.OnWaiting = new HTMLFieldAttribute("onwaiting");
            attributes.OnWheel = new HTMLFieldAttribute("onwheel");
        }

        public static List<HTMLAttribute> GetAttributes(HTMLElement e)
        {
            PropertyInfo[] propertyInfos = e.GetType().GetProperties();
            List<HTMLAttribute> attributes = new List<HTMLAttribute>();

            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                object value = propertyInfo.GetValue(e);

                if(value != null && typeof(HTMLAttribute).IsAssignableFrom(value.GetType()))
                {
                    attributes.Add((HTMLAttribute)value);
                }

            }

            return attributes;

        }

        public static List<string> GetNestedLines(HTMLElement element)
        {
            List<string> lines = new List<string>();

            if (typeof(INest).IsAssignableFrom(element.GetType()))
            {
                INest nest = (INest)element;

                foreach (HTMLElement nestedElement in nest.NestedElements)
                {
                    lines = lines.Add(nestedElement.GetLines());
                }
                lines.Add(string.Format("</{0}>", element.name));
            }
            return lines;
        }

        public static string GetNestedLine(HTMLElement element)
        {
            string line = "";
            if (typeof(INest).IsAssignableFrom(element.GetType()))
            {
                INest nest = (INest)element;

                foreach (HTMLElement nestedElement in nest.NestedElements)
                {
                    line += nestedElement.GetLine();
                }
                line += string.Format("</{0}>", element.name);
            }
            return line;
        }

    }
}
