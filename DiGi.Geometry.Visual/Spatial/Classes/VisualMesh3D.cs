using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Spatial.Classes
{
    public class VisualMesh3D : Visual<Mesh3D, IMeshAppearance>, IVisualMesh3D
    {
        public VisualMesh3D(Mesh3D? geometry, IMeshAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        public VisualMesh3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualMesh3D(VisualMesh3D? visualMesh3D)
            : base(visualMesh3D)
        {
        }
    }
}