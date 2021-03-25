using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrotorDesigner.Components;
using QuadrotorDesigner.Utils.Notation;
using QuadrotorDesigner.Workspace;
using static QuadrotorDesigner.Components.Model;

namespace QuadrotorDesigner.Workspace.Designer
{
    public class DesignEngine
    {
        public class RelationDesigner
        {
            public List<DocumentManager.ComponentDocument> AllModelList;
            public DroneDesignProject DroneDesignProject;
            public DroneDesignBOM DroneDesign;

            public double DroneWeight;

            public RelationDesigner(List<DocumentManager.ComponentDocument> modelList)
            {
                AllModelList = modelList;
                DroneDesignProject = new DroneDesignProject();
                DroneDesign = new DroneDesignBOM();
                DroneDesign.MotorModel = null;
                DroneDesign.PropellerModel = null;
                DroneDesign.BodyModel = null;
                DroneDesign.RCModel = null;
                DroneDesign.BatteryModel = null;
                DroneDesign.ESCModel = null;
                DroneDesign.FlightControllerModel = null;
                DroneDesign.DeviceModels.Clear();
            }

            public RelationDesigner(string Name, string Author, string Description, List<DocumentManager.ComponentDocument> modelList)
            {
                AllModelList = modelList;
                DroneDesignProject = new DroneDesignProject(Name, Author, Description);
                DroneDesign = new DroneDesignBOM();
                DroneDesign.MotorModel = null;
                DroneDesign.PropellerModel = null;
                DroneDesign.BodyModel = null;
                DroneDesign.RCModel = null;
                DroneDesign.BatteryModel = null;
                DroneDesign.ESCModel = null;
                DroneDesign.FlightControllerModel = null;
                DroneDesign.DeviceModels.Clear();
            }

            public bool AddComponent(ModelTypeList dronePart, DocumentManager.ComponentDocument modelDocument)
            {
                bool retValue = false;

                try
                {
                    if (dronePart == ModelTypeList.Device)
                    {
                        if (DroneDesignProject.DeviceModels == null)
                        {
                            DroneDesignProject.DeviceModels = new List<string>();

                            if (DroneDesignProject.DeviceModels.IndexOf(modelDocument.ModelFileName) == -1)
                            {
                                var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);
                                DroneDesignProject.DeviceModels.Add(modelDocument.ModelFileName);
                                DroneDesign.DeviceModels.Add(modelObject);
                                DroneWeight += modelObject.Weight;
                                modelDocument.Selected = true;
                                retValue = true;
                            }
                        }
                    }
                    else
                    {
                        switch (dronePart)
                        {
                            case ModelTypeList.Battery:
                                {
                                    if (DroneDesign.BatteryModel == null)
                                    {
                                        DroneDesignProject.BatteryModel = modelDocument.ModelFileName;
                                        DroneDesign.BatteryModel = OStream.GetStreamObject<Battery>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.BatteryModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel == null)
                                    {
                                        DroneDesignProject.BodyModel = modelDocument.ModelFileName;
                                        DroneDesign.BodyModel = OStream.GetStreamObject<Body>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.BodyModel.Weight;
                                        DroneDesign.RotorNumber = DroneDesign.BodyModel.RotorNumber;
                                        DroneDesignProject.RotorNumber = DroneDesign.BodyModel.RotorNumber;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    if (DroneDesign.ESCModel == null)
                                    {
                                        DroneDesignProject.ESCModel = modelDocument.ModelFileName;
                                        DroneDesign.ESCModel = OStream.GetStreamObject<SpeedController>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.ESCModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    if (DroneDesign.FlightControllerModel == null)
                                    {
                                        DroneDesignProject.FlightControllerModel = modelDocument.ModelFileName;
                                        DroneDesign.FlightControllerModel = OStream.GetStreamObject<FlightController>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.FlightControllerModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    if (DroneDesign.MotorModel == null)
                                    {
                                        DroneDesignProject.MotorModel = modelDocument.ModelFileName;
                                        DroneDesign.MotorModel = OStream.GetStreamObject<Motor>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.MotorModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    if (DroneDesign.PropellerModel == null)
                                    {
                                        DroneDesignProject.PropellerModel = modelDocument.ModelFileName;
                                        DroneDesign.PropellerModel = OStream.GetStreamObject<Propeller>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.PropellerModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    if (DroneDesign.RCModel == null)
                                    {
                                        DroneDesignProject.RCModel = modelDocument.ModelFileName;
                                        DroneDesign.RCModel = OStream.GetStreamObject<Device>(modelDocument.JSONText);
                                        DroneWeight += DroneDesign.RCModel.Weight;
                                        modelDocument.Selected = true;
                                        retValue = true;
                                    }

                                    break;
                                }
                        }

                    }
                }
                catch (Exception) { };

                return retValue;
            }

            public bool DeleteComponent(ModelTypeList dronePart, DocumentManager.ComponentDocument modelDocument)
            {
                bool retValue = false;

                if (dronePart == ModelTypeList.Device)
                {
                    if (DroneDesignProject.DeviceModels.Count(obj => obj == modelDocument.ModelFileName) != 0)
                    {
                        DroneDesignProject.DeviceModels.Remove(DroneDesignProject.DeviceModels.Where(obj => obj == modelDocument.ModelFileName).FirstOrDefault());
                        var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);
                        DroneWeight -= modelObject.Weight;
                        DroneDesign.DeviceModels.Remove(DroneDesign.DeviceModels.Where(obj => obj.DisplayName == modelObject.DisplayName).FirstOrDefault());
                        modelDocument.Selected = false;
                        retValue = true;
                    }
                }
                else
                {
                    switch (dronePart)
                    {
                        case ModelTypeList.Battery:
                            {
                                if (DroneDesign.BatteryModel != null)
                                {
                                    DroneDesignProject.BatteryModel = string.Empty;
                                    DroneWeight -= DroneDesign.BatteryModel.Weight;
                                    DroneDesign.BatteryModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.Body:
                            {
                                if (DroneDesign.BodyModel != null)
                                {
                                    DroneDesignProject.BodyModel = string.Empty;
                                    DroneWeight -= DroneDesign.BodyModel.Weight;
                                    DroneDesign.BodyModel = null;
                                    DroneDesign.RotorNumber = 0;
                                    DroneDesignProject.RotorNumber = 0;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.ESC:
                            {
                                if (DroneDesign.ESCModel != null)
                                {
                                    DroneDesignProject.ESCModel = string.Empty;
                                    DroneWeight -= DroneDesign.ESCModel.Weight;
                                    DroneDesign.ESCModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.FlightController:
                            {
                                if (DroneDesign.FlightControllerModel != null)
                                {
                                    DroneDesignProject.FlightControllerModel = string.Empty;
                                    DroneWeight -= DroneDesign.FlightControllerModel.Weight;
                                    DroneDesign.FlightControllerModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.Motor:
                            {
                                if (DroneDesign.MotorModel != null)
                                {
                                    DroneDesignProject.MotorModel = string.Empty;
                                    DroneWeight -= DroneDesign.MotorModel.Weight;
                                    DroneDesign.MotorModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.Propeller:
                            {
                                if (DroneDesign.PropellerModel != null)
                                {
                                    DroneDesignProject.PropellerModel = string.Empty;
                                    DroneWeight -= DroneDesign.PropellerModel.Weight;
                                    DroneDesign.PropellerModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                        case ModelTypeList.RC:
                            {
                                if (DroneDesign.RCModel != null)
                                {
                                    DroneDesignProject.RCModel = string.Empty;
                                    DroneWeight -= DroneDesign.RCModel.Weight;
                                    DroneDesign.RCModel = null;
                                    modelDocument.Selected = false;
                                    retValue = true;
                                }

                                break;
                            }
                    }

                }

                return retValue;
            }

            public string GetDesignProjectJSON()
            {
                return OStream.GetObjectStream(DroneDesignProject, true);
            }

            public bool CheckFullDefined()
            {
                return DroneDesign.BatteryModel != null && DroneDesign.BodyModel != null && DroneDesign.ESCModel != null
                    && DroneDesign.FlightControllerModel != null && DroneDesign.MotorModel != null && DroneDesign.PropellerModel != null
                    && DroneDesign.RCModel != null;
            }

            private bool CheckDimension()
            {
                return true;
            }

            private bool MotorCheckThrust(double objectWeight, bool considerRotor)
            {
                bool retValue = true;

                int rotorNumber = considerRotor ? (DroneDesign.BodyModel == null ? 1 : DroneDesign.BodyModel.RotorNumber)  : 1;

                // 如果 Body, Battery, Propeller 已经选择，则考虑推力限制
                if (DroneDesign.BodyModel != null && DroneDesign.BatteryModel != null && DroneDesign.PropellerModel != null)
                {
                    double maxThrust = double.MinValue;

                    var performanceCurves = DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers[DroneDesign.PropellerModel.Model];

                    foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                    {
                        if (performanceCurve.Voltage == DroneDesign.BatteryModel.TypicalVoltage)
                        {
                            for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                            {
                                maxThrust = Math.Max(maxThrust, performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber);
                            }
                        }
                    }

                    if (maxThrust < DroneWeight + objectWeight * rotorNumber)
                    {
                        retValue = false;
                        return retValue;
                    }
                }
                // 如果 Body, Propeller 已经选择，则考虑推力限制
                else if (DroneDesign.BodyModel != null && DroneDesign.BatteryModel == null && DroneDesign.PropellerModel != null)
                {
                    double maxThrust = double.MinValue;

                    var performanceCurves = DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers[DroneDesign.PropellerModel.Model];

                    foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                    {
                        for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                        {
                            maxThrust = Math.Max(maxThrust, performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber);
                        }
                    }

                    if (maxThrust < DroneWeight + rotorNumber)
                    {
                        retValue = false;
                        return retValue;
                    }
                }
                // 如果 Body, Battery 已经选择，则考虑推力限制
                else if (DroneDesign.BodyModel != null && DroneDesign.BatteryModel != null && DroneDesign.PropellerModel == null)
                {
                    double maxThrust = double.MinValue;

                    foreach (var performanceCurves in DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers.Values)
                    {
                        foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                        {
                            if (performanceCurve.Voltage == DroneDesign.BatteryModel.TypicalVoltage)
                            {
                                for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                                {
                                    maxThrust = Math.Max(maxThrust, performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber);
                                }
                            }
                        }
                    }

                    if (maxThrust < DroneWeight + rotorNumber)
                    {
                        retValue = false;
                        return retValue;
                    }
                }
                // 如果 Body 已经选择，则考虑推力限制
                else if (DroneDesign.BodyModel != null)
                {
                    double maxThrust = double.MinValue;

                    foreach (var performanceCurves in DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers.Values)
                    {
                        foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                        {
                            for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                            {
                                maxThrust = Math.Max(maxThrust, performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber);
                            }
                        }
                    }

                    if (maxThrust < DroneWeight + rotorNumber)
                    {
                        retValue = false;
                        return retValue;
                    }
                }

                return retValue;
            }

            public List<DocumentManager.ComponentDocument> CalcRelation()
            {
                List<DocumentManager.ComponentDocument> retValue = AllModelList;

                foreach (var modelDocument in retValue)
                {
                    modelDocument.Disable = false;
                }

                // 计算 Body 约束
                if (DroneDesign.BodyModel != null)
                {
                    double availableLoad = DroneWeight - DroneDesign.BodyModel.Weight;

                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 Body
                            case ModelTypeList.Body:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.BodyModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    if (DroneDesign.BatteryModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Battery>(modelDocument.JSONText);

                                    // 检查 Battery 与 Body 物理关系
                                    if (!CheckDimension() || availableLoad + modelObject.Weight > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    if (DroneDesign.ESCModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<SpeedController>(modelDocument.JSONText);

                                    // 检查 ESC 与 Body 物理关系
                                    if (!CheckDimension() || availableLoad + modelObject.Weight > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    if (DroneDesign.FlightControllerModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<FlightController>(modelDocument.JSONText);

                                    // 检查 FlightController 与 Body 物理关系
                                    if (!CheckDimension() || availableLoad + modelObject.Weight > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    if (DroneDesign.RCModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);

                                    // 检查 RC 与 Body 物理关系
                                    if (!CheckDimension() || availableLoad + modelObject.Weight > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    if (DroneDesign.MotorModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Motor>(modelDocument.JSONText);

                                    // 检查 Motor 与 Body 强制约束关系
                                    if (DroneDesign.BodyModel.AdaptedMotorModels.IndexOf(modelObject.Model) == -1 ||
                                        availableLoad + modelObject.Weight * DroneDesign.BodyModel.RotorNumber > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    if (DroneDesign.PropellerModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Propeller>(modelDocument.JSONText);

                                    // 检查 Propeller 与 Body 物理关系
                                    if (modelObject.Diameter > DroneDesign.BodyModel.MaxPropellerPitch ||
                                        availableLoad + modelObject.Weight * DroneDesign.BodyModel.RotorNumber > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                            case ModelTypeList.Device:
                                {
                                    if (modelDocument.Selected)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);

                                    // 检查 Device 与 Body 物理关系
                                    if (!CheckDimension() || availableLoad + modelObject.Weight > DroneDesign.BodyModel.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                    }

                                    break;
                                }
                        }
                    }
                }

                // 计算 Motor 约束
                if (DroneDesign.MotorModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 Motor
                            case ModelTypeList.Motor:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.MotorModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    if (DroneDesign.BatteryModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Battery>(modelDocument.JSONText);

                                    bool voltageFound = false;

                                    // 检查 Battery 与 Motor 强制约束关系（电压）
                                    foreach (var performanceCurves in DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers.Values)
                                    {
                                        foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                                        {
                                            if (performanceCurve.Voltage == modelObject.TypicalVoltage)
                                            {
                                                voltageFound = true;
                                                break;
                                            }
                                        }

                                        if (voltageFound)
                                        {
                                            break;
                                        }
                                    }

                                    if (!voltageFound)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    // 如果 Body, Propeller 已经选择，则考虑推力限制
                                    if (DroneDesign.BodyModel != null && DroneDesign.PropellerModel != null)
                                    {
                                        double minimalVoltage = double.MaxValue;

                                        var performanceCurves = DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers[DroneDesign.PropellerModel.Model];

                                        foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                                        {
                                            for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                                            {
                                                if (DroneDesign.BodyModel.RotorNumber * performanceCurve.ThrustPoints[i] >=
                                                        DroneWeight + modelObject.Weight)
                                                {
                                                    minimalVoltage = Math.Min(minimalVoltage, performanceCurve.Voltage);
                                                }
                                            }
                                        }

                                        if (modelObject.TypicalVoltage < minimalVoltage)
                                        {
                                            modelDocument.Disable = true;
                                            break;
                                        }
                                    }
                                    // 如果 Body 已经选择，则考虑推力限制
                                    else if (DroneDesign.BodyModel != null)
                                    {
                                        double minimalVoltage = double.MaxValue;

                                        foreach (var performanceCurves in DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers.Values)
                                        {
                                            foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                                            {
                                                for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                                                {
                                                    if (DroneDesign.BodyModel.RotorNumber * performanceCurve.ThrustPoints[i] >=
                                                            DroneWeight + modelObject.Weight)
                                                    {
                                                        minimalVoltage = Math.Min(minimalVoltage, performanceCurve.Voltage);
                                                    }
                                                }
                                            }

                                            if (modelObject.TypicalVoltage < minimalVoltage)
                                            {
                                                modelDocument.Disable = true;
                                                break;
                                            }
                                        }
                                    }

                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    if (DroneDesign.ESCModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<SpeedController>(modelDocument.JSONText);

                                    // 检查 ESC 与 Motor 强制约束关系
                                    if (modelObject.MaxOutputCurrent < DroneDesign.MotorModel.MaxCurrent)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    // 检查推力关系
                                    modelDocument.Disable = !MotorCheckThrust(modelObject.Weight, true);

                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    if (DroneDesign.FlightControllerModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<FlightController>(modelDocument.JSONText);

                                    // 检查推力关系
                                    modelDocument.Disable = !MotorCheckThrust(modelObject.Weight, false);

                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    if (DroneDesign.RCModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);

                                    // 检查推力关系
                                    modelDocument.Disable = !MotorCheckThrust(modelObject.Weight, false);

                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 Motor 与 Body 强制约束关系
                                    if (modelObject.AdaptedMotorModels.IndexOf(DroneDesign.MotorModel.Model) == -1)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    // 检查 Motor 与 Body 物理关系
                                    if (modelObject.MaxLoadWeight < DroneWeight + modelObject.RotorNumber * DroneDesign.MotorModel.Weight)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    if (DroneDesign.PropellerModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Propeller>(modelDocument.JSONText);

                                    // 检查 Motor 与 Propeller 强制约束关系
                                    if (DroneDesign.MotorModel.AdaptedPropellerModels.IndexOf(modelObject.Model) == -1)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    // 检查推力关系
                                    modelDocument.Disable = !MotorCheckThrust(modelObject.Weight, true);

                                    break;
                                }
                            case ModelTypeList.Device:
                                {
                                    if (modelDocument.Selected)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Device>(modelDocument.JSONText);

                                    // 检查推力关系
                                    modelDocument.Disable = !MotorCheckThrust(modelObject.Weight, true);

                                    break;
                                }
                        }
                    }
                }

                // 计算 ESC 约束
                if (DroneDesign.ESCModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 ESC
                            case ModelTypeList.ESC:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.ESCModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    if (DroneDesign.ESCModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Motor>(modelDocument.JSONText);

                                    // 检查电流关系
                                    if (modelObject.MaxCurrent > DroneDesign.ESCModel.MaxOutputCurrent)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 ESC 与 Body 物理关系
                                    if (modelObject.MaxLoadWeight < DroneWeight + DroneDesign.ESCModel.Weight * modelObject.RotorNumber)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Device:
                                {
                                    // 无约束关系
                                    break;
                                }
                        }
                    }
                }

                // 计算 Battery 约束
                if (DroneDesign.BatteryModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 Battery
                            case ModelTypeList.Battery:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.BatteryModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 Battery 与 Body 物理关系
                                    if (DroneWeight + DroneDesign.BatteryModel.Weight > modelObject.MaxLoadWeight)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Device:
                                {
                                    // 无约束关系
                                    break;
                                }
                        }
                    }
                }

                // 计算 Propeller 约束
                if (DroneDesign.PropellerModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 Propeller
                            case ModelTypeList.Propeller:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.PropellerModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 Propeller 与 Body 强制约束关系
                                    if (modelObject.MaxPropellerPitch < DroneDesign.PropellerModel.Diameter)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    // 检查 Propeller 与 Body 物理关系
                                    if (modelObject.MaxLoadWeight < DroneWeight + modelObject.RotorNumber * DroneDesign.PropellerModel.Weight)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    if (DroneDesign.MotorModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Motor>(modelDocument.JSONText);

                                    // 检查 Motor 与 Propeller 强制约束关系
                                    if (modelObject.AdaptedPropellerModels.IndexOf(DroneDesign.PropellerModel.Model) == -1)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                        }
                    }
                }

                // 计算 RC 约束
                if (DroneDesign.RCModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 RC
                            case ModelTypeList.RC:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.RCModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.FlightController:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 RC 与 Body 物理关系
                                    if (modelObject.MaxLoadWeight < DroneWeight + DroneDesign.RCModel.Weight)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    if (DroneDesign.MotorModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Motor>(modelDocument.JSONText);

                                    // 检查 Motor 与 Propeller 强制约束关系
                                    if (modelObject.AdaptedPropellerModels.IndexOf(DroneDesign.PropellerModel.Model) == -1)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                        }
                    }
                }

                // 计算 Controller 约束
                if (DroneDesign.FlightControllerModel != null)
                {
                    // 检查约束关系，递减
                    foreach (var modelDocument in retValue)
                    {
                        if (modelDocument.Disable)
                        {
                            continue;
                        }

                        switch (modelDocument.ModelType)
                        {
                            // 删除除自身外所有 Controller
                            case ModelTypeList.FlightController:
                                {
                                    if (modelDocument.ModelFileName != DroneDesignProject.FlightControllerModel)
                                    {
                                        modelDocument.Disable = true;
                                    }
                                    break;
                                }
                            case ModelTypeList.Battery:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.ESC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.RC:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Propeller:
                                {
                                    // 无约束关系
                                    break;
                                }
                            case ModelTypeList.Body:
                                {
                                    if (DroneDesign.BodyModel != null)
                                    {
                                        break;
                                    }

                                    var modelObject = OStream.GetStreamObject<Body>(modelDocument.JSONText);

                                    // 检查 RC 与 Body 物理关系
                                    if (modelObject.MaxLoadWeight < DroneWeight + DroneDesign.FlightControllerModel.Weight)
                                    {
                                        modelDocument.Disable = true;
                                        break;
                                    }

                                    break;
                                }
                            case ModelTypeList.Motor:
                                {
                                    // 无约束关系
                                    break;
                                }
                        }
                    }
                }

                return retValue;
            }

            public string Valide()
            {
                string retValue = string.Empty;

                DroneDesignResult droneDesignResult = new DroneDesignResult();

                // Summary
                droneDesignResult.Summary.Author = DroneDesignProject.Author;
                droneDesignResult.Summary.Name = DroneDesignProject.Name;
                droneDesignResult.Summary.Description = DroneDesignProject.Description;

                droneDesignResult.Summary.Price =
                    DroneDesign.BodyModel.UnitPrice + DroneDesign.BatteryModel.UnitPrice
                    + DroneDesign.ESCModel.UnitPrice * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.MotorModel.UnitPrice * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.PropellerModel.UnitPrice * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.FlightControllerModel.UnitPrice + DroneDesign.RCModel.UnitPrice
                    + DroneDesign.DeviceModels.Sum(obj => obj.UnitPrice);

                // Dimension
                droneDesignResult.DroneDimension.Weight =
                    DroneDesign.BodyModel.Weight + DroneDesign.BatteryModel.Weight
                    + DroneDesign.ESCModel.Weight * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.MotorModel.Weight * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.PropellerModel.Weight * DroneDesign.BodyModel.RotorNumber
                    + DroneDesign.FlightControllerModel.Weight + DroneDesign.RCModel.Weight
                    + DroneDesign.DeviceModels.Sum(obj => obj.Weight);

                droneDesignResult.DroneDimension.OutlineDimension =
                    DroneDesign.BodyModel.OutlineDimension;

                // PowerPerformance
                double maxMotorPower = double.MinValue;
                double typicalMotorPower = double.MaxValue;

                var performanceCurves = DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers[DroneDesign.PropellerModel.Model];

                foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                {
                    if (performanceCurve.Voltage == DroneDesign.BatteryModel.TypicalVoltage)
                    {
                        for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                        {
                            maxMotorPower = Math.Max(maxMotorPower, performanceCurve.PowerPoints[i] * DroneDesign.BodyModel.RotorNumber);

                            if (droneDesignResult.DroneDimension.Weight <= performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber)
                            {
                                typicalMotorPower = Math.Min(typicalMotorPower, performanceCurve.PowerPoints[i] * DroneDesign.BodyModel.RotorNumber);
                            }
                        }
                    }
                }

                droneDesignResult.PowerPerformance.MaxPower =
                    maxMotorPower + DroneDesign.RCModel.Power + DroneDesign.DeviceModels.Sum(obj => obj.Power);

                droneDesignResult.PowerPerformance.TypicalPower =
                    typicalMotorPower + DroneDesign.RCModel.Power + DroneDesign.DeviceModels.Sum(obj => obj.Power);

                droneDesignResult.PowerPerformance.EnduranceTime =
                    ((DroneDesign.BatteryModel.Capacity / 1000) * DroneDesign.BatteryModel.TypicalVoltage / droneDesignResult.PowerPerformance.TypicalPower) * 60;

                // DynamicPerformance
                var voltageCurve = new VoltagePerformanceCurve.Curve();

                double maxThrust = double.MinValue;

                performanceCurves = DroneDesign.MotorModel.VoltagePerformanceCurvesByPropellers[DroneDesign.PropellerModel.Model];

                foreach (var performanceCurve in performanceCurves.CurveByVoltage)
                {
                    if (performanceCurve.Voltage == DroneDesign.BatteryModel.TypicalVoltage)
                    {
                        voltageCurve.Voltage = performanceCurve.Voltage;

                        for (int i = 0; i < performanceCurve.ThrustPoints.Count; i++)
                        {
                            voltageCurve.ThrustPoints.Add(performanceCurve.ThrustPoints[i]);
                            voltageCurve.CurrentPoints.Add(performanceCurve.CurrentPoints[i]);
                            voltageCurve.PowerPoints.Add(performanceCurve.PowerPoints[i]);
                            voltageCurve.EfficiencyPoints.Add(performanceCurve.EfficiencyPoints[i]);

                            maxThrust = Math.Max(maxThrust, performanceCurve.ThrustPoints[i] * DroneDesign.BodyModel.RotorNumber);
                        }
                    }
                }

                droneDesignResult.DynamicPerformance.VoltagePerformanceCurve = new VoltagePerformanceCurve();
                droneDesignResult.DynamicPerformance.VoltagePerformanceCurve.CurveByVoltage.Add(voltageCurve);
                droneDesignResult.DynamicPerformance.MaxThrust = maxThrust;
                droneDesignResult.DynamicPerformance.ThrustWeightRatio = maxThrust / droneDesignResult.DroneDimension.Weight;

                droneDesignResult.Devices = DroneDesign.DeviceModels;
                droneDesignResult.Devices.Add(DroneDesign.RCModel);

                // BOM List
                droneDesignResult.BOMList = new List<DroneDesignResult.DroneDesignBOMItem>();

                // Body
                var BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.Body,
                    Model = DroneDesign.BodyModel.Model,
                    Price = DroneDesign.BodyModel.UnitPrice,
                    Reliability = DroneDesign.BodyModel.Reliability,
                    Manufacturer = DroneDesign.BodyModel.Manufacturer,
                    Quanlity = 1
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // Motor
                BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.Motor,
                    Model = DroneDesign.MotorModel.Model,
                    Price = DroneDesign.MotorModel.UnitPrice,
                    Reliability = DroneDesign.MotorModel.Reliability,
                    Manufacturer = DroneDesign.MotorModel.Manufacturer,
                    Quanlity = DroneDesign.BodyModel.RotorNumber
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // ESC
                BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.ESC,
                    Model = DroneDesign.ESCModel.Model,
                    Price = DroneDesign.ESCModel.UnitPrice,
                    Reliability = DroneDesign.ESCModel.Reliability,
                    Manufacturer = DroneDesign.ESCModel.Manufacturer,
                    Quanlity = DroneDesign.BodyModel.RotorNumber
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // Battery
                BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.Battery,
                    Model = DroneDesign.BatteryModel.Model,
                    Price = DroneDesign.BatteryModel.UnitPrice,
                    Reliability = DroneDesign.BatteryModel.Reliability,
                    Manufacturer = DroneDesign.BatteryModel.Manufacturer,
                    Quanlity = 1
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // Propeller
                BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.Propeller,
                    Model = DroneDesign.PropellerModel.Model,
                    Price = DroneDesign.PropellerModel.UnitPrice,
                    Reliability = DroneDesign.PropellerModel.Reliability,
                    Manufacturer = DroneDesign.PropellerModel.Manufacturer,
                    Quanlity = DroneDesign.BodyModel.RotorNumber
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // Flight Controller
                BOMItem = new DroneDesignResult.DroneDesignBOMItem
                {
                    ModelType = ModelTypeList.FlightController,
                    Model = DroneDesign.FlightControllerModel.Model,
                    Price = DroneDesign.FlightControllerModel.UnitPrice,
                    Reliability = DroneDesign.FlightControllerModel.Reliability,
                    Manufacturer = DroneDesign.FlightControllerModel.Manufacturer,
                    Quanlity = 1
                };

                droneDesignResult.BOMList.Add(BOMItem);

                // Devices
                foreach(var deviceObject in DroneDesign.DeviceModels)
                {
                    BOMItem = new DroneDesignResult.DroneDesignBOMItem
                    {
                        ModelType = ModelTypeList.Device,
                        Model = deviceObject.Model,
                        Price = deviceObject.UnitPrice,
                        Reliability = deviceObject.Reliability,
                        Manufacturer = deviceObject.Manufacturer,
                        Quanlity = 1
                    };

                    droneDesignResult.BOMList.Add(BOMItem);
                }

                retValue = OStream.GetObjectStream(droneDesignResult, true);

                return retValue;
            }
        };
    }
}
