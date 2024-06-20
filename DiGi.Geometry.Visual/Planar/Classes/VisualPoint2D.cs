using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public class VisualPoint2D : Visual<Point2D, IPointAppearance>, IVisualPoint2D
    {
        public VisualPoint2D(Point2D geometry, IPointAppearance appearance)
            :base(geometry, appearance)
        {

        }

        public VisualPoint2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualPoint2D(VisualPoint2D visualPoint2D)
            :base(visualPoint2D)
        {

        }
    }
}
