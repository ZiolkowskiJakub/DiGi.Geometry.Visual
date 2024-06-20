using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualSurface2D : IVisualSurface2D<ISurface2D>
    {

    }

    public interface IVisualSurface2D<T> : IVisual2D<T, ISurfaceAppearance> where T : ISurface2D
    {

    }
}
