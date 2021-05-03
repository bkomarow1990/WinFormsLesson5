using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class City
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public List<string> PhotosUrls { get; set; } = new List<string>();
        public City(string name,string url, params string[] urls)
        {
            Name = name;
            URL = url;
            PhotosUrls.AddRange(urls);
        }

    }
}
