using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 2D segment in a planar coordinate system.
    /// </summary>
    public interface IVisualSegment2D : IVisual2D<Segment2D, IPointAppearance>, IGeometry2DObject<Segment2D>
    {
    }
}