using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    /*Создать интерфейс, который уведомляет пользователя программы 
     * об изменении значений свойства в классе (в котором реализуется данный интерфейс). Сигнатура интерфейса:

        interface iPropertychanged
            {
            event PropertyeventHandler Propertychanged;
            }
    Делегат имеет следующий вид:
    public delegate void PropertyeventHandler
    (object sender, PropertyeventArgs e);
    где, в качестве дополнительного параметра (Property­EventArgs) выступает имя
    изменённого свойства. В методе Main() проверить работоспособность созданного интерфейса.
*/
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            PropertyToChangeClass newClass = new PropertyToChangeClass();
            newClass.PropertyChanged += ShowMessage;
            newClass.NumberInClass = 35;
            Console.Read();
        }

        public static void ShowMessage(object sender, PropertyEventArgs e)
        {
            Console.WriteLine("You have changed {0}", e.NameChanged);
        }

    }
}
