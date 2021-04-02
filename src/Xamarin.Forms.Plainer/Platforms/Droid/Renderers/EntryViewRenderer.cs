using Android.Content;
using Android.Graphics.Drawables;
using Plugin.Plainer.Platforms.Droid.Renderers;
using Plugin.Plainer.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryView), typeof(EntryViewRenderer))]
namespace Plugin.Plainer.Platforms.Droid.Renderers
{
    public class EntryViewRenderer : EntryRenderer
    {
        public EntryViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
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
