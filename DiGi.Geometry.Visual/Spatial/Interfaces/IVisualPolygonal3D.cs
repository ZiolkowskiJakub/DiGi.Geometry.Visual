using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the interface for a visual 3D polygonal object, combining spatial geometry and visual appearance properties.
    /// </summary>
    public interface IVisualPolygonal3D : IVisual3D<IPolygonal3D, ICurveAppearance>, IGeometry3DObject<IPolygonal3D>
    {
    }
}