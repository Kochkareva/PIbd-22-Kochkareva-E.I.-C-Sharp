using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Класс-ошибка "Если на базе уже есть военная техника с такими же характеристиками"
    /// </summary>
    public class BaseAlreadyHaveException : Exception
    {
        public BaseAlreadyHaveException() : base("На базе уже есть такая военная техника")
        { }
    }
}
