using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tugas_oop
{
    // sebuah Collection atau Interface yang berisi method-method untuk mengatur daftar buku
    interface IBook
    {
        void AddBook(Book Buku);
        void RemoveBook(Book Buku);
        void FindBook(string tittle);
        void ListBooks();
    }

    // penerapan generic class <T> 
    public class LibraryCatalog<T> : IBook // menerapkan collection interface
    {
        // dictionary untuk menampung daftar buku
        private Dictionary<string, Book> daftarBuku = new Dictionary<string, Book>();

        // method tambah buku ke daftar
        public void AddBook(Book Buku)
        {
            var judul = Buku.title.ToLower();
            daftarBuku.Add(judul, Buku);
        }

        // method cari buku dalam daftar
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

        // method menampilkan daftar buku
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
        // method menghapus buku dari daftar sesuai nomor urutan yang dipilih
        public void RemoveBook(int id)
        {
            int index = 0;
            string judulBuku = "";
            Book buku;
            // cari buku berdasarkan id yang dipilih saat input
            foreach (var item in daftarBuku)
            {
                index++;
                if (index == id)
                {
                    judulBuku = item.Key;
                    buku = item.Value;
                }
            }
            //  ada atai tidak buku dalam daftar
            if(judulBuku == "")
            {
                Console.WriteLine("Buku Tidak Ditemukan");
            }
            else
            {
                // jika ada hapus buku dari daftar
                Console.WriteLine("Buku Ditemukan");
                RemoveBook(daftarBuku[judulBuku.ToLower()]);
            }
        }
        // method hapus buku dari daftar
        public void RemoveBook(Book Buku)
        {
            daftarBuku.Remove(Buku.title.ToLower());
        }
    }
}
