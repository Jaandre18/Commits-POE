using Recipes_Menu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Recipes_Menu.Views
{
    /// <summary>
    /// Interaction logic for HomePg.xaml
    /// </summary>
    public partial class HomePg : Page
    {
        public List<Recipe> RecipeList { get; }
        public HomePg()
        {
            InitializeComponent();
            Loaded += HomePg_Load;
            RecipeList = new List<Recipe>();
        }
        private void HomePg_Load(object sender, RoutedEventArgs e)
        {
            List<string> foodgroups = new List<string>
            {
                 "Fruits",
                 "Vegetables",
                 "Grains",
                 "Protein Foods",
                 "Dairy"
            };
            Groups.ItemsSource = foodgroups;

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = txtRecipeName.Text;
            string ingredients = txtIngredients.Text;
            string steps = txtSteps.Text;   
            string foodGroup = Groups.SelectedItem as string;
            string calories = txtCalories.Text;

            Recipe recipe = new Recipe
            {
                Name = recipeName,
                Ingredients = ingredients,
                Steps = steps,
                group = foodGroup,
                Calories = calories
            };
            Clearfields();
            MessageBox.Show("Recipe created successfully!");
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.RecipeList.Add(recipe);
                mainWindow.NavigateToDisplayPage(mainWindow.RecipeList);
            }
        }
        private void Clearfields()
        {
            txtRecipeName.Text = "";
            txtIngredients.Text = "";
            txtSteps.Text = "";
            Groups.SelectedIndex = -1;
            txtCalories.Text = "";
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clearfields();
        }

        private void ComboBox_FoodGroup(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
