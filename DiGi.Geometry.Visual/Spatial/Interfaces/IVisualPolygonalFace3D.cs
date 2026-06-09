using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual representation of a 3D polygonal face, combining geometric properties and visual appearance.
    /// </summary>
    public interface IVisualPolygonalFace3D : IVisual3D<IPolygonalFace3D, IFaceAppearance>, IGeometry3DObject<IPolygonalFace3D>
    {
    }
}