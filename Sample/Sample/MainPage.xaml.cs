using LeoJHarris.RoundedLabel.Plugin.Abstractions;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            OnlyRoundedLabelView.Content = new RoundedLabel
            {
                TextColor = Color.White,
                CurvedBackgroundColor = Color.Red,
                Text = "RoundedLabel",
                RoundedCornerRadius = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
               // HeightRequest = 0,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            }; ;

            RoundedLabelViewInsideCustomContentView.Content =
                new PaddedRoundedLabel(new RoundedLabel
                {
                    TextColor = Color.White,
                    CurvedBackgroundColor = Color.Black,
                    Text = "RoundedLabel in custom ContentView",
                    RoundedCornerRadius = 20,
                    HorizontalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontSize = 15,
                    FontAttributes = FontAttributes.Bold
                })
                {
                    RoundedLabelHorizontalPadding = 20,
                    RoundedLabelVerticalPadding = 40
                };
        }
    }
}
