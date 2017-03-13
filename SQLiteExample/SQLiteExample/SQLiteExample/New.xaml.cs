using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteExample
{
    public partial class New : TodoItem
    {
        public New()
        {
          
            
        }

        public void ulozit(object sender, EventArgs args)
        {
           
            var dbConnection = App.Database;
            
            TodoItemDatabase userDatabase = App.Database;
            
            TodoItem item = new TodoItem();
            item.datum = datum.Date;
            item.Firstname = jmeno.Text;
            item.Phone = Convert.ToInt32(phone.Text);
            item.Lastname = prijmeni.Text;
            
            App.Database.SaveItemAsync(item);
            Task.Delay(3);
           
        }

    }
}
