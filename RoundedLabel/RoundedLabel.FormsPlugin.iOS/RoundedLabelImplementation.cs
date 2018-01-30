using LeoJHarris.RoundedLabel.Plugin.Abstractions;
using LeoJHarris.RoundedLabel.Plugin.iOS;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedLabel), typeof(RoundedLabelRenderer))]
namespace LeoJHarris.RoundedLabel.Plugin.iOS
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
                Abstractions.RoundedLabel roundedLabel = (Abstractions.RoundedLabel)Element;

                // Radius for the curves
                Layer.CornerRadius = (float)roundedLabel.RoundedCornerRadius;
                
                Layer.BackgroundColor = roundedLabel.CurvedBackgroundColor.ToCGColor();
            }
        }
    }
}
