using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EFL_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentAdd : ContentPage
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private async void addToDatabase_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstnameEntry.Text) && !string.IsNullOrWhiteSpace(lastnameEntry.Text))
            {
                await App.Database.SaveStudentAsync(new Student()
                {
                    FirstName = firstnameEntry.Text,
                    LastName = lastnameEntry.Text
                });
                await Navigation.PopAsync(true);
            }
        }
    }
}