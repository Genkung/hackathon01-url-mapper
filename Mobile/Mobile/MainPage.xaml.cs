using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlMapper.Implement;
using Xamarin.Forms;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        string Url = "https://mana.com/linkto/A2348";
        string Pattern = "https://mana.com/linkto/{link-id}";

        public MainPage()
        {
            InitializeComponent();
            UrlMapper.Implement.SimpleStringParameterBuilder builder = new UrlMapper.Implement.SimpleStringParameterBuilder();
            UrlMapper.Implement.SimpleStringParameter praser = builder.Parse(Pattern) as UrlMapper.Implement.SimpleStringParameter;
            var IsMatch = praser.IsMatched(Url);

            this.MyUrl.Text = Url;
            this.MyPattern.Text = Pattern;
            this.MyIsMatch.Text = IsMatch.ToString();
        }
    }
}
