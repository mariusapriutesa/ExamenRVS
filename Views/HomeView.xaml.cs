using ExamenRVS.Commands;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenRVS.Views 
{

    public partial class HomeView : UserControl
    {
      
        string name;

        

        
        public HomeView()
        {
            
            InitializeComponent();
          
           // this.myGrid.DataContext = user;
        }

        

        private void Registrar1(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
               // userHandler.AddUser(user);
                MessageBox.Show(" Usuario añadido exitosamente");
            }
            else
            {
                MessageBox.Show(" No Has escribido bien todos los campos");
            }
        }
        private bool Validation()
        {
            bool validation = true;

            foreach (UIElement element in myGrid.Children)
            {
                if (element is TextBox)
                {
                    TextBox textbox = (TextBox)element;
                    if (textbox.Text.Equals(""))
                    {

                        textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                       
                        validation = false;
                    }
                    else
                    {
                        textbox.BorderBrush = new SolidColorBrush(Colors.LightGray);
                    }
                }

            }

            return validation;
        }
        
    }
}
