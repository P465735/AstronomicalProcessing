/* Program: Astronomical Processing
 * Description: Brief explanation of the program and list, Inputs, Processes, Outputs
 *
 *
 * Author: Samuel Dunlop, AstroData Refinement, Sprint One
 * Created: 22/5/2025
 * Modified: 26/5/2025
 * Version: 1.0
 */

using System.Drawing.Text;

namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessing : Form
    {
        // declare fields
        private int[] neutrinoValues = new int[24];
        private bool dataIsSorted = false;

        public AstronomicalProcessing()
        {
            InitializeComponent();
        }

        // populate the array with random values and display
        private void LoadButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < neutrinoValues.Length; i++)
            {
                neutrinoValues[i] = rand.Next(10, 91);
            }

            DisplayArray();
            MessageBox.Show("Neutrino data loaded.");
        }

        // populate the listbox
        private void DisplayArray()
        {
            DataListBox.Items.Clear();
            foreach (int neutrinoValue in neutrinoValues)
            {
                DataListBox.Items.Add(neutrinoValue);
            }
        }

        // bubble sort the neutrino data
        private void SortButton_Click(object sender, EventArgs e)
        {
            // declare variable for performing swaps
            int temp;

            // number of iterations is one less than array length because final value will already be sorted
            for (int i = 1; i < neutrinoValues.Length; i++)
            {
                // sort next highest value to end of unsorted values
                for (int j = 0; j < neutrinoValues.Length - i; j++)
                {
                    // swap values if left value is higher
                    if (neutrinoValues[j] > neutrinoValues[j + 1])
                    {
                        temp = neutrinoValues[j];
                        neutrinoValues[j] = neutrinoValues[j + 1];
                        neutrinoValues[j + 1] = temp;
                    }
                }
            }

            dataIsSorted = true;
            DisplayArray();
            MessageBox.Show("Data sorted.");
        }

        // binary search function
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // check if data has been sorted before searching
            if (dataIsSorted)
            {
                // validate input
                if (int.TryParse(SearchBox.Text, out int target))
                {
                    int min = 0;
                    int max = neutrinoValues.Length;
                    int mid;

                    // binary search
                    while (min < max)
                    {
                        mid = (min + max) / 2; // find middle value
                        if (neutrinoValues[mid] == target)
                        {
                            DataListBox.SelectedIndex = mid;
                            MessageBox.Show($"Value found at list location {mid + 1}.");
                            return; // exit early if value found
                        }
                        else if (neutrinoValues[mid] > target) // select the left half of the array
                        {
                            max = mid - 1;
                        }
                        else // select the right half of the array
                        {
                            min = mid + 1;
                        }
                    }

                    MessageBox.Show("Value not found.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid search term.");
                }
            }
            else
            {
                MessageBox.Show("Data must be sorted first.");
            }
        }

        // replaces the selected index with user-provided value
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // check the user has selected a value to edit
            if (DataListBox.SelectedIndex != -1)
            {
                // set the selected value to the new value
                if (int.TryParse(EditBox.Text, out int newValue))
                {
                    neutrinoValues[DataListBox.SelectedIndex] = newValue;

                    // data must be sorted again before search
                    dataIsSorted = false;
                    DisplayArray();
                }
                else
                {
                    MessageBox.Show("Please enter a valid value first.");
                }
            }
            else
            {
                MessageBox.Show("Please select a value to edit.");
            }
        }
    }
}
