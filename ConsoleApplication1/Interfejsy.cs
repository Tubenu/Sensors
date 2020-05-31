using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    interface ITemperature
    {

        double return_measurement_tmp
        {
            get;
            set;

        }
        void set_type();


    }

    interface IHumidity
    {

        double return_measurement_humidity
        {
            get;
            set;

        }

    }

    interface IPressure
    {
        double return_measurement_pressure
        {
            get;
            set;

        }


    }
}
