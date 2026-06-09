using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the interface for a visual representation of a 3D segment, combining spatial geometry properties with visual appearance attributes.
    /// </summary>
    public interface IVisualSegment3D : IVisual3D<Segment3D, ICurveAppearance>, IGeometry3DObject<Segment3D>
    {
    }
}