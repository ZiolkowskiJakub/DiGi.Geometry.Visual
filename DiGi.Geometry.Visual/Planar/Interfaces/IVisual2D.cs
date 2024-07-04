using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisual2D : IVisual, IGeometry2DObject
    {
    }

    public interface IVisual2D<T, X> : IVisual2D, IVisual<T, X>, IGeometry2DObject<T> where T : IGeometry2D where X : IAppearance
    {
    }
}
