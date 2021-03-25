using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrotorDesigner.Components
{
    public partial class Model
    {
        // component motor class
        public class Motor : Base
        {
            public int KVValue;
            public double Diameter;
            public double StandbyCurrent;
            public double InternalResistance;
            public double MaxCurrent;
            public double MaxPower;

            public List<string> AdaptedPropellerModels;

            public Dictionary<string, VoltagePerformanceCurve> VoltagePerformanceCurvesByPropellers;

            public Motor() : base()
            {
                AdaptedPropellerModels = new List<string>();
                VoltagePerformanceCurvesByPropellers = new Dictionary<string, VoltagePerformanceCurve>();
                ModelType = ModelTypeList.Motor;
            }
        };
    }
}
