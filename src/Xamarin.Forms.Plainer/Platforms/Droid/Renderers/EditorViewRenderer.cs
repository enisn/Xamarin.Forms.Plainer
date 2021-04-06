using System;
using Android.Content;
using Android.Graphics.Drawables;
using Plugin.Plainer.Platforms.Droid.Renderers;
using Plugin.Plainer.Shared.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EditorView), typeof(EditorViewRenderer))]
namespace Plugin.Plainer.Platforms.Droid.Renderers
{
    public class EditorViewRenderer : EditorRenderer
    {
        public EditorViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                using (var gradientDrawable = new GradientDrawable())
                {
                    gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
                    this.Control.SetBackground(gradientDrawable);
                }
            }
        }
    }
}
