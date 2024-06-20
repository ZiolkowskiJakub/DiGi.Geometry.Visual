using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class PointAppearance : Appearance, IPointAppearance
    {
        public PointAppearance(PointAppearance pointAppearance)
            :base(pointAppearance)
        {
            if(pointAppearance != null)
            {
                Thickness = pointAppearance.Thickness;
            }
        }

        public PointAppearance(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public PointAppearance(Color color, double thickness)
            : base(color)
        {
            Thickness = thickness;
        }


        [JsonInclude, JsonPropertyName("Thickness"), Description("Thickness")]
        public double Thickness { get; set; }

    }
}
