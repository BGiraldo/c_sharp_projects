using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClsAuto
    {

        static LinkedList<Auto> listaVehiculos = new LinkedList<Auto>();


        public bool registrar(Auto auto)
        {
            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos.ElementAt(i).placa.Equals(auto.placa))
                {
                    return false;
                }
            }

            listaVehiculos.AddLast(auto);
            return true;
        }

        public Auto buscar(String placa)
        {

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos.ElementAt(i).placa.Equals(placa))
                {
                    return listaVehiculos.ElementAt(i);
                }
            }
            return null;
        }


        public bool editar(Auto auto)
        {

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos.ElementAt(i).placa.Equals(auto.placa))
                {
                    listaVehiculos.Remove(listaVehiculos.ElementAt(i));
                    listaVehiculos.AddLast(auto);
                    return true;
                }
            }
            return false;
        }

        public bool remove(String placa)
        {
            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos.ElementAt(i).placa.Equals(placa))
                {
                    listaVehiculos.Remove(listaVehiculos.ElementAt(i));
                    return true;
                }
            }
            return false;
        }


        public Auto next(String placa)
        {
            try
            {


                for (int i = 0; i < listaVehiculos.Count; i++)
                {
                    if (listaVehiculos.ElementAt(i).placa.Equals(placa))
                    {
                        if ((listaVehiculos.ElementAt(i + 1)) != null)
                        {
                            return listaVehiculos.ElementAt(i + 1);
                        }
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException exc)
            {
                return null;
            }
            return null;

        }

        public Auto before(String placa)
        {

            try
            {

                for (int i = 0; i < listaVehiculos.Count; i++)
                {
                    if (listaVehiculos.ElementAt(i).placa.Equals(placa))
                    {
                        if ((listaVehiculos.ElementAt(i - 1)) != null)
                        {
                            return listaVehiculos.ElementAt(i - 1);
                        }
                    }
                }

            }
            catch (System.ArgumentOutOfRangeException exc)
            {
                return null;
            }
            return null;
        }

        public Auto first()
        {
            return listaVehiculos.First();
        }

        public Auto last()
        {
            return listaVehiculos.Last();
        }

    }
}
