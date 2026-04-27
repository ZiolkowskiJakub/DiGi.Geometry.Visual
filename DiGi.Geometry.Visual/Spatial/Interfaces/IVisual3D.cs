using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisual3D : IVisual, IGeometry3DObject
    {
    }

    public interface IVisual3D<T, X> : IVisual3D, IVisual<T, X>, IGeometry3DObject<T> where T : IGeometry3D where X : IAppearance
    {
    }
}