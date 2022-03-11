using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if ANDROID
using Android.Graphics.Drawables;
using Microsoft.Maui.Controls.Platform;
#endif

namespace Plainer.Maui.Handlers;

public partial class TimePickerViewHandler : TimePickerHandler
{
    public TimePickerViewHandler()
    {
    }
}

#if ANDROID
public partial class TimePickerViewHandler : TimePickerHandler
{
    protected override MauiTimePicker CreateNativeView()
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
public partial class TimePickerViewHandler : TimePickerHandler
{
    protected override MauiTimePicker CreateNativeView()
    {
        var nativeView = base.CreateNativeView();

        nativeView.BorderStyle = UIKit.UITextBorderStyle.None;

        return nativeView;
    }
}
#endif

// WINDOWS

//  Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);