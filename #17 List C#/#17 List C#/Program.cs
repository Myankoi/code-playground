using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_List_C_
{
    internal class Program
    {
        static List<string> myList = new List<string>();
        static Identitas idt = new Identitas();
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadLine();
        }

        static void MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            idt.MyIdt();
            Console.WriteLine("\n=== Menu List ===");
            Console.WriteLine("1. Tambahkan dan tampilkan data dalam List");
            Console.WriteLine("2. Update dan tampilkan data dalam List");
            Console.WriteLine("3. Hapus dan tampilkan data dalam List\n");
            Console.Write("Pilih: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    AddData();
                    break;
                case "2":
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("List masih kosong! Silahkan tambahkan data terlebih dahulu!");
                        Back("ke main menu");
                        MainMenu();
                    }
                    else
                    {
                        Console.Clear();
                        UpdateData();
                    }
                    break;
                case "3":
                    if (myList.Count == 0)
                    {
                        Console.WriteLine("List masih kosong! Silahkan tambahkan data terlebih dahulu!");
                        Back("ke main menu");
                        MainMenu();
                    }
                    else
                    {
                        Console.Clear();
                        DeleteData();
                    }
                    break;
                default:
                    Console.WriteLine("Pilih menu dari 1-3!");
                    Back("ke menu");
                    MainMenu();
                    break;
            }
        }

        static void AddData()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            idt.MyIdt();
            Console.WriteLine("\n=== Menambah data ke List ===");
            if(myList.Count == 0)
            {
                Console.Write("Jumlah data yang ingin diinput : ");
                bool isValidAmmount = int.TryParse(Console.ReadLine(), out int dataAmmount);
                if (!isValidAmmount)
                {
                    Back("mengulang");
                    AddData();
                }
                else
                {
                    for (int i = 0; i < dataAmmount; i++)
                    {
                        Console.Write($"Masukan data ke {i + 1}: ");
                        string data = Console.ReadLine();
                        myList.Add(data);
                    }

                    LoadData();
                    Back("ke main menu");
                    MainMenu();
                }
            } else
            {
                LoadData();
                Console.WriteLine("\n1. Tambahkan data untuk disisip ke List");
                Console.WriteLine("2. Tambahkan data diawal List");
                Console.WriteLine("3. Tambahkan data diakhir List");
                Console.Write("Pilih: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Masukan index data yang akan disisip: ");
                        Console.Write("Pilih: ");
                        bool isIndex = int.TryParse(Console.ReadLine(), out int index);
                        if (!isIndex)
                        {
                            Console.WriteLine("Input tidak valid! harus bertipe Integer!");
                            Back("mengulang");
                            AddData();
                        }
                        else
                        {
                            Console.Write("Jumlah data yang ingin diinput : ");
                            bool isValidAmmount = int.TryParse(Console.ReadLine(), out int dataAmmount);
                            if (!isValidAmmount)
                            {
                                Back("mengulang");
                                AddData();
                            }
                            else
                            {
                                for (int i = 0; i < dataAmmount; i++)
                                {
                                    Console.Write($"Masukan data ke {i + 1}: ");
                                    string data = Console.ReadLine();
                                    myList.Insert(index + i, data);
                                }

                                Console.WriteLine("Mensisipkan data selesai!");
                                LoadData();
                                Back("ke main menu");
                                MainMenu();
                            }
                        }
                        break;
                    case "2":
                        Console.Write("Jumlah data yang ingin diinput : ");
                        bool isValidAmmount2 = int.TryParse(Console.ReadLine(), out int dataAmmount2);
                        if (!isValidAmmount2)
                        {
                            Back("mengulang");
                            AddData();
                        }
                        else
                        {
                            for (int i = 0; i < dataAmmount2; i++)
                            {
                                Console.Write($"Masukan data ke {i + 1}: ");
                                string data = Console.ReadLine();
                                myList.Insert(0, data);
                            }

                            Console.WriteLine("Menambah data di awal selesai!");
                            LoadData();
                            Back("ke main menu");
                            MainMenu();
                        }
                        break;
                    case "3":
                        Console.Write("Jumlah data yang ingin diinput : ");
                        bool isValidAmmount3 = int.TryParse(Console.ReadLine(), out int dataAmmount3);
                        if (!isValidAmmount3)
                        {
                            Back("mengulang");
                            AddData();
                        }
                        else
                        {
                            for (int i = 0; i < dataAmmount3; i++)
                            {
                                Console.Write($"Masukan data ke {i + 1}: ");
                                string data = Console.ReadLine();
                                myList.Add(data);
                            }

                            Console.WriteLine("Menambah data di akhir selesai!");
                            LoadData();
                            Back("ke main menu");
                            MainMenu();
                        }
                        break;
                    default:
                        Console.WriteLine("Pilih menu dari 1-3!");
                        Back("ke menu");
                        MainMenu();
                        break;
                }
            }
        }

        static void UpdateData()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            idt.MyIdt();
            Console.WriteLine("=== Update data ke List ===");
            LoadData();

            Console.WriteLine("\n1. Ubah data dari list");
            Console.WriteLine("2. Ubah urutan list menjadi ascending");
            Console.WriteLine("3. Ubah urutan list menjadi decending");
            Console.Write("Pilih: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Masukkan nomor data yang ingin diupdate: ");
                    bool isValidIndex = int.TryParse(Console.ReadLine(), out int index);
                    int nomor = index - 1;
                    if (!isValidIndex)
                    {

                    }
                    else
                    {
                        if (nomor < 0 || nomor >= myList.Count)
                        {
                            Console.WriteLine("Nomor data tidak valid.");
                            Back("ke main menu");
                            MainMenu();
                        }

                        Console.Write("Masukkan data baru: ");
                        string newData = Console.ReadLine();
                        myList[nomor] = newData;
                        Console.WriteLine($"Data pada nomor {index + 1} telah diupdate menjadi '{newData}'.");
                        LoadData();
                        Back("ke main menu");
                        MainMenu();
                    }
                    break;
                case "2":
                    myList.Sort();
                    LoadData();
                    Back("ke main menu");
                    MainMenu();
                    break;
                case "3":
                    myList.Sort((x, y) => y.CompareTo(x));
                    LoadData();
                    Back("ke main menu");
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Pilihan harus diantara 1-3");
                    Back("ke main menu");
                    MainMenu();
                    break;
            }
        }

        static void DeleteData()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            idt.MyIdt();
            Console.WriteLine("=== Hapus data dari List ===");
            LoadData();
            Console.Write("Masukkan nomor data yang ingin dihapus: ");
            bool isValidIndex = int.TryParse(Console.ReadLine(), out int index);
            int nomor = index - 1;
            if (!isValidIndex)
            {
                Console.WriteLine("Input harus angka!");
                Back("mengulang");
                DeleteData();
            }
            else
            {
                if (index < 0 || index >= myList.Count)
                {
                    Console.WriteLine("Nomor data tidak valid.");
                    Back("ke main menu");
                    MainMenu();
                }
                string removedData = myList[nomor];
                myList.RemoveAt(nomor);
                Console.WriteLine($"Data '{removedData}' telah dihapus.");
                LoadData();
                Back("ke main menu");
                MainMenu();
            }
        }

        static void Back(string tujuan)
        {
            Console.Write($"\nKlik Enter untuk kembali {tujuan}!");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        static void LoadData()
        {
            Console.WriteLine("\nIsi List :");
            int i = 0;
            foreach (var item in myList)
            {
                Console.WriteLine($"{i + 1}. {item}");
                i++;
            }
        }
    }
}
