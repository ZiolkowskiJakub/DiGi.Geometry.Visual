using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance of a surface, including its color and the appearance of its boundary curves.
    /// </summary>
    public class SurfaceAppearance : Appearance, ISurfaceAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAppearance"/> class by cloning an existing surface appearance.
        /// </summary>
        /// <param name="surfaceAppearance">The source surface appearance to copy from.</param>
        public SurfaceAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if (surfaceAppearance is not null)
            {
                CurveAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAppearance"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing surface appearance data.</param>
        public SurfaceAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceAppearance"/> class with specified colors and curve thickness.
        /// </summary>
        /// <param name="surfaceColor">The color of the surface.</param>
        /// <param name="curveColor">The color of the boundary curves.</param>
        /// <param name="curveThickness">The thickness of the boundary curves.</param>
        public SurfaceAppearance(Color surfaceColor, Color curveColor, double curveThickness)
            : base(surfaceColor)
        {
            CurveAppearance = new CurveAppearance(curveColor, curveThickness);
        }

        /// <summary>
        /// Gets or sets the appearance settings for the curves associated with the surface.
        /// </summary>
        [JsonInclude, JsonPropertyName("CurveAppearance"), Description("Curve Appearance")]
        public ICurveAppearance? CurveAppearance { get; set; }
    }
}