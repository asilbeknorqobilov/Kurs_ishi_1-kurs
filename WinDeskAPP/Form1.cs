namespace WinDeskAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] kun = new int[12, 31];
            int[] oy = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (checkBox1.Checked)
            {
                oy[1] = 29;
            }
            int k = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < oy[i]; j++)
                {
                    int hafta;
                    if (k % 7 == 0)
                    {
                        hafta = 7;
                    }
                    else
                    {
                        hafta = (k % 7);
                    }
                    kun[i, j] = hafta;
                    k++;
                }
            }

            int height = kun.GetLength(0);
            int width = kun.GetLength(1);

            dataGridView1.ColumnCount = width;
            //jadvalni tozalavorish kerak

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = kun[r, c];
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}