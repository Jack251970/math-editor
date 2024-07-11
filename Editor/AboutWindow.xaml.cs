using System.Reflection;
using System.Windows;

namespace Editor
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            versionLabel.Content = "Math Editor v." + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
