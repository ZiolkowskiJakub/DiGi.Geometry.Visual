using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    /// <summary>
    /// Represents a visual representation of a 3D polygonal geometry with associated curve appearance.
    /// </summary>
    public class VisualPolygonal3D : Visual<IPolygonal3D, ICurveAppearance>, IVisualPolygonal3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonal3D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 3D polygon geometry.</param>
        /// <param name="appearance">The curve appearance settings.</param>
        public VisualPolygonal3D(Polygon3D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonal3D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the visual polygonal data.</param>
        public VisualPolygonal3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonal3D"/> class by copying an existing instance.
        /// </summary>
        /// <param name="visualPolygonal3D">The source visual polygonal object to copy from.</param>
        public VisualPolygonal3D(VisualPolygonal3D? visualPolygonal3D)
            : base(visualPolygonal3D)
        {
        }
    }
}