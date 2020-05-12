using System;
using System.Collections;
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

namespace Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()            
           
        {

            InitializeComponent();
            hashtable = new Hashtable();

        }
        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            //add
            hashtable.Add(txtkey.Text.ToString(), txtvalue.Text.ToString());
            txtkey.Clear();
            txtvalue.Clear();


        }

        private void removebtn_TextChanged(object sender, TextChangedEventArgs e)
        {
            hashtable.Remove(txtkey.Text);
            txtkey.Clear();
           
        }

        
        private void showbtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {
                MessageBox.Show("data : " + hashtable[key].ToString());
            }

        }
    }
}
