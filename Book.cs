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
        // attribut buku yang masing masing memiliki method get set
        public string title { get; set; }
        public string author { get; set; }
        public int publicationYear { get; set; }

        // constructor, paling awal dieksekusi ketika create new book dan wajib diisi sesuai parameter
        public Book(string judul,string pengarang,int tahun)
        {
            title = judul;
            author = pengarang;
            publicationYear = tahun;
        }
    }
}
