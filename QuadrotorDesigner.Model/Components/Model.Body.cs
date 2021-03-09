using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component body class
        public class Body : Base
        {
            public double MaxPropellerPitch;

            public int RotorNumber;

            // space to attach devices under the body
            public Dimension BottomAreaSpace;

            // space to place the flight controller and battery
            public Dimension CentralBoxDimension;

            public double MaxLoadWeight;

            public List<string> AdaptedMotorModels;

            public Body() : base()
            {
                BottomAreaSpace = new Dimension();
                CentralBoxDimension = new Dimension();
                AdaptedMotorModels = new List<string>();
                ModelType = ModelTypeList.Body;
            }
        };
    }
}
