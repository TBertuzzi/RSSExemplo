using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RSSExemplo
{
    public partial class RSSWebViewPage : ContentPage
    {
        public RSSWebViewPage(string url)
        {
            InitializeComponent();

            webView.Source = url;
        }
    }
}
