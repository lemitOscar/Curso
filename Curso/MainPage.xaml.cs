using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Curso
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(1990,1,1);
            dtp.MaximumDate = new DateTime(2021,1,1);
            dtp.DateSelected += Dtp_DateSelected;
        }

        private void Dtp_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("fecha",e.NewDate.ToString(),"ok");
        }
    }
}
