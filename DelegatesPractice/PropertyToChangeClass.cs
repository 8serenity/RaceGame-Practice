using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class PropertyToChangeClass : IPropertyChanged
    {
        private int number;
        public int NumberInClass
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyEventArgs("NumberInClass"));
                }
            }

        }


        public event PropertyEventHandler PropertyChanged;
    }
}
