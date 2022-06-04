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
using test1.DataSetTableAdapters;
using System.Windows.Threading;



namespace test1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter usersTable = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            
        }


 
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (tb_login.Text.Length > 0 && tb_pass.Text.Length > 0)
            {
                if (tb_pass.Text.Length > 0)
                {
                    int? response = usersTable.ScalarQuery(tb_login.Text, tb_pass.Text);
                    if (response == 1)
                    {
                        this.Hide();
                        osnovaForm osnova = new osnovaForm();
                        osnova.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!");
            }
        }

    }
}
