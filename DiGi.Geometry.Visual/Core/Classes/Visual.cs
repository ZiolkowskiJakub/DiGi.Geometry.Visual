using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.ComponentModel;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;


namespace DiGi.Geometry.Visual.Core.Classes
{
    public abstract class Visual : UniqueObject, IVisual
    {
        public Visual(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Visual(Visual visual)
            : base(visual)
        {

        }

        public Visual()
            : base()
        {

        }
    }

    public abstract class Visual<T, X> : Visual, IVisual<T, X> where T : IGeometry where X : IAppearance
    {
        [JsonInclude, JsonPropertyName("Geometry"), Description("Geometry")]
        public virtual T Geometry { get; set; }

        [JsonInclude, JsonPropertyName("Appearance"), Description("Appearance")]
        public virtual X Appearance { get; set; }

        public Visual(JsonObject jsonObject)
        : base(jsonObject)
        {

        }

        public Visual(Visual visual)
            : base()
        {

        }

        public Visual(T geometry, X appearance)
            : base()
        {
            Geometry = geometry == null ? default : geometry.Clone<T>();
            Appearance = appearance == null ? default : appearance.Clone<X>();
        }
    }
}
