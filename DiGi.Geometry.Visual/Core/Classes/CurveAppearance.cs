using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class CurveAppearance : PointAppearance
    {
        public CurveAppearance(CurveAppearance curveAppearance)
            :base(curveAppearance)
        {

        }

        public CurveAppearance(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public CurveAppearance(Color color, double thickness)
            : base(color, thickness)
        {

        }
    }
}
