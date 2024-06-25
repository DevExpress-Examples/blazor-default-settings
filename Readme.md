<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/219019222/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T827941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-default-settings&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-default-settings&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
