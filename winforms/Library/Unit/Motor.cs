using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Motor : Unit
    {
        public string FuelType;
        public decimal FuelVolume;
        public decimal MaxFuelVolume;

        //переопределение
        public override string TypeUnit
        {
            get => "Мотор";
        }
        public Motor(string fuel, decimal fuelVolume, decimal maxFuelVolume)
        {
            FuelType = fuel;
            FuelVolume = fuelVolume;
            MaxFuelVolume = maxFuelVolume;
        }

        public Motor()
        {
        }

        //переопредление метода
        public override string ToString()
        {
            return 
                String.Format(
                    "Тип топлива: {0}\n" +
                    "Макс. объем топлива: {1}\n" +
                    "Объем топлива: {2}\n",
                    FuelType,
                    MaxFuelVolume,
                    FuelVolume
                );
        }

        public void Refill(decimal volume, string fuelType)
        {
            //если тип топлива совпадает
            if (FuelType == fuelType)
            {
                //прибавляем
                FuelVolume += volume;
                if (FuelVolume > MaxFuelVolume)
                {
                    //если заполнили
                    FuelVolume = MaxFuelVolume;
                }
            }
        }
    }
}
