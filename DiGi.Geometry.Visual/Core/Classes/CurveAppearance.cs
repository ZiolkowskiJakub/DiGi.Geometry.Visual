using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class CurveAppearance : PointAppearance, ICurveAppearance
    {
        public CurveAppearance(CurveAppearance curveAppearance)
            : base(curveAppearance)
        {
            if (PointAppearance is not null)
            {
                PointAppearance = DiGi.Core.Query.Clone(curveAppearance.PointAppearance);
            }
        }

        public CurveAppearance(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public CurveAppearance(Color color, double thickness)
            : base(color, thickness)
        {
        }

        [JsonInclude, JsonPropertyName("PointAppearance"), Description("Point Appearance")]
        public IPointAppearance? PointAppearance { get; set; }
    }
}