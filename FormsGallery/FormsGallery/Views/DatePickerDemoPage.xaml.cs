using System;
using Xamarin.Forms;

namespace FormsGallery.Views
{
    public partial class DatePickerDemoPage : ContentPage
    {
        public DatePickerDemoPage()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var dp = (DatePicker)sender;
            lblDate.Text = $"Date is: {dp.Date:F}";
        }
    }
}