using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Класс-ошибка "Если на базе уже заняты все места"
    /// </summary>
    public class BaseOverflowException : Exception
    {
        public BaseOverflowException() : base("На базе нет свободных мест")
        { }
    }
}
