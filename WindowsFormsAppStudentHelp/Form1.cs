using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsAppStudentHelp
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            sqlConnection.Open();

            if(sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Connected good!");

        }
        static void SELECTIDENTITY(SqlCommand command, string IdVal)
        {
            command.CommandText = $"SELECT @@IDENTITY AS '{IdVal}'";
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO [CatalogInMusicStore] (IdRecords, IdPerformers, IdGenres, IdRecordCompanys, Price, Quantity, NumberOfSales, IdInformationAboutPerformers) " +
                "VALUES (@IdRecords, @IdPerformers, @IdGenres, @IdRecordCompanys, @Price, @Quantity, @NumberOfSales, @IdInformationAboutPerformers)", sqlConnection);

            //command.Parameters.AddWithValue("IdRecords", tB_IdRecords.Text);
            //command.Parameters.AddWithValue("IdPerformers", tB_IdPerformers.Text);
            //command.Parameters.AddWithValue("IdGenres", tB_IdGenres.Text);
            //command.Parameters.AddWithValue("IdRecordCompanys", tB_RecordCompany.Text);
            command.Parameters.AddWithValue("Price", tB_Price.Text);
            command.Parameters.AddWithValue("Quantity", tB_Quantity.Text);
            command.Parameters.AddWithValue("NumberOfSales", tb_NumberOfSalesStore.Text);
            //command.Parameters.AddWithValue("IdInformationAboutPerformers", tB_IdInformationAboutPerformers.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());

            command.CommandText = "SELECT @@IDENTITY AS 'Id'";
            MessageBox.Show(command.ExecuteScalar().ToString());

        }

        private void tb_INSERTRECORDS_Click(object sender, EventArgs e)
        {
            SqlCommand commandRecordings = new SqlCommand(
                "INSERT INTO [Recordings] (AlbumTitle, YearOfRelease, DateOfSale, NumberOfSales) " +
                "VALUES (@AlbumTitle, @YearOfRelease, @DateOfSale, @NumberOfSales)", sqlConnection);

            commandRecordings.Parameters.AddWithValue("AlbumTitle", tb_AlbumTitle.Text);
            commandRecordings.Parameters.AddWithValue("DateOfSale", tb_DateOfSale.Text);
            commandRecordings.Parameters.AddWithValue("NumberOfSales", tb_NumberOfSales.Text);


            var commandCatalogInMusicStore = new SqlCommand("INSERT INTO [CatalogInMusicStore] (IdRecords) " +
                "VALUES (@IdRecords)", sqlConnection);

            SELECTIDENTITY(commandRecordings, "IdRecord");

            var c = commandRecordings.ExecuteScalar().ToString();

            commandCatalogInMusicStore.Parameters.AddWithValue("IdRecords", c);
            MessageBox.Show(commandCatalogInMusicStore.ExecuteNonQuery().ToString());


        }

        private void btn_InsertPerfomers_Click(object sender, EventArgs e)
        {
            SqlCommand commandPerformers = new SqlCommand("INSERT INTO [Performers] (Performer) " +
    "VALUES (@Performer)", sqlConnection);

            commandPerformers.Parameters.AddWithValue("Performer", tb_Performer.Text);

            var commandCatalogInMusicStore1 = new SqlCommand("INSERT INTO [CatalogInMusicStore] (IdPerformers) " +
                "VALUES (@IdPerformers)", sqlConnection);
            SELECTIDENTITY(commandPerformers, "IdPerformer");
            var c1 = commandPerformers.ExecuteScalar().ToString();

            commandCatalogInMusicStore1.Parameters.AddWithValue("IdPerformers", c1);


            MessageBox.Show(c1);
        }

        private void btn_Album_Click(object sender, EventArgs e)
        {
            if(tb_Album.Text != string.Empty)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Performers.Performer, Genres.Genre, RecordCompanys.RecordCompany,CatalogInMusicStore.Price, CatalogInMusicStore.Quantity FROM CatalogInMusicStore, Performers, Genres, Recordings, RecordCompanys WHERE CatalogInMusicStore.IdPerformers = Performers.IdPerformer AND CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany AND CatalogInMusicStore.IdGenres = Genres.IdGenre AND CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = '{tb_Album.Text}'", sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter($"SELECT Recordings.AlbumTitle, Recordings.YearOfRelease, Recordings.DateOfSale, Recordings.NumberOfSales FROM CatalogInMusicStore, Recordings WHERE CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = '{tb_Album.Text}'", sqlConnection);

                DataSet dataSet1 = new DataSet();

                dataAdapter1.Fill(dataSet1);
                dataGridView2.DataSource = dataSet1.Tables[0];

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter($"SELECT InfoAboutPerformers.FirstName, InfoAboutPerformers.LastName, InfoAboutPerformers.DateOfBirth, InfoAboutPerformers.PlaceOfBirth, InfoAboutPerformers.Professions, InfoAboutPerformers.Groups FROM CatalogInMusicStore, InfoAboutPerformers, Recordings WHERE CatalogInMusicStore.IdInformationAboutPerformers = InfoAboutPerformers.IdPerfomersInfo AND CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = '{tb_Album.Text}'", sqlConnection);

                DataSet dataSet2 = new DataSet();

                dataAdapter2.Fill(dataSet2);
                dataGridView3.DataSource = dataSet2.Tables[0];
            }
            else
                MessageBox.Show("Будь ласка, введіть дані!");


        }


        private void btn_Perfomers_Click(object sender, EventArgs e)
        {
            if(tb_Perfomers.Text != string.Empty)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT CatalogInMusicStore.Id, Performers.Performer, Genres.Genre, RecordCompanys.RecordCompany,CatalogInMusicStore.Price,  CatalogInMusicStore.Quantity FROM CatalogInMusicStore, Performers, Genres, Recordings, RecordCompanys WHERE CatalogInMusicStore.IdPerformers = Performers.IdPerformer AND CatalogInMusicStore.IdGenres = Genres.IdGenre AND CatalogInMusicStore.IdRecords = Recordings.IdRecord AND CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany AND Performers.Performer = '{tb_Perfomers.Text}'", sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter($"SELECT Recordings.AlbumTitle, Recordings.YearOfRelease, Recordings.DateOfSale, Recordings.NumberOfSales FROM CatalogInMusicStore, Recordings, RecordCompanys, Performers WHERE CatalogInMusicStore.IdRecords = Recordings.IdRecord AND CatalogInMusicStore.IdPerformers = Performers.IdPerformer AND CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany AND Performers.Performer = '{tb_Perfomers.Text}'", sqlConnection);

                DataSet dataSet1 = new DataSet();

                dataAdapter1.Fill(dataSet1);
                dataGridView2.DataSource = dataSet1.Tables[0];

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter($"SELECT InfoAboutPerformers.FirstName, InfoAboutPerformers.LastName, InfoAboutPerformers.DateOfBirth,  InfoAboutPerformers.PlaceOfBirth, InfoAboutPerformers.Professions, InfoAboutPerformers.Groups FROM CatalogInMusicStore, InfoAboutPerformers, RecordCompanys, Performers WHERE CatalogInMusicStore.IdInformationAboutPerformers = InfoAboutPerformers.IdPerfomersInfo AND CatalogInMusicStore.IdInformationAboutPerformers = RecordCompanys.IdRecordCompany AND Performers.Performer = '{tb_Perfomers.Text}'", sqlConnection);

                DataSet dataSet2 = new DataSet();

                dataAdapter2.Fill(dataSet2);
                dataGridView3.DataSource = dataSet2.Tables[0];
            }
            else
                MessageBox.Show("Будь ласка, введіть дані!");
        }

        private void btn_RecordCompanys_Click(object sender, EventArgs e)
        {
            if(tb_RecordCompanys.Text != string.Empty)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Performers.Performer, Genres.Genre, RecordCompanys.RecordCompany, CatalogInMusicStore.Price, CatalogInMusicStore.Quantity FROM CatalogInMusicStore, Performers, Genres, Recordings, RecordCompanys WHERE CatalogInMusicStore.IdPerformers = Performers.IdPerformer AND CatalogInMusicStore.IdGenres = Genres.IdGenre and CatalogInMusicStore.IdRecords = Recordings.IdRecord and CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany and RecordCompanys.RecordCompany = '{tb_RecordCompanys.Text}'", sqlConnection);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter($"SELECT Recordings.AlbumTitle, Recordings.YearOfRelease, Recordings.DateOfSale, Recordings.NumberOfSales FROM CatalogInMusicStore, Recordings, RecordCompanys WHERE CatalogInMusicStore.IdRecords = Recordings.IdRecord AND CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany AND RecordCompanys.RecordCompany = '{tb_RecordCompanys.Text}'", sqlConnection);

                DataSet dataSet1 = new DataSet();

                dataAdapter1.Fill(dataSet1);
                dataGridView2.DataSource = dataSet1.Tables[0];

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter($"SELECT InfoAboutPerformers.FirstName, InfoAboutPerformers.LastName, InfoAboutPerformers.DateOfBirth, InfoAboutPerformers.PlaceOfBirth, InfoAboutPerformers.Professions, InfoAboutPerformers.Groups FROM CatalogInMusicStore, InfoAboutPerformers, RecordCompanys WHERE CatalogInMusicStore.IdInformationAboutPerformers = InfoAboutPerformers.IdPerfomersInfo AND CatalogInMusicStore.IdRecordCompanys = RecordCompanys.IdRecordCompany AND RecordCompanys.RecordCompany = '{tb_RecordCompanys.Text}'", sqlConnection);

                DataSet dataSet2 = new DataSet();

                dataAdapter2.Fill(dataSet2);
                dataGridView3.DataSource = dataSet2.Tables[0];
            }
            else
                MessageBox.Show("Будь ласка, введіть дані!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            string cbox = comboBox1.SelectedItem.ToString();
            if(cbox == "Кількість продаж")
            {
                cmd = new SqlCommand("SELECT COUNT(select sum(CatalogInMusicStore.Quantity) from CatalogInMusicStore", sqlConnection);

                int countSale = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                cmd.CommandText = "SELECT COUNT(select sum(CatalogInMusicStore.Quantity) from CatalogInMusicStore";
                //MessageBox.Show("Загальна кількість продаж: " + cmd.);
            }
            else if(cbox == "Кількість альбомів")
            {
                cmd = new SqlCommand("SELECT COUNT(DISTINCT Recordings.AlbumTitle) FROM Recordings", sqlConnection);

                int countAlbum = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                MessageBox.Show("Загальна кількість альбомів: " + countAlbum.ToString());
            }
        }
    }
}