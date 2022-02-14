using System.Text;

namespace Student_Management_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | * csv.";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | * csv.";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != string.Empty)
                {
                    filepath = saveFileDialog.FileName;


                    //save file
                    File.WriteAllText(filepath, this.textBox1.Text, Encoding.UTF8);
                }
            }

        }
    }
}