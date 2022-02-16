using System;
using System.Collections.Generic;
using System.Text;

namespace NetEscapades.EnumGenerators
{
    public class EnumCodeAttribute : System.Attribute
    {
        public EnumCodeAttribute(string code)
        {
            Code = code;
        }

        public string Code { get; }
    }
}
