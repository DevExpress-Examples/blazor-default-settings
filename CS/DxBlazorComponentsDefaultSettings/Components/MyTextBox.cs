using System;
using System.Threading.Tasks;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace DxBlazorComponentsDefaultSettings.Components
{
    public class MyTextBox : DxTextBox
    {
        public override Task SetParametersAsync(ParameterView parameters) {
            base.ReadOnly = true;
            return base.SetParametersAsync(parameters);
        }
    }
}
