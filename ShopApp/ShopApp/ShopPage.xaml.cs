using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace ShopApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        public List<ProductPair> tempdata;
        public List<Product> tempdata2;
        private List<ProductPair> l1;

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
                                new Product{Designation = "BELT NATURAL LEATHER",Status = "Almost New",Price = "770.00 SAR",Image = "p6.png",Category = "Accessories"}),
            };
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
               
                tempdata2 = new List<Product>();

                foreach (var prod in tempdata)
                {


                    if (prod.Item1.Designation.ToLower().Contains(e.NewTextValue.ToLower()))
                    {
                        tempdata2.Add(prod.Item1);
                        prod.Item2.IsVisible = false;
                    }

                    if (prod.Item2.Designation.ToLower().Contains(e.NewTextValue.ToLower()))
                    {
                        tempdata2.Add(prod.Item2);
                        prod.Item1.IsVisible = false;
                    }

                }
                l1 = new List<ProductPair>();
                for (int i = 0; i <= tempdata2.Count; i = i + 2)
                {
                    if (i < tempdata2.Count - 1)
                    {
                        ProductPair pp = new ProductPair(tempdata2[i], tempdata2[i + 1]);
                        l1.Add(pp);
                    }
                    else if (i == tempdata2.Count - 1)
                    {
                        ProductPair pp = new ProductPair(tempdata2[i], null);
                        l1.Add(pp);
                    }
                }

                ListProducts.ItemsSource = l1;

            }

        }

        void getdatabycategory(string category)
        {
            tempdata2 = new List<Product>();

            foreach (var prod in tempdata)
            {


                if (prod.Item1.Category.Equals(category))
                {
                    tempdata2.Add(prod.Item1);
                    prod.Item2.IsVisible = false;
                }

                if (prod.Item2.Category.Equals(category))
                {
                    tempdata2.Add(prod.Item2);
                    prod.Item1.IsVisible = false;
                }

            }
            l1 = new List<ProductPair>();

            for (int i = 0; i <= tempdata2.Count; i = i + 2)
            {
                if (i < tempdata2.Count - 1)
                {
                    ProductPair pp = new ProductPair(tempdata2[i], tempdata2[i + 1]);
                    l1.Add(pp);
                }
                else if (i == tempdata2.Count - 1)
                {
                    ProductPair pp = new ProductPair(tempdata2[i], null);
                    l1.Add(pp);
                }
            }

            ListProducts.ItemsSource = l1;
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(Shoes))
            {
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.White;
                Dresses.TextColor = Color.Gray;
                Accessories.TextColor = Color.Gray;
                Bags.TextColor = Color.Gray;
                getdatabycategory("Shoes");


            }
            else if (sender.Equals(Bags))
            {
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.Gray;
                Dresses.TextColor = Color.Gray;
                Accessories.TextColor = Color.Gray;
                Bags.TextColor = Color.White;
                getdatabycategory("Bags");

            }
            else if (sender.Equals(Accessories))
            {
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.Gray;
                Dresses.TextColor = Color.Gray;
                Accessories.TextColor = Color.White;
                Bags.TextColor = Color.Gray;
                getdatabycategory("Accessories");
            }
            else if (sender.Equals(Dresses))
            {
                Travel.TextColor = Color.Gray;
                Shoes.TextColor = Color.Gray;
                Dresses.TextColor = Color.White;
                Accessories.TextColor = Color.Gray;
                Bags.TextColor = Color.Gray;
                getdatabycategory("Dresses");
            }
            else if (sender.Equals(Travel))
            {
                Travel.TextColor = Color.White;
                Shoes.TextColor = Color.Gray;
                Dresses.TextColor = Color.Gray;
                Accessories.TextColor = Color.Gray;
                Bags.TextColor = Color.Gray;
                getdatabycategory("Travel");

            }
        }



    }
}