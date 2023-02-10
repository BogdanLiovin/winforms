using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public abstract class Unit : IBuild, IDelivery
    {
        public abstract string TypeUnit { get;}
        public delegate void UnitHandler(string message);
        public event UnitHandler Note;

        //метод для установки детали
        public void SetUnit()
        {
            Note?.Invoke("Set " + TypeUnit);
        }

        public void RemoveUnit()
        {
            Note?.Invoke("Remove " + TypeUnit);
        }
        //перегруженный метод для установки детали
        public void SetUnit(DateTime dateTime)
        {
            Note?.Invoke(String.Format("Set {0}, Date: {1}", TypeUnit, dateTime.ToShortDateString()));
        }

        public void RemoveUnit(DateTime dateTime)
        {
            Note?.Invoke(String.Format("Remove {0}, Date: {1}", TypeUnit, dateTime.ToShortDateString()));
        }

        //метод для отправки детали
        public void Send()
        {
            Note?.Invoke("Send " + TypeUnit);
        }
        //метод для прибытия детали
        public void Arrival()
        {
            Note?.Invoke("Arrival " + TypeUnit);
        }

        public override string ToString()
        {
            return TypeUnit;
        }
    }
}