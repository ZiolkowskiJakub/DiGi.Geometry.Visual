using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    /// <summary>
    /// Represents a generic visual object that pairs a visual representation with a serializable data object.
    /// </summary>
    /// <typeparam name="TVisual">The type of the visual component, which must implement <see cref="IVisual"/>.</typeparam>
    /// <typeparam name="TSerializableObject">The type of the serializable object, which must implement <see cref="ISerializableObject"/>.</typeparam>
    public class VisualObject<TVisual, TSerializableObject> : GuidObject, IVisualObject<TVisual, TSerializableObject> where TVisual : IVisual where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualObject{TVisual, TSerializableObject}"/> class with a specified visual and serializable object.
        /// </summary>
        /// <param name="visual">The visual component associated with this object.</param>
        /// <param name="object">The serializable data object associated with this object.</param>
        public VisualObject(TVisual? visual, TSerializableObject? @object)
            : base()
        {
            Object = @object;
            Visual = visual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualObject{TVisual, TSerializableObject}"/> class with a specified visual.
        /// </summary>
        /// <param name="visual">The visual component associated with this object.</param>
        public VisualObject(TVisual? visual)
            : base()
        {
            Visual = visual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualObject{TVisual, TSerializableObject}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public VisualObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualObject{TVisual, TSerializableObject}"/> class by copying another visual object.
        /// </summary>
        /// <param name="visualObject">The source visual object to copy from.</param>
        public VisualObject(VisualObject<TVisual, TSerializableObject>? visualObject)
            : base(visualObject)
        {
            if (visualObject is not null)
            {
                Object = visualObject.Object;
                Visual = visualObject.Visual;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualObject{TVisual, TSerializableObject}"/> class.
        /// </summary>
        public VisualObject()
            : base()
        {
        }

        /// <summary>
        /// Gets the serializable data object associated with this visual object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Object")]
        public TSerializableObject? Object { get; private set; }

        /// <summary>
        /// Gets the visual component associated with this visual object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Visual")]
        public TVisual? Visual { get; private set; }
    }
}