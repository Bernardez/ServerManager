using System;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ServerManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            Uri requestUri = new Uri("http://10.0.0.50:8080/api/start"); //replace your Url  
            var objClint = new System.Net.Http.HttpClient();
            objClint.DefaultRequestHeaders.Add("key", "89034h8973hg83hg387g3hg0837h0g3hg08w34ashga34");
            System.Net.Http.HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent("Test"));
            string responJsonText = await respon.Content.ReadAsStringAsync();
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            Uri requestUri = new Uri("http://10.0.0.50:8080/api/stop"); //replace your Url  
            var objClint = new System.Net.Http.HttpClient();
            objClint.DefaultRequestHeaders.Add("key", "89034h8973hg83hg387g3hg0837h0g3hg08w34ashga34");
            System.Net.Http.HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent("Test"));
            string responJsonText = await respon.Content.ReadAsStringAsync();
        }
    }


}
