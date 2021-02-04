using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component esc speed controller class
        public class SpeedController : Base
        {
            public double MaxOutputCurrent;
            public double MaxInputVoltage;

            public SpeedController() : base()
            {
                ModelType = ModelTypeList.ESC;
            }
        };
    }
}
