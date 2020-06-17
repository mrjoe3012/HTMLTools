using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(A base class for all attributes within a HTML tag.)
    public abstract class HTMLAttribute : IStringLineConvertable
    {
        //@qdmfield(The name of the attribute as seen in HTML syntax)
        public readonly string name;

        public abstract string GetLine();
        //@qdmfunction(The Constructor*Constructor)
        //@qdparam(name*The name of the attribute as seen in HTML syntax*string)
        public HTMLAttribute(string name)
        {
            this.name = name;
        }

        /*public HTMLAttribute(HTMLAttribute rhs)
        {
            this.name = rhs.name;
        }*/

        protected void OnValueChanged()
        {
            Validate();
        }

        protected virtual void Validate() {}

        [Serializable]
        protected class InvalidValueException : Exception
        {
            public InvalidValueException(string value, char illegalChar) : base(string.Format(" The value '{0}' is not a valid value. Value cannot contain {1} ", value, illegalChar))
            {
            }
        }

    }
    //@qdend
}
