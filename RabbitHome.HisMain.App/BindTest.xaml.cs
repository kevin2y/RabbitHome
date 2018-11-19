using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace RabbitHome.HisMain.App
{
    /// <summary>
    /// BindTest.xaml 的交互逻辑
    /// </summary>
    public partial class BindTest : Window
    {
        public BindTest()
        {
            InitializeComponent();
        }

        UIState state = new UIState();
        private void button_Click(object sender, RoutedEventArgs e)
        {           
            Dictionary<string, object> dict = new Dictionary<string, object> { { "ModelName", "test" }, { "ModelNumber", "X-01" } };
            this.gdProductDetail.DataContext = dict;
            state.SetPropertyValue("ModelName", "test");
            state.SetPropertyValue("ModelNumber", "X-01");
            this.gdProductDetail.DataContext = state;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            state.SetPropertyValue("ModelName", "hahha");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("state.ModelName=" + state.GetPropertyValue("ModelName"));
        }
    }
}
