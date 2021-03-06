﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(<a target="_blank" href="https://www.w3schools.com/tags/tag_input.asp">Input</a>)
    public class Input : HTMLElement, IGlobalAttributes, IEventAttributes
    {
        public HTMLFieldAttribute ID { get; set; }
        public HTMLFieldAttribute Class { get; set; }
        public HTMLFieldAttribute Style { get; set; }
        public HTMLFieldAttribute AccessKey { get; set; }
        public HTMLFieldAttribute ContentEditable { get; set; }
        public HTMLFieldAttribute Dir { get; set; }
        public HTMLFieldAttribute Draggable { get; set; }
        public HTMLFieldAttribute DropZone { get; set; }
        public HTMLFieldAttribute Lang { get; set; }
        public HTMLFieldAttribute SpellCheck { get; set; }
        public HTMLFieldAttribute TabIndex { get; set; }
        public HTMLFieldAttribute Title { get; set; }
        public HTMLFieldAttribute Translate { get; set; }
        public HTMLBooleanAttribute Hidden { get; set; }
        public HTMLFieldAttribute OnAfterPrint { get; set; }
        public HTMLFieldAttribute OnBeforePrint { get; set; }
        public HTMLFieldAttribute OnBeforeUnload { get; set; }
        public HTMLFieldAttribute OnError { get; set; }
        public HTMLFieldAttribute OnHashChange { get; set; }
        public HTMLFieldAttribute OnLoad { get; set; }
        public HTMLFieldAttribute OnMessage { get; set; }
        public HTMLFieldAttribute OnOffline { get; set; }
        public HTMLFieldAttribute OnOnline { get; set; }
        public HTMLFieldAttribute OnPageHide { get; set; }
        public HTMLFieldAttribute OnPageShow { get; set; }
        public HTMLFieldAttribute OnPopState { get; set; }
        public HTMLFieldAttribute OnResize { get; set; }
        public HTMLFieldAttribute OnStorage { get; set; }
        public HTMLFieldAttribute OnUnload { get; set; }
        public HTMLFieldAttribute OnBlur { get; set; }
        public HTMLFieldAttribute OnChange { get; set; }
        public HTMLFieldAttribute OnContextMenu { get; set; }
        public HTMLFieldAttribute OnFocus { get; set; }
        public HTMLFieldAttribute OnInput { get; set; }
        public HTMLFieldAttribute OnInvalid { get; set; }
        public HTMLFieldAttribute OnReset { get; set; }
        public HTMLFieldAttribute OnSearch { get; set; }
        public HTMLFieldAttribute OnSelect { get; set; }
        public HTMLFieldAttribute OnSubmit { get; set; }
        public HTMLFieldAttribute OnKeyDown { get; set; }
        public HTMLFieldAttribute OnKeyPress { get; set; }
        public HTMLFieldAttribute OnKeyUp { get; set; }
        public HTMLFieldAttribute OnClick { get; set; }
        public HTMLFieldAttribute OnDblClick { get; set; }
        public HTMLFieldAttribute OnMouseDown { get; set; }
        public HTMLFieldAttribute OnMouseMove { get; set; }
        public HTMLFieldAttribute OnMouseOut { get; set; }
        public HTMLFieldAttribute OnMouseOver { get; set; }
        public HTMLFieldAttribute OnMouseUp { get; set; }
        public HTMLFieldAttribute OnMouseWheel { get; set; }
        public HTMLFieldAttribute OnWheel { get; set; }
        public HTMLFieldAttribute OnDrag { get; set; }
        public HTMLFieldAttribute OnDragEnd { get; set; }
        public HTMLFieldAttribute OnDragEnter { get; set; }
        public HTMLFieldAttribute OnDragLeave { get; set; }
        public HTMLFieldAttribute OnDragOver { get; set; }
        public HTMLFieldAttribute OnDragStart { get; set; }
        public HTMLFieldAttribute OnDrop { get; set; }
        public HTMLFieldAttribute OnScroll { get; set; }
        public HTMLFieldAttribute OnCopy { get; set; }
        public HTMLFieldAttribute OnCut { get; set; }
        public HTMLFieldAttribute OnPaste { get; set; }
        public HTMLFieldAttribute OnAbort { get; set; }
        public HTMLFieldAttribute OnCanPlay { get; set; }
        public HTMLFieldAttribute OnCanPlayThrough { get; set; }
        public HTMLFieldAttribute OnCueChange { get; set; }
        public HTMLFieldAttribute OnDurationChange { get; set; }
        public HTMLFieldAttribute OnEmptied { get; set; }
        public HTMLFieldAttribute OnEnded { get; set; }
        public HTMLFieldAttribute OnLoadedData { get; set; }
        public HTMLFieldAttribute OnLoadedMetadata { get; set; }
        public HTMLFieldAttribute OnLoadStart { get; set; }
        public HTMLFieldAttribute OnPause { get; set; }
        public HTMLFieldAttribute OnPlay { get; set; }
        public HTMLFieldAttribute OnPlaying { get; set; }
        public HTMLFieldAttribute OnProgress { get; set; }
        public HTMLFieldAttribute OnRateChange { get; set; }
        public HTMLFieldAttribute OnSeeked { get; set; }
        public HTMLFieldAttribute OnSeeking { get; set; }
        public HTMLFieldAttribute OnStalled { get; set; }
        public HTMLFieldAttribute OnSuspend { get; set; }
        public HTMLFieldAttribute OnTimeUpdate { get; set; }
        public HTMLFieldAttribute OnVolumeChange { get; set; }
        public HTMLFieldAttribute OnWaiting { get; set; }
        public HTMLFieldAttribute OnToggle { get; set; }

        public HTMLFieldAttribute Accept { get; set; }
        public HTMLFieldAttribute Alt { get; set; }
        public HTMLFieldAttribute AutoComplete { get; set; }
        public HTMLBooleanAttribute AutoFocus { get; set; }
        public HTMLBooleanAttribute Checked { get; set; }
        public HTMLFieldAttribute DirName { get; set; }
        public HTMLBooleanAttribute Disabled { get; set; }
        public HTMLFieldAttribute FormID { get; set; }
        public HTMLFieldAttribute FormAction { get; set; }
        public HTMLFieldAttribute FormEncType { get; set; }
        public HTMLFieldAttribute FormMethod { get; set; }
        public HTMLFieldAttribute FormNoValidate { get; set; }
        public HTMLFieldAttribute FormTarget { get; set; }
        public HTMLFieldAttribute Height { get; set; }
        public HTMLFieldAttribute List { get; set; }
        public HTMLFieldAttribute Max { get; set; }
        public HTMLFieldAttribute MaxLength { get; set; }
        public HTMLFieldAttribute Min { get; set; }
        public HTMLFieldAttribute MinLength { get; set; }
        public HTMLBooleanAttribute Multiple { get; set; }
        public HTMLFieldAttribute Name { get; set; }
        public HTMLFieldAttribute Text { get; set; }
        public HTMLFieldAttribute Pattern { get; set; }
        public HTMLFieldAttribute PlaceHolder { get; set; }
        public HTMLBooleanAttribute Readonly { get; set; }
        public HTMLBooleanAttribute Required { get; set; }
        public HTMLFieldAttribute Size { get; set; }
        public HTMLFieldAttribute Source { get; set; }
        public HTMLFieldAttribute Step { get; set; }
        public HTMLFieldAttribute Type { get; set; }
        public HTMLFieldAttribute Value { get; set; }
        public HTMLFieldAttribute Width { get; set; }

        public Input() : base("input")
        {
            Accept = new HTMLFieldAttribute("accept");
            Alt = new HTMLFieldAttribute("alt");
            AutoComplete = new HTMLFieldAttribute("autocomplete");
            AutoFocus = new HTMLBooleanAttribute("autofocus");
            Checked = new HTMLBooleanAttribute("checked");
            DirName = new HTMLFieldAttribute("dirname");
            Disabled = new HTMLBooleanAttribute("disabled");
            FormID = new HTMLFieldAttribute("form");
            FormAction = new HTMLFieldAttribute("formaction");
            FormEncType = new HTMLFieldAttribute("formenctype");
            FormMethod = new HTMLFieldAttribute("formmethod");
            FormNoValidate = new HTMLFieldAttribute("formnovalidate");
            FormTarget = new HTMLFieldAttribute("formtarget");
            Height = new HTMLFieldAttribute("height");
            List = new HTMLFieldAttribute("list");
            Max = new HTMLFieldAttribute("max");
            MaxLength = new HTMLFieldAttribute("maxlength");
            Min = new HTMLFieldAttribute("min");
            MinLength = new HTMLFieldAttribute("minlength");
            Multiple = new HTMLBooleanAttribute("multiple");
            Name = new HTMLFieldAttribute("name");
            Pattern = new HTMLFieldAttribute("pattern");
            PlaceHolder = new HTMLFieldAttribute("placeholder");
            Readonly = new HTMLBooleanAttribute("readonly");
            Required = new HTMLBooleanAttribute("required");
            Size = new HTMLFieldAttribute("size");
            Source = new HTMLFieldAttribute("src");
            Step = new HTMLFieldAttribute("step");
            Type = new HTMLFieldAttribute("type");
            Value = new HTMLFieldAttribute("value");
            Width = new HTMLFieldAttribute("width");

            InitAttributes();

        }

    }
    //@qdend
}
