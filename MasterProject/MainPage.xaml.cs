using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using $safeprojectname$;
using Xamarin.Forms;

namespace $safeprojectname$
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {


            InitializeComponent();

            var config = MasterConfig.Root;
            //label.Text = config.Title;
            label.Text = config.Title;

        }
    }
}
