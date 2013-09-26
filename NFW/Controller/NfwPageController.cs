using NFW.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NFW.Controller
{
    internal class NfwPageController
    {
        private NfwPage MyPage { get; set; }
        private UserControl MyPageView { get; set; }

        internal UserControl Create(NfwPage page) 
        {
            MyPage = page;
            MyPageView = new UserControl();
            MyPageView.Content = new StackPanel();
            var content = MyPageView.Content as StackPanel;

            if(null != page.Header)
            {
                content.Children.Add(new TextBlock() { Text = page.Header.Text, FontSize = 18, FontFamily = new FontFamily("Calibri"), FontWeight = FontWeights.Bold, TextAlignment = TextAlignment.Center});
            }

            if (null != page.Background)
            {
                content.Children.Add(new Image() { Source = new BitmapImage(page.Background.ImageUri), Stretch = Stretch.Fill });
            }

            if (null != page.Text)
            {
                content.Children.Add(new TextBlock() { Text = page.Text.Text, TextWrapping = TextWrapping.Wrap, Padding = new Thickness(0, 10, 0, 10) });
            }

            return MyPageView;
        }
    }
}
