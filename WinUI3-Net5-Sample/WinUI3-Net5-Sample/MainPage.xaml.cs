using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3_Net5_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            appType = InAppContainer ? "UWP" : "Win32";
        }

        public bool InAppContainer => (App.Current as App).InAppContainer;

        private string appType;
        public string AppType
        {
            get => $"Hello from {appType}";
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationView currentView = ApplicationView.GetForCurrentView();
            ApplicationViewMode currentMode = currentView.ViewMode;
            ApplicationViewMode nextMode = currentMode == ApplicationViewMode.Default ? ApplicationViewMode.CompactOverlay : ApplicationViewMode.Default;
            if (currentView.IsViewModeSupported(nextMode))
            {
                await currentView.TryEnterViewModeAsync(nextMode);
            }
        }
    }
}
