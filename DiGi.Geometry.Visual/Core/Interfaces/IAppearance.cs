using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    public interface IAppearance : ISerializableObject
    {
        public DiGi.Core.Classes.Color Color { get; set; }

        public double Opacity { get; set; }

        public bool Visible { get; set; }
    }
}
