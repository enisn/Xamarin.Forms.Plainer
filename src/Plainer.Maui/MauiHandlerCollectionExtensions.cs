using System;
using Plainer.Maui.Controls;
using Plainer.Maui.Handlers;

namespace Plainer.Maui;

public static class MauiHandlerCollectionExtensions
{
    public static void AddPlainer(this IMauiHandlersCollection handlers)
    {
        handlers.AddHandler(typeof(EntryView), typeof(EntryViewHandler));
    }
}

