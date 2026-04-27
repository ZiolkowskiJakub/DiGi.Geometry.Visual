using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    public class VisualSegment2D : Visual<Segment2D, IPointAppearance>, IVisualSegment2D
    {
        public VisualSegment2D(Segment2D? geometry, IPointAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualSegment2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualSegment2D(VisualSegment2D? visualSegment2D)
            : base(visualSegment2D)
        {
        }
    }
}