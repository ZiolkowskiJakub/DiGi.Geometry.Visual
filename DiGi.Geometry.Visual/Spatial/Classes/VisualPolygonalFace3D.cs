using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    public class VisualPolygonalFace3D : Visual<IPolygonalFace3D, IFaceAppearance>, IVisualPolygonalFace3D
    {
        public VisualPolygonalFace3D(IPolygonalFace3D? geometry, IFaceAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualPolygonalFace3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualPolygonalFace3D(VisualPolygonalFace3D? visualPolygonalFace3D)
            : base(visualPolygonalFace3D)
        {
        }
    }
}