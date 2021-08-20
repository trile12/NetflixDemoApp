using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.MVVM.Model
{
    public class MovieModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public int CategoryId { get; set; }
    }
}
