using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var relativeLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var roundedLabelView = new RoundedLabel.FormsPlugin.Abstractions.RoundedLabel
            {
                TextColor = Color.White,
                CurvedBackgroundColor = Color.Black,
                Text = "RoundedLabel",
                RoundedCornerRadius = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 40,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            double GetRoundedLabelWidth(RelativeLayout parent) =>
                roundedLabelView.Measure(parent.Width, parent.Height).Request.Width;

            double GetRoundedLabelHeight(RelativeLayout parent) =>
              roundedLabelView.Measure(parent.Width, parent.Height).Request.Height;

            relativeLayout.Children.Add(
                         roundedLabelView,
                         Constraint.RelativeToParent(parent => parent.Width / 2 - (GetRoundedLabelWidth(parent) + 60) / 2),
                          Constraint.Constant(0),//Constraint.RelativeToParent(parent => parent.Height / 2 - (GetRoundedLabelHeight(parent) + 30) / 2),
                         Constraint.RelativeToParent(layout => GetRoundedLabelWidth(layout) + 60)
                         //,Constraint.RelativeToParent(layout => GetRoundedLabelHeight(layout) + 30)
                         );

            RoundedLabelView.Content = relativeLayout;
        }
    }
}
