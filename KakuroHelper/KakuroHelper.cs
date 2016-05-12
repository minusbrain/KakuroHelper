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
                lstbMust1.Items.Add(i);
                lstbMust2.Items.Add(i);
                lstbMust3.Items.Add(i);
            }
            //KakuroSolver solver = new KakuroSolver();
            //solver.Show();
        }

        private void btClear_Click(object sender, EventArgs e) {
            lstbMust1.SelectedItems.Clear();
            recalculateCombinations(1);
        }

        private void tbNumber_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(1);
        }

        private void tbLength_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(1);
        }

        private void lstbMust_SelectedValueChanged(object sender, EventArgs e) {
            recalculateCombinations(1);
        }

        private bool checkIfRecalculationIsPossible(int group) {
            try {
                if (group == 1) { 
                    currentNumber[0] = Convert.ToInt32(tbNumber1.Text);
                    currentLength[0] = Convert.ToInt32(tbLength1.Text);
                }
                else if (group == 2) {
                    currentNumber[1] = Convert.ToInt32(tbNumber2.Text);
                    currentLength[1] = Convert.ToInt32(tbLength2.Text);
                }
                else if (group == 3) {
                    currentNumber[2] = Convert.ToInt32(tbNumber3.Text);
                    currentLength[2] = Convert.ToInt32(tbLength3.Text);
                }
            }
            catch (Exception) {
                return false;
            }

            return true;
        }

        private void recalculateCombinations(int group) {
            if (checkIfRecalculationIsPossible(group) == true) {
                List<int> exclude = new List<int>();
                List<int> must = new List<int>();
                if (group == 1) { 
                    foreach (int i in lstbMust1.SelectedItems) {
                        must.Add(i);
                    }
                    //foreach (int i in lstbMustNot.SelectedItems) {
                    //    exclude.Add(i);
                    //}
                }
                else if (group == 2) {
                    foreach (int i in lstbMust2.SelectedItems) {
                        must.Add(i);
                    }
                }
                else if (group == 3) {
                    foreach (int i in lstbMust3.SelectedItems) {
                        must.Add(i);
                    }
                }

                List<List<int>> result = helper.getPossibleCombinationsForSum(currentNumber[group - 1], currentLength[group - 1], exclude, must);

                if(group == 1) lstbResult1.Items.Clear();
                else if (group == 2) lstbResult2.Items.Clear();
                else if (group == 3) lstbResult3.Items.Clear();

                foreach (List<int> currentList in result) {
                    string s = "[ ";
                    foreach (int i in currentList) { s += i.ToString() + " "; }
                    s += "]";
                    if (group == 1) lstbResult1.Items.Add(s);
                    else if (group == 2) lstbResult2.Items.Add(s);
                    else if (group == 3) lstbResult3.Items.Add(s);
                }
            }
        }

        private void menuLvl1About_Click(object sender, EventArgs e) {
            Form form = new AboutBox();
            form.ShowDialog();
        }

        private void menuLvl1Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
        private KakuroBase helper;
        private int[] currentNumber = {0,0,0};
        private int[] currentLength = {0,0,0};

        private void tbNumber2_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(2);
        }

        private void tbLength2_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(2);
        }

        private void tbNumber3_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(3);
        }

        private void tbLength3_TextChanged(object sender, EventArgs e) {
            recalculateCombinations(3);
        }

        private void btClear2_Click(object sender, EventArgs e) {
            lstbMust2.SelectedItems.Clear();
            recalculateCombinations(2);
        }

        private void btClear3_Click(object sender, EventArgs e) {
            lstbMust3.SelectedItems.Clear();
            recalculateCombinations(3);
        }

        private void lstbMust2_SelectedValueChanged(object sender, EventArgs e) {
            recalculateCombinations(2);
        }

        private void lstbMust3_SelectedValueChanged(object sender, EventArgs e) {
            recalculateCombinations(3);
        }
    }
}
