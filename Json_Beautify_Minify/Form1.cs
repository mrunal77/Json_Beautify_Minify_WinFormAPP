using CompactJson;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Json_Beautify_Minify
{
    public partial class formJsonFormatter : Form
    {
        public formJsonFormatter()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Json_Convert(true);
            //var options = new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //};
            //try
            //{
            //    //var jsonElement = JsonSerializer.Deserialize<JsonElement>(txtMinifiedJson.Text);

            //    var Data = Serializer.Parse(txtMinifiedJson.Text);

            //    txtFormattedJSON.Text = Serializer.ToString(Data, true);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Minified Json Data.");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Json_Convert(false);
            //try
            //{
            //    var Data = Serializer.Parse(txtMinifiedJson.Text);

            //    txtMinifiedJson.Text = Serializer.ToString(Data, false);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid Json Data.");
            //}
        }

        private void formJsonFormatter_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    var data = this.ReadFile(fileStream);

                }

            }
        }

        private void Json_Convert(bool formatter)
        {
            try
            {
                //var jsonElement = JsonSerializer.Deserialize<JsonElement>(txtMinifiedJson.Text);
                                  
                    var Data = Serializer.Parse(txtMinifiedJson.Text);
                    if (formatter)
                        txtFormattedJSON.Text = Serializer.ToString(Data, formatter);
                    else
                        txtMinifiedJson.Text = Serializer.ToString(Data, false);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Minified Json Data.");
            }
        }

        private async Task ReadFile(Stream fileStream)
        {
            var fileContent = string.Empty;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = await reader.ReadToEndAsync();
                txtMinifiedJson.Clear();
                txtMinifiedJson.AppendText(fileContent);

                //txtMinifiedJson.Text = fileContent;
                //foreach (string line in fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                //{
                //    AppendText(line);                    
                //}
            }
        }

        private void AppendText(string line)
        {
            if (txtMinifiedJson.InvokeRequired)
            {
                txtMinifiedJson.Invoke((ThreadStart)(() => AppendText(line)));
            }
            else
            {
                txtMinifiedJson.AppendText(line + Environment.NewLine);
            }
        }
    }
}
