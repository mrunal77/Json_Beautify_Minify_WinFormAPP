using CompactJson;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSON_Beautifier_WPF
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

        private void Select_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                var data = this.ReadFile(fileStream);
            }
        }

        private async Task ReadFile(Stream fileStream)
        {
            var fileContent = string.Empty;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = await reader.ReadToEndAsync();
                txt_MinfiedJSON.Document.Blocks.Clear();
                txt_MinfiedJSON.AppendText(fileContent);

                //txtMinifiedJson.Text = fileContent;
                //foreach (string line in fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                //{
                //    AppendText(line);                    
                //}
            }
        }

        private void Btn_Minifiy_CLick(object sender, RoutedEventArgs e)
        {
            this.Json_Convert(false);
        }

        private void Btn_Beautify_CLick(object sender, RoutedEventArgs e)
        {
            this.Json_Convert(true);

        }

        private async Task Json_Convert(bool formatter)
        {
            try
            {
                //var jsonElement = JsonSerializer.Deserialize<JsonElement>(txtMinifiedJson.Text);
                var jsonData = new TextRange(txt_MinfiedJSON.Document.ContentStart, txt_MinfiedJSON.Document.ContentEnd).Text.Replace("\n", "");
                var Data = Serializer.Parse(jsonData);
                if (formatter)
                {
                    txt_BeautifiedJSON.Document.Blocks.Clear();
                    txt_BeautifiedJSON.AppendText(Serializer.ToString(Data, formatter));
                }
                else
                {
                    txt_MinfiedJSON.Document.Blocks.Clear();
                    txt_MinfiedJSON.AppendText(Serializer.ToString(Data, false));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Minified Json Data.");
            }
        }

    }
}