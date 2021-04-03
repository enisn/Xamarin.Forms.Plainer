using System;
using Plugin.Plainer.Platforms.iOS.Renderers;
using Plugin.Plainer.Shared.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(TimePickerView), typeof(TimePickerViewRenderer))]
namespace Plugin.Plainer.Platforms.iOS.Renderers
{
    public class TimePickerViewRenderer : TimePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                Control.TextColor = Element.TextColor.ToUIColor();
            }
        }
    }
}
