using DevExpress.Blazor;

namespace GridWithPredefinedSettings.Data {
    public class GridDefaultParameters {
        public static void SetDefaultParameters(IGrid Grid) {
            Grid.ShowFilterRow = true;
            Grid.PageSize = 4;
            Grid.ShowGroupPanel = true;
        }
    }
}
