using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfApp2;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegstrButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Password == "")
            {
                MessageBox.Show("Поля пустые");
            }
            else
            {
                int login = int.Parse(Login.Text);

                using (AzatikEntities2 db = new AzatikEntities2())
                {
                    Users user = db.Users.Where(x => x.IdNumber == login && x.Password == Password.Password).FirstOrDefault();
                    if (user != null)
                    {
                        CurrentUser.Id = user.IdNumber;
                        switch (user.RoleId)
                        {
                            case 1:
                                gfgfgff Ggg = new gfgfgff();
                                Ggg.Show();
                                this.Close();
                                break;
                                case 2:
                                Worker worker = new Worker();
                                worker.Show();
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("НЕверные данные");
                    }
                }
            }
        }
    }
}

//if (Login.Text == "" || Password.Password == "")
//{
//    MessageBox.Show("qwewqe");
//}
//else
//{
//    int ident = int.Parse(Login.Text);
//    var db = new AzatikEntities2();

//    var isers = (Users)db.Users.Where(x => x.IdNumber == ident && x.Password == Password.Password).FirstOrDefault();
//    Users user = db.Users.Where(x => x.IdNumber == ident && x.Password == Password.Password).FirstOrDefault();
//    cURuSER.id = ident;
//    cURuSER.pass = Password.Password;
//    cURuSER.role = user.RoleId;
//    switch (user.RoleId)
//    {
//        case 1:
//            gfgfgff Gfgfgff = new gfgfgff();
//            Gfgfgff.Show();
//            this.Close();
//            break;
//        case 2:
//            Worker worker = new Worker();
//            worker.Show();
//            this.Close();
//            break;
//    }
//}


//if (Login.Text == "" || Password.Password == "")
//{
//    MessageBox.Show("Поля пустые");
//}
//else

//{
//    int login = int.Parse(Login.Text);
//    using (AzatikEntities2 db = new AzatikEntities2())
//    {
//        Users user = db.Users.Where(x => x.IdNumber == login && x.Password == Password.Password).FirstOrDefault();
//        if (user != null)
//        {
//            CurrentUser.Id = user.IdNumber;
//            switch (user.RoleId)
//            {
//                case 1:
//                    gfgfgff Gggg = new gfgfgff();
//                    Gggg.Show();
//                    this.Close();
//                    break;
//                case 2:
//                    Worker worker = new Worker();
//                    worker.Show();
//                    this.Close();
//                    break;
//            }
//        }
//        else
//        {
//            MessageBox.Show("Неверные данные");
//        }
//    }
//}