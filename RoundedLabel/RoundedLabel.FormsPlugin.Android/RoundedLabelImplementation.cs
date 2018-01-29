using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Content;
using Android.Util;
using LeoJHarris.RoundedLabel.Plugin.Abstractions;

[assembly: ExportRenderer(typeof(RoundedLabel), typeof(RoundedLabelRenderer))]
namespace LeoJHarris.RoundedLabel.Plugin.Abstractions
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