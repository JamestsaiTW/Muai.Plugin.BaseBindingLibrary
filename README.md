# Maui.Plugin.BaseBingingLibrary 套件用意
本套件搭配 [The code snippet of MVVM & Binding for .NET MAUI / Xamarin.Forms](https://gist.github.com/JamestsaiTW/3b400c7f680f1379c13233af9ceb20d6) 使用時，可供簡化實作 [INotifyPropertyChanged 介面](https://docs.microsoft.com/zh-tw/dotnet/api/system.componentmodel.inotifypropertychanged)，並仍對其 MVVM 框架撰寫概念有一定的認識與幫助。

過去若在 Xamarin.Forms 專案內有使用到 Xam.Plugin.BaseBindingLibrary 套件，當 Xamarin.Forms 專案升級為 .NET MAUI 之後，可使用本 Maui.Plugin.BaseBingingLibrary 套件來取代原本所使用的 Xam.Plugin.BaseBindingLibrar 套件。

## 安裝完畢後的動作

* 若採用命名空間引用，請將 `using Xam.Plugin.BaseBindingLibrary;` 的部分更換為 `using Maui.Plugin.BaseBindingLibrary;`。
* 若採用完整名稱撰寫，請將 `Xam.Plugin.BaseBindingLibrary` 的部分更換為 `Maui.Plugin.BaseBindingLibrary`。

## 建議升級 .NET MAUI 改引用本套件後的動作

若對 MVVM 框架概念與撰寫方式已熟悉，可繼續進一步改用 [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) 套件，並透過 [ObservableProperty] 與 [RelayCommand] 等相關掛載 **[Attritube](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/attributes)** 的方式來撰寫的 MVVM 程式，其套件詳細介紹請參考下列連結:  
[https://docs.microsoft.com/dotnet/communitytoolkit/mvvm/](https://docs.microsoft.com/dotnet/communitytoolkit/mvvm/)