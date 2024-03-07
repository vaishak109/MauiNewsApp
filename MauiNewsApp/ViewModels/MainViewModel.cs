using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiNewsApp.Helpers;
using MauiNewsApp.Models;
using MauiNewsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNewsApp.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        public ObservableRangeCollection<News> NewsList { get; } = new();
        public ObservableRangeCollection<News> NewsCarousel { get; } = new();
        INewsService newsService;
        public ICollection<NewsCategory> NewsCategories { get; set; }
        public MainViewModel(INewsService service)
        {
            Console.WriteLine("MainViewModel invoked");
            newsService = service;
            NewsCategories = service.GetNewsCategories();
        }

        [ObservableProperty]
        bool isRefreshing = true;

        [RelayCommand]
        async Task GetNewsListAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                Console.WriteLine("Calling api");

                var newsResult = await newsService.GetNewsAsync();

                if (NewsList.Count != 0)
                    NewsList.Clear();
                if (NewsCarousel.Count != 0)
                    NewsCarousel.Clear();
                List<News> articles = (List<News>)newsResult.Articles;
                NewsList.AddRange(articles);
                NewsCarousel.AddRange(articles.Take(5));
                Console.WriteLine("Added range");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get News List {ex.StackTrace}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }

        }

    }
}
