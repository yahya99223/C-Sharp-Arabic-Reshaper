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
using ArabicUnshaper;

namespace Arabic_Unshaping_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            var input = txtbxInput.Text;
            var shapedUnicode = input.GetAsUnicode();
            var unshapedUnicode = input.GetUnShapedUnicode();
            var unshapedText = unshapedUnicode.DecodeEncodedNonAsciiCharacters();
            lblShapedInputUnicode.Text = shapedUnicode;
            lblUnshapedInputUnicode.Text = unshapedUnicode;
            lblUnshapedText.Text = unshapedText;
        }
    }
}
