using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TestWpfProj.Data
{
    public class FilmGanr
    {
        public FilmGanr(string title)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            //Data = data;
            //Otsenka = otsenka;
            //Picture = picture;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        //public string Ganr { get; set; }
        //public DateTime Data { get; set; }
        //public double Otsenka { get; set; }
        //public string Picture { get; set; }
    }
}
