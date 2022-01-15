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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO [CatalogInMusicStore] (Id, IdRecords, IdPerformers, IdGenres, Price, Quantity, IdInformationAboutPerformers) VALUES (@Id, @IdRecords, @IdPerformers, @IdGenres, @Price, @Quantity, @Quantity, @IdInformationAboutPerformers)", sqlConnection);

            command.Parameters.AddWithValue("Id", tB_AlbumName.Text);
            command.Parameters.AddWithValue("IdRecords", tB_Artist.Text);
            command.Parameters.AddWithValue("IdPerformers", tB_Year.Text);
            command.Parameters.AddWithValue("IdGenres", tB_RecordCompany.Text);
            command.Parameters.AddWithValue("Price", tB_Media.Text);
            command.Parameters.AddWithValue("Quantity", tB_PlayingTime.Text);
            command.Parameters.AddWithValue("IdInformationAboutPerformers", tB_Quantity.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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
                cmd = new SqlCommand("SELECT COUNT(DISTINCT CatalogInMusicStore.Quantity) FROM CatalogInMusicStore", sqlConnection);

                int countSale = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                MessageBox.Show("Загальна кількість продаж: " + countSale.ToString());
            }
            else if (cbox == "Кількість альбомів")
            {
                cmd = new SqlCommand("SELECT COUNT(DISTINCT Recordings.AlbumTitle) FROM Recordings", sqlConnection);

                int countAlbum = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                MessageBox.Show("Загальна кількість альбомів: " + countAlbum.ToString());
            }
        }
    }
}
