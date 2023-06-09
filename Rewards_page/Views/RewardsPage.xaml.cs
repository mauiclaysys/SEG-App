using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Rewards_page.Views;

    public partial class RewardsPage : ContentPage
    {

        public List<string> CouponList { get; set; }
        public RewardsPage()
        {
            InitializeComponent();

            List<ListItem> Items = new List<ListItem>() {
              new ListItem{Image= "featured_offers_image.png", Title ="But X Save Y", Description= "But X Save Y", Expiry="Exp. 31/12"},
              new ListItem{Image= "featured_offers_image.png", Title ="But X Save Y", Description= "But X Save Y", Expiry="Exp. 31/12"},
              new ListItem{Image= "featured_offers_image.png", Title ="But X Save Y", Description= "But X Save Y", Expiry="Exp. 31/12"},
            };

            collectionView.ItemsSource = Items;

            CouponList = new List<string>()
            {
            "All coupons",
            "Picked for you",
            "Baby",
            "Backery",
            "Batteries",
            "All coupons",
            "Picked for you",
            "Baby",
            "Backery",
            "Batteries"
            };

            listView.ItemsSource = CouponList;

        }
        public class ListItem
        {
            public string Image { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Expiry { get; set; }
        }
    }


