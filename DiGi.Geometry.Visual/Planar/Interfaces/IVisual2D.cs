using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines a 2D visual object that combines the characteristics of a visual element and a 2D geometry object.
    /// </summary>
    public interface IVisual2D : IVisual, IGeometry2DObject
    {
    }

    /// <summary>
    /// Defines a generic 2D visual object associated with a specific geometry type and appearance.
    /// </summary>
    /// <typeparam name="T">The type of the underlying 2D geometry.</typeparam>
    /// <typeparam name="X">The type of the appearance used for visualization.</typeparam>
    public interface IVisual2D<T, X> : IVisual2D, IVisual<T, X>, IGeometry2DObject<T> where T : IGeometry2D where X : IAppearance
    {
    }
}