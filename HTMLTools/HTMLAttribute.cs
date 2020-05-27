using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    public abstract class HTMLAttribute : IStringLineConvertable
    {
        public readonly string name;

        public abstract string GetLine();

        public HTMLAttribute(string name)
        {
            this.name = name;
        }

        public HTMLAttribute(HTMLAttribute rhs)
        {
            this.name = rhs.name;
        }

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
}
