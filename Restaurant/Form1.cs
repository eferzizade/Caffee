namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sandwich - 7.5 Azn");
            total += 7.5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 3.5 Azn");
            total += 3.5;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza  - 8.2 Azn");
            total += 8.2;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Dessert  - 4.2 Azn");
            total += 4.2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Muffin  - 3.7 Azn");
            total += 3.7;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ice cream  - 5.7 Azn");
            total += 5.7;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tea  - 2.1 Azn");
            total += 2.1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coffee  - 4.1 Azn");
            total += 4.1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Smoothie  - 7.3 Azn");
            total += 7.3;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Green salad - 5.9 Azn");
            total += 5.9;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Soda lemon - 2.9 Azn");
            total += 2.9;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Water - 1.2 Azn");
            total += 1.2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            total = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return; // Heç nə seçilməyibsə çıx

            DialogResult result = MessageBox.Show("Silinsinmi?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            string selectedItem = listBox1.SelectedItem.ToString();

            // Qiyməti çıxarmaq
            double price = ExtractPrice(selectedItem);

            // Ümumi məbləğdən çıxırıq
            total -= price;

            // ListBox-dan silirik
            listBox1.Items.Remove(selectedItem);
        }

        // Məhsulun qiymətini çıxaran metod
        private double ExtractPrice(string item)
        {
            // Mətnin sonundakı " - X Azn" hissəsini parçalayır
            string priceText = item.Split('-')[1].Replace("Azn", "").Trim();
            return Convert.ToDouble(priceText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = total.ToString() + " Azn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox2.Text);
            if (total < s)
            {
                label6.Text = (s - total).ToString() + " Azn";

            }
            else
            {
                label6.Text = "Xəta baş verdi";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
        }
    }

}
