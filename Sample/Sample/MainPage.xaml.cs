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
            };

            double GetRoundedLabelWidth(RelativeLayout parent) =>
                roundedLabelView.Measure(parent.Width, parent.Height).Request.Width + 80;

            double GetRoundedLabelHeight(RelativeLayout parent) =>
              roundedLabelView.Measure(parent.Width, parent.Height).Request.Height + 30;

            relativeLayout.Children.Add(
                         roundedLabelView,
                         Constraint.RelativeToParent(parent => parent.Width / 2 - (GetRoundedLabelWidth(parent)) / 2),
                          Constraint.Constant(0),//Constraint.RelativeToParent(parent => parent.Height / 2 - (GetRoundedLabelHeight(parent) + 30) / 2),
                         Constraint.RelativeToParent(layout => GetRoundedLabelWidth(layout))
                         //,Constraint.RelativeToParent(layout => GetRoundedLabelHeight(layout) + 30)
                         );
            relativeLayout.Padding = new Thickness(80,0);

            RoundedLabelView.Content = relativeLayout();

        RoundedLabelView.Content = new RoundedLabel
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
                };
        }
    }
}
