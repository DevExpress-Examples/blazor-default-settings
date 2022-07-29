<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T827941)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Blazor Grid - Set predefined common settings for several components

Controls usually have the same settings for different pages of a large web application, and we recommend that you specify the component settings in markup. For our Grid component, you can use the [Save and Restore the Layout](https://demos.devexpress.com/blazor/Grid/Layout) feature to apply common settings for several components.

![Grid with predefined settings](images/result.png)

Specify the same **LayoutAutoLoading** [event handler](./CS/GridWithPredefinedSettings/Pages/Index.razor#L22) for grids that should have the same settings. In this event handler, call a [function](./CS/GridWithPredefinedSettings/Data/GridDefaultParameters.cs#L4) that takes the Grid instance and applies settings to it.

## Files to Look At

* [Index.razor](./CS/GridWithPredefinedSettings/Pages/Index.razor)
* [GridDefaultParameters.cs](./CS/GridWithPredefinedSettings/Data/GridDefaultParameters.cs)
