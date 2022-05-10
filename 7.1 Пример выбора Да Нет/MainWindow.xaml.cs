using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace _7._1_Пример_выбора_Да_Нет
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


        private void txtManager_MouseEnter(object sender, MouseEventArgs e)
        {
            var posLeftTxtYes = Canvas.GetLeft(txtConsultant);
            var posLeftTxtNo = Canvas.GetLeft(txtManager);

            Canvas.SetLeft(txtConsultant, posLeftTxtNo);
            Canvas.SetLeft(txtManager, posLeftTxtYes);

            SystemSounds.Hand.Play();
        }

        private void txtConsultant_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Я в этом и не сомневался :)");
        }

    }
}
