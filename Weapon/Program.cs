using Weapon.Models;
namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapons weapon = new Weapons(30, 30, 5, FireMode.Auto);
            weapon.Shoot();
            weapon.Shoot(); weapon.Shoot();
            weapon.GetRemainBulletCount();
            weapon.Reload(); weapon.Shoot();
            weapon.ChangeFireMode();
            weapon.Fire();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Weapon Menyu =====");
                Console.WriteLine("0 - İnformasiya almaq");
                Console.WriteLine("1 - Shoot");
                Console.WriteLine("2 - Fire");
                Console.WriteLine("3 - GetRemainBulletCount");
                Console.WriteLine("4 - Reload");
                Console.WriteLine("5 - ChangeFireMode");
                Console.WriteLine("6 - Proqramdan çıx");
                Console.WriteLine("7 - Redaktə et (T/S/D)");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        weapon.Shoot();
                        break;

                    case "2":
                        weapon.Fire();
                        break;

                    case "3":
                        weapon.GetRemainBulletCount();
                        break;

                    case "4":
                        weapon.Reload();
                        break;

                    case "5":
                        weapon.ChangeFireMode();
                        break;

                    case "6":
                        Console.WriteLine("Proqram dayandırılır...");
                        return;

                    default:
                        Console.WriteLine("Yanlış seçim etdiniz.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Davam etmək üçün hər hansı düyməyə bas...");
                Console.ReadKey();

            }
        }
    }
}
