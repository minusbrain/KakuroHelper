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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KakuroHelper
{
    public partial class KakuroHelper : Form
    {
        public KakuroHelper()
        {
            helper = new KakuroBase();
            InitializeComponent();
            for (int i = 1; i < 10; ++i)
            {
                lstbMust.Items.Add(i);
                lstbMustNot.Items.Add(i);
            }
            //KakuroSolver solver = new KakuroSolver();
            //solver.Show();
        }

        private void btClear_Click(object sender, EventArgs e) {
            lstbMust.SelectedItems.Clear();
            lstbMustNot.SelectedItems.Clear();
            recalculateCombinations();
        }

        private void tbNumber_TextChanged(object sender, EventArgs e) {
            recalculateCombinations();
        }

        private void tbLength_TextChanged(object sender, EventArgs e) {
            recalculateCombinations();
        }

        private void lstbMustNot_SelectedValueChanged(object sender, EventArgs e) {
            recalculateCombinations();
        }

        private void lstbMust_SelectedValueChanged(object sender, EventArgs e) {
            recalculateCombinations();
        }

        private bool checkIfRecalculationIsPossible() {
            try {
                currentNumber = Convert.ToInt32(tbNumber.Text);
                currentLength = Convert.ToInt32(tbLength.Text);
            }
            catch (Exception) {
                return false;
            }

            return true;
        }

        private void recalculateCombinations() {
            if (checkIfRecalculationIsPossible() == true) {
                List<int> exclude = new List<int>();
                List<int> must = new List<int>();
                foreach (int i in lstbMust.SelectedItems) {
                    must.Add(i);
                }
                foreach (int i in lstbMustNot.SelectedItems) {
                    exclude.Add(i);
                }

                List<List<int>> result = helper.getPossibleCombinationsForSum(currentNumber, currentLength, exclude, must);

                lstbResult.Items.Clear();
                foreach (List<int> currentList in result) {
                    string s = "[ ";
                    foreach (int i in currentList) { s += i.ToString() + " "; }
                    s += "]";
                    lstbResult.Items.Add(s);
                }
            }
        }
        
        private KakuroBase helper;
        private int currentNumber = 0;
        private int currentLength = 0;
    }
}
