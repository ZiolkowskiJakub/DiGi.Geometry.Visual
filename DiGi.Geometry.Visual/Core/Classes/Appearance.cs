using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Core.Classes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public abstract class Appearance : SerializableObject, IAppearance
    {
        public Appearance(Color color)
            :base()
        {
            Color = color;
        }

        public Appearance(Appearance appearance)
            :base()
        {
            if (appearance != null)
            {
                Color = appearance.Color;
                Opacity = appearance.Opacity;
                Visible = appearance.Visible;
            }
        }

        public Appearance(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Color"), Description("Color")]
        public Color Color { get; set; }

        [JsonInclude, JsonPropertyName("Opacity"), Description("Opacity")]
        public double Opacity { get; set; } = 1;

        [JsonInclude, JsonPropertyName("Visible"), Description("Visible")]
        public bool Visible { get; set; } = true;
    }
}
