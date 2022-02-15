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
                //this.textBox1.Text = readAllText;
                //this.dataGridView1.Rows.Add()
                addDataToGridview("01","name","cis");
            }
            
        }
        private void addDataToGridview(string id, string name, string major)
        {
            this.dataGridView1.Rows.Add(new string[] { "id", "name", "major" });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { 

            string strData = string.Empty;
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != string.Empty)
                {

                    int row = this.dataGridView1.Rows.Count;
                    for(int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for(int j = 0; j < column; j++)
                        {
                            strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //TODO make data from dataGridViewl to variable
                        }
                    }

                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }

        }
    }
}