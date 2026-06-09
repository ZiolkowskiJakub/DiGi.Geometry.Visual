using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents a visual representation of a 2D polygon, combining its geometric definition with appearance properties.
    /// </summary>
    public class VisualPolygon2D : Visual<Polygon2D, ICurveAppearance>, IVisualPolygon2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygon2D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 2D polygon geometry.</param>
        /// <param name="appearance">The curve appearance settings.</param>
        public VisualPolygon2D(Polygon2D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygon2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual polygon data.</param>
        public VisualPolygon2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygon2D"/> class by copying another <see cref="VisualPolygon2D"/> object.
        /// </summary>
        /// <param name="visualPolygon2D">The source visual polygon to copy from.</param>
        public VisualPolygon2D(VisualPolygon2D? visualPolygon2D)
            : base(visualPolygon2D)
        {
        }
    }
}