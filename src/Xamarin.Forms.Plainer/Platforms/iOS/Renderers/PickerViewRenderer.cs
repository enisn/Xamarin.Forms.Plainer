using System;
using Plugin.Plainer.Platforms.iOS.Renderers;
using Plugin.Plainer.Shared.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(PickerView), typeof(PickerViewRenderer))]
namespace Plugin.Plainer.Platforms.iOS.Renderers
{
    public class PickerViewRenderer : PickerRenderer
    {
        public PickerViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}
