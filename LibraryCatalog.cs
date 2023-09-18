using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tugas_oop
{
    interface IBook
    {
        void AddBook(Book Buku);
        void RemoveBook(Book Buku);
        void FindBook(string tittle);
        void ListBooks();
    }

    public class LibraryCatalog<T> : IBook
    {

        private Dictionary<string, Book> daftarBuku = new Dictionary<string, Book>();

        public void AddBook(Book Buku)
        {
            var judul = Buku.title.ToLower();
            //Console.WriteLine(judul);
            daftarBuku.Add(judul, Buku);
        }

        public void FindBook(string title)
        {
            var cek = daftarBuku.ContainsKey(title.ToLower());
            if (cek)
            {
                var buku = daftarBuku[title.ToLower()];
                Console.WriteLine("Buku ditemukan:");
                Console.WriteLine("Judul Buku: "+buku.title);
                Console.WriteLine("Author Buku: " + buku.author);
                Console.WriteLine("Tahun Buku: " + buku.publicationYear);
            }
            Console.WriteLine();
        }

        public void ListBooks()
        {
            Console.WriteLine("Jumlah: " + daftarBuku.Count());
            int index = 1;
            foreach (var item in daftarBuku)
            {
                Console.WriteLine(index + ". " + item.Value.title);
                index++;
            }
            Console.WriteLine();
        }
        public void RemoveBook(int id)
        {
            int index = 0;
            string judulBuku = "";
            Book buku;
            foreach (var item in daftarBuku)
            {
                index++;
                if (index == id)
                {
                    judulBuku = item.Key;
                    buku = item.Value;
                }
            }
            if(judulBuku == "")
            {
                Console.WriteLine("Buku Tidak Ditemukan");
            }
            else
            {
                Console.WriteLine("Buku Ditemukan");
                RemoveBook(daftarBuku[judulBuku.ToLower()]);
            }
        }
        public void RemoveBook(Book Buku)
        {
            daftarBuku.Remove(Buku.title.ToLower());
        }
    }
}
