using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class SurfaceAppearance : Appearance
    {
        [JsonInclude, JsonPropertyName("CurveAppearance"), Description("CurveAppearance")]
        public CurveAppearance CurveAppearance { get; set; }

        public SurfaceAppearance(SurfaceAppearance surfaceAppearance)
            :base(surfaceAppearance)
        {

        }

        public SurfaceAppearance(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public SurfaceAppearance(Color surfaceColor, Color curveColor, double curveThickness)
            : base(surfaceColor)
        {
            CurveAppearance = new CurveAppearance(curveColor, curveThickness);
        }
    }
}
