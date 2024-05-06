using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfProj.Data
{
    public static class DataContext
    {
        public static List<Film> Films = new List<Film>()
        {
            new Film("Megusto", "romantic", new DateTime(02,02,2022), 5.8,""),
            new Film("bruh", "romantic", new DateTime(02,02,2022), 5.8,""),
            new Film("Omsk", "romantic", new DateTime(02,02,2022), 5.8,""),
            new Film("MalishkaHochetSdatPraktiku", "romantic", new DateTime(02,02,2022), 5.8,""),
            new Film("Sigma", "romantic", new DateTime(02,02,2022), 5.8,"")
        };
    }
}
