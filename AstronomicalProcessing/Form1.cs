/* Program: Astronomical Processing
 * Description: GUI application to view, sort, search, edit, and perform
 * statistical calculations on a simulated 24 hour period of neutrino data
 *
 *
 * Author: Samuel Dunlop, Astrodata Refinement, Sprint One
 * Created: 22/5/2025
 * Modified: 29/5/2025
 * Version: 2.0.0
 */

using System.Drawing.Text;
using System.Security.Cryptography;

namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessing : Form
    {
        // declare fields
        private int[] neutrinoValues = new int[24];
        private bool dataIsSorted = false, dataIsLoaded = false;

        public AstronomicalProcessing()
        {
            InitializeComponent();
        }

        /// <summary>
        /// populate the array with random values between 10 and 90 and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < neutrinoValues.Length; i++)
            {
                neutrinoValues[i] = rand.Next(10, 91);
            }

            dataIsLoaded = true;
            dataIsSorted = false;

            // clear math calculation boxes and display new array
            MidExtremeBox.Clear();
            ModeBox.Clear();
            MeanBox.Clear();
            RangeBox.Clear();
            DisplayArray();

            MessageBox.Show("Neutrino data loaded.");
        }

        /// <summary>
        /// populate the list box with values in the array
        /// </summary>
        private void DisplayArray()
        {
            DataListBox.Items.Clear();
            foreach (int neutrinoValue in neutrinoValues)
            {
                DataListBox.Items.Add(neutrinoValue);
            }
        }

        /// <summary>
        /// bubble sort the neutrino data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
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
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// sequential search function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SequentialSearchButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
            {
                // validate input
                if (int.TryParse(SearchBox.Text, out int target))
                {

                    // sequential search
                    for (int i = 0; i < neutrinoValues.Length; i++)
                    {
                        if (neutrinoValues[i] == target)
                        {
                            DataListBox.SelectedIndex = i;
                            MessageBox.Show($"Value found at list location {i + 1}.");
                            return;
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
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// binary search function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BinarySearchButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
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
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// replaces the selected index with user-provided value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
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
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// calculates the mid-extreme of the neutrino data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MidExtremeButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
            {
                int min = neutrinoValues[0], max = neutrinoValues[neutrinoValues.Length - 1];

                // if 
                if (!dataIsSorted)
                {
                    foreach (int neutrinoValue in neutrinoValues)
                    {
                        if (neutrinoValue < min)
                        {
                            min = neutrinoValue;
                        }
                        else if (neutrinoValue > max)
                        {
                            max = neutrinoValue;
                        }
                    }
                }

                MidExtremeBox.Text = $"{(double)(min + max) / 2.0}";
            }
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// calculates the mode of the neutrino data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
            {
                // count is set to 1 so we can skip comparing each value to itself
                int count = 1, maxCount = 0, mode = 0;

                // traverse neutrino array, skipping last value
                for (int i = 0; i < neutrinoValues.Length - 1; i++)
                {
                    // compare current value to all proceeding values
                    for (int j = i + 1; j < neutrinoValues.Length; j++)
                    {
                        if (neutrinoValues[j] == neutrinoValues[i])
                        {
                            count++;
                        }
                    }

                    // check if current value is mode, preferring lowest value
                    if (count > maxCount | (count == maxCount && neutrinoValues[i] < mode))
                    {
                        maxCount = count;
                        mode = neutrinoValues[i];
                    }

                    count = 1;
                }

                ModeBox.Text = $"{mode}, occurrs {maxCount} times";
            }
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// calculates the mean of the neutrino data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeanButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
            {
                int sum = 0;
                double mean;

                foreach (int neutrinoValue in neutrinoValues)
                {
                    sum += neutrinoValue;
                }

                mean = Double.Round((double)sum / (double)neutrinoValues.Length, 2);

                MeanBox.Text = $"{mean}";
            }
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }

        /// <summary>
        /// calculates the range of the neutrino data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RangeButton_Click(object sender, EventArgs e)
        {
            if (dataIsLoaded)
            {
                int min = neutrinoValues[0], max = neutrinoValues[neutrinoValues.Length - 1];

                if (!dataIsSorted)
                {
                    foreach (int neutrinoValue in neutrinoValues)
                    {
                        if (neutrinoValue < min)
                        {
                            min = neutrinoValue;
                        }
                        else if (neutrinoValue > max)
                        {
                            max = neutrinoValue;
                        }
                    }
                }

                RangeBox.Text = $"{max - min}";
            }
            else
            {
                MessageBox.Show("Please load some data first.");
            }
        }
    }
}
