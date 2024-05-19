using LuxGamingShop.Models;

namespace LuxGamingShop.ViewModels
{
    public class HomeIndexVM
    {
        public List<Feature> Features { get; set; }

        public List<Gaming> Gamings { get; set; }

        public List<HomePageTrendingGames> TrendingGames { get; set; }

        public List<HomePageIntro> Intro { get; set; }
    }
}
