using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2200_WozniakD_Project02
{
    public class Food
    {
        public Food(string[] food)
        {
            FoodName = food[0];
            FoodType = food[1];
            ServingSize = food[2][0];
            Weight = food[4][0];
            PercentWater = food[5][0];
            Energy = food[6][0];
            Protein = food[7][0];
            Carbohydrates = food[8][0];
            Fiber = food[9][0];
            Cholesterol = food[4][2];
            Calcium = food[0][0];
            TotalFat = food[5][2];
            SaturateFat = food[6][2];
            PolyunsatFat = food[8][2];
            Iron = food[1][0];
            Magnesium = food[2][0];
            Sodium = food[3][0];
            Phosphorous = food[4][0];
            CaPRation = food[5][0];
            Potassium = food[6][0];
            Zinc = food[0][2];
            Niacin = food[1][2];
            Thiamin = food[2][2];
            Riboflavin = food[3][2];
            VitA = food[4][2];
            VitB6 = food[5][2];
            VitC = food[6][2];
        }
        public string FoodName { get; set; } 
        public string FoodType { get;}
        public double ServingSize { get; set;}
        public double Weight { get; set;}
        public double PercentWater { get; set;}
        public double Energy { get; set;}
        public double Protein { get; set;}
        public double Carbohydrates { get; set;}
        public double Fiber { get; set;}
        public double Cholesterol { get; set;}
        public double Calcium { get; set;}
        public double TotalFat { get; set;}
        public double SaturateFat { get; set;}
        public double MonosatFat { get; set;}
        public double PolyunsatFat { get; set;}
        public double Iron {  get; set;}
        public double Magnesium { get; set;}
        public double Sodium { get; set;}
        public double Phosphorous { get;set;}
        public double CaPRation { get; set; } 
        public double Potassium { get; set;}
        public double Zinc {  get; set;}
        public double Niacin { get; set;}
        public double Thiamin { get; set;}
        public double Riboflavin { get; set;}
        public double VitA {  get; set;}
        public double VitB6 { get; set;}
        public double VitC { get; set;}

    }
}
