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

            // Battery
            modelFileName = Environment.CurrentDirectory + @"\Models\Battery\Demo-2800mAh-25C-4S-14.8.model";

            var batteryModel = new Model.Battery();
            batteryModel.Model = "2800mAh-25C-4S-14.8";
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

            // Body
            modelFileName = Environment.CurrentDirectory + @"\Models\Body\Demo-450.model";

            var bodyModel = new Model.Body();
            bodyModel.Model = "450";
            bodyModel.Manufacturer = "Demo";
            bodyModel.DisplayName = "Demo 450 Frame";
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
            bodyModel.DisplayName = "Demo 550 Frame";
            bodyModel.RotorNumber = 6;
            bodyModel.MaxPropellerPitch = 390;
            bodyModel.OutlineDimension = new Model.Dimension(550, 550, 300);
            bodyModel.BottomAreaSpace = new Model.Dimension(160, 160, 36);
            bodyModel.CentralBoxDimension = new Model.Dimension(160, 160, 36);
            bodyModel.MaxLoadWeight = 800;
            bodyModel.Reliability = 85;
            bodyModel.UnitPrice = 60;
            bodyModel.Weight = 630;
            bodyModel.AdaptedMotorModels.Add("3508");
            bodyModel.AdaptedMotorModels.Add("4208");

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(bodyModel, true));

            // Flight Controller
            modelFileName = Environment.CurrentDirectory + @"\Models\FlightController\Demo-Pixhawk4.model";

            var controllerModel = new Model.FlightController();

            controllerModel.Model = "Pixhawk4";
            controllerModel.Manufacturer = "Demo";
            controllerModel.DisplayName = "Demo Pixhawk4";
            controllerModel.MCUFrequency = 216;
            controllerModel.OutlineDimension = new Model.Dimension(0, 0, 0);
            controllerModel.IO = new Model.IONumber(16, 5, 3, 4, 0);
            controllerModel.Reliability = 90;
            controllerModel.UnitPrice = 100;
            controllerModel.Weight = 158;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(controllerModel, true));

            // Propeller 9443
            modelFileName = Environment.CurrentDirectory + @"\Models\Propeller\Demo-9443.model";

            var propellerModel = new Model.Propeller();

            propellerModel.Model = "9443";
            propellerModel.Manufacturer = "Demo";
            propellerModel.DisplayName = "Demo 9443";
            propellerModel.Diameter = 109.22;
            propellerModel.OutlineDimension = new Model.Dimension(109.22, 109.22, 0);
            propellerModel.Reliability = 80;
            propellerModel.UnitPrice = 2;
            propellerModel.Weight = 7.5;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(propellerModel, true));

            // 1137
            modelFileName = Environment.CurrentDirectory + @"\Models\Propeller\Demo-1137.model";

            propellerModel = new Model.Propeller();

            propellerModel.Model = "1137";
            propellerModel.Manufacturer = "Demo";
            propellerModel.DisplayName = "Demo 1137";
            propellerModel.Diameter = 280;
            propellerModel.OutlineDimension = new Model.Dimension(280, 280, 0);
            propellerModel.Reliability = 80;
            propellerModel.UnitPrice = 6;
            propellerModel.Weight = 13;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(propellerModel, true));

            // 1240
            modelFileName = Environment.CurrentDirectory + @"\Models\Propeller\Demo-1240.model";

            propellerModel = new Model.Propeller();

            propellerModel.Model = "1240";
            propellerModel.Manufacturer = "Demo";
            propellerModel.DisplayName = "Demo 1240";
            propellerModel.Diameter = 300;
            propellerModel.OutlineDimension = new Model.Dimension(300, 300, 0);
            propellerModel.Reliability = 80;
            propellerModel.UnitPrice = 7;
            propellerModel.Weight = 16;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(propellerModel, true));

            // 1344
            modelFileName = Environment.CurrentDirectory + @"\Models\Propeller\Demo-1344.model";

            propellerModel = new Model.Propeller();

            propellerModel.Model = "1344";
            propellerModel.Manufacturer = "Demo";
            propellerModel.DisplayName = "Demo 1344";
            propellerModel.Diameter = 330;
            propellerModel.OutlineDimension = new Model.Dimension(330, 330, 0);
            propellerModel.Reliability = 80;
            propellerModel.UnitPrice = 8;
            propellerModel.Weight = 19;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(propellerModel, true));

            // 1448
            modelFileName = Environment.CurrentDirectory + @"\Models\Propeller\Demo-1448.model";

            propellerModel = new Model.Propeller();

            propellerModel.Model = "1448";
            propellerModel.Manufacturer = "Demo";
            propellerModel.DisplayName = "Demo 1448";
            propellerModel.Diameter = 354;
            propellerModel.OutlineDimension = new Model.Dimension(354, 354, 0);
            propellerModel.Reliability = 80;
            propellerModel.UnitPrice = 9;
            propellerModel.Weight = 21;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(propellerModel, true));

            // RC
            modelFileName = Environment.CurrentDirectory + @"\Models\Remote\Demo-9Channel-RC.model";

            var RCModel = new Model.Device();

            RCModel.Model = "9Channel-RC";
            RCModel.Manufacturer = "Demo";
            RCModel.DisplayName = "Demo 9Channel RC";
            RCModel.BodyAttachLocation = Model.Device.DeviceBodyAttachLocation.Bottom;
            RCModel.Power = 1.1;
            RCModel.Feature = "RC Module";
            RCModel.Parameters.Add("Frequency", "2.4Ghz");
            RCModel.Parameters.Add("Remote Control Distance", "2500m");
            RCModel.OutlineDimension = new Model.Dimension(47, 14, 25);
            RCModel.Reliability = 80;
            RCModel.UnitPrice = 100;
            RCModel.Weight = 12;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(RCModel, true));

            // ESC
            // 20A
            modelFileName = Environment.CurrentDirectory + @"\Models\SpeedController\Demo-20A.model";

            var ESCModel = new Model.SpeedController();

            ESCModel.Model = "20A";
            ESCModel.Manufacturer = "Demo";
            ESCModel.DisplayName = "Demo 20A";
            ESCModel.MaxContinuousCurrent = 20;
            ESCModel.MaxOutputCurrent = 30;
            ESCModel.OutlineDimension = new Model.Dimension(42, 21.6, 12);
            ESCModel.Reliability = 80;
            ESCModel.UnitPrice = 8;
            ESCModel.Weight = 18.5;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(ESCModel, true));

            // 40A
            modelFileName = Environment.CurrentDirectory + @"\Models\SpeedController\Demo-40A.model";

            ESCModel = new Model.SpeedController();

            ESCModel.Model = "40A";
            ESCModel.Manufacturer = "Demo";
            ESCModel.DisplayName = "Demo 40A";
            ESCModel.MaxContinuousCurrent = 40;
            ESCModel.MaxOutputCurrent = 60;
            ESCModel.OutlineDimension = new Model.Dimension(56, 25.2, 12.4);
            ESCModel.Reliability = 80;
            ESCModel.UnitPrice = 9;
            ESCModel.Weight = 32;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(ESCModel, true));

            // 50A
            modelFileName = Environment.CurrentDirectory + @"\Models\SpeedController\Demo-50A.model";

            ESCModel = new Model.SpeedController();

            ESCModel.Model = "50A";
            ESCModel.Manufacturer = "Demo";
            ESCModel.DisplayName = "Demo 50A";
            ESCModel.MaxContinuousCurrent = 50;
            ESCModel.MaxOutputCurrent = 70;
            ESCModel.OutlineDimension = new Model.Dimension(48, 30, 15.5);
            ESCModel.Reliability = 80;
            ESCModel.UnitPrice = 15;
            ESCModel.Weight = 54.4;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(ESCModel, true));

            // Camera
            modelFileName = Environment.CurrentDirectory + @"\Models\Device\Demo-3Axis-8MP.model";

            var CameraModel = new Model.Device();

            CameraModel.Model = "3Axis-8MP";
            CameraModel.Manufacturer = "Demo";
            CameraModel.DisplayName = "Demo 3Axis 8MP";
            CameraModel.BodyAttachLocation = Model.Device.DeviceBodyAttachLocation.Bottom;
            CameraModel.Feature = "Aerial Photography";
            CameraModel.IORequests = new Model.IONumber(spi:1);
            CameraModel.Parameters.Add("Pixel", "8MP");
            CameraModel.Parameters.Add("TransmissionType", "Digital");
            CameraModel.Parameters.Add("TransmissionDistance", "1500m");
            CameraModel.OutlineDimension = new Model.Dimension(80, 80, 100);
            CameraModel.Reliability = 80;
            CameraModel.UnitPrice = 50;
            CameraModel.Weight = 180;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(CameraModel, true));

            // Motor
            // 2212-KV900
            modelFileName = Environment.CurrentDirectory + @"\Models\Motor\Demo-2212-KV900.model";

            var motorModel = new Model.Motor();

            motorModel.Model = "2212";
            motorModel.Manufacturer = "Demo";
            motorModel.DisplayName = "Demo 2212 KV900";
            motorModel.OutlineDimension = new Model.Dimension(27.7, 27.7, 24.2);
            motorModel.Diameter = 27.7;
            motorModel.KVValue = 900;
            motorModel.MaxCurrent = 16;
            motorModel.StandbyCurrent = 0;
            motorModel.InternalResistance = 0;
            motorModel.MaxPower = 265;

            Model.VoltagePerformanceCurve performanceCurveList1 = new Model.VoltagePerformanceCurve();

            // 11.1V
            Model.VoltagePerformanceCurve.Curve performanceCurveList1Curve1 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList1Curve1.Voltage = 11.1;

            performanceCurveList1Curve1.CurrentPoints.Add(1.0);
            performanceCurveList1Curve1.CurrentPoints.Add(2.0);
            performanceCurveList1Curve1.CurrentPoints.Add(3.0);
            performanceCurveList1Curve1.CurrentPoints.Add(5.0);
            performanceCurveList1Curve1.CurrentPoints.Add(7.9);

            performanceCurveList1Curve1.ThrustPoints.Add(105);
            performanceCurveList1Curve1.ThrustPoints.Add(200);
            performanceCurveList1Curve1.ThrustPoints.Add(280);
            performanceCurveList1Curve1.ThrustPoints.Add(415);
            performanceCurveList1Curve1.ThrustPoints.Add(580);

            performanceCurveList1Curve1.PowerPoints.Add(11.1);
            performanceCurveList1Curve1.PowerPoints.Add(22.2);
            performanceCurveList1Curve1.PowerPoints.Add(33.3);
            performanceCurveList1Curve1.PowerPoints.Add(55.5);
            performanceCurveList1Curve1.PowerPoints.Add(87.69);

            performanceCurveList1Curve1.EfficiencyPoints.Add(9.46);
            performanceCurveList1Curve1.EfficiencyPoints.Add(9.00);
            performanceCurveList1Curve1.EfficiencyPoints.Add(8.41);
            performanceCurveList1Curve1.EfficiencyPoints.Add(7.47);
            performanceCurveList1Curve1.EfficiencyPoints.Add(6.61);

            // 14.8V
            Model.VoltagePerformanceCurve.Curve performanceCurveList1Curve2 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList1Curve2.Voltage = 14.8;

            performanceCurveList1Curve2.CurrentPoints.Add(1.0);
            performanceCurveList1Curve2.CurrentPoints.Add(2.0);
            performanceCurveList1Curve2.CurrentPoints.Add(3.0);
            performanceCurveList1Curve2.CurrentPoints.Add(5.0);
            performanceCurveList1Curve2.CurrentPoints.Add(7.0);
            performanceCurveList1Curve2.CurrentPoints.Add(9.0);
            performanceCurveList1Curve2.CurrentPoints.Add(11.0);
            performanceCurveList1Curve2.CurrentPoints.Add(11.7);

            performanceCurveList1Curve2.ThrustPoints.Add(125);
            performanceCurveList1Curve2.ThrustPoints.Add(235);
            performanceCurveList1Curve2.ThrustPoints.Add(325);
            performanceCurveList1Curve2.ThrustPoints.Add(485);
            performanceCurveList1Curve2.ThrustPoints.Add(630);
            performanceCurveList1Curve2.ThrustPoints.Add(740);
            performanceCurveList1Curve2.ThrustPoints.Add(845);
            performanceCurveList1Curve2.ThrustPoints.Add(900);

            performanceCurveList1Curve2.PowerPoints.Add(14.8);
            performanceCurveList1Curve2.PowerPoints.Add(29.6);
            performanceCurveList1Curve2.PowerPoints.Add(44.4);
            performanceCurveList1Curve2.PowerPoints.Add(74);
            performanceCurveList1Curve2.PowerPoints.Add(103.6);
            performanceCurveList1Curve2.PowerPoints.Add(133.2);
            performanceCurveList1Curve2.PowerPoints.Add(162.8);
            performanceCurveList1Curve2.PowerPoints.Add(173.16);

            performanceCurveList1Curve2.EfficiencyPoints.Add(8.44);
            performanceCurveList1Curve2.EfficiencyPoints.Add(7.93);
            performanceCurveList1Curve2.EfficiencyPoints.Add(7.31);
            performanceCurveList1Curve2.EfficiencyPoints.Add(6.55);
            performanceCurveList1Curve2.EfficiencyPoints.Add(6.08);
            performanceCurveList1Curve2.EfficiencyPoints.Add(5.55);
            performanceCurveList1Curve2.EfficiencyPoints.Add(5.19);
            performanceCurveList1Curve2.EfficiencyPoints.Add(5.19);

            performanceCurveList1.CurveByVoltage.Add(performanceCurveList1Curve1);
            performanceCurveList1.CurveByVoltage.Add(performanceCurveList1Curve2);

            motorModel.AdaptedPropellerModels.Add("9443");

            motorModel.VoltagePerformanceCurvesByPropellers.Add("9443", performanceCurveList1);

            motorModel.Reliability = 80;
            motorModel.UnitPrice = 5;
            motorModel.Weight = 52;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(motorModel, true));

            // 3508 KV690
            modelFileName = Environment.CurrentDirectory + @"\Models\Motor\Demo-3508-KV690.model";

            motorModel = new Model.Motor();

            motorModel.Model = "3508";
            motorModel.Manufacturer = "Demo";
            motorModel.DisplayName = "Demo 3508 KV690";
            motorModel.OutlineDimension = new Model.Dimension(42, 42, 25.3);
            motorModel.Diameter = 42;
            motorModel.KVValue = 690;
            motorModel.MaxCurrent = 30;
            motorModel.StandbyCurrent = 0.26;
            motorModel.InternalResistance = 0.086;
            motorModel.MaxPower = 440;

            Model.VoltagePerformanceCurve performanceCurveList2 = new Model.VoltagePerformanceCurve();
            Model.VoltagePerformanceCurve performanceCurveList3 = new Model.VoltagePerformanceCurve();
            Model.VoltagePerformanceCurve performanceCurveList4 = new Model.VoltagePerformanceCurve();
            Model.VoltagePerformanceCurve performanceCurveList5 = new Model.VoltagePerformanceCurve();

            // 1137 14.8V
            Model.VoltagePerformanceCurve.Curve performanceCurveList2Curve1 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList2Curve1.Voltage = 14.8;

            performanceCurveList2Curve1.CurrentPoints.Add(1.8);
            performanceCurveList2Curve1.CurrentPoints.Add(2.8);
            performanceCurveList2Curve1.CurrentPoints.Add(4.3);
            performanceCurveList2Curve1.CurrentPoints.Add(6.1);
            performanceCurveList2Curve1.CurrentPoints.Add(8);
            performanceCurveList2Curve1.CurrentPoints.Add(10.3);

            performanceCurveList2Curve1.ThrustPoints.Add(349);
            performanceCurveList2Curve1.ThrustPoints.Add(491);
            performanceCurveList2Curve1.ThrustPoints.Add(653);
            performanceCurveList2Curve1.ThrustPoints.Add(786);
            performanceCurveList2Curve1.ThrustPoints.Add(951);
            performanceCurveList2Curve1.ThrustPoints.Add(1146);

            performanceCurveList2Curve1.PowerPoints.Add(26.6);
            performanceCurveList2Curve1.PowerPoints.Add(41.4);
            performanceCurveList2Curve1.PowerPoints.Add(63.6);
            performanceCurveList2Curve1.PowerPoints.Add(90.3);
            performanceCurveList2Curve1.PowerPoints.Add(118.4);
            performanceCurveList2Curve1.PowerPoints.Add(152.4);

            performanceCurveList2Curve1.EfficiencyPoints.Add(13.101);
            performanceCurveList2Curve1.EfficiencyPoints.Add(11.848);
            performanceCurveList2Curve1.EfficiencyPoints.Add(10.261);
            performanceCurveList2Curve1.EfficiencyPoints.Add(8.706);
            performanceCurveList2Curve1.EfficiencyPoints.Add(8.032);
            performanceCurveList2Curve1.EfficiencyPoints.Add(7.518);

            // 1240 11.1V
            Model.VoltagePerformanceCurve.Curve performanceCurveList3Curve1 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList3Curve1.Voltage = 11.1;

            performanceCurveList3Curve1.CurrentPoints.Add(1.5);
            performanceCurveList3Curve1.CurrentPoints.Add(2.6);
            performanceCurveList3Curve1.CurrentPoints.Add(3.7);
            performanceCurveList3Curve1.CurrentPoints.Add(5.2);
            performanceCurveList3Curve1.CurrentPoints.Add(7.0);
            performanceCurveList3Curve1.CurrentPoints.Add(8.7);

            performanceCurveList3Curve1.ThrustPoints.Add(262);
            performanceCurveList3Curve1.ThrustPoints.Add(383);
            performanceCurveList3Curve1.ThrustPoints.Add(491);
            performanceCurveList3Curve1.ThrustPoints.Add(620);
            performanceCurveList3Curve1.ThrustPoints.Add(742);
            performanceCurveList3Curve1.ThrustPoints.Add(882);

            performanceCurveList3Curve1.PowerPoints.Add(16.7);
            performanceCurveList3Curve1.PowerPoints.Add(28.9);
            performanceCurveList3Curve1.PowerPoints.Add(41.1);
            performanceCurveList3Curve1.PowerPoints.Add(57.7);
            performanceCurveList3Curve1.PowerPoints.Add(77.7);
            performanceCurveList3Curve1.PowerPoints.Add(96.6);

            performanceCurveList3Curve1.EfficiencyPoints.Add(15.736);
            performanceCurveList3Curve1.EfficiencyPoints.Add(13.271);
            performanceCurveList3Curve1.EfficiencyPoints.Add(11.955);
            performanceCurveList3Curve1.EfficiencyPoints.Add(10.742);
            performanceCurveList3Curve1.EfficiencyPoints.Add(9.550);
            performanceCurveList3Curve1.EfficiencyPoints.Add(8.926);

            // 1240 14.8V
            Model.VoltagePerformanceCurve.Curve performanceCurveList3Curve2 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList3Curve2.Voltage = 14.8;

            performanceCurveList3Curve2.CurrentPoints.Add(2.3);
            performanceCurveList3Curve2.CurrentPoints.Add(4.1);
            performanceCurveList3Curve2.CurrentPoints.Add(6);
            performanceCurveList3Curve2.CurrentPoints.Add(8.2);
            performanceCurveList3Curve2.CurrentPoints.Add(11);
            performanceCurveList3Curve2.CurrentPoints.Add(13.7);

            performanceCurveList3Curve2.ThrustPoints.Add(447);
            performanceCurveList3Curve2.ThrustPoints.Add(642);
            performanceCurveList3Curve2.ThrustPoints.Add(851);
            performanceCurveList3Curve2.ThrustPoints.Add(1001);
            performanceCurveList3Curve2.ThrustPoints.Add(1177);
            performanceCurveList3Curve2.ThrustPoints.Add(1402);

            performanceCurveList3Curve2.PowerPoints.Add(34.0);
            performanceCurveList3Curve2.PowerPoints.Add(60.7);
            performanceCurveList3Curve2.PowerPoints.Add(88.8);
            performanceCurveList3Curve2.PowerPoints.Add(121.4);
            performanceCurveList3Curve2.PowerPoints.Add(162.8);
            performanceCurveList3Curve2.PowerPoints.Add(202.8);

            performanceCurveList3Curve2.EfficiencyPoints.Add(13.132);
            performanceCurveList3Curve2.EfficiencyPoints.Add(10.580);
            performanceCurveList3Curve2.EfficiencyPoints.Add(9.583);
            performanceCurveList3Curve2.EfficiencyPoints.Add(8.248);
            performanceCurveList3Curve2.EfficiencyPoints.Add(7.230);
            performanceCurveList3Curve2.EfficiencyPoints.Add(6.915);

            // 1344 11.1V
            Model.VoltagePerformanceCurve.Curve performanceCurveList4Curve1 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList4Curve1.Voltage = 11.1;

            performanceCurveList4Curve1.CurrentPoints.Add(1.9);
            performanceCurveList4Curve1.CurrentPoints.Add(2.9);
            performanceCurveList4Curve1.CurrentPoints.Add(4.2);
            performanceCurveList4Curve1.CurrentPoints.Add(6.1);
            performanceCurveList4Curve1.CurrentPoints.Add(8.1);
            performanceCurveList4Curve1.CurrentPoints.Add(10);

            performanceCurveList4Curve1.ThrustPoints.Add(317);
            performanceCurveList4Curve1.ThrustPoints.Add(451);
            performanceCurveList4Curve1.ThrustPoints.Add(567);
            performanceCurveList4Curve1.ThrustPoints.Add(728);
            performanceCurveList4Curve1.ThrustPoints.Add(859);
            performanceCurveList4Curve1.ThrustPoints.Add(1001);

            performanceCurveList4Curve1.PowerPoints.Add(21.1);
            performanceCurveList4Curve1.PowerPoints.Add(32.2);
            performanceCurveList4Curve1.PowerPoints.Add(46.6);
            performanceCurveList4Curve1.PowerPoints.Add(67.7);
            performanceCurveList4Curve1.PowerPoints.Add(89.9);
            performanceCurveList4Curve1.PowerPoints.Add(111.0);

            performanceCurveList4Curve1.EfficiencyPoints.Add(15.031);
            performanceCurveList4Curve1.EfficiencyPoints.Add(14.011);
            performanceCurveList4Curve1.EfficiencyPoints.Add(12.162);
            performanceCurveList4Curve1.EfficiencyPoints.Add(10.752);
            performanceCurveList4Curve1.EfficiencyPoints.Add(9.554);
            performanceCurveList4Curve1.EfficiencyPoints.Add(9.018);


            // 1344 14.8V
            Model.VoltagePerformanceCurve.Curve performanceCurveList4Curve2 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList4Curve2.Voltage = 14.8;

            performanceCurveList4Curve2.CurrentPoints.Add(3);
            performanceCurveList4Curve2.CurrentPoints.Add(4.6);
            performanceCurveList4Curve2.CurrentPoints.Add(6.8);
            performanceCurveList4Curve2.CurrentPoints.Add(9.4);
            performanceCurveList4Curve2.CurrentPoints.Add(12.5);
            performanceCurveList4Curve2.CurrentPoints.Add(15.6);

            performanceCurveList4Curve2.ThrustPoints.Add(562);
            performanceCurveList4Curve2.ThrustPoints.Add(742);
            performanceCurveList4Curve2.ThrustPoints.Add(948);
            performanceCurveList4Curve2.ThrustPoints.Add(1169);
            performanceCurveList4Curve2.ThrustPoints.Add(1391);
            performanceCurveList4Curve2.ThrustPoints.Add(1586);

            performanceCurveList4Curve2.PowerPoints.Add(44.4);
            performanceCurveList4Curve2.PowerPoints.Add(68.1);
            performanceCurveList4Curve2.PowerPoints.Add(100.6);
            performanceCurveList4Curve2.PowerPoints.Add(139.1);
            performanceCurveList4Curve2.PowerPoints.Add(185.0);
            performanceCurveList4Curve2.PowerPoints.Add(230.9);

            performanceCurveList4Curve2.EfficiencyPoints.Add(12.658);
            performanceCurveList4Curve2.EfficiencyPoints.Add(10.884);
            performanceCurveList4Curve2.EfficiencyPoints.Add(9.420);
            performanceCurveList4Curve2.EfficiencyPoints.Add(8.403);
            performanceCurveList4Curve2.EfficiencyPoints.Add(7.519);
            performanceCurveList4Curve2.EfficiencyPoints.Add(6.869);

            // 1448 11.1V
            Model.VoltagePerformanceCurve.Curve performanceCurveList5Curve1 = new Model.VoltagePerformanceCurve.Curve();

            performanceCurveList5Curve1.Voltage = 11.1;

            performanceCurveList5Curve1.CurrentPoints.Add(2.3);
            performanceCurveList5Curve1.CurrentPoints.Add(3.9);
            performanceCurveList5Curve1.CurrentPoints.Add(5.8);
            performanceCurveList5Curve1.CurrentPoints.Add(7.8);
            performanceCurveList5Curve1.CurrentPoints.Add(10.4);
            performanceCurveList5Curve1.CurrentPoints.Add(12.9);

            performanceCurveList5Curve1.ThrustPoints.Add(394);
            performanceCurveList5Curve1.ThrustPoints.Add(557);
            performanceCurveList5Curve1.ThrustPoints.Add(711);
            performanceCurveList5Curve1.ThrustPoints.Add(835);
            performanceCurveList5Curve1.ThrustPoints.Add(1030);
            performanceCurveList5Curve1.ThrustPoints.Add(1180);

            performanceCurveList5Curve1.PowerPoints.Add(25.5);
            performanceCurveList5Curve1.PowerPoints.Add(43.3);
            performanceCurveList5Curve1.PowerPoints.Add(64.4);
            performanceCurveList5Curve1.PowerPoints.Add(86.6);
            performanceCurveList5Curve1.PowerPoints.Add(115.4);
            performanceCurveList5Curve1.PowerPoints.Add(143.2);

            performanceCurveList5Curve1.EfficiencyPoints.Add(15.443);
            performanceCurveList5Curve1.EfficiencyPoints.Add(12.867);
            performanceCurveList5Curve1.EfficiencyPoints.Add(11.044);
            performanceCurveList5Curve1.EfficiencyPoints.Add(9.644);
            performanceCurveList5Curve1.EfficiencyPoints.Add(8.922);
            performanceCurveList5Curve1.EfficiencyPoints.Add(8.241);

            performanceCurveList2.CurveByVoltage.Add(performanceCurveList2Curve1);
            performanceCurveList3.CurveByVoltage.Add(performanceCurveList3Curve1);
            performanceCurveList3.CurveByVoltage.Add(performanceCurveList3Curve2);
            performanceCurveList4.CurveByVoltage.Add(performanceCurveList4Curve1);
            performanceCurveList4.CurveByVoltage.Add(performanceCurveList4Curve2);
            performanceCurveList5.CurveByVoltage.Add(performanceCurveList5Curve1);

            motorModel.AdaptedPropellerModels.Add("1137");
            motorModel.AdaptedPropellerModels.Add("1240");
            motorModel.AdaptedPropellerModels.Add("1344");
            motorModel.AdaptedPropellerModels.Add("1448");

            motorModel.VoltagePerformanceCurvesByPropellers.Add("1137", performanceCurveList2);
            motorModel.VoltagePerformanceCurvesByPropellers.Add("1240", performanceCurveList3);
            motorModel.VoltagePerformanceCurvesByPropellers.Add("1344", performanceCurveList4);
            motorModel.VoltagePerformanceCurvesByPropellers.Add("1448", performanceCurveList5);

            motorModel.Reliability = 90;
            motorModel.UnitPrice = 30;
            motorModel.Weight = 88;

            FStream.WriteStreamToTextFile(modelFileName, OStream.GetObjectStream(motorModel, true));
        }
    }
}
