using System;
using Xamarin.Forms;

namespace LeoJHarris.RoundedLabel.Plugin.Abstractions
{
    /// <summary>
    /// RoundedLabel Interface
    /// </summary>
    public class RoundedLabel : Label
    {
        public static readonly BindableProperty RoundedCornerRadiusBindableProperty =
      BindableProperty.Create(
          nameof(RoundedCornerRadius),
          typeof(double),
          typeof(RoundedLabel),
          12.0);

        public double RoundedCornerRadius
        {
            get { return (double)GetValue(RoundedCornerRadiusBindableProperty); }
            set { SetValue(RoundedCornerRadiusBindableProperty, value); }
        }

        public static readonly BindableProperty RoundedBackgroundColorBindableProperty =
            BindableProperty.Create(
                nameof(CurvedBackgroundColor),
                typeof(Color),
                typeof(RoundedLabel),
                Color.Default);

        public Color CurvedBackgroundColor
        {
            get { return (Color)GetValue(RoundedBackgroundColorBindableProperty); }
            set { SetValue(RoundedBackgroundColorBindableProperty, value); }
        }
    }
}
