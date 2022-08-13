using System;
using System.Reflection;
using Xamarin.Forms;

namespace FormsGallery.Views
{
    public partial class PickerDemoPage : ContentPage
    {
        public PickerDemoPage()
        {
            InitializeComponent();
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;

            string colorName = (string) picker.SelectedItem;

            //Use reflection as Color does not have a Parse() Method
            FieldInfo colorField = typeof(Color).GetRuntimeField(colorName);
            boxView.Color = (Color)(colorField.GetValue(null));

            /*
            if (picker.SelectedIndex == -1)
            {
                boxView.Color = Color.Default;
            }
            else
            {
                string colorName = picker.Items[picker.SelectedIndex];
                
                //Use reflection as Color does not have a Parse() Method
                FieldInfo colorField = typeof(Color).GetRuntimeField(colorName);
                boxView.Color = (Color)(colorField.GetValue(null));
            }
            */
        }
    }
}