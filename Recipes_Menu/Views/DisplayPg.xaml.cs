using Recipes_Menu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for DisplayPg.xaml
    /// </summary>
    public partial class DisplayPg : Page
    {
        private List<Recipe> recipes;
        public DisplayPg(List<Recipe> recipeList)
        {
            InitializeComponent();
            recipes = recipeList;

            foreach (Recipe recipe in recipeList)
            {
                RecipeComboBox.Items.Add(recipe.Name);
            }
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedRecipeName = RecipeComboBox.SelectedItem as string;
            Recipe selectedRecipe = recipes.Find(recipe => recipe.Name == selectedRecipeName);

            if(selectedRecipe != null)
            {
                MessageBox.Show($"Recipe Name: {selectedRecipe.Name}\nIngredients: {selectedRecipe.Ingredients}\nSteps: {selectedRecipe.Steps}\nFood Group: {selectedRecipe.group}\nCalories: {selectedRecipe.Calories}");
            }
        }

        private void RecipeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
