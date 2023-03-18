using PZ_26.c_s_o_dFile;
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

namespace PZ_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rect positionRect;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void newProject(object sender, RoutedEventArgs e)
        {
            MenuItem item = e.OriginalSource as MenuItem;
            if(null != item)
            {
                NewFile newFile = new NewFile("file");
                newFile.createFile();

                OpenFile openFile = new OpenFile("file");
            }
        }

        private void openProject(object sender, RoutedEventArgs e)
        {
            MenuItem item = e.OriginalSource as MenuItem;
            if (null != item)
            {

            }
        }

        private void saveProject(object sender, RoutedEventArgs e)
        {
            MenuItem item = e.OriginalSource as MenuItem;
            if (null != item)
            {

            }

        } 
        
        private void deleteProject(object sender, RoutedEventArgs e)
        {
            MenuItem item = e.OriginalSource as MenuItem;
            if (null != item)
            {

            }
        }

        private void UpdateCursorPosition()
        {

            int row = mainTextBox.SelectionStart;
            int col = mainTextBox.CaretIndex - mainTextBox.GetLineIndexFromCharacterIndex(row);

            lineCount.Text = $"строка: {row + 1} столбец: {col + 1}";

        }

        private void textField_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void textField_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void mainTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            UpdateCursorPosition();
        }

    }
}
