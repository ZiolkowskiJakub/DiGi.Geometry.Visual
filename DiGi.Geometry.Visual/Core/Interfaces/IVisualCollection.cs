using System.Collections;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Represents a strongly-typed collection of visual elements.
    /// </summary>
    /// <typeparam name="T">The type of visual elements in the collection, which must implement <see cref="IVisual"/>.</typeparam>
    public interface IVisualCollection<T> : IVisualCollection where T : IVisual
    {
    }

    /// <summary>
    /// Represents a collection of visual elements.
    /// </summary>
    public interface IVisualCollection : IVisual, IEnumerable
    {
    }
}