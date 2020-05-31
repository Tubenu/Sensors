using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Czujniki
    {
        public class Czujnik_temperatury_i_wiglotnosci : Sensor, ITemperature, IHumidity
        {
            public double value_temp;
            public double value_humidity;
            public string nameT;
            public Czujnik_temperatury_i_wiglotnosci(String nameA, double value1, double value2)
            {
                this.value_temp = value1;
                this.value_humidity = value2;
                this.nameT = nameA;

            }
            public double return_measurement_tmp
            {
                get
                {
                    return this.value_temp;

                }
                set
                {
                    this.value_temp = value;
                }

            }

            public double return_measurement_humidity
            {
                get
                {
                    return this.value_humidity;


                }
                set
                {
                    this.value_humidity = value;

                }

            }


            public void set_type()
            {
                String choose;
                Console.WriteLine("1.Konwersja na Fahrenheit\n 2. wyjscie");
                choose = Console.ReadLine();

                if (choose.Equals("1"))
                {

                    double final_tmp = this.value_temp * 9 / 5 + 32;
                    this.value_temp = final_tmp;
                    // Console.WriteLine(final_tmp);
                    Console.WriteLine("Ustwiles Fahrenheity");

                }
                else if (choose.Equals("2"))
                {
                    System.Environment.Exit(1);
                }
            }
        }

        public class Czujnik_cisnienia : Sensor, IPressure
        {
            public double valueP;
            public string nameP;

            public Czujnik_cisnienia(String name, double value)
            {
                this.nameP = name;
                this.valueP = value;

            }
            public double return_measurement_pressure
            {
                get
                {
                    return this.valueP;
                }
                set
                {
                    this.valueP = value;


                }

            }


        }
        public class Czujnik_temperatury : Sensor, ITemperature
        {
            public double valueT;
            public string nameT;
            public Czujnik_temperatury(String nameA, double value)
            {
                this.nameT = nameA;
                this.valueT = value;


            }

            public double return_measurement_tmp
            {
                get
                {
                    return this.valueT;
                }
                set
                {
                    this.valueT = value;


                }

            }

            public void set_type()
            {
                String choose;
                Console.WriteLine("1.Konwersja na Fahrenheit\n2. wyjscie");
                choose = Console.ReadLine();

                if (choose.Equals("1"))
                {

                    double final_tmp = this.valueT * 9 / 5 + 32;
                    this.valueT = final_tmp;
                    //Console.WriteLine(final_tmp);
                    Console.WriteLine("Ustwiles Fahrenheity");

                }
                else if (choose.Equals("2"))
                {
                    System.Environment.Exit(1);
                }
            }
        }

    }
}
