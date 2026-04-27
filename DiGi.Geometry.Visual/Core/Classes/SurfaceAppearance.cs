using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class SurfaceAppearance : Appearance, ISurfaceAppearance
    {
        public SurfaceAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if (surfaceAppearance is not null)
            {
                CurveAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }

        }

        public SurfaceAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public SurfaceAppearance(Color surfaceColor, Color curveColor, double curveThickness)
            : base(surfaceColor)
        {
            CurveAppearance = new CurveAppearance(curveColor, curveThickness);
        }

        [JsonInclude, JsonPropertyName("CurveAppearance"), Description("Curve Appearance")]
        public ICurveAppearance? CurveAppearance { get; set; }
    }
}