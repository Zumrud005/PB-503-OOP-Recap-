using PB_503_Recap_OOP_.Enum;
using PB_503_Recap_OOP_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Recap_OOP_.Models
{
    public class Weapon
    {
       
        public int CombCapacity {  get; set; }
        
        
        public int BulletNumber { get; set; }
        
           
        
        public FireTypeEnum FireMod { get; set; }
        public Weapon(int combCapasity, int bulletNumber, FireTypeEnum fireMod)
        {
            CombCapacity = combCapasity;
            BulletNumber = bulletNumber;
            FireMod = fireMod;
        }


       

        public void Shoot()
        {
            if (BulletNumber > 0)
            {
                BulletNumber -= 1;
                Console.WriteLine("1 shot fired");
            }
            else
            {
                Console.WriteLine("No bullets left to shoot!");
            }
        }

        public void Fire()
        {
            if (BulletNumber > 0)
            {
                int bulletsToFire = GetBulletsToFire();

                if (BulletNumber < bulletsToFire)
                {
                    throw new EnoughBulletsException("Not enough bullets to fire the desired mode");
                }
                else
                {
                    BulletNumber -= bulletsToFire;
                    Console.WriteLine($"{bulletsToFire} bullets fired in {FireMod} mode.");

                }
            }
            else { throw new InvalidBulletNumberException("Bullet number cannot be 0 or negative"); }
        
        }


        public int GetRemainBulletCount()
        {
            if (BulletNumber >= CombCapacity)
            {
                throw new InvalidReloadUseException("Bulletnumber cannot be greater or less than combcapacity");
            }
            else
            {
                return CombCapacity - BulletNumber;
            }

        }

        public void Reload()
        {
            if (BulletNumber >= 0 && BulletNumber < CombCapacity)
            {
                BulletNumber = CombCapacity;
                Console.WriteLine("The comb is full");
            }
            else { Console.WriteLine("Try combcapasity or bulletnumber"); }
        }

        private int GetBulletsToFire()
        {
            switch (FireMod)
            {
                case FireTypeEnum.Shoot:
                    return 1;
                case FireTypeEnum.Burst:
                    return 3;
                case FireTypeEnum.Automatic:
                    return BulletNumber;
                default:
                    return 0;
            }
        }

        public void ChangeFireMode()
        {

            int count = 0;
            if (FireMod == FireTypeEnum.Shoot)
            {

                Console.WriteLine("Choose new fire mod:");
                Console.WriteLine("1- Change Burst");
                Console.WriteLine("2-Automatic");
                count = Convert.ToInt32(Console.ReadLine());
                switch (count)
                {
                    case 1:
                        FireMod = FireTypeEnum.Burst;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    case 2:
                        FireMod = FireTypeEnum.Automatic;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    default:
                        Console.WriteLine("Please choose true mode");
                        break;
                }
            }
            else if (FireMod == FireTypeEnum.Burst)
            {
                Console.WriteLine("Choose new fire mod:");
                Console.WriteLine("0- Change Shoot");
                Console.WriteLine("2-Change Automatic");
                count = Convert.ToInt32(Console.ReadLine());
                switch (count)
                {
                    case 0:
                        FireMod = FireTypeEnum.Shoot;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    case 2:
                        FireMod = FireTypeEnum.Automatic;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    default:
                        Console.WriteLine("Please choose true mode");
                        
                        break;
                }
            }
            else
            {
                Console.WriteLine("Choose new fire mod:");
                Console.WriteLine("0- Change Shoot");
                Console.WriteLine("1-Change Burst");
                count = Convert.ToInt32(Console.ReadLine());
                switch (count)
                {
                    case 0:
                        FireMod = FireTypeEnum.Shoot;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    case 1:
                        FireMod = FireTypeEnum.Burst;
                        Console.WriteLine($"New fire mod: {FireMod}");
                        break;
                    default:
                        Console.WriteLine("Please choose true mode");
                        break;
                }
            }

            





        }

    }

}








