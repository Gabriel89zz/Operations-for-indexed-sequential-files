namespace Operations_for_indexed_sequential_files
{
    public partial class Form1 : Form
    {

        private string dataFile = "employees.dat";
        private string indexFile = "index.idx";

        private Dictionary<int, long> index = new Dictionary<int, long>();
        public Form1()
        {
            InitializeComponent();
            LoadIndex();
        }

        private void LoadIndex()
        {
            if (File.Exists(indexFile))
            {
                using (StreamReader reader = new StreamReader(indexFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        int id = int.Parse(parts[0]);
                        long position = long.Parse(parts[1]);
                        index[id] = position;
                    }
                }
            }
        }

        private void SaveIndex()
        {
            using (StreamWriter writer = new StreamWriter(indexFile))
            {
                foreach (var entry in index)
                {
                    writer.WriteLine($"{entry.Key},{entry.Value}");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text.Trim();
                string position = txtPosition.Text.Trim();
                decimal salary = decimal.Parse(txtSalary.Text);

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position) || salary <= 0)
                {
                    MessageBox.Show("Please enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (index.ContainsKey(id))
                {
                    MessageBox.Show("An employee with this ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string employeeData = $"{id},{name},{position},{salary}";

                using (StreamWriter writer = new StreamWriter(dataFile, true))
                {
                    long positioon = writer.BaseStream.Length;
                    writer.WriteLine(employeeData);
                    index[id] = positioon;
                }

                SaveIndex();
                ClearFields();
                MessageBox.Show("Employee registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtPosition.Clear();
            txtSalary.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                rtbResult.Clear();

                if (!File.Exists(dataFile))
                {
                    MessageBox.Show("No employees registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (StreamReader reader = new StreamReader(dataFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(',');
                        rtbResult.AppendText($"ID: {data[0]}, Name: {data[1]}, Position: {data[2]}, Salary: {decimal.Parse(data[3]):C}\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                if (!index.ContainsKey(id))
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                index.Remove(id); 
                SaveIndex();

                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                if (!index.ContainsKey(id))
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long position = index[id];
                using (StreamReader reader = new StreamReader(dataFile))
                {
                    reader.BaseStream.Seek(position, SeekOrigin.Begin);
                    string line = reader.ReadLine();
                    var data = line.Split(',');

                    rtbResult.Clear();
                    rtbResult.AppendText($"ID: {data[0]}\nName: {data[1]}\nPosition: {data[2]}\nSalary: {decimal.Parse(data[3]):C}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
