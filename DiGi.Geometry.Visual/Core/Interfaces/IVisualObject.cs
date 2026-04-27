using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IVisualObject : IGuidObject
    {

    }

    public interface IVisualObject<TVisual> : IVisualObject where TVisual : IVisual
    {
        public TVisual? Visual { get; }
    }

    public interface IVisualObject<TVisual, TSerializableObject> : IVisualObject<TVisual> where TVisual : IVisual where TSerializableObject : ISerializableObject
    {
        public TSerializableObject? Object { get; }
    }
}