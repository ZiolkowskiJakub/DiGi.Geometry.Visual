using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents a base class for visual objects in the geometry system.
    /// </summary>
    public abstract class Visual : GuidObject, IVisual
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visual"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual data.</param>
        public Visual(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Visual"/> class by copying another visual object.
        /// </summary>
        /// <param name="visual">The source visual object to copy from.</param>
        public Visual(Visual? visual)
            : base(visual)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Visual"/> class.
        /// </summary>
        public Visual()
            : base()
        {
        }
    }

    /// <summary>
    /// Represents a generic base class for visual objects that combine a specific geometry and appearance.
    /// </summary>
    /// <typeparam name="T">The type of geometry, which must implement <see cref="IGeometry"/>.</typeparam>
    /// <typeparam name="X">The type of appearance, which must implement <see cref="IAppearance"/>.</typeparam>
    public abstract class Visual<T, X> : Visual, IVisual<T, X> where T : IGeometry where X : IAppearance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visual{T, X}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing visual data.</param>
        public Visual(JsonObject? jsonObject)
        : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Visual{T, X}"/> class by copying another visual object.
        /// </summary>
        /// <param name="visual">The source visual object to copy from.</param>
        public Visual(Visual<T, X>? visual)
            : base(visual)
        {
            if (visual is not null)
            {
                Geometry = visual.Geometry == null ? default : visual.Geometry.Clone<T>();
                Appearance = visual.Appearance == null ? default : visual.Appearance.Clone<X>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Visual{T, X}"/> class with specified geometry and appearance.
        /// </summary>
        /// <param name="geometry">The geometry to assign to the visual object.</param>
        /// <param name="appearance">The appearance to assign to the visual object.</param>
        public Visual(T? geometry, X? appearance)
            : base()
        {
            Geometry = geometry == null ? default : geometry.Clone<T>();
            Appearance = appearance == null ? default : appearance.Clone<X>();
        }

        /// <summary>
        /// Gets or sets the appearance of the visual object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Appearance"), Description("Appearance")]
        public virtual X? Appearance { get; set; }

        /// <summary>
        /// Gets or sets the geometry of the visual object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        public virtual T? Geometry { get; set; }
    }
}