using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal interface IBuild
    {
        //метод для установки детали
        void SetUnit();
        //метод для снятия детали
        void RemoveUnit();
    }
}
