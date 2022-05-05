<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/219019222/20.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T827941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Blazor Components - Set predefined settings for the specific component

Controls usually have the same settings for different pages of a large web application, and we recommend that you specify the component settings in markup. You can also override the **SetParametersAsync** method to specify the default settings for Blazor components in your application. However, we do not recommend that you use this approach because it is not a common approach in Blazor. Use it at your own risk.

![Grid with predefined settings and default](images/result.png)

Create an inheritor from our Blazor control that overrides the **SetParametersAsync** method. In this method, set the default values for the public properties before you call the base method. You can initialize properties with custom default values in markup because the base method is called after your custom settings. We do not recommend that you override and change the values of protected properties.

In this example, the [MyDataGrid](./CS/DxBlazorComponentsDefaultSettings/Components/MyDataGrid.cs) component contains the inherited **DxDataGrid** component whose **PageSize**, **ShowFilterRow**, and **ShowGroupPanel** properties contain new default values. You can compare the **MyDataGrid** component with the default **DxDataGrid** component on the [Index](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor) page to ensure they have the same settings in markup.

The Data Grid was moved to maintenance support mode. No new features/capabilities will be added to this component. We recommend that you [migrate](https://docs.devexpress.com/Blazor/403162/grid/migrate-from-data-grid-to-grid) to the [Grid](https://docs.devexpress.com/Blazor/403143/grid) component. 

You cannot use this approach for **DxChartXXXSeries** components and specify the **ValueField**, **ArgumentField**, **NameField**, and **PaneField** properties.

## Files to Look At

* [Index.razor](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor)
* [MyTextBox.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyTextBox.cs)
* [MyDataGrid.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyDataGrid.cs)
