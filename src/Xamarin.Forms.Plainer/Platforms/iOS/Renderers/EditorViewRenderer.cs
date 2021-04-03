using System;
using Plugin.Plainer.Platforms.iOS.Renderers;
using Plugin.Plainer.Shared.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EditorView), typeof(EditorViewRenderer))]

namespace Plugin.Plainer.Platforms.iOS.Renderers
{
    public class EditorViewRenderer : EditorRenderer
    {
        /* No any custom implementation required
         * Just keeping this renderer for future fixes.
         */
    }
}