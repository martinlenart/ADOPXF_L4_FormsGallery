using Xamarin.Forms;

namespace FormsGallery.Models
{
    public class NamedColor
    {
        public string Name { set; get; }
        public Color Color { set; get; }
        public override string ToString() => Name;
        public NamedColor() { }
        public NamedColor(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
