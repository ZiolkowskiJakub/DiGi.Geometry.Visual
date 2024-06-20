using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisual2D : IVisual
    {
    }

    public interface IVisual2D<T, X> : IVisual2D, IVisual<T, X> where T : IGeometry2D where X : IAppearance
    {
    }
}
