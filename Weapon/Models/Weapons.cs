namespace Weapon.Models
{
    public enum FireMode
    {
        Single,
        Auto 
    }
    public class Weapons
    {
        public int MagazineCapacity;
        public int NumberOfBulletsInTheMagazine;
        public double MagazineEmptyingTime;
        public FireMode ShootingMode;

        public FireMode FireMode { get; private set; }

        public Weapons(int magazinecapacity,int numberofbulletsinthemagazine,double magazineemptyingtime, FireMode shootingmode)
        {
            MagazineCapacity = magazinecapacity;
            NumberOfBulletsInTheMagazine = numberofbulletsinthemagazine;
            MagazineEmptyingTime = magazineemptyingtime;
            ShootingMode = shootingmode;
        }
        public void Shoot()
        {
            if(NumberOfBulletsInTheMagazine <= 0)
            {
                Console.WriteLine("Daraqda gulle qalmayib");
                return;
            }
            NumberOfBulletsInTheMagazine--;
            Console.WriteLine($"Atesh bash verdi,{ NumberOfBulletsInTheMagazine}");
        }
        public void Fire()
        {
            double timePerBullet = MagazineEmptyingTime / MagazineCapacity;
            double neededTime = timePerBullet * NumberOfBulletsInTheMagazine;
            Console.WriteLine($"{NumberOfBulletsInTheMagazine} gulle {neededTime:F2} saniyeye ateşlenecek.");
            while (NumberOfBulletsInTheMagazine > 0)
            {
                NumberOfBulletsInTheMagazine--;
                Console.WriteLine("Bang!");
            }
            Console.WriteLine("Gulle bitdi");
        }
        public void GetRemainBulletCount()
        {
            int count = MagazineCapacity - NumberOfBulletsInTheMagazine;
            Console.WriteLine($"lazimi gulle sayi, {count}");
        }
        public void Reload()
        {
            NumberOfBulletsInTheMagazine =MagazineCapacity;

        }
        public void ChangeFireMode()
        {
            if (FireMode == FireMode.Single)
            {
                FireMode = FireMode.Auto;
            }
            else
            {
                FireMode = FireMode.Single;
            }

        }

    }
}
