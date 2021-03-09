using QuadrotorDesigner.Workspace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrotorDesigner.Workspace.UserInterface
{
    public partial class FromLoad : Form
    {
        private void ActionLoadModelDatabase()
        {
            // Clear Database
            DocumentManager.LocalModelDocuments.Clear();

            // Load Assembly
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.AssemblyPath, Resources.DesignFileExtName, Components.Model.ModelTypeList.Assembly));

            // Load Battery
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.BatteryModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.Battery));

            // Load Body
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.BodyModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.Body));

            // Load Device
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.DeviceModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.Device));

            // Load Flight Controller
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.FlightControllerModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.FlightController));

            // Load Motor
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.MotorModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.Motor));

            // Load Propeller
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.PropellerModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.Propeller));

            // Load Remote
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.RemoteModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.RC));

            // Load Speed Controller
            DocumentManager.LocalModelDocuments.AddRange(
                DocumentManager.LoadModelDocuments(Resources.SpeedControllerModelPath, Resources.ModelFileExtName, Components.Model.ModelTypeList.ESC));
        }
    }
}
