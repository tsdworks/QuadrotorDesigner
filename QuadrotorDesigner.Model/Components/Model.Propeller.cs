using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component propeller class
        public class Propeller : Base
        {
            public double Diameter;

            public Propeller() : base()
            {
                ModelType = ModelTypeList.Propeller;
            }
        };
    }
}
