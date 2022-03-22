using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
#if ANDROID
using Android.Graphics.Drawables;
using Microsoft.Maui.Controls.Platform;
#endif
#if IOS || MACCATALYST
using UIKit;
#endif
#if WINDOWS
using Microsoft.UI.Xaml.Controls;
#endif

namespace Plainer.Maui.Handlers;

public partial class DatePickerViewHandler : DatePickerHandler
{
    public DatePickerViewHandler()
    {
    }

    public DatePickerViewHandler(IPropertyMapper mapper) : base(mapper)
    {
    }
}

#if ANDROID
public partial class DatePickerViewHandler : DatePickerHandler
{
    protected override MauiDatePicker CreatePlatformView()
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
public partial class DatePickerViewHandler : DatePickerHandler
{
    protected override MauiDatePicker CreatePlatformView()
    {
        var nativeView = base.CreatePlatformView();

        nativeView.BorderStyle = UITextBorderStyle.None;

        return nativeView;
    }
}
#endif

#if WINDOWS
public partial class DatePickerViewHandler : DatePickerHandler
{
    protected override CalendarDatePicker CreatePlatformView()
    {
        var nativeView = base.CreatePlatformView();
        nativeView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
        return nativeView;
    }
}
#endif