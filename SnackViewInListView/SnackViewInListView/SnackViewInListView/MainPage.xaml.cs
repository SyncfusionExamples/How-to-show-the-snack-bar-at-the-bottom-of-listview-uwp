using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SnackViewInListView
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        protected override void OnSizeAllocated(double width, double height)
        {
            viewModel.ItemWidth = width;
            base.OnSizeAllocated(width, height);
        }
    }
}
