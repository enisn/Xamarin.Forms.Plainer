using System;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if ANDROID
using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Controls.Platform;
#endif

#if WINDOWS
using Microsoft.UI.Xaml.Controls;
#endif

namespace Plainer.Maui.Handlers;

public partial class EditorViewHandler : EditorHandler
{
    public EditorViewHandler()
    {
    }

    public EditorViewHandler(IPropertyMapper mapper = null) : base(mapper)
    {
    }
}

#if ANDROID
public partial class EditorViewHandler : EditorHandler
{
    protected override AppCompatEditText CreateNativeView()
    {
        var nativeView = base.CreateNativeView();

        using (var gradientDrawable = new GradientDrawable())
        {
            gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
            nativeView.SetBackground(gradientDrawable);
        }

        return nativeView;
    }
}
#endif

#if IOS || MACCATALYST
public partial class EditorViewHandler : EditorHandler
{
    /* No any custom implementation required
     * Just keeping this handler to prevent build errors.
     */
}
#endif

#if WINDOWS
public partial class EditorViewHandler : EditorHandler
{
    protected override TextBox CreateNativeView()
    {
        var nativeView = base.CreateNativeView();

        nativeView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);

        return nativeView;
    }
}
#endif