using Plugin.Plainer.Platforms.iOS.Renderers;
using Plugin.Plainer.Shared.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(EntryView), typeof(EntryViewRenderer))]
namespace Plugin.Plainer.Platforms.iOS.Renderers
{
#pragma warning disable DF0033 // Marks undisposed objects assinged to a property, originated from a method invocation.
    public class EntryViewRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
#pragma warning restore DF0033 // Marks undisposed objects assinged to a property, originated from a method invocation.
}
