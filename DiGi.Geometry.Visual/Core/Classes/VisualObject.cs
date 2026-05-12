using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Visual.Core.Classes
{
    public class VisualObject<TVisual, TSerializableObject> : GuidObject, IVisualObject<TVisual, TSerializableObject> where TVisual : IVisual where TSerializableObject : ISerializableObject
    {
        public VisualObject(TVisual? visual, TSerializableObject? @object)
            : base()
        {
            Object = @object;
            Visual = visual;
        }

        public VisualObject(TVisual? visual)
            : base()
        {
            Visual = visual;
        }

        public VisualObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public VisualObject(VisualObject<TVisual, TSerializableObject>? visualObject)
            : base(visualObject)
        {
            if (visualObject is not null)
            {
                Object = visualObject.Object;
                Visual = visualObject.Visual;
            }
        }

        public VisualObject()
            : base()
        {
        }

        [JsonInclude, JsonPropertyName("Object")]
        public TSerializableObject? Object { get; private set; }

        [JsonInclude, JsonPropertyName("Visual")]
        public TVisual? Visual { get; private set; }
    }
}