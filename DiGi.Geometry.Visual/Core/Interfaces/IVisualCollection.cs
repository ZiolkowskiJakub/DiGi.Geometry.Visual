using System.Collections;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IVisualCollection<T> : IVisualCollection where T: IVisual
    {
    }

    public interface IVisualCollection : IVisual, IEnumerable
    {

    }
}
