using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Класс-ошибка "Если не найдена военная техника по определенному месту"
    /// </summary>
    public class BaseNotFoundException : Exception
    {
        public BaseNotFoundException(int i) : base("Не найдена военная техника по месту "+ i)
        { }
    }
}
