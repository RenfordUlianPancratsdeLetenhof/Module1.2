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


namespace Module1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Enterprise enterprise;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Ініціалізація даних про підприємство
            enterprise = new Enterprise
            {
                Name = "ХПП",
                Subordinates = new List<Concern>
                {
                    // Додавання концернів
                    new Concern
                    {
                        Name = "Концерн 1",
                        Subordinates = new List<Department>
                        {
                            // Додавання відділів
                            new Department
                            {
                                Name = "Відділка 1",
                                Subordinates = new List<Workshop>
                                {
                                    // Додавання цехів
                                    new Workshop { Name = "Цех 1" },
                                    new Workshop { Name = "Цех 2" }
                                }
                            }
                        }
                    },
                    new Concern
                    {
                        Name = "Концерн 2",
                        Subordinates = new List<Department>
                        {
                            // Додавання відділів
                            new Department
                            {
                                Name = "Відділка 2",
                                Subordinates = new List<Workshop>
                                {
                                    // Додавання цехів
                                    new Workshop { Name = "Цех 3" },
                                    new Workshop { Name = "Цех 4" }
                                }
                            }
                        }
                    }
                },
                Products = new List<string> { "Булки", "Млинці", "Пиріжки", "Тістечка" }
            };
        }

   

        private void ShowInformation_Click_1(object sender, RoutedEventArgs e)
        {
            enterpriseNameLabel.Content = $"Ім'я підприємства: {enterprise.Name}";
            concernCountLabel.Content = $"Кількість концернів: {enterprise.Subordinates.Count}";

            List<string> concernDetails = new List<string>();
            int totalDepartments = 0;
            int totalWorkshops = 0;

            foreach (var concern in enterprise.Subordinates)
            {
                int departmentsCount = concern.Subordinates.Count;
                int workshopsCount = concern.Subordinates.Sum(d => d.Subordinates.Count);

                totalDepartments += departmentsCount;
                totalWorkshops += workshopsCount;

                concernDetails.Add($"{concern.Name}: {departmentsCount} відділів, {workshopsCount} цехів");
            }

            concernDetails.Add($"Всього відділів: {totalDepartments}, Всього цехів: {totalWorkshops}");
            concernDetailsListBox.ItemsSource = concernDetails;

            // Виведення інформації про продукти
            productsListBox.ItemsSource = enterprise.Products;
            /*
            // Виведення інформації на екран
                        MessageBox.Show($"Підприємство {enterprise.Name}\n" +
                                        $"{enterprise.Subordinates.Count} концерна\n" +
                                        $"{enterprise.Products.Count} продукт(ів)"); */
        }
    }
}
