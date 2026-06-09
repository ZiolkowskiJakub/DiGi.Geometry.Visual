using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    /// <summary>Represents a visual representation of a 3D polygonal face, combining its geometry and appearance.</summary>
    public class VisualPolygonalFace3D : Visual<IPolygonalFace3D, IFaceAppearance>, IVisualPolygonalFace3D
    {
        /// <summary>Initializes a new instance of the <see cref="VisualPolygonalFace3D"/> class with specified geometry and appearance.</summary>
        /// <param name="geometry">The 3D polygonal face geometry.</param>
        /// <param name="appearance">The appearance settings for the face.</param>
        public VisualPolygonalFace3D(IPolygonalFace3D? geometry, IFaceAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="VisualPolygonalFace3D"/> class from a <see cref="JsonObject"/>.</summary>
        /// <param name="jsonObject">The JSON object containing the visual polygonal face data.</param>
        public VisualPolygonalFace3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="VisualPolygonalFace3D"/> class by copying another <see cref="VisualPolygonalFace3D"/> object.</summary>
        /// <param name="visualPolygonalFace3D">The source visual polygonal face to copy from.</param>
        public VisualPolygonalFace3D(VisualPolygonalFace3D? visualPolygonalFace3D)
            : base(visualPolygonalFace3D)
        {
        }
    }
}