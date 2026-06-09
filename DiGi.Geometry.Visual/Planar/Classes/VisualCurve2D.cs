using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Visual.Planar.Classes
{
    /// <summary>
    /// Represents a visual representation of a 2D curve with associated appearance properties.
    /// </summary>
    /// <typeparam name="T">The type of the geometry, which must implement <see cref="ICurve2D"/>.</typeparam>
    public abstract class VisualCurve2D<T> : Visual<T, ICurveAppearance>, IVisualCurve2D<T> where T : ICurve2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D{T}"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The underlying 2D curve geometry.</param>
        /// <param name="appearance">The visual appearance settings for the curve.</param>
        public VisualCurve2D(T? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual curve data.</param>
        public VisualCurve2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D{T}"/> class by copying another <see cref="VisualCurve2D{T}"/> instance.
        /// </summary>
        /// <param name="visualCurve2D">The source visual curve to copy from.</param>
        public VisualCurve2D(VisualCurve2D<T>? visualCurve2D)
            : base(visualCurve2D)
        {
        }
    }

    /// <summary>
    /// Represents a visual representation of a 2D curve using the base <see cref="ICurve2D"/> interface.
    /// </summary>
    public class VisualCurve2D : VisualCurve2D<ICurve2D>, IVisualCurve2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The underlying 2D curve geometry.</param>
        /// <param name="appearance">The visual appearance settings for the curve.</param>
        public VisualCurve2D(ICurve2D? geometry, ICurveAppearance? appearance)
            : base(geometry, appearance)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual curve data.</param>
        public VisualCurve2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualCurve2D"/> class by copying another <see cref="VisualCurve2D"/> instance.
        /// </summary>
        /// <param name="visualCurve2D">The source visual curve to copy from.</param>
        public VisualCurve2D(VisualCurve2D? visualCurve2D)
            : base(visualCurve2D)
        {
        }
    }
}