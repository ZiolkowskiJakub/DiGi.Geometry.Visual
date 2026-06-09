using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 3D point, combining 3D visual properties with 3D geometry object characteristics.
    /// </summary>
    public interface IVisualPoint3D : IVisual3D<Point3D, IPointAppearance>, IGeometry3DObject<Point3D>
    {
    }
}