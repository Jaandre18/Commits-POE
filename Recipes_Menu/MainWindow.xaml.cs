using Recipes_Menu.Classes;
using Recipes_Menu.Views;
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

namespace Recipes_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Recipe> RecipeList { get; set; } = new List<Recipe>();
        HomePg homePg = new HomePg();
        PieChartPg piechartPg;
        public MainWindow()
        {
            InitializeComponent();
            piechartPg = new PieChartPg(RecipeList);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            frmContainer.Content = homePg;

        }
        public void NavigateToDisplayPage(List<Recipe> recipeList)
        {
            DisplayPg displayPg = new DisplayPg(recipeList);
            frmContainer.Content = displayPg;
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            NavigateToDisplayPage(RecipeList);
        }
        private void btnPieChart_Click(object sender, RoutedEventArgs e)
        {
            piechartPg = new PieChartPg(RecipeList);
            frmContainer.Content = piechartPg;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            ;
            if (MessageBox.Show("Do you want to exit?", "Recipe App", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
