using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tugas_oop
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int publicationYear { get; set; }

        public Book(string judul,string pengarang,int tahun)
        {
            title = judul;
            author = pengarang;
            publicationYear = tahun;
        }
    }
}
