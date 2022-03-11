using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
#if ANDROID
using Android.Graphics.Drawables;
using Microsoft.Maui.Controls.Platform;
#endif
#if IOS || MACCATALYST
using UIKit;
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
    protected override MauiDatePicker CreateNativeView()
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
public partial class DatePickerViewHandler : DatePickerHandler
{
    protected override MauiDatePicker CreateNativeView()
    {
        var nativeView = base.CreateNativeView();

        nativeView.BorderStyle = UITextBorderStyle.None;

        return nativeView;
    }
}
#endif

// WINDOWS

// Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);