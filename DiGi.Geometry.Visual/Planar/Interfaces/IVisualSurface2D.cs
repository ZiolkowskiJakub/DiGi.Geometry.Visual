using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Represents a visual representation of a 2D surface.
    /// </summary>
    public interface IVisualSurface2D : IVisualSurface2D<ISurface2D>
    {
    }

    /// <summary>
    /// Represents a generic visual representation of a 2D surface.
    /// </summary>
    /// <typeparam name="T">The type of the 2D surface, which must implement <see cref="ISurface2D"/>.</typeparam>
    public interface IVisualSurface2D<T> : IVisual2D<T, ISurfaceAppearance> where T : ISurface2D
    {
    }
}