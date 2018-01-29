using System;
using Xamarin.Forms;

namespace RoundedLabel.FormsPlugin.Abstractions
{
    /// <summary>
    /// RoundedLabel Interface
    /// </summary>
    public class RoundedLabelControl //: Control type
    {
        public static readonly BindableProperty CurvedCornerRadiusProperty =
      BindableProperty.Create(
          nameof(CurvedCornerRadius),
          typeof(double),
          typeof(RoundedLabelControl),
          12.0);
        public double CurvedCornerRadius
        {
            get { return (double)GetValue(CurvedCornerRadiusProperty); }
            set { SetValue(CurvedCornerRadiusProperty, value); }
        }


        public static readonly BindableProperty CurvedBackgroundColorProperty =
            BindableProperty.Create(
                nameof(CurvedBackgroundColor),
                typeof(Color),
                typeof(RoundedLabelControl),
                Color.Default);
        public Color CurvedBackgroundColor
        {
            get { return (Color)GetValue(CurvedBackgroundColorProperty); }
            set { SetValue(CurvedBackgroundColorProperty, value); }
        }
    }
}
