using Microsoft.Win32;
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
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stream mystream;
        string f_name;
        int finish;
        int start;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menunew_Click(object sender, RoutedEventArgs e)
        {
            newfile();
        }

        private void menuopen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Filter = "Text Documents|*.txt";
            if (opendlg.ShowDialog() == true)
            {
                if ((mystream = opendlg.OpenFile()) != null)
                {
                    string strFileName = opendlg.FileName;
                    string filetex = File.ReadAllText(strFileName);
                    textboxDoc.Document.Blocks.Clear();
                    textboxDoc.AppendText(filetex);
                }
            }
        }
        #region
        //public static void SetText(this RichTextBox richTextBox, string text)
        //{
        //    richTextBox.Document.Blocks.Clear();
        //    richTextBox.Document.Blocks.Add(new Paragraph(new Run(text)));
        //}

        //string GetString(RichTextBox rtb)
        //{
        //    var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        //    return textRange.Text;
        //}
        #endregion
        private void menuexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menusaveas_Click(object sender, RoutedEventArgs e)
        {
            saveas();
        }

        private void menuprint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog prtdlg = new PrintDialog();
            if (prtdlg.ShowDialog() == true)
            {
                prtdlg.PrintVisual(textboxDoc as Visual, "Printing as Visual");
            }
        }

        private void menuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontArial.IsChecked = false;
            menuFontCourier.IsChecked = false;
            menuFontConsolas.IsChecked = false;
            textboxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void menuFontArial_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontCourier.IsChecked = false;
            menuFontConsolas.IsChecked = false;
            textboxDoc.FontFamily = new FontFamily("Arial");
        }

        private void menuFontCourier_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontArial.IsChecked = false;
            menuFontConsolas.IsChecked = false;
            textboxDoc.FontFamily = new FontFamily("Courier");
        }

        private void menuFontConsolas_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontArial.IsChecked = false;
            menuFontCourier.IsChecked = false;
            textboxDoc.FontFamily = new FontFamily("Consolas");
        }

        public void saveas()
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            savedlg.DefaultExt = "*.txt";
            savedlg.Filter = "Text Documents|*.txt";
            Nullable<bool> myresult = savedlg.ShowDialog();

            if (myresult == true)
            {
                textboxDoc.SelectAll();
                textboxDoc.Selection.Save(new FileStream(savedlg.FileName, FileMode.OpenOrCreate, FileAccess.Write), DataFormats.Text);
                start = 0;
                finish = savedlg.SafeFileName.IndexOf(".");
                f_name = savedlg.SafeFileName.Substring(start, finish);
                paperPad.Title = f_name + "- PaperPad";
            }
        }

        public void newfile()
        {
            string text = new TextRange(textboxDoc.Document.ContentStart, textboxDoc.Document.ContentEnd).Text;
            if (string.IsNullOrWhiteSpace(text) == false)
            {
                MessageBoxResult m = MessageBox.Show("Do you want to Save Changes to " + f_name, "File Save", MessageBoxButton.YesNoCancel);
                if (m == MessageBoxResult.Yes)
                {
                    SaveFileDialog savedlg = new SaveFileDialog();
                    savedlg.DefaultExt = "*.txt";
                    savedlg.Filter = "Text Documents|*.txt";
                    Nullable<bool> myresult = savedlg.ShowDialog();

                    if (myresult == true)
                    {
                        textboxDoc.SelectAll();
                        textboxDoc.Selection.Save(new FileStream(savedlg.FileName, FileMode.OpenOrCreate, FileAccess.Write), DataFormats.Text);
                    }
                    textboxDoc.Document.Blocks.Clear();
                    // Do something
                }
                else if (m == MessageBoxResult.No)
                {
                    // Do something else
                    textboxDoc.Document.Blocks.Clear();
                }

            }
        } 

        private void menusize5_Click(object sender, RoutedEventArgs e)
        {
            menusize10.IsChecked = false;
            menusize15.IsChecked = false;
            menusize20.IsChecked = false;
            //TextSelection selectedText = textboxDoc.Selection;
            //selectedText.ApplyPropertyValue(RichTextBox.FontSizeProperty, 5);
            textboxDoc.FontSize = 5;
        }

        private void menusize10_Click(object sender, RoutedEventArgs e)
        {
            menusize5.IsChecked = false;
            menusize15.IsChecked = false;
            menusize20.IsChecked = false;
            //TextSelection selectedText = textboxDoc.Selection;
            //selectedText.ApplyPropertyValue(RichTextBox.FontSizeProperty, 10);
            textboxDoc.FontSize = 10;
        }

        private void menusize15_Click(object sender, RoutedEventArgs e)
        {
            menusize5.IsChecked = false;
            menusize10.IsChecked = false;
            menusize20.IsChecked = false;
            //TextSelection selectedText = textboxDoc.Selection;
            //selectedText.ApplyPropertyValue(RichTextBox.FontSizeProperty, 15);
            textboxDoc.FontSize = 15;
        }

        private void menusize20_Click(object sender, RoutedEventArgs e)
        {
            menusize5.IsChecked = false;
            menusize10.IsChecked = false;
            menusize15.IsChecked = false;
            //TextSelection selectedText = textboxDoc.Selection;
            //selectedText.ApplyPropertyValue(RichTextBox.FontSizeProperty, 20);
            textboxDoc.FontSize = 20;
        }

        private void menuwordwrap_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void textboxDoc_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
