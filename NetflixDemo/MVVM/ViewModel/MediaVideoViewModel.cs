using NetflixDemo.Core;
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
        public MediaVideoViewModel()
        {
            Parts = new ObservableCollection<int>();
            for (int i = 1; i <= 24; i++)
            {
                Parts.Add(i);
            }
        }
    }
}
