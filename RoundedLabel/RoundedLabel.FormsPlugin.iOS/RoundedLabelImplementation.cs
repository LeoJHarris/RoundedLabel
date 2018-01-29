using RoundedLabel.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using RoundedLabel.FormsPlugin.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedLabel.FormsPlugin.Abstractions.RoundedLabel), typeof(RoundedLabelRenderer))]
namespace RoundedLabel.FormsPlugin.iOS
{
    /// <summary>
    /// RoundedLabel Renderer
    /// </summary>
    public class RoundedLabelRenderer : LabelRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public async static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Abstractions.RoundedLabel _xfViewReference = (Abstractions.RoundedLabel)Element;

                // Radius for the curves
                Layer.CornerRadius = (float)_xfViewReference.RoundedCornerRadius;

                // this.Layer.Bounds = new CGRect();
                Layer.BackgroundColor = _xfViewReference.CurvedBackgroundColor.ToCGColor();
            }
        }
    }
}
