﻿using Plugin.Plainer.Platforms.UWP.Renderers;
using Plugin.Plainer.Shared.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(PickerView), typeof(PickerViewRenderer))]
namespace Plugin.Plainer.Platforms.UWP.Renderers
{
    public class PickerViewRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
