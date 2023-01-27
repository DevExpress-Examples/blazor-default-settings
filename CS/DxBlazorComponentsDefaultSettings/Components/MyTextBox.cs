using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace DxBlazorComponentsDefaultSettings.Components {
    public class MyTextBox : DxTextBox {
        bool _initialParametersSet;
        protected override Task SetParametersAsyncCore(ParameterView parameters) {
            if (!_initialParametersSet) {
                base.ReadOnly = true;
                _initialParametersSet = true;
            }
            return base.SetParametersAsyncCore(parameters);
        }
    }
}