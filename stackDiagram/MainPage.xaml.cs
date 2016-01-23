using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace stackDiagram
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            gridView.ItemsSource = stacks;
        }

        ObservableCollection<S> stacks = new ObservableCollection<S>();

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            stacks.Add(new S()
            {
                item1 = text1.Text,
                item2 = text2.Text,
                item3 = text3.Text,
                item4 = text4.Text,
                item5 = text5.Text,
                item6 = text6.Text
            });

            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
        }
    }

    public class S
    {
        public string item1 { set; get; }
        public string item2 { set; get; }
        public string item3 { set; get; }
        public string item4 { set; get; }
        public string item5 { set; get; }
        public string item6 { set; get; }
    }
}
