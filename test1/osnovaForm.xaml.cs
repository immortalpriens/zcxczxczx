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
using System.Windows.Shapes;
using test1.DataSetTableAdapters;


namespace test1
{
    /// <summary>
    /// Логика взаимодействия для osnovaForm.xaml
    /// </summary>
    public partial class osnovaForm : Window
    {
        CinemaTableAdapter cinemaTable = new CinemaTableAdapter();


        public osnovaForm()
        {
            InitializeComponent();
            dgTest.ItemsSource = cinemaTable.GetData();
        }
    }
}
