using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // model type notation
        public enum ModelTypeList
        { Assembly = 0, Body = 1, Motor = 2, ESC = 3, Battery = 4, Propeller = 5, Device = 6, RC = 7, FlightController = 8, None = 9 };

        // common dimension notation
        public class Dimension
        {
            public double Length;
            public double Width;
            public double Height;

            public Dimension(double length = 0, double width = 0, double height = 0)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public Dimension() { }
        };

        // common voltage-performance curve notation
        public class VoltagePerformanceCurve
        {
            // curve in one voltage
            public class Curve
            {
                public double Voltage;
                public List<double> CurrentPoints;
                public List<double> ThrustPoints;
                public List<double> PowerPoints;
                public List<double> EfficiencyPoints;

                public Curve()
                {
                    Voltage = 0;
                    CurrentPoints = new List<double>();
                    ThrustPoints = new List<double>();
                    PowerPoints = new List<double>();
                    EfficiencyPoints = new List<double>();
                }
            }

            // curve by voltage as x
            public List<Curve> CurveByVoltage;

            public VoltagePerformanceCurve()
            {
                CurveByVoltage = new List<Curve>();
            }
        };

        // common io notation
        public class IONumber
        {
            public int GPIO;
            public int USART;
            public int SPI;
            public int I2C;
            public int Ethernet;

            public IONumber(int gpio = 0, int usart = 0, int spi = 0, int i2c = 0, int ethernet = 0)
            {
                GPIO = gpio;
                USART = usart;
                SPI = spi;
                I2C = i2c;
                Ethernet = ethernet;
            }
        };

        // component base class
        public class Base
        {
            public ModelTypeList ModelType;
            public string DisplayName;
            public string Manufacturer;
            public string Model;
            public double UnitPrice;
            public double Reliability;
            public Dimension OutlineDimension;
            public double Weight;
            public string PreviewImageFileName;

            public Base(ModelTypeList model_type = ModelTypeList.None, string display_name = "", string manufacturer = "", string model = "",
                double unit_price = 0, double reliability = 0, double length = 0, double width = 0,
                double height = 0, double weight = 0, string preview_image_filename = "")
            {
                ModelType = model_type;
                DisplayName = display_name;
                Manufacturer = manufacturer;
                Model = model;
                UnitPrice = unit_price;
                Reliability = reliability;

                OutlineDimension = new Dimension(length, width, height);

                Weight = weight;
                PreviewImageFileName = preview_image_filename;
            }

            public Base()
            {
                OutlineDimension = new Dimension(0, 0, 0);
            }
        };
    }
}
