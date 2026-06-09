using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    /// <summary>
    /// Represents a 3D mesh visualization that combines geometric data with visual appearance settings.
    /// </summary>
    public class VisualMesh3D : Visual<Mesh3D, IMeshAppearance>, IVisualMesh3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualMesh3D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 3D mesh geometry.</param>
        /// <param name="appearance">The visual appearance settings for the mesh.</param>
        public VisualMesh3D(Mesh3D? geometry, IMeshAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualMesh3D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the visualization data.</param>
        public VisualMesh3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualMesh3D"/> class by copying another <see cref="VisualMesh3D"/> instance.
        /// </summary>
        /// <param name="visualMesh3D">The source visual mesh to copy from.</param>
        public VisualMesh3D(VisualMesh3D? visualMesh3D)
            : base(visualMesh3D)
        {
        }
    }
}