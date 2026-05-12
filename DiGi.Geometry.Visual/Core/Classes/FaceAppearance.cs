using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class FaceAppearance : Appearance, IFaceAppearance
    {
        public FaceAppearance(FaceAppearance? faceAppearance)
            : base(faceAppearance)
        {
            if (faceAppearance is not null)
            {
                ExternalEdgeAppearance = DiGi.Core.Query.Clone(faceAppearance.ExternalEdgeAppearance);
                InternalEdgeAppearance = DiGi.Core.Query.Clone(faceAppearance.InternalEdgeAppearance);
            }
        }

        public FaceAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if (surfaceAppearance is not null)
            {
                ExternalEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
                InternalEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }
        }

        public FaceAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public FaceAppearance(Color surfaceColor, Color edgeColor, double edgeThickness)
            : base(surfaceColor)
        {
            ExternalEdgeAppearance = new CurveAppearance(edgeColor, edgeThickness);
            InternalEdgeAppearance = new CurveAppearance(edgeColor, edgeThickness);
        }

        [JsonInclude, JsonPropertyName("ExternalEdgeAppearance"), Description("External Edge Appearance")]
        public ICurveAppearance? ExternalEdgeAppearance { get; set; }

        [JsonInclude, JsonPropertyName("InternalEdgeAppearance"), Description("Internal Edge Appearance")]
        public ICurveAppearance? InternalEdgeAppearance { get; set; }
    }
}