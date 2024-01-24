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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для gfgfgff.xaml
    /// </summary>
    public partial class gfgfgff : Window
    {
        public gfgfgff()
        {
            InitializeComponent();

            IdUsss.Content = cURuSER.id;
            Pass.Content = cURuSER.pass;
            Role.Content = cURuSER.role;
        }
    }
}
