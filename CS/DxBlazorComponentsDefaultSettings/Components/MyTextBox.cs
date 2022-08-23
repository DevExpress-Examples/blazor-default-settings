using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace DxBlazorComponentsDefaultSettings.Components {
    public class MyTextBox : DxTextBox {
        bool _initialParametersSet;
        public override Task SetParametersAsync(ParameterView parameters) {
            if (!_initialParametersSet) {
                base.ReadOnly = true;
                _initialParametersSet = true;
            }
            return base.SetParametersAsync(parameters);
        }
    }
}
