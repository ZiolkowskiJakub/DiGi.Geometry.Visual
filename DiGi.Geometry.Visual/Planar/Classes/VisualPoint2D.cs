using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents a visual representation of a 2D point, combining its geometric position with appearance properties.
    /// </summary>
    public class VisualPoint2D : Visual<Point2D, IPointAppearance>, IVisualPoint2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint2D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 2D point geometry.</param>
        /// <param name="appearance">The appearance settings for the point.</param>
        public VisualPoint2D(Point2D? geometry, IPointAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint2D"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual point data.</param>
        public VisualPoint2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint2D"/> class by copying another <see cref="VisualPoint2D"/> object.
        /// </summary>
        /// <param name="visualPoint2D">The source visual point to copy from.</param>
        public VisualPoint2D(VisualPoint2D? visualPoint2D)
            : base(visualPoint2D)
        {
        }
    }
}