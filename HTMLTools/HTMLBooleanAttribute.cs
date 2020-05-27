using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    public class HTMLBooleanAttribute : HTMLAttribute
    {
        private bool value = false;
        public bool Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public HTMLBooleanAttribute(string name) : base(name)
        {
        }

        public HTMLBooleanAttribute(string name, bool value) : base(name)
        {
            this.value = value;
        }

        public HTMLBooleanAttribute(HTMLBooleanAttribute rhs) : base(rhs)
        {
            this.value = rhs.value;
        }

        public override string GetLine()
        {
            return _getLine();
        }

        protected virtual string _getLine()
        {
            string line = "";

            if(this.value)
            {
                line = string.Format(" {0}", this.name);
            }

            return line;

        }
    }
}
