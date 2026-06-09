using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance of a point, including its color and thickness.
    /// </summary>
    public class PointAppearance : Appearance, IPointAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointAppearance"/> class by copying another <see cref="PointAppearance"/> object.
        /// </summary>
        /// <param name="pointAppearance">The source appearance to copy from.</param>
        public PointAppearance(PointAppearance pointAppearance)
            : base(pointAppearance)
        {
            if (pointAppearance != null)
            {
                Thickness = pointAppearance.Thickness;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointAppearance"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing appearance data.</param>
        public PointAppearance(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointAppearance"/> class with specified color and thickness.
        /// </summary>
        /// <param name="color">The color of the point.</param>
        /// <param name="thickness">The thickness of the point.</param>
        public PointAppearance(Color color, double thickness)
            : base(color)
        {
            Thickness = thickness;
        }

        /// <summary>
        /// Gets or sets the thickness of the point.
        /// </summary>
        [JsonInclude, JsonPropertyName("Thickness"), Description("Thickness")]
        public double Thickness { get; set; }
    }
}