using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainvievModel mainvievModel = new MainvievModel();
            var a = new MainWindow(mainvievModel);
            a.Show();
            MainWindow = a;
        }
    }

}
