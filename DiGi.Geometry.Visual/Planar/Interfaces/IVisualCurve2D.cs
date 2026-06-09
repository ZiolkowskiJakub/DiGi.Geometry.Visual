using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Represents a visual 2D curve, providing a non-generic specialization of <see cref="IVisualCurve2D{T}"/> using <see cref="ICurve2D"/>.
    /// </summary>
    public interface IVisualCurve2D : IVisualCurve2D<ICurve2D>
    {
    }

    /// <summary>
    /// Defines the contract for a visual representation of a 2D curve.
    /// </summary>
    /// <typeparam name="T">The type of the underlying 2D curve, which must implement <see cref="ICurve2D"/>.</typeparam>
    public interface IVisualCurve2D<T> : IVisual2D<T, ICurveAppearance> where T : ICurve2D
    {
    }
}