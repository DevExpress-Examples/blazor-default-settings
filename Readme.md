<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/219019222/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T827941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Blazor Components - Set predefined settings for the specific component

Controls usually have the same settings for different pages of a large web application. We recommend that you specify these component settings in markup. You can also override the **SetParametersAsyncCore** (for the Grid) or the **SetParametersAsync** (for other components) method to specify the default settings for Blazor components in your application.


![Grid with predefined settings and default](images/result.png)

Create an inheritor from our Blazor control to override the **SetParametersAsync** or **SetParametersAsyncCore** method. You can set the default initial values for the **public** properties in either the SetParametersAsync or SetParametersAsyncCore method before you call the base SetParametersXXX method. In markup, you can initialize properties with modified default values since the base method is called after custom settings are applied. 

Note that we do not recommend that you override and change the values of **protected** properties as it may lead to incorrect control behavior.

In this example solution, the [MyGrid](./CS/DxBlazorComponentsDefaultSettings/Components/MyGrid.cs) component contains the inherited **DxGrid** component whose **PageSize**, **ShowFilterRow**, **AllowSort**, and **ShowGroupPanel** properties contain new default values. You can compare the **MyGrid** component to the original **DxGrid** component on the [Index](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor) page to ensure they have the same settings in markup.


You cannot use this technique for **DxChartXXXSeries** components and specify the **ValueField**, **ArgumentField**, **NameField**, and **PaneField** properties.

## Files to Look At

* [Index.razor](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor)
* [MyTextBox.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyTextBox.cs)
* [MyGrid.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyGrid.cs)
