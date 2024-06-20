using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System.Text.Json.Nodes;


namespace DiGi.Geometry.Visual.Planar.Classes
{
    public abstract class VisualCurve2D<T> : Visual<T, ICurveAppearance>, IVisualCurve2D<T> where T : ICurve2D
    {
        public VisualCurve2D(T geometry, ICurveAppearance appearance)
            :base(geometry, appearance)
        {

        }

        public VisualCurve2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualCurve2D(VisualCurve2D visualCurve2D)
            :base(visualCurve2D)
        {

        }
    }

    public class VisualCurve2D : VisualCurve2D<ICurve2D>, IVisualCurve2D
    {
        public VisualCurve2D(ICurve2D geometry, ICurveAppearance appearance)
            : base(geometry, appearance)
        {

        }

        public VisualCurve2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualCurve2D(VisualCurve2D visualCurve2D)
            : base(visualCurve2D)
        {

        }
    }
}
