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
        private SqlConnection sqlConnection = null;
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
            //command.ExecuteNonQuery();

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT CatalogInMusicStore.Id, CatalogInMusicStore.Price, CatalogInMusicStore.Quantity, Performers.Performer, Genres.Genre FROM CatalogInMusicStore, Performers, Genres, Recordings WHERE CatalogInMusicStore.IdPerformers = Performers.IdPerformer AND CatalogInMusicStore.IdGenres = Genres.IdGenre and CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = 'Love Yurself'", sqlConnection);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Recordings WHERE AlbumTitle = 'Butter'", sqlConnection);


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT CatalogInMusicStore.IdRecords, Recordings.AlbumTitle, Recordings.YearOfRelease, Recordings.DateOfSale, Recordings.NumberOfSales " +
                "FROM CatalogInMusicStore, Recordings WHERE CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = 'Love Yurself'", sqlConnection);

            DataSet dataSet1 = new DataSet();

            dataAdapter1.Fill(dataSet1);
            dataGridView2.DataSource = dataSet1.Tables[0];
            
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT CatalogInMusicStore.IdInformationAboutPerformers, InfoAboutPerformers.FirstName, InfoAboutPerformers.LastName, InfoAboutPerformers.DateOfBirth, InfoAboutPerformers.PlaceOfBirth, InfoAboutPerformers.YearsOfActivity, InfoAboutPerformers.Professions, InfoAboutPerformers.Groups FROM CatalogInMusicStore, InfoAboutPerformers, Recordings WHERE CatalogInMusicStore.IdInformationAboutPerformers = InfoAboutPerformers.IdPerfomersInfo AND CatalogInMusicStore.IdRecords = Recordings.IdRecord AND Recordings.AlbumTitle = 'Love Yurself'", sqlConnection);

            DataSet dataSet2 = new DataSet();

            dataAdapter2.Fill(dataSet2);
            dataGridView3.DataSource = dataSet2.Tables[0];



            // MessageBox.Show("___");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
