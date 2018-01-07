using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCommandBarWebViewMapControl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // *** Comment/uncomment to demo overriding xaml webview and various ways to navigate with webview ***

            //Uri saraWebApp = new Uri("http://codefellowswebapp.herokuapp.com");
            //WebView1.Source = saraWebApp;

            //WebView1.NavigateToString("<center>Navigate to this html string</center>");

            //WebView1.Navigate(new Uri("ms-appx-web:///help.html"));

            // *** MapControl ***

            Geopoint point1 = new Geopoint(new BasicGeoposition() {
                Latitude = 45,
                Longitude = -75
            });

            map1.Center = point1;

            // Comment/uncomment next lines and .xaml file line to demo tick mark
            //MapControl.SetLocation(tickMark, point1);
            //MapControl.SetNormalizedAnchorPoint(tickMark, new Windows.Foundation.Point(0.5, 0.5));

            MapControl.SetLocation(skates, point1);
            MapControl.SetNormalizedAnchorPoint(skates, new Windows.Foundation.Point(0.5, 0.5));
        }
    }
}
