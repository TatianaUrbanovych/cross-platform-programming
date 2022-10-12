namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static class DB
        {
            //public static string TestDB = "Admin";
            public static Dictionary<string, string> TestDB = new Dictionary<string, string>()
            {
                { "user1@ukr.net", "user1"},
                { "user2@gmail.com", "user2"},
                { "user3@knute.edu.ua", "user3"}
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                if (Email.Text == "admin@admin" && Password.Text == "admin")
                {
                    MessageBox.Show("You've autorised as an admin. Welcome!");
                }
                else if (DB.TestDB.ContainsKey(Email.Text) && DB.TestDB.ContainsValue(Password.Text))
                {
                    MessageBox.Show("You've autorised as a user. Welcome!");
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
                Email.Clear();
                Password.Clear();
            }
            else
            {
                MessageBox.Show("Заповніть обидва поля");
            }
        }
    }
}