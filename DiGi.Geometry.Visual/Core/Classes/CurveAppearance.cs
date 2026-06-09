using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance settings for a curve, extending point appearance properties.
    /// </summary>
    public class CurveAppearance : PointAppearance, ICurveAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurveAppearance"/> class by copying values from another <see cref="CurveAppearance"/> instance.
        /// </summary>
        /// <param name="curveAppearance">The source curve appearance to copy from.</param>
        public CurveAppearance(CurveAppearance curveAppearance)
            : base(curveAppearance)
        {
            if (PointAppearance is not null)
            {
                PointAppearance = DiGi.Core.Query.Clone(curveAppearance.PointAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveAppearance"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the appearance data.</param>
        public CurveAppearance(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurveAppearance"/> class with specified color and thickness.
        /// </summary>
        /// <param name="color">The color of the curve.</param>
        /// <param name="thickness">The line thickness of the curve.</param>
        public CurveAppearance(Color color, double thickness)
            : base(color, thickness)
        {
        }

        /// <summary>
        /// Gets or sets the appearance settings for points associated with the curve.
        /// </summary>
        [JsonInclude, JsonPropertyName("PointAppearance"), Description("Point Appearance")]
        public IPointAppearance? PointAppearance { get; set; }
    }
}