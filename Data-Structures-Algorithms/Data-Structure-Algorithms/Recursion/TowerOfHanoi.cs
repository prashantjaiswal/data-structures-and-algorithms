using System;
namespace DataStructuresAlgorithms.Recursion
{
    public class TowerOfHanoi
    {
        public void TowerOfHanoiOperation(int numberOfPlates, int towerA, int towerB, int towerC)
        {
            if(numberOfPlates > 0)
            {
                TowerOfHanoiOperation(numberOfPlates - 1, towerA, towerC, towerB);
                Console.WriteLine($"Move from: {towerA} to {towerC}");
                TowerOfHanoiOperation(numberOfPlates - 1, towerB, towerA, towerC);
            }
        }
    }
}
