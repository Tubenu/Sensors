using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{

    public class Sensor
    {

        static int counter = 0;
        public string name;

        public Sensor()
        {
            this.name = "Sensor" + counter;
            counter++;
        }
        public Sensor(String name)
        {


            if (name.Length <= 16)
            {

                this.name = name;



            }

            else
            {
                this.name = name.Substring(0, 16);


            }


        }

        class Program
        {

            static void Main(string[] args)
            {
                string mystring;

                Czujniki.Czujnik_cisnienia dupa = new Czujniki.Czujnik_cisnienia("Maciek", 23);
                Czujniki.Czujnik_cisnienia dupa1 = new Czujniki.Czujnik_cisnienia("Maciek", 45);
                Czujniki.Czujnik_temperatury temp = new Czujniki.Czujnik_temperatury("Adam", 3);
                Czujniki.Czujnik_temperatury_i_wiglotnosci wysoka_baba = new Czujniki.Czujnik_temperatury_i_wiglotnosci("Adrjan", 20, 30);
                Czujniki.Czujnik_temperatury_i_wiglotnosci fabijanska = new Czujniki.Czujnik_temperatury_i_wiglotnosci("Adrjan", 20, 15);
                Czujniki.Czujnik_cisnienia gowno = new Czujniki.Czujnik_cisnienia("Gowno", 100);
                WeatherStation stacja = new WeatherStation();
                
                stacja.add_sensor(temp);
                stacja.add_sensor(dupa);
                stacja.add_sensor(dupa1);
                stacja.add_sensor(wysoka_baba);
                stacja.add_sensor(fabijanska);
                stacja.add_sensor(gowno);
                stacja.Timer();
                Console.WriteLine("Podaj dla jakiego czujnika chcesz pozyskac wartosci.\n1 - temperatura\n2 - cisnienie\n3 - Temperatura oraz wilgotnosc\n4 - Wyswietl wartosci Sensora wilgotnosci i temperatury pasujace do kryterium\n5 - Wyswietl wartosci Sensora temperatury pasujace do kryterium\n6 - Wyswietl wartosci Sensora cisnienia pasujace do kryterium\nx - wyjscie z aplikacji");
                mystring = Console.ReadLine();
                while (mystring != "x")
                {
                    switch (mystring)
                    {
                        case "1":
                            stacja.TempValue();
                            
                            break;
                        case "2":
                            stacja.PressureValue();
                            break;
                        case "3":
                            stacja.TempHumidityValue();
                            break;
                        case "x":
                            System.Environment.Exit(1);
                            break;
                        case "4":
                            string test1;
                            Console.WriteLine("Podaj wartosc kryterium");
                            test1 = Console.ReadLine();
                          //  stacja.Get_specific_humidity_and_temperature(Double.Parse(test1));
                            break;
                        case "5":
                            string test2;
                            Console.WriteLine("Podaj wartosc kryterium");
                            test2 = Console.ReadLine();
                           // stacja.Get_specific_temp(Double.Parse(test2));
                            break;
                        case "6":
                            string test3;
                            Console.WriteLine("Podaj wartosc kryterium");
                            test3 = Console.ReadLine();
                          //  stacja.Get_specific_pressure(Double.Parse(test3));
                            break;

                    }
                    Console.WriteLine("Podaj dla jakiego czujnika chcesz pozyskac wartosci.\n1 - temperatura\n2 - cisnienie\n3 - Temperatura oraz wilgotnosc\n4 - Wyswietl wartosci Sensora wilgotnosci i temperatury pasujace do kryterium\n5 - Wyswietl wartosci Sensora temperatury pasujace do kryterium\n6 - Wyswietl wartosci Sensora cisnienia pasujace do kryterium\nx - wyjscie z aplikacji");
                    mystring = Console.ReadLine();

                }

            }

        }
    }
}
