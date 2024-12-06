using PB_503_Recap_OOP_.Enum;
using PB_503_Recap_OOP_.Exceptions;
using PB_503_Recap_OOP_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.WebRequestMethods;

namespace PB_503_Recap_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combCapacity;
            int bulletNumber;
            int fireModeInput;
            Weapon weapon = null;
            try
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter comb capacity:");
                        combCapacity = Convert.ToInt32(Console.ReadLine());
                        if (combCapacity <= 0)
                        {
                            throw new InvalidCombCapasityException("Comb capacity must be greater than 0!");
                        }
                        break;

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Eror: {ex.Message}");
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter bullet number:");
                        bulletNumber = Convert.ToInt32(Console.ReadLine());

                        if (bulletNumber < 0)
                        {
                            throw new InvalidBulletNumberException("Bullet number must be greater than 0!");
                        }
                        if (bulletNumber > combCapacity)
                        {
                            throw new InvalidBulletNumberException("Bullet number cannot be high than comb capasity");
                        }

                        break;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Eror: {ex.Message}");
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Choose Fire Mode:");
                        Console.WriteLine("1 - Shoot");
                        Console.WriteLine("2 - Burst");
                        Console.WriteLine("3 - Automatic");
                        fireModeInput = Convert.ToInt32(Console.ReadLine());
                        if (fireModeInput < 1 || fireModeInput > 3)
                        {
                            throw new InvalidFireModeException("Invalid fire mode selected!");
                        }
                        FireTypeEnum fireMode = (FireTypeEnum)fireModeInput;
                        Console.WriteLine($"Weapon fire mod: {fireMode}");
                        weapon = new Weapon(combCapacity, bulletNumber, fireMode);
                        Console.WriteLine("Weapon successfully created!");
                        break;
                    }
                    catch (InvalidFireModeException ex)
                    {
                        Console.WriteLine($"Fire mode error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eror:{ex.Message}");
            }

            Console.WriteLine("Please choose operation");
            Console.WriteLine("0 - Get information");
            Console.WriteLine("1 - Shoot ");
            Console.WriteLine("2 - Fire ");
            Console.WriteLine("3 - GetRemainBulletCount");
            Console.WriteLine("4 - Reload ");
            Console.WriteLine("5 - ChangeFireMode ");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("7 - Edit");

            int count;
            
            do
            {
                count = Convert.ToInt32(Console.ReadLine());
                switch (count)
                {
                    case 0:
                        Console.WriteLine($"Weapon Comb capasity:{weapon.CombCapacity}, Weapon Bullet number:{weapon.BulletNumber}, Weapon fire mod:{weapon.FireMod}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Stop program...");
                        break;
                    case 7:
                        int number;
                        Console.WriteLine("Please choose:");
                        Console.WriteLine("8 - Change Comb capasity ");
                        Console.WriteLine("9 - Change Bullet number");
                        Console.WriteLine("10 - Exit main menu");
                        do
                        {
                           
                            number = Convert.ToInt32(Console.ReadLine());
                            switch (number)
                            {
                                case 8:
                                    Console.WriteLine("Please add new comb capasity");
                                    int newCombCapasity = Convert.ToInt32(Console.ReadLine());
                                    if (newCombCapasity > 0)
                                    {
                                        weapon.CombCapacity = newCombCapasity;
                                    }
                                    break;

                                case 9:
                                    Console.WriteLine("Please add new number");
                                    int newNumber = Convert.ToInt32(Console.ReadLine());
                                    if (newNumber > 0)
                                    {
                                        weapon.BulletNumber = newNumber;
                                        Console.WriteLine("Buller number updated");
                                    }
                                    break;
                                case 10:
                                    Console.WriteLine("Returned to main menu");
                                    Console.WriteLine("Please choose operation");
                                    Console.WriteLine("0 - Get information");
                                    Console.WriteLine("1 - Shoot ");
                                    Console.WriteLine("2 - Fire ");
                                    Console.WriteLine("3 - GetRemainBulletCount");
                                    Console.WriteLine("4 - Reload ");
                                    Console.WriteLine("5 - ChangeFireMode ");
                                    Console.WriteLine("6 - Exit");
                                    Console.WriteLine("7 - Edit");
                                    break;
                                default:
                                    Console.WriteLine("Please choose true operation");
                                    break;


                            }
                        }
                        while (number != 10);
                        break;
                    default:
                        Console.WriteLine("Please choose true operation");
                        break ;
                }

            }
            while (count != 6);

        
        }
    }
}


                   


            




        
                  
  
    

























            








