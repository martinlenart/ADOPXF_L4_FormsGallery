using Xamarin.Forms;

namespace FormsGallery.Views
{
    public partial class CheckBoxPage : ContentPage
    {
        public CheckBoxPage()
        {
            InitializeComponent();
        }

        private void checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var chkbx = (CheckBox)sender;
            lblAlternative.Text = $"Checkbox is now: {chkbx.IsChecked}";
        }
    }
}
