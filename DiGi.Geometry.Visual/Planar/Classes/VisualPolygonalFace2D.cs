using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public class VisualPolygonalFace2D : Visual<PolygonalFace2D, ISurfaceAppearance>, IVisualPolygonalFace2D
    {
        public VisualPolygonalFace2D(PolygonalFace2D geometry, ISurfaceAppearance appearance)
            :base(geometry, appearance)
        {

        }

        public VisualPolygonalFace2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualPolygonalFace2D(VisualPolygonalFace2D visualPolygon2D)
            :base(visualPolygon2D)
        {

        }
    }
}
