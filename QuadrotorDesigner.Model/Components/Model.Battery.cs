using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component battery class
        public class Battery : Base
        {
            public double Capacity;
            public int CRating;
            public double TypicalVoltage;

            public Battery() : base()
            {
                ModelType = ModelTypeList.Battery;
            }
        };
    }
}
