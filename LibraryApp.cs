using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tugas_oop
{
    internal class LibraryApp
    {
        static void Main(string[] args)
        {
            LibraryCatalog<Book> library = new LibraryCatalog<Book>();
            Book baru = new Book("Bahasa Indonesia", "Yazid", 2020);
            Book baru2 = new Book("Database", "Yazid", 2021);
            //Console.WriteLine(baru.title);
            //library.Add("buku");
            library.AddBook(baru);
            library.AddBook(baru2);
            //library.ListBooks();
            bool loopContinue = true;
            int pilihanMenu;
            try { 
                while (loopContinue)
                {
                    Console.WriteLine("Pilih Menu dibawah ini.");
                    Console.WriteLine("1. Tambah Buku ke Katalog");
                    Console.WriteLine("2. Hapus Buku dari Katalog");
                    Console.WriteLine("3. Cari Buku");
                    Console.WriteLine("4. Tampilkan Semua Buku");
                    Console.WriteLine("5. Keluar");
                    Console.WriteLine("Masukan Pilihan : ");
                    pilihanMenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanMenu)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine();
                                Console.WriteLine("Tambah Buku");
                                Console.WriteLine("Judul Buku:");
                                string judulBuku = Console.ReadLine();
                                Console.WriteLine("Pengarang Buku:");
                                string pengarang = Console.ReadLine();
                                Console.WriteLine("Tahun Terbit Buku");
                                int tahun = Convert.ToInt32(Console.ReadLine());
                                library.AddBook(new Book(judulBuku, pengarang, tahun));
                                Console.WriteLine();
                            }
                            catch (Exception)
                            {
                                throw new Exception();
                            }
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Pilih Buku yang ingin dihapus?");
                            library.ListBooks();
                            int pilihanMenu2 = Convert.ToInt32(Console.ReadLine());
                            library.RemoveBook(pilihanMenu2);
                            library.ListBooks();
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Cari Buku Melalui Judul:");
                            string cariJudul = Console.ReadLine();
                            library.FindBook(cariJudul);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Daftar Semua Buku");
                            library.ListBooks();
                            Console.WriteLine();
                            break;
                        case 5:
                                Console.WriteLine();
                                Console.WriteLine("Keluar");
                                Console.WriteLine();
                                loopContinue =false;
                            break;
                        default:
                            throw new Exception();
                    }   
                }
                }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi Kesalahan Input");
                Console.WriteLine("Keluar..");
            }
        }
    }
}
