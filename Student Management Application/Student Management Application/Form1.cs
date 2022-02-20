using System.Text;

namespace Student_Management_Application
{
    public partial class Form1 : Form
    {
        Student_Management STD = new Student_Management();

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
                

                for(int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                    
                    //addDataToGridview(student);  //แสดงผลลงที่ช่องของAllData
                    //TODO Add student object to DataGridView 
                }
                //TODO calculate max, min, gpax //เขียนวิธีการคำนวณ

            }
        }
        private void addDataToGridview(string id, string name, string major)
        {
            this.dataGridView1.Rows.Add(new string[] { "id", "name", "major" });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO add data to data gridview
            //TODO calculate GPX, Max, Min

            //string input = this.dataGridView1.Text;
            
        }
        */

        private void button2Add_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxId.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxName.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBoxMajor.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxGPA.Text;

            string input = this.textBoxGPA.Text;
            string name = this.textBoxName.Text;

            double dInput = Convert.ToDouble(input);
            STD.addGPA(name, dInput);

            //double doutput = Convert.ToDouble(output);
            //STD.addGPA(name, doutput);

            double gpax = STD.GetGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = STD.getMax();
            textBoxMax.Text = max.ToString();

            double min = STD.getMin();
            textBoxMin.Text = min.ToString();
        }
    } 
}