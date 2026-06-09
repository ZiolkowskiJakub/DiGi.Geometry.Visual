using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance settings for a mesh, including surface and edge properties.
    /// </summary>
    public class MeshAppearance : Appearance, IMeshAppearance
    {
        /// <summary>
        /// Gets or sets the appearance of the boundary edges of the mesh.
        /// </summary>
        [JsonInclude, JsonPropertyName("BoundaryEdgeAppearance"), Description("Boundary Edge Appearance")]
        public ICurveAppearance? BoundaryEdgeAppearance { get; set; }

        /// <summary>
        /// Gets or sets the appearance of the auxiliary edges of the mesh.
        /// </summary>
        [JsonInclude, JsonPropertyName("AuxiliaryEdgeAppearance"), Description("Auxiliary Edge Appearance")]
        public ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAppearance"/> class by cloning an existing mesh appearance.
        /// </summary>
        /// <param name="meshAppearance">The source mesh appearance to copy from.</param>
        public MeshAppearance(MeshAppearance? meshAppearance)
            : base(meshAppearance)
        {
            if (meshAppearance is not null)
            {
                BoundaryEdgeAppearance = DiGi.Core.Query.Clone(meshAppearance.BoundaryEdgeAppearance);
                AuxiliaryEdgeAppearance = DiGi.Core.Query.Clone(meshAppearance.AuxiliaryEdgeAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAppearance"/> class based on a surface appearance.
        /// </summary>
        /// <param name="surfaceAppearance">The source surface appearance to copy from.</param>
        public MeshAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if (surfaceAppearance is not null)
            {
                BoundaryEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAppearance"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing appearance data.</param>
        public MeshAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeshAppearance"/> class with specified surface color and boundary edge properties.
        /// </summary>
        /// <param name="surfaceColor">The color of the mesh surface.</param>
        /// <param name="boundaryEdgeColor">The color of the boundary edges.</param>
        /// <param name="boundaryEdgeThickness">The thickness of the boundary edges.</param>
        public MeshAppearance(Color surfaceColor, Color boundaryEdgeColor, double boundaryEdgeThickness)
            : base(surfaceColor)
        {
            BoundaryEdgeAppearance = new CurveAppearance(boundaryEdgeColor, boundaryEdgeThickness);
        }
    }
}