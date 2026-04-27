using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualMesh3D : IVisual3D<Mesh3D, IMeshAppearance>, IGeometry3DObject<Mesh3D>
    {
    }
}