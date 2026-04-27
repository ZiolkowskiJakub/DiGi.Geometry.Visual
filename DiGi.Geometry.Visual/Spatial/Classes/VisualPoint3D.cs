using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    public class VisualPoint3D : Visual<Point3D, IPointAppearance>, IVisualPoint3D
    {
        public VisualPoint3D(Point3D? geometry, IPointAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualPoint3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualPoint3D(VisualPoint3D? visualPoint2D)
            : base(visualPoint2D)
        {
        }
    }
}