using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    public class HTMLFieldAttribute : HTMLAttribute
    {
        private string value;
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnValueChanged();
            }
        }

        public HTMLFieldAttribute(string name) : base(name)
        {
        }

        public HTMLFieldAttribute(string name, string value) : base(name)
        {
            this.value = value;
        }

        public HTMLFieldAttribute(HTMLFieldAttribute rhs) : base(rhs)
        {
            this.value = rhs.value;
        }

        protected override void Validate()
        {
            if(this.value.Contains("\""))
            {
                throw new InvalidValueException(this.value, '"');
            }
        }

        public override string GetLine()
        {
            return _getLine();
        }

        protected virtual string _getLine()
        {
            string line = "";

            if(!string.IsNullOrEmpty(value))
            {
                line = string.Format(" {0}=\"{1}\"", this.name, this.value);
            }

            return line;

        }

    }
}
