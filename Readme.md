<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor)
* [MyTextBox.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyTextBox.cs)
* [MyDataGrid.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyDataGrid.cs)
<!-- default file list end -->

### DevExpress Blazor Components - A way to set predefined settings for the specific component

In the case of a large Web application, you often use controls with the same settings on numerous pages.  It's quite annoying to specify the same settings many times.
In this example we show how to specify some default settings for all DevExpress Blazor components in your application.

Create an inheritor from our Blazor control and override the *SetParametersAsync* method. In this method, set the necessary default values for the **public** properties before calling the base method. Since the base method is called after your custom settings, you can initialize properties with custom default values in markup.

In this example, the [MyDataGrid](./CS/DxBlazorComponentsDefaultSettings/Components/MyDataGrid.cs) component contains the inherited DxDataGrid component whose *PageSize*, *ShowFilterRow*, and *ShowGroupPanel* properties contain new default values. Compare these components with the default DxDataGrid component on the [Index](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor) page: they have the same settings in markup.

The list of limitations:

* It's not possible to use this approach with the *DxChartXXXSeries* components and specify the *ValueField*, *ArgumentField*, *NameField*, and *PaneField* properties.


**Note:** We don't recommend you override any other members of our components and change values of any protected properties.
