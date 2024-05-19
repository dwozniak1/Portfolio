using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;


namespace _2200_WozniakD_Project02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Food> foodDict = new Dictionary<string, Food>();
        public MainWindow()
        {
            InitializeComponent();
            LoadNutritionalValues();
        }

        private void LoadNutritionalValues()
        {
            const string NUTRITION_FILE = "nutrition.txt"; // declare constant to store the name of the data file
            StreamReader inputFile; // create reference variable (object) of the StreamReader class            
            string[] tempFood; // declare array of string            

            // try-catch statement for simple exception handling

            try
            {
                inputFile = File.OpenText("nutrition.txt"); // call the OpenText method and assign value to inputFile      
                inputFile.ReadLine(); // skips first line (record) containing header information
                                      // loop for reading in records until end of file
                while (!inputFile.EndOfStream)
                {
                    tempFood = inputFile.ReadLine().Split(',');
                    cbFoods.Items.Add(tempFood[1]);
                    foodDict.Add(tempFood[1], new Food(tempFood));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow dw = new DetailWindow();
            string key = cbFoods.SelectedItem.ToString();
            Food food;

            if (foodDict.TryGetValue(key, out food))
            {
                dw.SetNutritionalValues(food);
                dw.Show();
            }
            else
            {
                {
                    MessageBox.Show($"Could not find {key} in the database.");
                }
            }
        }
    }
}
