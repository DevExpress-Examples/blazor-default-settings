using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace DxBlazorComponentsDefaultSettings.Components {
    public class MyDataGrid<T> : DxDataGrid<T> {
        public override Task SetParametersAsync(ParameterView parameters) {
            base.PageSize = 7;
            base.ShowFilterRow = false;
            base.ShowGroupPanel = true;
            base.AllowColumnDragDrop = false;
            return base.SetParametersAsync(parameters);
        }
    }
}
