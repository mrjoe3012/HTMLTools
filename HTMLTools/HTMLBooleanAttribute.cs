using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(A class representing an HTML attribute in which the value is either true or false. This value is shown simply by writing the name of the attribute within the tag.)
    public class HTMLBooleanAttribute : HTMLAttribute
    {
        private bool value = false;
        //@qdmfield(The value of the field)
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

        /*public HTMLBooleanAttribute(HTMLBooleanAttribute rhs) : base(rhs)
        {
            this.value = rhs.value;
        }*/

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
    //@qdend
}
