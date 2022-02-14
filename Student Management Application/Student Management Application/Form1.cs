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
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                this.textBox1.Text = readAllText;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string data = this.dataGridView1.Rows[0].Cells[0].Value.ToString();


            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != string.Empty)
                {
                    filepath = saveFileDialog.FileName;

                    int row = this.dataGridView1.Rows.Count;
                    for(int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for(int j = 0; j < column; j++)
                        {
                            this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    //save file
                    File.WriteAllText(saveFileDialog.FileName, this.textBox1.Text, Encoding.UTF8);
                }
            }

        }
    }
}