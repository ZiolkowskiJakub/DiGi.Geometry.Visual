using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public class VisualPolygon2D : Visual<Polygon2D, ICurveAppearance>, IVisualPolygon2D
    {
        public VisualPolygon2D(Polygon2D geometry, ICurveAppearance appearance)
            :base(geometry, appearance)
        {

        }

        public VisualPolygon2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualPolygon2D(VisualPolygon2D visualPolygon2D)
            :base(visualPolygon2D)
        {

        }
    }
}
