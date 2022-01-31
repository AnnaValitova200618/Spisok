using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Список_вы_знаете_кого_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Hum> DataArray { get; set; }
        public Hum SelectedHum { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            DataArray = new ObservableCollection<Hum>();
            DataArray.Add(new Hum { Name = "Степанида", Species = "Курильский Бобтейл", Year = 2017, ImagePath = "/Коты/бобтейл.jpg" });
            DataArray.Add(new Hum { Name = "Лари", Species = "Британская-короткошёрстная", Year = 2019, ImagePath = "/Коты/Британская-короткошерстная.jpg" });
            DataArray.Add(new Hum { Name = "Рафик", Species = "Манчкин", Year = 2020, ImagePath = "/Коты/manchkiny.jpg" });
        }
    }
}
