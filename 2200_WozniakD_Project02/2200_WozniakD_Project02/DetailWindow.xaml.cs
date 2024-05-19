using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace _2200_WozniakD_Project02
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        internal void SetNutritionalValues(Food food)
        {
            lbFoodName.Content = food.FoodName;
            lbFoodType.Content = food.FoodType;
            lbServingSize.Content = food.ServingSize;
            lbWeight.Content = food.Weight.ToString();
            lbPercentWater.Content = food.PercentWater.ToString();
            lbCalories.Content = food.Energy.ToString();
            lbProtein.Content = food.Protein.ToString();
            lbCarbohydrates.Content = food.Carbohydrates.ToString();
            lbFiber.Content = food.Fiber.ToString();
            lbCholesterol.Content = food.Cholesterol.ToString();
            lbCalcium.Content = food.Calcium.ToString();
            lbTotalFat.Content = food.TotalFat.ToString();
            lbSaturatedFat.Content = food.SaturateFat.ToString();
            lbMonosatFat.Content = food?.MonosatFat.ToString();
            lbPolyunsatFat.Content = food?.PolyunsatFat.ToString();
            lbIron.Content = food?.Iron.ToString();
            lbMagnesium.Content = food?.Magnesium.ToString();
            lbSodium.Content = food?.Sodium.ToString();
            lbPhosphorous.Content = food.Phosphorous.ToString();
            lbCapRation.Content = food.CaPRation.ToString();
            lbZinc.Content = food?.Zinc.ToString();
            lbNiacin.Content = food?.Niacin.ToString();
            lbThiamin.Content = food?.Thiamin.ToString();
            lbRiboflavin.Content = food.Riboflavin.ToString();
            lbVitaminA.Content = food.VitA.ToString();
        }
    }
}
