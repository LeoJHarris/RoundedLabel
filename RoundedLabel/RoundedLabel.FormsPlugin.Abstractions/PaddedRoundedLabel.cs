using Xamarin.Forms;

namespace LeoJHarris.RoundedLabel.Plugin.Abstractions
{
    public class PaddedRoundedLabel : ContentView
    {
        public static readonly BindableProperty RoundedLabelVerticalPaddingBindableProperty =
       BindableProperty.Create(
           nameof(RoundedLabelVerticalPadding),
           typeof(int),
           typeof(PaddedRoundedLabel),
           5);

        public int RoundedLabelVerticalPadding
        {
            get { return (int)GetValue(RoundedLabelVerticalPaddingBindableProperty); }
            set { SetValue(RoundedLabelVerticalPaddingBindableProperty, value); }
        }

        public static readonly BindableProperty RoundedLabelHorizontalPaddingBindableProperty =
           BindableProperty.Create(
               nameof(RoundedLabelHorizontalPadding),
               typeof(int),
               typeof(PaddedRoundedLabel),
               5);

        public int RoundedLabelHorizontalPadding
        {
            get { return (int)GetValue(RoundedLabelHorizontalPaddingBindableProperty); }
            set { SetValue(RoundedLabelHorizontalPaddingBindableProperty, value); }
        }

        public PaddedRoundedLabel(RoundedLabel roundedLabel)
        {
            var relativeLayout = new RelativeLayout();

            double GetRoundedLabelWidth(RelativeLayout parent) =>
                roundedLabel.Measure(parent.Width, parent.Height).Request.Width;

            double GetRoundedLabelHeight(RelativeLayout parent) =>
              roundedLabel.Measure(parent.Width, parent.Height).Request.Height;

            relativeLayout.Children.Add(
                         roundedLabel,
                         Constraint.RelativeToParent(parent => parent.Width / 2
                         - (GetRoundedLabelWidth(parent) + RoundedLabelHorizontalPadding) / 2),
                          Constraint.RelativeToParent(parent => parent.Height / 2
                          - (GetRoundedLabelHeight(parent) + RoundedLabelVerticalPadding) / 2),
                         Constraint.RelativeToParent(layout => GetRoundedLabelWidth(layout) + RoundedLabelHorizontalPadding),
                         Constraint.RelativeToParent(layout => GetRoundedLabelHeight(layout) + RoundedLabelVerticalPadding));

            this.Content = relativeLayout;
        }
    }
}
