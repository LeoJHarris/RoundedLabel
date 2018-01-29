using System;
using Xamarin.Forms;
using RoundedLabel.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using RoundedLabel.FormsPlugin.Abstractions;
using Android.Content;
using Android.Util;

[assembly: ExportRenderer(typeof(RoundedLabel.FormsPlugin.Abstractions.RoundedLabel), typeof(RoundedLabelRenderer))]
namespace RoundedLabel.FormsPlugin.Android
{
    /// <summary>
    /// RoundedLabel Renderer
    /// </summary>
    public class RoundedLabelRenderer : LabelRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
            var temp = DateTime.Now;
        }
        
        public RoundedLabelRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        private GradientDrawable gradientDrawable;

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (Abstractions.RoundedLabel)Element;
            if (view == null) return;
            
            gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(view.CurvedBackgroundColor.ToAndroid());
            
            gradientDrawable.SetStroke(4, view.CurvedBackgroundColor.ToAndroid());
            
            gradientDrawable.SetCornerRadius(
                DpToPixels(Context,
                Convert.ToSingle(view.RoundedCornerRadius)));
            
            Control.SetBackground(gradientDrawable);
        }
        
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}