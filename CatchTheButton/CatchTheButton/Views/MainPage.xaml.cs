using CatchTheButton.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CatchTheButton.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //tapMeButton.Clicked += OnTapMeButtonClicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var animation = new Animation(v => myLabel.Text = new string('.', (int)v), 1, 10);
            //animation.Commit(this, "TextAnimation", 16, 1000);
        }
        //async void OnTapMeButtonClicked(object sender, EventArgs e)
        //{
        //    var button = (Button)sender;
        //    var rnd = new Random();

        //    var x = rnd.Next((int)tapMeLayot.Width);
        //    var y = rnd.Next((int)tapMeLayot.Height);

        //    var translateTo = button.TranslateTo(x, y, 500);

        //    await button.ScaleTo(1.5, 250);
        //    await button.ScaleTo(1, 250);

        //    await button.RelRotateTo(360, 1000, Easing.SinIn);

        //    await translateTo;

        //    //AbsoluteLayout.SetLayoutBounds(button, new Rectangle(x, y, 150, 50));
        //}
    }
}
