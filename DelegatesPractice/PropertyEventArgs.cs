using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class PropertyEventArgs
    {
        public string NameChanged { get; set; }

        public PropertyEventArgs(string text)
        {
            NameChanged = text;
        }

    }
}
