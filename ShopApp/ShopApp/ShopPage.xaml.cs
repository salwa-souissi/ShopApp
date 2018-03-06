using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShopPage : ContentPage
	{
	    public List<ProductPair> tempdata;
    public ShopPage()
            {
                InitializeComponent();
                data();
                ListProducts.ItemsSource = tempdata;
            
            }
            void data()
            {

                tempdata = new List<ProductPair>
                {
                new ProductPair(new Product{Designation = "BROWNIE HIP SUNGLASSES",Status = "Almost New",Price = "770.00 SAR",Image = "p1.png"},
                                new Product{Designation = "BROWNIE GLASSES HOLDER",Status = "Acceptable",Price = "2200 SAR",Image = "p2.png"}),
                new ProductPair(new Product{Designation = "HANDBAG NATURAL LEATHER",Status = "New",Price = "770.00 SAR",Image = "p3.png"},
                                new Product{Designation = "CONCORD HANDWATCH",Status = "Almost New",Price = "3000.00 SAR",Image = "p4.png"}),
                new ProductPair(new Product{Designation = "EVENING SHOES HIGH HEAL",Status = "Almost New",Price = "2200 SAR",Image = "p5.png"},
                                new Product{Designation = "HANDBAG NATURAL LEATHER",Status = "Almost New",Price = "770.00 SAR",Image = "p6.png"})

            };
            }

            //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
            //{
            //    //thats all you need to make a search  

            //    if (string.IsNullOrEmpty(e.NewTextValue))
            //    {
            //        ListProducts.ItemsSource = tempdata;
            //    }

            //    else
            //    {
            //        ListProducts.ItemsSource = tempdata.Where(x => x.Designation.ToLower().Contains(e.NewTextValue.ToLower()));
            //    }

            //}




        }
    }