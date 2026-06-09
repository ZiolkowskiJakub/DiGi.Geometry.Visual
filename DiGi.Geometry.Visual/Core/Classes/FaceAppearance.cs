using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents the visual appearance of a face, including surface and edge properties.
    /// </summary>
    public class FaceAppearance : Appearance, IFaceAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAppearance"/> class by cloning another <see cref="FaceAppearance"/> object.
        /// </summary>
        /// <param name="faceAppearance">The source face appearance to copy from.</param>
        public FaceAppearance(FaceAppearance? faceAppearance)
            : base(faceAppearance)
        {
            if (faceAppearance is not null)
            {
                ExternalEdgeAppearance = DiGi.Core.Query.Clone(faceAppearance.ExternalEdgeAppearance);
                InternalEdgeAppearance = DiGi.Core.Query.Clone(faceAppearance.InternalEdgeAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAppearance"/> class based on a <see cref="SurfaceAppearance"/>.
        /// </summary>
        /// <param name="surfaceAppearance">The source surface appearance to derive settings from.</param>
        public FaceAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if (surfaceAppearance is not null)
            {
                ExternalEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
                InternalEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAppearance"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing appearance data.</param>
        public FaceAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAppearance"/> class with specified surface color, edge color, and edge thickness.
        /// </summary>
        /// <param name="surfaceColor">The color of the face surface.</param>
        /// <param name="edgeColor">The color of the edges.</param>
        /// <param name="edgeThickness">The thickness of the edges.</param>
        public FaceAppearance(Color surfaceColor, Color edgeColor, double edgeThickness)
            : base(surfaceColor)
        {
            ExternalEdgeAppearance = new CurveAppearance(edgeColor, edgeThickness);
            InternalEdgeAppearance = new CurveAppearance(edgeColor, edgeThickness);
        }

        /// <summary>
        /// Gets or sets the appearance of the external edges of the face.
        /// </summary>
        [JsonInclude, JsonPropertyName("ExternalEdgeAppearance"), Description("External Edge Appearance")]
        public ICurveAppearance? ExternalEdgeAppearance { get; set; }

        /// <summary>
        /// Gets or sets the appearance of the internal edges of the face.
        /// </summary>
        [JsonInclude, JsonPropertyName("InternalEdgeAppearance"), Description("Internal Edge Appearance")]
        public ICurveAppearance? InternalEdgeAppearance { get; set; }
    }
}