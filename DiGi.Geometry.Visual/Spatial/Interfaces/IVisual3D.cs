using DiGi.Geometry.Object.Spatial.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    /// <summary>
    /// Defines a 3D visual object that combines visual properties and 3D spatial geometry.
    /// </summary>
    public interface IVisual3D : IVisual, IGeometry3DObject
    {
    }

    /// <summary>
    /// Defines a generic 3D visual object with specific types for its geometry and appearance.
    /// </summary>
    /// <typeparam name="T">The type of the 3D geometry.</typeparam>
    /// <typeparam name="X">The type of the appearance.</typeparam>
    public interface IVisual3D<T, X> : IVisual3D, IVisual<T, X>, IGeometry3DObject<T> where T : IGeometry3D where X : IAppearance
    {
    }
}