using NFW;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewFeatureWalkthrough
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string version = "19.0";
        NfwController m_nfw = new NfwController(version);
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void m_btnFeature_Click(object sender, RoutedEventArgs e)
        {

            if (m_nfw.IsDisplayRequired("NewFeatureWalkthrough.m_btnFeature_Click"))
            {
                m_nfw.CreatePage("Hello first page", "Enjoy bla bla!", new Uri("http://rimblogs.files.wordpress.com/2010/08/bbdesktops-31.jpg?w=561&h=531"));
                m_nfw.CreatePage("Hello second page", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", new Uri("http://www.ideaspectrum.com/help/pro2011_help/ImagesExt/landscaping_software_no_full_screen_dialog.jpg"));
                m_nfw.CreatePage("Hello", "World!", new Uri("http://www.locklizard.com/Images/flash-security-software.gif"));
            }
        }
    }
}
