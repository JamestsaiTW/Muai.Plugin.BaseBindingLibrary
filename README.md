# Maui.Plugin.BaseBingingLibrary 套件用意
本套件可供簡化實作 [INotifyPropertyChanged](https://docs.microsoft.com/zh-tw/dotnet/api/system.componentmodel.inotifypropertychanged) 介面的處理，並仍對其 MVVM 框架撰寫概念有一定的認識與幫助。

## Getting Started

* 從 [![Nuget](https://img.shields.io/nuget/v/Muai.Plugin.BaseBindingLibrary.svg?label=NuGet)](https://www.nuget.org/packages/Muai.Plugin.BaseBindingLibrary) 下載，或直接在 .NET MAUI 專案安裝此 Nuget 套件。

* 請在 Visual Studio 當中搭配 [The code snippet of MVVM & Binding for .NET MAUI / Xamarin.Forms](https://gist.github.com/JamestsaiTW/3b400c7f680f1379c13233af9ceb20d6) 使用。

### 使用的撰寫方式

* 若採用命名空間引用，請 `using Maui.Plugin.BaseBindingLibrary;` 的撰寫。
* 若採用完整名稱撰寫，請 `Maui.Plugin.BaseBindingLibrary` 的撰寫。

### 建議 .NET MAUI 使用本套件撰寫後

若對 MVVM 框架概念與撰寫方式已熟悉，可繼續進一步改用 [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) 套件，並透過 [ObservableProperty] 與 [RelayCommand] 等相關掛載 **[Attritube](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/attributes)** 的方式來撰寫的 MVVM 程式。  

其套件詳細介紹請參考下列連結:  
[https://docs.microsoft.com/dotnet/communitytoolkit/mvvm/](https://docs.microsoft.com/dotnet/communitytoolkit/mvvm/)

## 若是從 Xamarin.Forms 升級至 .NET MAUI

過去若在 Xamarin.Forms 專案內有使用到 Xam.Plugin.BaseBindingLibrary 套件，當 Xamarin.Forms 專案升級為 .NET MAUI 之後，可使用本 Maui.Plugin.BaseBingingLibrary 套件來取代原本所使用的 Xam.Plugin.BaseBindingLibrar 套件。

### 改成 .NET MAUI 引用本 Maui.Plugin.BaseBingingLibrary 套件後的改寫動作

* 若採用命名空間引用，請將 `using Xam.Plugin.BaseBindingLibrary;` 的部分更換為 `using Maui.Plugin.BaseBindingLibrary;`。
* 若採用完整名稱撰寫，請將 `Xam.Plugin.BaseBindingLibrary` 的部分更換為 `Maui.Plugin.BaseBindingLibrary`。