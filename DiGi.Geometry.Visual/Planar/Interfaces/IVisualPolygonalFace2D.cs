using DiGi.Geometry.Object.Planar.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 2D polygonal face.
    /// </summary>
    public interface IVisualPolygonalFace2D : IVisual2D<PolygonalFace2D, ISurfaceAppearance>, IGeometry2DObject<PolygonalFace2D>
    {
    }
}