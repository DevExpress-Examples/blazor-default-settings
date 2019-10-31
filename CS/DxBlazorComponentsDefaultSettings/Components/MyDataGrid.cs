using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DevExpress.Blazor;

namespace DxBlazorComponentsDefaultSettings.Components
{
    public class MyDataGrid<T> : DxDataGrid<T>
    {
        public override Task SetParametersAsync(ParameterView parameters) {
            base.PageSize = 7;
            base.ShowFilterRow = false;
            base.ShowGroupPanel = true;
            base.AllowColumnDragDrop = false;
            return base.SetParametersAsync(parameters);
        }
    }
}
