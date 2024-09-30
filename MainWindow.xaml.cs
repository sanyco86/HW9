using System.Linq;
using System.Windows;

namespace HW9
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

        /// <summary>
        /// Обработка нажатия первой кнопки для разделения строки на слова
        /// </summary>
        private void OnSplitWordsButtonClick(object sender, RoutedEventArgs e)
        {
            string inputText = InputTextBoxSplitWords.Text;

            WordsListBox.Items.Clear();

            string[] words = inputText.Split(' ');

            foreach (string word in words)
            {
                WordsListBox.Items.Add(word);
            }
        }

        /// <summary>
        /// Обработка нажатия второй кнопки для перестановки слов
        /// </summary>
        private void OnReverseWordsButtonClick(object sender, RoutedEventArgs e)
        {
            string inputText = InputTextBoxReverseWords.Text;

            string[] words = inputText.Split(' ');

            string reversedSentence = string.Join(" ", words.Reverse());

            ReversedSentenceLabel.Content = reversedSentence;
        }
    }
}
