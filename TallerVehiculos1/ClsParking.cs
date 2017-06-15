using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos1
{
    class ClsParking
    {

        public static LinkedList<Car> cars = new LinkedList<Car>();


        public ClsParking()
        {

        }

        public bool add(Car car)
        {

            for (int i = 0; i < cars.Count; i++)
            {

                if (cars.ElementAt(i).Plaque.Equals(car.Plaque))
                {
                    return false;
                }

            }

            cars.AddLast(car);
            return true;

        }

        public Car search(String plaque)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars.ElementAt(i).Plaque.Equals(plaque))
                {
                    return cars.ElementAt(i);
                }


            }
            return null;
        }

        public bool edit(Car car)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars.ElementAt(i).Plaque.Equals(car.Plaque))
                {
                    cars.Remove(cars.ElementAt(i));
                    cars.AddLast(car);
                    return true;
                }
            }

            return false;

        }

        public bool remove(String plaque)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars.ElementAt(i).Plaque.Equals(plaque))
                {
                    cars.Remove(cars.ElementAt(i));
                    return true;
                }
            }
            return false;
        }


        public double calculatePrice (int hours)
        {
            return 500 * hours;
        }

    }
}
