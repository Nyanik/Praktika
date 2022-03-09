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

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<Product> ProductStart = BaseClass.Base.Product.ToList();
        public Page1()
        {
            InitializeComponent();
            LVProdMat.ItemsSource = ProductStart;
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            int index = Convert.ToInt32(tb.Uid);
            List<ProductMaterial> TC = BaseClass.Base.ProductMaterial.Where(x => x.ProductID == index).ToList();
            string str = "Материалы: ";
            foreach (ProductMaterial item in TC)
            {
                str += item.Material.Title + ", ";
            }
            if (str == "Материалы: ")
            {
                tb.Text = str.Substring(0) + "-";
            }
            else
            {
                tb.Text = str.Substring(0, str.Length - 2);
            }

        }
        List<Product> PRFilter;
        private void Filter() 
        {
            if (!string.IsNullOrWhiteSpace(TBFilter.Text))  
            {
                PRFilter = PRFilter.Where(x => x.Title.ToLower().Contains(TBFilter.Text)).ToList();
            }
            LVProdMat.ItemsSource = PRFilter;

        }

        private void TBFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
    }
}
