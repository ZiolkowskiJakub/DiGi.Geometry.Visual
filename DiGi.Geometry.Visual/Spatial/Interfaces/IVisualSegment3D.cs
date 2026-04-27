using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualSegment3D : IVisual3D<Segment3D, ICurveAppearance>, IGeometry3DObject<Segment3D>
    {
    }
}