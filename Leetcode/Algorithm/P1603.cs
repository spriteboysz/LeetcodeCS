/*
 * Author: Deean
 * Date: 2023-03-28 23:43:37
 * FileName: P1603.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1603 {
    public class ParkingSystem {
        private int big, medium, small;

        public ParkingSystem(int big, int medium, int small) {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType) {
            switch (carType) {
                case 1:
                    if (big-- > 0) return true;
                    break;
                case 2:
                    if (medium-- > 0) return true;
                    break;
                case 3:
                    if (small-- > 0) return true;
                    break;
            }
            return false;
        }
    }

    public static void Test() {
        ParkingSystem parking = new ParkingSystem(1, 1, 0);
        Console.WriteLine(parking.AddCar(1));
        Console.WriteLine(parking.AddCar(2));
        Console.WriteLine(parking.AddCar(3));
        Console.WriteLine(parking.AddCar(4));
    }
}