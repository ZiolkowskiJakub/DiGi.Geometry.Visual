using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines the contract for a visual 3D mesh object, combining spatial geometry properties of a <see cref="Mesh3D"/> with its visual appearance.
    /// </summary>
    public interface IVisualMesh3D : IVisual3D<Mesh3D, IMeshAppearance>, IGeometry3DObject<Mesh3D>
    {
    }
}