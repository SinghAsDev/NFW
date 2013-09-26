using NFW.Controller;
using System.Windows;

namespace NFW.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NfwWindow : Window
    {
        private NfwWindowController m_controller;

        internal NfwWindow(NfwWindowController controller)
        {
            m_controller = controller;
            InitializeComponent();
        }

        private void m_btnNext_Click(object sender, RoutedEventArgs e)
        {
            m_controller.NextPage();
        }

        private void m_btnPrev_Click(object sender, RoutedEventArgs e)
        {
            m_controller.PrevPage();
        }
    }
}
