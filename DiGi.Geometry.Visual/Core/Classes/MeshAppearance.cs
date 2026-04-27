using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class MeshAppearance : Appearance, IMeshAppearance
    {
        [JsonInclude, JsonPropertyName("BoundaryEdgeAppearance"), Description("Boundary Edge Appearance")]
        public ICurveAppearance? BoundaryEdgeAppearance { get; set; }

        [JsonInclude, JsonPropertyName("AuxiliaryEdgeAppearance"), Description("Auxiliary Edge Appearance")]
        public ICurveAppearance? AuxiliaryEdgeAppearance { get; set; }

        public MeshAppearance(MeshAppearance? meshAppearance)
            : base(meshAppearance)
        {
            if(meshAppearance is not null)
            {
                BoundaryEdgeAppearance = DiGi.Core.Query.Clone(meshAppearance.BoundaryEdgeAppearance);
                AuxiliaryEdgeAppearance = DiGi.Core.Query.Clone(meshAppearance.AuxiliaryEdgeAppearance);
            }

        }

        public MeshAppearance(SurfaceAppearance? surfaceAppearance)
            : base(surfaceAppearance)
        {
            if(surfaceAppearance is not null)
            {
                BoundaryEdgeAppearance = DiGi.Core.Query.Clone(surfaceAppearance.CurveAppearance);
            }            
        }

        public MeshAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public MeshAppearance(Color surfaceColor, Color boundaryEdgeColor, double boundaryEdgeThickness)
            : base(surfaceColor)
        {
            BoundaryEdgeAppearance = new CurveAppearance(boundaryEdgeColor, boundaryEdgeThickness);
        }
    }
}