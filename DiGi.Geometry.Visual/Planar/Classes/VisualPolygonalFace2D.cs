using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents a visual representation of a polygonal face in 2D space, combining its geometric definition with surface appearance properties.
    /// </summary>
    public class VisualPolygonalFace2D : Visual<PolygonalFace2D, ISurfaceAppearance>, IVisualPolygonalFace2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonalFace2D"/> class with the specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The polygonal face geometry.</param>
        /// <param name="appearance">The surface appearance to be applied to the face.</param>
        public VisualPolygonalFace2D(PolygonalFace2D? geometry, ISurfaceAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonalFace2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for the visual polygonal face.</param>
        public VisualPolygonalFace2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualPolygonalFace2D"/> class by copying an existing visual polygonal face.
        /// </summary>
        /// <param name="visualPolygon2D">The source visual polygonal face to copy from.</param>
        public VisualPolygonalFace2D(VisualPolygonalFace2D? visualPolygon2D)
            : base(visualPolygon2D)
        {
        }
    }
}