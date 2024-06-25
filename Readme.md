<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/219019222/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T827941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# DevExpress Blazor Components - Set predefined settings for a specific component

Controls generally have the same settings across different pages within a large web application. We recommend that you specify these component settings in markup. You can also override the **SetParametersAsyncCore** (for the Grid and Editors) or the **SetParametersAsync** (for other components) method to specify default settings for Blazor components used within in your application.

![Grid with predefined settings and default](images/result.png)

Create an inheritor from our Blazor control to override the **SetParametersAsync** or **SetParametersAsyncCore** method. You can set the default initial values for the **public** properties in either the SetParametersAsync or SetParametersAsyncCore method before you call the base SetParametersXXX method. In markup, you can initialize properties with modified default values since the base method is called after custom settings are applied.

Note: You should not override and change the values of **protected** properties. Such changes may generate unexpected outcomes.

In this example, the [MyGrid](./CS/DxBlazorComponentsDefaultSettings/Components/MyGrid.cs) component contains an inherited **DxGrid** component whose **PageSize**, **ShowFilterRow**, **AllowSort**, and **ShowGroupPanel** properties contain new default values. You can compare the **MyGrid** component to the original **DxGrid** component on the [Index](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor) page to ensure they have the same settings in markup.


You cannot use this technique for **DxChartXXXSeries** components and specify the **ValueField**, **ArgumentField**, **NameField**, and **PaneField** properties.

## Files to Review

* [Index.razor](./CS/DxBlazorComponentsDefaultSettings/Pages/Index.razor)
* [MyTextBox.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyTextBox.cs)
* [MyGrid.cs](./CS/DxBlazorComponentsDefaultSettings/Components/MyGrid.cs)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-default-settings&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-default-settings&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
