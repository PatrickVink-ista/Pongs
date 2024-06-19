using System.Windows;
using NLog;
using PongsSBK;

namespace Pongs
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>

    public partial class Settings : Window
    {
        public Settings(SliderInfo sliderInfo)
        {
            InitializeComponent();
            DataContext = sliderInfo;
        }

        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
             Logger log = LogManager.GetLogger("");
             log.Info("Settings Changed!");
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ((SliderInfo)DataContext).Engine.GamePlayable = true;
        }
    }
}
