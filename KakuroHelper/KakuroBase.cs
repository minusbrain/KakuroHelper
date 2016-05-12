/*  Kakuro Helper - Support solving kakuro puzzles (http://www.kakuro.com/)
    Copyright (C) 2016  Andreas Evers

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakuroHelper
{
    public class KakuroBase
    {
        public KakuroBase(int min = 1, int max = 9)
        {
            _minFieldValue = min;
            _maxFieldValue = max;
        }

        private void getPossibleCombinationsForSumRecursive(int sum, int size, int currentValue, ref List<int> currentList, ref List<List<int>> lists)
        {
            if (size == 0 || sum < currentValue)
            {
                return;
            }
            for (int i = currentValue; i <= _maxFieldValue; ++i)
            {
                if (sum == i && size == 1)
                {
                    List<int> newList = new List<int>(currentList);
                    currentList.Add(i);
                    lists.Add(currentList);
                    currentList = newList;
                    return;
                }
                else if (sum < i)
                {
                    return;
                }
                else
                {
                    currentList.Add(i);
                    getPossibleCombinationsForSumRecursive(sum - i, size - 1, i + 1, ref currentList, ref lists);
                    currentList.Remove(i);
                }
            }
        }

        private List<List<int>> getPossibleCombinationsForSum(int sum, int size)
        {
            List<List<int>> lists = new List<List<int>>();
            List<int> currentList = new List<int>();
            int currentValue = _minFieldValue;

            getPossibleCombinationsForSumRecursive(sum, size, currentValue, ref currentList, ref lists);

            return lists;
        }

        public List<List<int>> getPossibleCombinationsForSum(int sum, int size, List<int> exclude, List<int> mustContain)
        {
            List<List<int>> lists = getPossibleCombinationsForSum(sum, size);

            if (exclude != null)
            {
                foreach (int i in exclude)
                {
                    lists.RemoveAll(list => list.Contains(i));
                }
            }

            if (mustContain != null)
            {
                foreach (int i in mustContain)
                {
                    lists.RemoveAll(list => !list.Contains(i));
                }
            }

            return lists;
        }

        private int _maxFieldValue;
        private int _minFieldValue;
    }
}
