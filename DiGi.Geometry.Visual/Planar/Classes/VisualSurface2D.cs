using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents an abstract visual representation of a 2D surface.
    /// </summary>
    /// <typeparam name="T">The type of the geometry, which must implement <see cref="ISurface2D"/>.</typeparam>
    public abstract class VisualSurface2D<T> : Visual<T, ISurfaceAppearance>, IVisualSurface2D<T> where T : ISurface2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D{T}"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 2D surface geometry.</param>
        /// <param name="appearance">The visual appearance of the surface.</param>
        public VisualSurface2D(T? geometry, ISurfaceAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing surface data.</param>
        public VisualSurface2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D{T}"/> class by copying another visual surface.
        /// </summary>
        /// <param name="visualSurface2D">The source visual surface to copy from.</param>
        public VisualSurface2D(VisualSurface2D<T>? visualSurface2D)
            : base(visualSurface2D)
        {
        }
    }

    /// <summary>
    /// Represents a visual representation of a 2D surface using the generic <see cref="ISurface2D"/> interface.
    /// </summary>
    public class VisualSurface2D : VisualSurface2D<ISurface2D>, IVisualSurface2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The 2D surface geometry.</param>
        /// <param name="appearance">The visual appearance of the surface.</param>
        public VisualSurface2D(ISurface2D? geometry, ISurfaceAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing surface data.</param>
        public VisualSurface2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSurface2D"/> class by copying another visual surface.
        /// </summary>
        /// <param name="visualSurface2D">The source visual surface to copy from.</param>
        public VisualSurface2D(VisualSurface2D? visualSurface2D)
            : base(visualSurface2D)
        {
        }
    }
}