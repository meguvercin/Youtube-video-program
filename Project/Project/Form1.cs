namespace Project
{
    public partial class Form1 : Form
    {
        private string adminFilePath = "Admin.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void grpboxGrs_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (CheckLogin(adminFilePath, username, password))
            {
                // Giriþ baþarýlý
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                // Giriþ baþarýsýz
                MessageBox.Show("Invalid username or password!");
            }
        }
        private bool CheckLogin(string filePath, string username, string password)
        {
            var admins = ReadAdminsFromCsv(filePath);
            return admins.Any(admin => admin.Username == username && admin.Password == password);
        }
        private List<Admin> ReadAdminsFromCsv(string filePath)
        {
            List<Admin> admins = new List<Admin>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var values = line.Split('|');
                admins.Add(new Admin
                {
                    Username = values[0],
                    Password = values[1]
                });
            }
            return admins;
        }
        public class Admin
        {
            public string Username { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        private void lblEnter_Click(object sender, EventArgs e)
        {
            lblEnter.Font = new Font(lblEnter.Font.FontFamily, 32);
        }
    }
}
