using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Object.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for a visual object associated with a specific geometry type and appearance type.
    /// </summary>
    /// <typeparam name="T">The type of the underlying geometry, which must implement <see cref="IGeometry"/>.</typeparam>
    /// <typeparam name="X">The type of the appearance, which must implement <see cref="IAppearance"/>.</typeparam>
    public interface IVisual<T, X> : IVisual, IGeometryObject<T> where T : IGeometry where X : IAppearance
    {
        /// <summary>
        /// Gets or sets the visual appearance of the object.
        /// </summary>
        X? Appearance { get; set; }
    }

    /// <summary>
    /// Defines a contract for an object that can be visually represented within the geometry system.
    /// </summary>
    public interface IVisual : IGuidObject, IGeometryObject
    {
    }
}