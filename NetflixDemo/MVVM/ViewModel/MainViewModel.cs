﻿using NetflixDemo.Core;
using NetflixDemo.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<MovieModel> Movies { get; set; }
        public ObservableCollection<CategoryModel> CategoryMovie { get; set; }

        private MovieModel _selectedMovie;

        public MovieModel SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                if(value!=null)
                {
                    _selectedMovie = value;
                }
                OnPropertyChanged();
            }
        }


        public RelayCommand SelectCommand { get; set; }

        public MainViewModel()
        {
            Movies = new ObservableCollection<MovieModel>();
            CategoryMovie = new ObservableCollection<CategoryModel>();
            CreateDataTest();
        }

        public void CreateDataTest()
        {
            //CategoryMovie.Add(new CategoryModel
            //{
            //    Id = 1,
            //    Name = "Action & Adventure",
            //    lstMovie = new ObservableCollection<MovieModel>()
            //    {
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B1.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B2.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B3.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Stranger Thing",
            //             Description = "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supermatural forces and one strange little girl.",
            //             ImageSource = "./Icons/BG2.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B5.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B6.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B7.jpg"
            //        }
            //    }
            //});
            //CategoryMovie.Add(new CategoryModel
            //{
            //    Id = 1,
            //    Name = "Science Fiction",
            //    lstMovie = new ObservableCollection<MovieModel>()
            //    {
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B10.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B9.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B6.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B3.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B1.jpg"
            //        },
            //        new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B7.jpg"
            //        },
            //                       new MovieModel
            //        {
            //             Name = "Super Man",
            //             Description = "Mô tả",
            //             ImageSource = "./Icons/B8.jpg"
            //        }     
            //    }
            //});

            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B1.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B3.jpg"
            });
            Movies.Add(new MovieModel
            {

                Name = "Stranger Thing",
                Description = "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supermatural forces and one strange little girl.",
                ImageSource = "./Icons/BG2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B5.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B6.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B7.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B8.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B9.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B1.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B2.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B3.jpg"
            });
            Movies.Add(new MovieModel
            {
                Name = "Super Man",
                Description = "Mô tả",
                ImageSource = "./Icons/B5.jpg"
            });


            SelectedMovie = Movies[3];
        }
    }
}
