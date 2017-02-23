using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlAppExample
{
	public partial class MainPage : ContentPage
	{
        static string[] possibleHexes = {"30BCED", "FFFAFF", "FC5130", "102B3F"};

		public MainPage()
		{
            InitializeComponent();
            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 20,
                Padding = 10,
                Children =
                {
                   IAmText,
                   clickMe
                }
            };

            clickMe.Clicked += IWasClicked;
		}

        private void IWasClicked(object sender, EventArgs e)
        {
            IAmText.BackgroundColor = Color.FromHex(GiveRandomColor());
        }

        private string GiveRandomColor()
        {
            return possibleHexes[GiveRandomNumber()];
        }

        private int GiveRandomNumber()
        {
            return ((new Random()).Next(0, possibleHexes.Length));
        }
    }
}
