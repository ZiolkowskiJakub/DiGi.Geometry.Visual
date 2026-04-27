using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    public class VisualPolygonal3D : Visual<IPolygonal3D, ICurveAppearance>, IVisualPolygonal3D
    {
        public VisualPolygonal3D(Polygon3D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualPolygonal3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualPolygonal3D(VisualPolygonal3D? visualPolygonal3D)
            : base(visualPolygonal3D)
        {
        }
    }
}