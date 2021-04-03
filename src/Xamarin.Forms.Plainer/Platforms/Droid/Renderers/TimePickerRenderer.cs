using System;
using Android.Content;
using Android.Graphics.Drawables;
using Plugin.Plainer.Platforms.Droid.Renderers;
using Plugin.Plainer.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(TimePickerView), typeof(TimePickerViewRenderer))]
namespace Plugin.Plainer.Platforms.Droid.Renderers
{
    public class TimePickerViewRenderer : TimePickerRenderer
    {
        public TimePickerViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                using (var gradientDrawable = new GradientDrawable())
                {
                    gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
                    this.Control.SetBackground(gradientDrawable);
                    Control.SetTextColor(Element.TextColor.ToAndroid());
                }
            }
        }
    }
}
