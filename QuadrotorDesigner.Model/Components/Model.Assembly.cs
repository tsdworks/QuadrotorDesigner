using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        public class DroneDesignProject
        {
            public string Name;
            public string Author;
            public string Description;

            public int RotorNumber;
            public string MotorModel;
            public string PropellerModel;
            public string BodyModel;
            public List<string> DeviceModels;
            public string RCModel;
            public string BatteryModel;
            public string ESCModel;
            public string FlightControllerModel;

            public DroneDesignProject()
            {
                DeviceModels = new List<string>();
            }

            public DroneDesignProject(string name, string author, string description)
            {
                Name = name;
                Author = author;
                Description = description;
            }
        }

        public class DroneDesignBOM
        {
            public int RotorNumber;
            public Motor MotorModel;
            public Propeller PropellerModel;
            public Body BodyModel;
            public List<Device> DeviceModels;
            public Device RCModel;
            public Battery BatteryModel;
            public SpeedController ESCModel;
            public FlightController FlightControllerModel;

            public DroneDesignBOM()
            {
                DeviceModels = new List<Device>();
            }
        }

        public class DroneDesignResult
        {
            public class DroneDesignBOMItem
            {
                public ModelTypeList ModelType;
                public string Manufacturer;
                public string Model;
                public double Price;
                public int Quanlity;
                public double Reliability;
            }

            public class SummaryInfo
            {
                public string Name;
                public string Author;
                public string Description;
                public double Price;
            }
            
            public class DroneDimensionInfo
            {
                public double Weight;
                public Dimension OutlineDimension;

                public DroneDimensionInfo()
                {
                    OutlineDimension = new Dimension();
                }
            }

            public class PowerPerformanceInfo
            {
                public double MaxPower;
                public double TypicalPower;
                public double EnduranceTime;
            }

            public class DynamicPerformanceInfo
            {
                public double MaxThrust;
                public double ThrustWeightRatio;
                public VoltagePerformanceCurve VoltagePerformanceCurve;

                public DynamicPerformanceInfo()
                {
                    VoltagePerformanceCurve = new VoltagePerformanceCurve();
                }
            }

            public SummaryInfo Summary;
            public DroneDimensionInfo DroneDimension;
            public PowerPerformanceInfo PowerPerformance;
            public DynamicPerformanceInfo DynamicPerformance;
            public List<Device> Devices;
            public List<DroneDesignBOMItem> BOMList;

            public DroneDesignResult()
            {
                Summary = new SummaryInfo();
                DroneDimension = new DroneDimensionInfo();
                PowerPerformance = new PowerPerformanceInfo();
                DynamicPerformance = new DynamicPerformanceInfo();
                Devices = new List<Device>();
                BOMList = new List<DroneDesignBOMItem>();
            }
        }
    }
}
