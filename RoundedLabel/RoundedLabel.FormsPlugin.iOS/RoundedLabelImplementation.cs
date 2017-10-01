﻿using RoundedLabel.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using RoundedLabel.FormsPlugin.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedLabel.FormsPlugin.Abstractions.RoundedLabelControl), typeof(RoundedLabelRenderer))]
namespace RoundedLabel.FormsPlugin.iOS
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
    }
}
