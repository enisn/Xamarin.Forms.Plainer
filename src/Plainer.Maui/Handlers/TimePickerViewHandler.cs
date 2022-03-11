using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

#if ANDROID
using Android.Graphics.Drawables;
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
            this.Control.SetBackground(gradientDrawable);
        }

        return nativeView;
    }
}
#endif

#if IOS || MACCATALYST
public  class TimePickerViewHandler : TimePickerHandler
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