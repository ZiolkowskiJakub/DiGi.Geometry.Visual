using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 2D polygon, combining geometric properties with visual appearance attributes.
    /// </summary>
    public interface IVisualPolygon2D : IVisual2D<Polygon2D, ICurveAppearance>, IGeometry2DObject<Polygon2D>
    {
    }
}