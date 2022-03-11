using System;
using Plainer.Maui.Controls;
using Plainer.Maui.Handlers;

namespace Plainer.Maui;

public static class MauiHandlerCollectionExtensions
{
    public static IMauiHandlersCollection AddPlainer(this IMauiHandlersCollection handlers)
    {
        handlers
            .AddHandler(typeof(EntryView), typeof(EntryViewHandler))
            .AddHandler(typeof(EditorView), typeof(EditorViewHandler))
            .AddHandler(typeof(PickerView), typeof(PickerViewHandler))
            .AddHandler(typeof(DatePickerView), typeof(DatePickerViewHandler))
            ;
        return handlers;
    }
}

