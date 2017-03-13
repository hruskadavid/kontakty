using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class MainPage
    {
        public MainPage()
        {
             var dbConnection = App.Database;
            TodoItemDatabase personDatabase = App.Database;

            PeopleListViewFormatted.ItemsSource = App.Database.GetItemsAsync().Result;

        
        }
        
        
        public void pridat(object sender, EventArgs args)
        {
            
             new NavigationPage (new New());
        }

      
        
        
           



    }
}
