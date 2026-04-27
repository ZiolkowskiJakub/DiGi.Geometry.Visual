using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    public class VisualSegment3D : Visual<Segment3D, ICurveAppearance>, IVisualSegment3D
    {
        public VisualSegment3D(Segment3D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualSegment3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualSegment3D(VisualSegment3D? visualSegment3D)
            : base(visualSegment3D)
        {
        }
    }
}