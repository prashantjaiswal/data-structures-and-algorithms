using System;
namespace DataStructuresAlgorithms.Recursion
{
    public class TowerOfHanoi
    {
        public void TowerOfHanoiSolution(int numberOfPlates, int towerA, int towerB, int towerC)
        {
            if(numberOfPlates > 0)
            {
                TowerOfHanoiSolution(numberOfPlates - 1, towerA, towerC, towerB);
                Console.WriteLine($"Move from: {towerA} to {towerC}");
                TowerOfHanoiSolution(numberOfPlates - 1, towerB, towerA, towerC);
            }
        }
    }
}
