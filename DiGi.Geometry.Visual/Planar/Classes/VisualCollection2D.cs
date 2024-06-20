using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public class VisualCollection2D : VisualCollection<IVisual2D>
    {
        public VisualCollection2D(IEnumerable<IVisual2D> visual2Ds)
            :base(visual2Ds)
        {

        }

        public VisualCollection2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualCollection2D(VisualCollection2D visualCollection2D)
            :base(visualCollection2D)
        {

        }


    }
}
