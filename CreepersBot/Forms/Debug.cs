using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace CreepyBot.Forms
{
    public partial class Debug : Form
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"User=schoolnet;Password=qawsedrf123;Database=D:\users\Cheshirees\Google\Cheshire Project\Creepermenn\DB\DB1.FDB;DataSource=82.193.125.32;Port=3051;Dialect=3;Charset=WIN1251;Role=;Connection lifetime=30;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            FbConnection con = new FbConnection(connectionString);
            con.Open();
            FbCommand command = new FbCommand("insert into SN_USERS (surname,name) values ('Иди нахуй', 'пидор!!')", con);
            MessageBox.Show(command.ToString());
            con.Close();
        }
    }
}
