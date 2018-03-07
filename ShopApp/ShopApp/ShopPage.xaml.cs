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
                new ProductPair(new Product{Designation = "BROWNIE HIP SUNGLASSES",Status = "Almost New",Price = "770.00 SAR",Image = "p1.png",Category = "Accessories"},
                                new Product{Designation = "BROWNIE GLASSES HOLDER",Status = "Acceptable",Price = "2200 SAR",Image = "p2.png",Category = "Accessories"}),
                new ProductPair(new Product{Designation = "HANDBAG NATURAL LEATHER",Status = "New",Price = "770.00 SAR",Image = "p3.png",Category = "Bags"},
                                new Product{Designation = "CONCORD HANDWATCH",Status = "Almost New",Price = "3000.00 SAR",Image = "p4.png",Category = "Accessories"}),
                new ProductPair(new Product{Designation = "EVENING SHOES HIGH HEAL",Status = "Almost New",Price = "2200 SAR",Image = "p5.png",Category = "Shoes"},
                                new Product{Designation = "HANDBAG NATURAL LEATHER",Status = "Almost New",Price = "770.00 SAR",Image = "p6.png",Category = "Bags"}),
                new ProductPair(new Product{Designation = "xxxxxxx",Status = "Almost New",Price = "2200 SAR",Image = "p5.png",Category = "Shoes"},
                                new Product{Designation = "sssssss",Status = "Almost New",Price = "770.00 SAR",Image = "p6.png",Category = "Bags"})
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


	    private void TapGestureRecognizer_OnBagsTapped(object sender, EventArgs e)
	    {
	        Travel.TextColor = Color.Gray;
	        Shoes.TextColor = Color.Gray;
	        Dresses.TextColor = Color.Gray;
	        Accessories.TextColor = Color.Gray;
            Bags.TextColor = Color.White;
	        ListProducts.ItemsSource = tempdata.Where(x => x.Item1.Category.Equals("Bags"));
	       // ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Category.Equals("Bags"));



        }

        private void TapGestureRecognizer_OnTravelTapped(object sender, EventArgs e)
	    {
	        Travel.TextColor = Color.White;
	        Shoes.TextColor = Color.Gray;
	        Dresses.TextColor = Color.Gray;
	        Accessories.TextColor = Color.Gray;
	        Bags.TextColor = Color.Gray;
	        ListProducts.ItemsSource = tempdata.Where(x => x.Item1.Category.Equals("Travel"));
	     //   ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Category.Equals("Travel"));

        }
	    private void TapGestureRecognizer_OnAccessoriesTapped(object sender, EventArgs e)
	    {
	        Travel.TextColor = Color.Gray;
	        Shoes.TextColor = Color.Gray;
	        Dresses.TextColor = Color.Gray;
	        Accessories.TextColor = Color.White;
	        Bags.TextColor = Color.Gray;
	        ListProducts.ItemsSource = tempdata.Where(x => x.Item1.Category.Equals("Accessories"));
	      //  ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Category.Equals("Accessories"));

        }

	    private void TapGestureRecognizer_OnShoesTapped(object sender, EventArgs e)
	    {
	        Travel.TextColor = Color.Gray;
	        Shoes.TextColor = Color.White;
	        Dresses.TextColor = Color.Gray;
	        Accessories.TextColor = Color.Gray;
	        Bags.TextColor = Color.Gray;
	        ListProducts.ItemsSource= tempdata.Where(x => x.Item1.Category.Equals("Shoes"));
	     //   ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Category.Equals("Shoes"));

        }
	    private void TapGestureRecognizer_OnDressesTapped(object sender, EventArgs e)
	    {
	        Travel.TextColor = Color.Gray;
	        Shoes.TextColor = Color.Gray;
	        Dresses.TextColor = Color.White;
	        Accessories.TextColor = Color.Gray;
	        Bags.TextColor = Color.Gray;
	        ListProducts.ItemsSource = tempdata.Where(x => x.Item1.Category.Equals("Dresses"));
	     //   ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Category.Equals("Dresses"));

        }


	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListProducts.ItemsSource = tempdata;
            }

            else
            {
                ListProducts.ItemsSource = tempdata.Where(x => x.Item1.Designation.ToLower().Contains(e.NewTextValue.ToLower()));
                ListProducts.ItemsSource = tempdata.Where(x => x.Item2.Designation.ToLower().Contains(e.NewTextValue.ToLower()));

            }

        }
    }
}