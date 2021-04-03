using System;
using Plugin.Plainer.Platforms.iOS.Renderers;
using Plugin.Plainer.Shared.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(DatePickerView), typeof(DatePickerViewRenderer))]
namespace Plugin.Plainer.Platforms.iOS.Renderers
{
    public class DatePickerViewRenderer : DatePickerRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
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
