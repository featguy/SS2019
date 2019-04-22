using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Book book = new Book();
            lister.ItemsSource = book.Lessons;
        }

        private async void lister_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = (ListView)sender;
            var lesson = (Lesson)listView.SelectedItem;

            await Navigation.PushModalAsync(new Read(lesson));
        }
    }
}
