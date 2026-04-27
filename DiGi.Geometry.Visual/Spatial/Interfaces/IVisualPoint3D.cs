using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualPoint3D : IVisual3D<Point3D, IPointAppearance>, IGeometry3DObject<Point3D>
    {
    }
}