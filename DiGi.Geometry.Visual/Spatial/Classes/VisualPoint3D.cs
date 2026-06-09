using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    /// <summary>
    /// Represents a visual representation of a 3D point, combining its spatial geometry with appearance properties.
    /// </summary>
    public class VisualPoint3D : Visual<Point3D, IPointAppearance>, IVisualPoint3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint3D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 3D point geometry.</param>
        /// <param name="appearance">The visual appearance settings for the point.</param>
        public VisualPoint3D(Point3D? geometry, IPointAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint3D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the visual point.</param>
        public VisualPoint3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPoint3D"/> class by copying another <see cref="VisualPoint3D"/> instance.
        /// </summary>
        /// <param name="visualPoint2D">The source visual point to copy from.</param>
        public VisualPoint3D(VisualPoint3D? visualPoint2D)
            : base(visualPoint2D)
        {
        }
    }
}