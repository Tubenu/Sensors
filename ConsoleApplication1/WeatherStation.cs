using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    public class WeatherStation : Czujniki
    {

        public List<Sensor> Sensors = new List<Sensor>();


        public void add_sensor(Sensor a)
        {
            Sensors.Add(a);
        }



        public void TempValue()
        {
            foreach (Sensor a in Sensors)
                if (a is Czujnik_temperatury)
                {
                    Czujnik_temperatury T = a as Czujnik_temperatury;
                    Console.WriteLine(T.valueT);
                }
        }
        public void PressureValue()
        {
            foreach (Sensor a in Sensors)
                if (a is Czujnik_cisnienia)
                {
                    Czujnik_cisnienia P = a as Czujnik_cisnienia;
                    Console.WriteLine(P.valueP);
                }
        }
        public void TempHumidityValue()
        {

            foreach (Sensor a in Sensors)
                if (a is Czujnik_temperatury_i_wiglotnosci)
                {
                    Czujnik_temperatury_i_wiglotnosci TH = a as Czujnik_temperatury_i_wiglotnosci;
                    Console.WriteLine(TH.value_temp + TH.value_humidity);
                }

        }
        public void save_JSON()
        {
            var list = new List<string>();
            foreach (Sensor a in Sensors)
            {
                if (a is Czujnik_temperatury)
                {
                    Czujnik_temperatury T = a as Czujnik_temperatury;
                    list.Add(T.valueT.ToString());
                }
                else if (a is Czujnik_cisnienia)
                {
                    Czujnik_cisnienia P = a as Czujnik_cisnienia;
                    list.Add(P.valueP.ToString());
                }
                else if (a is Czujnik_temperatury_i_wiglotnosci)
                {
                    Czujnik_temperatury_i_wiglotnosci TH = a as Czujnik_temperatury_i_wiglotnosci;
                    list.Add(TH.value_humidity.ToString());
                    list.Add(TH.value_temp.ToString());
                }
        
            }
            File.AppendAllText(@"C:\Users\Adam\Desktop\test.json", JsonConvert.SerializeObject(list, Formatting.Indented));

        }

        public void Timer()
        {

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(30);

            var timer = new System.Threading.Timer((e) =>
            {
                save_JSON();

            }, null, startTimeSpan, periodTimeSpan);
        }
        /*
                public void Get_specific_temp(double value)
                {
                    foreach (Sensor Sensor in (Sensors.FindAll(e => (e.valueT < value)).Take(2).ToList())
                    {
                        Console.WriteLine("Temperatura " + Sensor.valueT);
                    }

                }

                public void Get_specific_pressure(double value)
                {
                    foreach (Sensor Sensor in Sensors.FindAll(e => (e.valueP < value)).Take(2).ToList())
                    {
                        Console.WriteLine("Cisnienie " + Sensor.valueP);
                    }

                }

                public void Get_specific_humidity_and_temperature(double value)
                {
                    foreach (Czujnik_temperatury_i_wiglotnosci Sensor in Sensors.FindAll(e => (e.value_humidity < value)).Take(2).ToList())
                    {
                        Console.WriteLine("Wiglotnosc " + Sensor.value_humidity);
                    }
                    foreach (Czujnik_temperatury_i_wiglotnosci Sensor in Sensors.FindAll(e => (e.value_temp < value)).Take(2).ToList())
                    {
                        Console.WriteLine("Temperatura " + Sensor.value_temp);
                    }
                }
                */
    }

}