using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restapi3
{
    public partial class Form1 : Form
    {

        String URL = "http://localhost/SOP/PHP/";
        String ROUTE = "index.php";
        bool LOGGEDIN = false;
        string TOKEN = "";

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += logoutBrn_Click;
            nameTxtBox.Hide();
            salaryTxtBox.Hide();
            ageTxtBox.Hide();
            createNewBtn.Hide();
            deleteByIdBtn.Hide();
            updateBtn.Hide();
            tokenLbl.Hide();
            logoutBrn.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listAllBtn_Click(object sender, EventArgs e)
        {

            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);

            IRestResponse<List<Employee>> response = client.Execute<List<Employee>>(request);
            foreach (Employee emp in response.Data)
            {
                dataGridView1.DataSource = response.Data;
            }
        }

        private void listByIdBtn_Click(object sender, EventArgs e)
        {
            int id;
            if(idTxtBox.Text == "" || !Int32.TryParse(idTxtBox.Text,out id))
            {
                MessageBox.Show("Kérem adjon meg egy helyes ID-t");
            }
            else
            {
                var client = new RestClient(URL);
                String ROUTE = "index.php" + "?id=" + idTxtBox.Text;
                var request = new RestRequest(ROUTE, Method.GET);
                IRestResponse<List<Employee>> response = client.Execute<List<Employee>>(request);
                foreach (Employee emp in response.Data)
                {
                    dataGridView1.DataSource = response.Data;
                }
            }

        }

        private void createNewBtn_Click(object sender, EventArgs e)
        {
            int age;
            int salary;
            var client = new RestClient(URL);
            String ROUTE = "index.php" + "?token=" + TOKEN;
            var request = new RestRequest(ROUTE, Method.POST);  //index is kellett mögé
            request.RequestFormat = DataFormat.Json;
            if(!Int32.TryParse(ageTxtBox.Text, out age) || !Int32.TryParse(salaryTxtBox.Text,out salary))
            {
                MessageBox.Show("Kérem adjon meg számot a kornak és a fizetésnek!");
            }
            else
            {
                request.AddBody(new Employee
                {
                    employee_name = nameTxtBox.Text,
                    employee_age = int.Parse(ageTxtBox.Text),
                    employee_salary = int.Parse(salaryTxtBox.Text)
                });
                IRestResponse response = client.Execute(request);
            }
        }

        private void deleteByIdBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php" + "?token=" + TOKEN;
            //String ROUTE = "index.php/{id}";
            var request = new RestRequest(ROUTE, Method.DELETE);
            request.AddJsonBody(new Employee
            {
                Id = idTxtBox.Text
            });
            //request.AddParameter("id", textBox2.Text);
            IRestResponse response = client.Execute(request);
        }

        private void updateBtn_Click(object sender, EventArgs e) //Módosítás
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php" + "?token=" + TOKEN;
            var request = new RestRequest(ROUTE, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            int employee_age;
            int employee_sallary;
            if (!Int32.TryParse(ageTxtBox.Text, out employee_age) || !Int32.TryParse(salaryTxtBox.Text, out employee_sallary))
            {
                MessageBox.Show("Kérem adjon meg számot a kornak és a fizetésnek!");
            }
            else
            {
                request.AddBody(new Employee
                {
                    Id = idTxtBox.Text,
                    employee_name = nameTxtBox.Text,
                    employee_age = int.Parse(ageTxtBox.Text),
                    employee_salary = int.Parse(salaryTxtBox.Text)
                });
                IRestResponse response = client.Execute(request);

            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(userTxtBox.Text == "" || passwordTxtBox.Text == "")
            {
                MessageBox.Show("Kérem adjon meg egy felhasználónevet és jelszót!");
            }
            else if (userTxtBox.Text.Length < 3 || passwordTxtBox.Text.Length < 3)
            {
                MessageBox.Show("Rövid felhasználónév vagy jelszó!");
            }
            else
            {
                var client = new RestClient(URL);
                String ROUTE = "login.php" + "?login=try";
                var request = new RestRequest(ROUTE, Method.POST);
                request.AddJsonBody(new User
                {
                    username = userTxtBox.Text,
                    password = passwordTxtBox.Text

                });
                IRestResponse response = client.Execute(request);
                string message = response.Content;
                string[] sections = message.Split(',');
                if (sections[0].Contains("1"))
                {
                    LOGGEDIN = true;
                    string[] status_message = sections[1].Split(':');
                    string tokenLong = status_message[1];
                    TOKEN = tokenLong.Substring(1, tokenLong.Length - 3);
                    tokenLbl.Text = TOKEN;
                    nameTxtBox.Show();
                    salaryTxtBox.Show();
                    ageTxtBox.Show();
                    createNewBtn.Show();
                    deleteByIdBtn.Show();
                    updateBtn.Show();
                    tokenLbl.Show();
                    loginBtn.Hide();
                    userTxtBox.Hide();
                    passwordTxtBox.Hide();
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    logoutBrn.Show();
                    label5.Hide();
                    label6.Hide();
                }
            }
        }

        private void logoutBrn_Click(object sender, EventArgs e)
        {
            if (LOGGEDIN)
            {
                var client = new RestClient(URL);
                String ROUTE = "login.php" + "?logout=" + TOKEN;
                var request = new RestRequest(ROUTE, Method.POST);
                request.AddJsonBody(new Token
                {
                    token = TOKEN
                });
                IRestResponse response = client.Execute(request);

                nameTxtBox.Hide();
                salaryTxtBox.Hide();
                ageTxtBox.Hide();
                createNewBtn.Hide();
                deleteByIdBtn.Hide();
                updateBtn.Hide();
                tokenLbl.Hide();
                logoutBrn.Hide();
                loginBtn.Show();
                passwordTxtBox.Show();
                userTxtBox.Show();
                TOKEN = "";
                tokenLbl.Text = "";
                userTxtBox.Text = "";
                passwordTxtBox.Text = "";
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label5.Show();
                label6.Show();
                LOGGEDIN = false;
            }

        }

    }

    public class Employee
    {
        public string Id { get; set; }
        public string employee_name { get; set; }
        public decimal employee_salary { get; set; }
        public decimal employee_age { get; set; }
    }
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class Token
    {
        public string token { get; set; }
    }

}
