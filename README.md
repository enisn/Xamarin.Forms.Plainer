<p align="center">
  <img src="art/cover.svg" width="100%" alt="icon" />
</p>

# Xamarin.Forms.Plainer
This library removes all visual effects from controls and makes them easy to style from portable layer instead of writing custom renderers always.
No underlines, no borders, no background colors. Just interactive fields without visual effect.

***

[![CodeFactor](https://www.codefactor.io/repository/github/enisn/xamarin.forms.plainer/badge)](https://www.codefactor.io/repository/github/enisn/xamarin.forms.plainer)
[![Nuget](https://img.shields.io/nuget/v/Xamarin.Forms.Plainer)](https://www.nuget.org/packages/Xamarin.Forms.Plainer/)

***

## Getting Started on MAUI

- Install `Plainer.Maui` nuget package to your project.

- Go to **MauiProgram.cs** and add Plainer handlers

  ```csharp
  builder.ConfigureMauiHandlers(handlers =>
  {
    handlers.AddPlainer();
  });
  ```
  
---

## Getting Started on Xamarin Forms

- Install `Xamarin.Forms.Plainer` to each platform

- Add Initialize method into platforms

  - **Android**: Go to `MainActivity` and add following:

    ```csharp
    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);
    
      global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
    
      // Add follwoing line
      global::Plugin.Plainer.Platforms.Droid.Plainer.Init(this, savedInstanceState); // <--
    
      LoadApplication(new App());
    }
    ```

  - **iOS**: Go to `AppDelegate  ` and add following line:

    ```csharp
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
      global::Xamarin.Forms.Forms.Init();
    
      // Add following line
      global::Plugin.Plainer.Platforms.iOS.Plainer.Init(); // <--
    
      LoadApplication(new App());
    
      return base.FinishedLaunching(app, options);
    }
    ```



## Usage

- Go your XAML page and add following namespace:

  | MAUI | `xmlns:plain="clr-namespace:Plainer.Maui.Controls;assembly=Plainer.Maui"` |
  | --- | --- |
  | Xamarin | `xmlns:plain="clr-namespace:Plugin.Plainer.Shared.Controls;assembly=Plugin.Plainer"` |

- And you can start to use plain controls:

  ```xml
  <plain:EntryView/>
  ```

  This will be completely invisible, that's the point of the Plainer. Just try a rounded corner for input:

  ```xml
  <Frame BorderColor="Blue" CornerRadius="20" Padding="5">
    <plain:EntryView TextColor="Blue"/>
  </Frame>
  ```

  Result will be:

  <table>
    <tr>
      <td>
      	<img width="200" src="art/images/sample_1_ios.png" />
      </td>
      <td>
        <img width="200" src="art/images/sample_1_android.png" />
      </td>
    </tr>
  </table>



## Showcase

<table>
  <tr>
    <td>
    	<img width="200" src="art/images/showcase_ios.png" />
    </td>
    <td>
      <img width="200" src="art/images/showcase_android.png" />
    </td>
  </tr>
</table>



You can create this view with following code:

```xml
<StackLayout Spacing="20" Padding="40,20">
  <StackLayout>
    <Label Text="EntryView"/>
    <plain:EntryView TextColor="Blue" BackgroundColor="WhiteSmoke"/>
  </StackLayout>

  <StackLayout>
    <Label Text="EditorPickerView"/>
    <plain:EditorView HeightRequest="120" TextColor="Blue" BackgroundColor="WhiteSmoke"/>
  </StackLayout>

  <StackLayout>
    <Label Text="PickerView"/>
    <plain:PickerView TextColor="Blue" BackgroundColor="WhiteSmoke">
      <plain:PickerView.ItemsSource>
        <x:Array Type="{x:Type x:String}">
          <x:String>Option 1</x:String>
          <x:String>Option 2</x:String>
          <x:String>Option 3</x:String>
        </x:Array>
      </plain:PickerView.ItemsSource>
    </plain:PickerView>
  </StackLayout>

  <StackLayout>
    <Label Text="TimePickerView"/>
    <plain:TimePickerView TextColor="Blue" BackgroundColor="WhiteSmoke"/>
  </StackLayout>

  <StackLayout>
    <Label Text="DatePickerView"/>
    <plain:DatePickerView TextColor="Blue" BackgroundColor="WhiteSmoke"/>
  </StackLayout>

</StackLayout>
```

