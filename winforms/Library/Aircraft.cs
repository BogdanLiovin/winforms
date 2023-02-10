using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class Aircraft
    {
        public string Title { get; set; }

        //композиция
        public Motor Motor { get; set; }
        public Wing Wing { get; set; }
        public Chassis Chassis { get; set; }

        //ассоциация, у самолета может и не быть аэропорта, а может быть
        public Route Route;

        //агрегация 
        public Factory Factory { get; set; }

        public int Number { get; set; }
        public byte QuantityOfSeats { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Aircraft(Factory factory, string fuelType, decimal wingSpan, string title, int number, byte quantityOfSeats, DateTime releaseDate)
        {
            Title = title;

            //композиция, детали создаются вместе с самолетом
            Motor = new Motor(fuelType, 100, 1000);
            Wing = new Wing(wingSpan);
            Chassis = new Chassis(6);

            //агрегация, потому что фабрика это внешний объект, который мы указываем, они равноправны
            Factory = factory;

            Number = number;
            QuantityOfSeats = quantityOfSeats;
            ReleaseDate = releaseDate;

            Motor.Note += DisplayMessage;
            Wing.Note += DisplayMessage;
            Chassis.Note += DisplayMessage;
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
        public new string ToString()
        {
            return String.Format(
                "Самолет с номером {0}.\n" +
                "Название самолета: {1} \n" +
                "Количество посадочных мест: {2} \n" +
                "Дата выпуска: {3} \n" +
                "Мотор: {4} \n" +
                "Шасси: {5} \n" +
                "Крыло: {6} \n",
                Number,
                Title,
                QuantityOfSeats,
                ReleaseDate.ToShortDateString(),
                Motor.ToString(),
                Chassis.ToString(),
                Wing.ToString()
                );
        }

        //перегруженные методы
        public void Build()
        {
            Motor.SetUnit();
            Wing.SetUnit();
            Chassis.SetUnit();
        }

        public void Build(DateTime date)
        {
            Motor.SetUnit(date);
            Wing.SetUnit(date);
            Chassis.SetUnit(date);
        }

        public void Refill(decimal volume, string fuelType)
        {
            Motor.Refill(volume, fuelType);
        }
    }
}
