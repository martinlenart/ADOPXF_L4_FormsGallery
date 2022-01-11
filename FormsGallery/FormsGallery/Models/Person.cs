using System;
using Xamarin.Forms;

namespace FormsGallery.Models
{
    public class Person
    {
        public string Name { set; get; }
        public DateTime Birthday { set; get; }
        public Color FavoriteColor { set; get; }

        public Person() { }
        public Person(string name, DateTime birthday, Color favoriteColor)
        {
            Name = name;
            Birthday = birthday;
            FavoriteColor = favoriteColor;
        }
    }
}
