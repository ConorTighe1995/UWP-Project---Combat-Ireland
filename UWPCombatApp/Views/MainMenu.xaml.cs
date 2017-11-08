﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCombatApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public ObservableCollection<AdaptItem> picItems_;

        private ObservableCollection<AdaptItem> PicItems
        {
            get
            {
                return picItems_;
            }
            set
            {
                picItems_ = value;
            }

        }

        public MainMenu()
        {
            this.InitializeComponent();
            picItems_ = AdaptItem.AdaptList();
            AGVC.ItemsSource = picItems_;

        }

        public void AGVC_ItemClick(object sender, Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            String catagory;
            if ((e.ClickedItem as AdaptItem).Title == "b1")
            {
                catagory = "Boxing";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b2")
            {

                catagory = "Karate";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b3")
            {

                catagory = "TKD";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b4")
            {

                catagory = "Kickboxing";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b5")
            {

                catagory = "MuayThai";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b6")
            {

                catagory = "BJJ";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b7")
            {

                catagory = "Judo";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "b8")
            {

                catagory = "MMA";

                MainPage.MyFrame.Navigate(typeof(DisplayDrills), catagory);
            }
            else if ((e.ClickedItem as AdaptItem).Title == "map")
            {
                try
                {
                    MainPage.MyFrame.Navigate(typeof(MapMenu));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                }
            }
            else if ((e.ClickedItem as AdaptItem).Title == "news")
            {
                try
                {
                    MainPage.MyFrame.Navigate(typeof(NewsMenu));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                }
            }

        }

    }
}
