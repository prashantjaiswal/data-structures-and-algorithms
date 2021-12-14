using System;
namespace DataStructuresAlgorithms.Recursion
{
    public class TowerOfHanoi
    {
        public void TowerOfHanoi(int numberOfPlates, int towerA, int towerB, int towerC)
        {
            if(numberOfPlates > 0)
            {
                TowerOfHanoi(numberOfPlates - 1, towerA, towerC, towerB);
                Console.WriteLine($"Move from: {towerA} to {towerC}");
                TowerOfHanoi(numberOfPlates - 1, towerB, towerA, towerC);
            }
        }
    }
}
