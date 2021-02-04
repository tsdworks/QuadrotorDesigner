using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component flight controller class
        public class FlightController : Base
        {
            public double MCUFrequency;
            public IONumber IO;

            public FlightController() : base()
            {
                IO = new IONumber();
                ModelType = ModelTypeList.FlightController;
            }
        };
    }
}
