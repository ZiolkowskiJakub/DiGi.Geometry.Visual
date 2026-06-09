using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the base contract for an object that can be visually represented.
    /// </summary>
    public interface IVisualObject : IGuidObject
    {
    }

    /// <summary>
    /// Defines a contract for an object associated with a specific type of visual representation.
    /// </summary>
    /// <typeparam name="TVisual">The type of the visual representation, which must implement <see cref="IVisual"/>.</typeparam>
    public interface IVisualObject<TVisual> : IVisualObject where TVisual : IVisual
    {
        /// <summary>
        /// Gets the visual representation associated with this object.
        /// </summary>
        public TVisual? Visual { get; }
    }

    /// <summary>
    /// Defines a contract for an object that associates a specific type of visual representation with a serializable data object.
    /// </summary>
    /// <typeparam name="TVisual">The type of the visual representation, which must implement <see cref="IVisual"/>.</typeparam>
    /// <typeparam name="TSerializableObject">The type of the serializable object, which must implement <see cref="ISerializableObject"/>.</typeparam>
    public interface IVisualObject<TVisual, TSerializableObject> : IVisualObject<TVisual> where TVisual : IVisual where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Gets the serializable data object associated with this visual object.
        /// </summary>
        public TSerializableObject? Object { get; }
    }
}