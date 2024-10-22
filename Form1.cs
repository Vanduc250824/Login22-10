namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            if (a == "admin" && b == "1234")
            {
                MessageBox.Show("Đăng nhập thành công!!!");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
