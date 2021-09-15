using Caliburn.Micro;
using DataCore.DTOs;
using DataCore.Models;
using DataCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.ViewModels
{
    public class TablePageViewModel:Screen
    {
        public ICollection<Album> Ablums { get; set; } = new List<Album> {
                new Album { Title="1",Genres="aaa",Artists="adsf",Price=10},
                new Album { Title="11",Genres="aaa",Artists="adsf",Price=20},
                new Album { Title="12",Genres="aaa",Artists="adsf",Price=30},
                new Album { Title="13",Genres="aaa",Artists="adsf",Price=40},
                new Album { Title="14",Genres="aaa",Artists="adsf",Price=50},
                new Album { Title="15",Genres="aaa",Artists="adsf",Price=60},
                new Album { Title="16",Genres="aaa",Artists="adsf",Price=70},
                new Album { Title="17",Genres="aaa",Artists="adsf",Price=221},
                new Album { Title="18",Genres="aaa",Artists="adsf",Price=221},
                new Album { Title="91",Genres="aaa",Artists="adsf",Price=221},
                new Album { Title="10",Genres="aaa",Artists="adsf",Price=221},
                new Album { Title="10",Genres="aaa",Artists="adsf",Price=221},
            };
        private ICollection<TestApiDTO> _testApis;
        public ICollection<TestApiDTO> testApis
        {
            get { return _testApis; }
            set { this._testApis = value; NotifyOfPropertyChange(() => testApis);}
        }
        public TablePageViewModel()
        {
            //testApis = TestApiService.GetTestApis();
        }
        public async void btnRefresh()
        {
            testApis =await TestApiService.GetTestApis();
            //testApis = new List<TestApi> { new TestApi() { Id = 1, Name = "aaa", Age = 111, IsDeleted = false } };
        }
    }
    public class Album: PropertyChangedBase
    {
        private string? title;
        private string? genres;
        private string? artists;
        private decimal price;
        public string? Title
        {
            get => this.title;
            set { this.title = value; NotifyOfPropertyChange(() => Title); }
        }
        public string? Genres
        {
            get => this.genres;
            set { this.genres = value; NotifyOfPropertyChange(() => Genres); }
        }
        public string? Artists
        {
            get => this.artists;
            set { this.artists = value; NotifyOfPropertyChange(() => Artists); }
        }
        public decimal Price
        {
            get => this.price;
            set { this.price = value; NotifyOfPropertyChange(() => Price); }
        }
    }
}
