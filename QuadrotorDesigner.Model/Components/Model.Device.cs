using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component device class
        public class Device : Base
        {
            public enum DeviceBodyAttachLocation
            { Top = 0, Bottom = 1, None = 2 };

            public IONumber IORequests;
            public double Power;
            public DeviceBodyAttachLocation BodyAttachLocation;

            public string DeviceName;
            public Dictionary<string, string> Parameters;

            public Device() : base()
            {
                IORequests = new IONumber();
                BodyAttachLocation = DeviceBodyAttachLocation.None;
                Parameters = new Dictionary<string, string>();
                ModelType = ModelTypeList.Device;
            }
        };
    }
}
