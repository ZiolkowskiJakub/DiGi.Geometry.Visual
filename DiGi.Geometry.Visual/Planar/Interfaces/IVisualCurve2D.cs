using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.Geometry.Visual.Planar.Interfaces
{
    public interface IVisualCurve2D : IVisualCurve2D<ICurve2D>
    {


    }

    public interface IVisualCurve2D<T> : IVisual2D<T, ICurveAppearance> where T : ICurve2D
    {


    }
}
