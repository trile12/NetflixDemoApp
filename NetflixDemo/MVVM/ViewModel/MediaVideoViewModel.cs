using NetflixDemo.Core;
using NetflixDemo.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.MVVM.ViewModel
{
    public class MediaVideoViewModel : ObservableObject
    {
        public ObservableCollection<int> Parts { get; set; }
        public ObservableCollection<MovieModel> Movies { get; set; }
        public MediaVideoViewModel()
        {
            Movies = new ObservableCollection<MovieModel>();
            Parts = new ObservableCollection<int>();
            for (int i = 1; i <= 24; i++)
            {
                Parts.Add(i);
            }
            CreateDataTest();
        }
        public void CreateDataTest()
        {
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
        }
    }
}
