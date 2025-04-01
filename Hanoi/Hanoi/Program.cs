namespace HanoiTower
{
    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method of the Program Class
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="Exception">Exception raised if rings number at start is below 3</exception>
        static void Main(string[] args)
        {
            int rings = 3;
            /// Only the first array is initialized with the beggining values, according to the number of rings in the game
            int[] towerOrigin = OriginTower(rings);
            int[] towerIntermediate = new int[rings];
            int[] towerDestination = new int[rings];
            towerIntermediate = OtherTowers(towerIntermediate, rings);
            towerDestination = OtherTowers(towerDestination, rings);

            if (rings < 3)
            {
                throw new Exception("The selected amount of rings is not enough!");
            }

            DisplayTowers(towerOrigin, towerIntermediate, towerDestination);

            HanoiTowerGame(rings, towerOrigin, towerDestination, towerIntermediate);

            DisplayTowers(towerOrigin, towerIntermediate, towerDestination);
        }

        /// <summary>
        /// Recursive method for the game to proceed, stops when the parameter _rings reaches 0 
        /// </summary>
        /// <param name="rings">Number of rings in the game, used as a limit for the recursion</param>
        /// <param name="towerOrigin">First array, the Origin one</param>
        /// <param name="towerIntermediate">Second array, for the second tower</param>
        /// <param name="towerDestination">Final array, for the third tower</param>
        public static void HanoiTowerGame(int _rings, int[] _towerOrigin, int[] _towerDestination, int[] _towerIntermediate)
        {
            if (_rings == 1)
            {
                MoveRing(_towerOrigin, _towerDestination);
                return;
            }

            HanoiTowerGame(_rings - 1, _towerOrigin, _towerIntermediate, _towerDestination);

            MoveRing(_towerOrigin, _towerDestination);

            HanoiTowerGame(_rings - 1, _towerIntermediate, _towerDestination, _towerOrigin);
        }

        /// <summary>
        /// Method that handle the moving action of the rings
        /// Transfers the letter from Origin to Destination and erases it in Origin after
        /// </summary>
        /// <param name="rings">Number of rings in the game, to get the arrays values, with "- 1" to get the correct index</param>
        /// <param name="towerOrigin">The origin tower's array</param>
        /// <param name="towerDestination">The destination tower's array</param>
        private static void MoveRing(int[] _towerOrigin, int[] _towerDestination)
        {
            int indexOrigin = GetIndex(_towerOrigin);
            int indexDestination = GetIndex(_towerDestination);
            if (!CheckSize(_towerDestination[indexDestination], _towerOrigin[indexOrigin + 1]))
            {
                throw new Exception("A bigger ring was put on a smaller one!");
            }
            _towerDestination[indexDestination] = _towerOrigin[indexOrigin + 1];
            _towerOrigin[indexOrigin + 1] = 0;
        }

        /// <summary>
        /// Method that calculate the index we need for the MoveRing method
        /// </summary>
        /// <param name="_tower">The tower array that we need for the calculation of the index of its first positive value (its smaller ring)</param>
        /// <returns>The index of its first positive value, the smallest ring</returns>
        private static int GetIndex(int[] _tower)
        {
            int index = 0;
            if (Array.TrueForAll(_tower, x => x == 0))
            {
                index = _tower.Length - 1;
            }
            else
            {
                index = Array.IndexOf(_tower, _tower.FirstOrDefault(x => x > 0)) - 1;
            }
            return index;
        }

        /// <summary>
        /// Method that creates the Origin tower's array, with letters as string elements, at the beggining of the game
        /// </summary>
        /// <param name="rings">Size of the future Origin array</param>
        /// <returns>Returns a array with the specified numbers of letters</returns>
        private static int[] OriginTower(int _rings)
        {
            int[] intArray = new int[_rings];
            for (int i = 0; i < _rings; i++)
            {
                intArray[i] = i + 1;
            }
            return intArray;
        }

        /// <summary>
        /// Method that fills the other arrays with 0.
        /// </summary>
        /// <param name="_tower">The array corresponding to the tower passed in parameter</param>
        /// <param name="_rings">The number of entries in the array</param>
        /// <returns>An array filled with 0</returns>
        private static int[] OtherTowers(int[] _tower, int _rings)
        {
            for (int i = 0; i < _rings; i++)
            {
                _tower[i] = 0;
            }
            return _tower;
        }

        /// <summary>
        /// Method that displays the elements of an array of strings
        /// </summary>
        /// <param name="_tower">The tower passed as a parameter that we want to see displayed in the console</param>
        private static void DisplayTowers(int[] _towerOrigin, int[] _towerIntermediate, int[] _towerDestination)
        {
            for (int i = 0; i < _towerOrigin.Length; i++)
            {
                Console.WriteLine($"{_towerOrigin[i]} {_towerIntermediate[i]} {_towerDestination[i]}");
            }
        }

        /// <summary>
        /// Check if a smaller ring actually goes on a bigger one
        /// </summary>
        /// <param name="_destination">The destination tower</param>
        /// <param name="_origin">The origin tower</param>
        /// <returns></returns>
        private static bool CheckSize(int _destination, int _origin)
        {
            return _destination == 0 || _destination > _origin;
        }
    }
}




