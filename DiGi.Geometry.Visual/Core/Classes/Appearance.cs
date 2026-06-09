using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance properties of a geometry object, including color, opacity, and visibility.
    /// </summary>
    public abstract class Appearance : SerializableObject, IAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Appearance"/> class with a specified color.
        /// </summary>
        /// <param name="color">The color to assign to the appearance.</param>
        public Appearance(Color? color)
            : base()
        {
            Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appearance"/> class by copying properties from an existing appearance object.
        /// </summary>
        /// <param name="appearance">The source appearance object to copy from.</param>
        public Appearance(Appearance? appearance)
            : base()
        {
            if (appearance != null)
            {
                Color = appearance.Color;
                Opacity = appearance.Opacity;
                Visible = appearance.Visible;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Appearance"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the appearance data.</param>
        public Appearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the color of the appearance.
        /// </summary>
        [JsonInclude, JsonPropertyName("Color"), Description("Color")]
        public Color? Color { get; set; }

        /// <summary>
        /// Gets or sets the opacity of the appearance.
        /// </summary>
        [JsonInclude, JsonPropertyName("Opacity"), Description("Opacity")]
        public double Opacity { get; set; } = 1;

        /// <summary>
        /// Gets or sets a value indicating whether the appearance is visible.
        /// </summary>
        [JsonInclude, JsonPropertyName("Visible"), Description("Visible")]
        public bool Visible { get; set; } = true;
    }
}