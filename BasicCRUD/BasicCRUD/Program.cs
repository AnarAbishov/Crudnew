using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programin teyinati veya tesviri
            List<string> db = new List<string>();


            // Istifadeci ekrani
            void Instructions()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1.Melumat elave et");
                Console.WriteLine("2.Melumatlari goster");
                Console.WriteLine("3.Melumatlari yenile");
                Console.WriteLine("4.Melumati sil");
                Console.WriteLine("-----------------------------------");
                Console.Write("Icra etmek istediyiniz emrin nomresini daxil edin:");
                var emrNomresi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------");
                

                switch (emrNomresi)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    default:
                        Console.WriteLine("Daxil etdiyiniz emr movcud deyil, sizi ana ekrana yonlendirirem");
                        Instructions();
                        break;

                }

            }


            // Melumat elave etme prosesi

            void Create()
            {
                Console.Write("Elave etmek istediyiniz melumati daxil edin:");
                var createdData = Console.ReadLine();
                db.Add(createdData);
                Instructions();
            }

            // Melumat oxuma prosesi

            void Read()
            {
                var count = 0;
                foreach (var element in db)
                {
                    count++;
                    Console.WriteLine(count+"-"+element);
                    
                }
                Instructions();
            }

            // Melumat yenileme prosesi

            void Update()
            {
                Console.Write("Yenilemek istediyiniz melumatin sira nomresini daxil edin: ");
                var selectedDataRow = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yeni deyeri daxil edin: ");
                var updatedData = Console.ReadLine();
                db[selectedDataRow - 1]= updatedData;
                Instructions();
            }

            // Melumat silme prosesi

            void Delete()
            {
                Console.Write("Silmek istediyiniz melumatin sira nomresini daxil edin: ");
                var selectedDataRow = Convert.ToInt32(Console.ReadLine());
                db.Remove(db[selectedDataRow - 1]);
                Instructions();
            }

            Instructions();
        }
    }
}
