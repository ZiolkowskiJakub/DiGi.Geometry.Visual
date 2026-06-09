using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 2D point, combining geometric properties with visual appearance.
    /// </summary>
    public interface IVisualPoint2D : IVisual2D<Point2D, IPointAppearance>, IGeometry2DObject<Point2D>
    {
    }
}