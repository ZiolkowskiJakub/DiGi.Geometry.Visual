using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualPolygonal3D : IVisual3D<IPolygonal3D, ICurveAppearance>, IGeometry3DObject<IPolygonal3D>
    {
    }
}