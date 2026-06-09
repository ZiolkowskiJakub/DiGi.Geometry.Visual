using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Visual.Core.Interfaces
{
    /// <summary>
    /// Defines the visual appearance properties for a geometry object.
    /// </summary>
    public interface IAppearance : ISerializableObject
    {
        /// <summary>
        /// Gets or sets the color of the object.
        /// </summary>
        public DiGi.Core.Classes.Color? Color { get; set; }

        /// <summary>
        /// Gets or sets the opacity level of the object.
        /// </summary>
        public double Opacity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the object is visible.
        /// </summary>
        public bool Visible { get; set; }
    }
}