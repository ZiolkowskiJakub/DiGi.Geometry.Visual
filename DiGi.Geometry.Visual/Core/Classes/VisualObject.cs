using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Core.Classes
{
    public class VisualObject<T> : GuidObject where T: IVisual
    {
        public T Visual { get; set; }

        public VisualObject(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public VisualObject(VisualObject<T> visualObject)
            : base(visualObject)
        {

        }

        public VisualObject()
            : base()
        {

        }
    }
}
