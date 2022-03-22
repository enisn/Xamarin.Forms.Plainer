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
    protected override MauiTimePicker CreatePlatformView()
    {
        var nativeView = base.CreatePlatformView();

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
    protected override MauiTimePicker CreatePlatformView()
    {
        var nativeView = base.CreatePlatformView();

        nativeView.BorderStyle = UIKit.UITextBorderStyle.None;

        return nativeView;
    }
}
#endif

#if WINDOWS
public partial class TimePickerViewHandler : TimePickerHandler
{
    protected override Microsoft.UI.Xaml.Controls.TimePicker CreatePlatformView()
    {
        var nativeView = base.CreatePlatformView();

        nativeView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);

        return nativeView;
    }
}
#endif
//  Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);