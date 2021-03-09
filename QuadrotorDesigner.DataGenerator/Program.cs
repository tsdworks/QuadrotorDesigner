using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrotorDesigner.Components;
using QuadrotorDesigner.Utils;
using QuadrotorDesigner.Utils.IOStream;
using QuadrotorDesigner.Utils.Notation;

namespace QuadrotorDesigner.DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelFileName;

            // Generator Battery
            modelFileName = Environment.CurrentDirectory + @"\Models\Battery\Demo-2800mAh-25C-4S.model";

            var batteryModel = new Model.Battery();
            batteryModel.Model = "2800mAh-25C-4S";
            batteryModel.Manufacturer = "Demo";
            batteryModel.DisplayName = "Demo Battery 2800mAh 25C 4S";
            batteryModel.TypicalVoltage = 14.8;
            batteryModel.CRating = 25;
            batteryModel.Capacity = 2800;
            batteryModel.Reliability = 80;
            batteryModel.UnitPrice = 25;
            batteryModel.Weight = 234;
            batteryModel.OutlineDimension = new Model.Dimension(106, 34, 32);

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(batteryModel, true));

            // Generator Body
            modelFileName = Environment.CurrentDirectory + @"\Models\Body\Demo-450.model";

            var bodyModel = new Model.Body();
            bodyModel.Model = "450";
            bodyModel.Manufacturer = "Demo";
            batteryModel.DisplayName = "Demo 450 Frame";
            bodyModel.RotorNumber = 4;
            bodyModel.MaxPropellerPitch = 318;
            bodyModel.OutlineDimension = new Model.Dimension(450, 450, 250);
            bodyModel.BottomAreaSpace = new Model.Dimension(100, 100, 180);
            bodyModel.CentralBoxDimension = new Model.Dimension(100, 100, 40);
            bodyModel.MaxLoadWeight = 500;
            bodyModel.Reliability = 90;
            bodyModel.UnitPrice = 50;
            bodyModel.Weight = 520;
            bodyModel.AdaptedMotorModels.Add("2212");

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(bodyModel, true));

            modelFileName = Environment.CurrentDirectory + @"\Models\Body\Demo-550.model";

            bodyModel = new Model.Body();
            bodyModel.Model = "550";
            bodyModel.Manufacturer = "Demo";
            batteryModel.DisplayName = "Demo 550 Frame";
            bodyModel.RotorNumber = 4;
            bodyModel.MaxPropellerPitch = 390;
            bodyModel.OutlineDimension = new Model.Dimension(550, 550, 300);
            bodyModel.BottomAreaSpace = new Model.Dimension(160, 160, 36);
            bodyModel.CentralBoxDimension = new Model.Dimension(160, 160, 36);
            bodyModel.MaxLoadWeight = 800;
            bodyModel.Reliability = 85;
            bodyModel.UnitPrice = 60;
            bodyModel.Weight = 630;
            bodyModel.AdaptedMotorModels.Add("3500");

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(bodyModel, true));

            // Flight Controller
            modelFileName = Environment.CurrentDirectory + @"\Models\FlightController\Demo-Pixhawk4.model";

            var controllerModel = new Model.FlightController();

            controllerModel.Model = "Pixhawk4";
            controllerModel.Manufacturer = "Demo";
            controllerModel.DisplayName = "Demo Pixhawk4";
            controllerModel.MCUFrequency = 216;
            controllerModel.IO = new Model.IONumber(16, 5, 3, 4, 0);
            controllerModel.Reliability = 90;
            controllerModel.UnitPrice = 100;
            controllerModel.Weight = 158;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(controllerModel, true));
        }
    }
}
