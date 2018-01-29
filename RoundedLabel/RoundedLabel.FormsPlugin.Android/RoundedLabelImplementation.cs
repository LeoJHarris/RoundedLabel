using System;
using Xamarin.Forms;
using RoundedLabel.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(RoundedLabel.FormsPlugin.Abstractions.RoundedLabelControl), typeof(RoundedLabelRenderer))]
namespace RoundedLabel.FormsPlugin.Android
{
    /// <summary>
    /// RoundedLabel Renderer
    /// </summary>
    public class RoundedLabelRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        private GradientDrawable _gradientBackground;

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (RoundedLabelControl)Element;
            if (view == null) return;

            // creating gradient drawable for the curved background
            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.CurvedBackgroundColor.ToAndroid());

            // Thickness of the stroke line
            _gradientBackground.SetStroke(4, view.CurvedBackgroundColor.ToAndroid());

            // Radius for the curves
            _gradientBackground.SetCornerRadius(
                DpToPixels(this.Context,
                Convert.ToSingle(view.CurvedCornerRadius)));

            // set the background of the label
            Control.SetBackground(_gradientBackground);
        }

        /// <summary>
        /// Device Independent Pixels to Actual Pixles conversion
        /// </summary>
        /// <param name="context"></param>
        /// <param name="valueInDp"></param>
        /// <returns></returns>
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}