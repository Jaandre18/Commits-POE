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
using LiveCharts;
using LiveCharts.Wpf;
using Recipes_Menu.Classes;

namespace Recipes_Menu.Views
{
    /// <summary>
    /// Interaction logic for PieChartPg.xaml
    /// </summary>
    public partial class PieChartPg : Page
    {
        private List<Recipe> recipeList;
        public SeriesCollection FoodGroupSeries { get; set; }
        public PieChartPg(List<Recipe> recipes)
        {
            InitializeComponent();
            recipeList = recipes;
            GeneratePieChart();
            DataContext = this;
        }
        private void GeneratePieChart()
        {
            var foodGroups = recipeList.Select(r => r.group).Distinct().ToList();

            FoodGroupSeries = new SeriesCollection();
            foreach (var group in foodGroups)
            {
                var percentage = (double)recipeList.Count(r => r.group == group) / recipeList.Count * 100;
                FoodGroupSeries.Add(new PieSeries
                {
                    Title = group,
                    Values = new ChartValues<double> { percentage },
                    DataLabels = true
                });
            }

            pieChart.Series = FoodGroupSeries;
            pieChart.LegendLocation = LegendLocation.Bottom;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added to menu");
        }
    }
}
