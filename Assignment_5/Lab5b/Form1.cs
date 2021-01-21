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
using System.IO;
namespace Lab5b
{
   /**
   * Name: Zhiping Yu   student number: 000822513
   * File date: 2020.12.09
   * Purpose: This class is a form which provides controls for users to play around. When user load the form each time, they
   *          can see the first doctor's information and his companion and episode information. At this moment, the app uses 
   *          LINQ to extract data from database. However, after loading, users can choose any other doctor's id and click SQL
   *          radio button to display the relevant information by using SQL approach. All in all, no matter which radio button 
   *          has been clicked, the final result would be the same as long as users choose the same doctor'id.
   *          
   * I, Zhiping Yu, 000822513 certify that this material is my original work.  No other person's work has been used 
   * without due acknowledgement.
   */
    public partial class Form1 : Form
    {
        
        private List<Doctor> doctors = new List<Doctor>(); // list of Doctor
        private List<Companion> companions = new List<Companion>(); // list of Companion
        private List<Episode> episodes = new List<Episode>();// list of Episode
        public SqlConnection Connection { get;}
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";//MultipleActiveResultSets=true";

        /// <summary>
        /// Set up the controls in the form and connect to the database
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // connect to the COMP10204_Lab5 database
            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLB.Text = "Connected to the Database successfully!";

            }
            catch (Exception ex)
            {
                statusLB.Text = "Database connection failed, check connection string: " + ex.Message;
            }

        }
        /// <summary>
        ///  When the form is loaded, first doctor's information and his companion and episondes details displayed in the textbox, listbox.
        ///  Plus, doctors'id will populate into a combobox
        /// </summary>
        /// <param name="sender">an object </param>
        /// <param name="e">event arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // clear the listbox containing the companion, episode results and all lists will be clear first when loading
            resultsLB.Items.Clear();
            doctors.Clear();
            companions.Clear();
            episodes.Clear();

            // the default value for the doctor's id
            int defaultDocId = int.Parse(doctorIdCB.Text);

            // the combobox on the left is filled with doctors' id
            PopulateDoctorId();

            // first doctor's relevant information will be filled in and shown
            FillDoctors();          
            FillCompanions();
            FillEpisodes();

            // use LINQ to obtain data
            LINQExtraDoctorInfo(defaultDocId);
            LINQExtraCompanionEpisodeInfo(defaultDocId);
        }

        /// <summary>
        /// Use LINQ or SQL to solve the problem based on the radio buttons users click. When user select different doctor's id,
        /// different doctor's information  should be displayed in the form
        /// </summary>
        /// <param name="sender">an object</param>
        /// <param name="e">avent arguments</param>
        private void doctorIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsLB.Items.Clear();

            // the selected doctor's id
            int docId = int.Parse(doctorIdCB.SelectedItem.ToString());
            
            // choose one of two radio buttons to click and shows different approachs to solve the problem
            if (linqRB.Checked)
            {
                SolveUsingLINQ(docId);
            }
            else
            {
                SolveUsingSQL(docId);

            }
        }

        /// <summary>
        /// Use LINQ to solve the problem and it has two steps including extract doctor information and extract companion
        /// and episode information based on the doctor's id.
        /// </summary>
        /// <param name="docId">the selected doctor's id or default doctor's id</param>
        private void SolveUsingLINQ(int docId)
        {
            LINQExtraDoctorInfo(docId);
            LINQExtraCompanionEpisodeInfo(docId);
        }

        /// <summary>
        /// Use SQL to solve the problem and it has two steps including extract doctor information and extract companion
        /// and episode information based on the doctor's id.
        /// </summary>
        /// <param name="docId">the selected doctor's id</param>
        private void SolveUsingSQL(int docId)
        {
            SQLExtractDoctorInfo(docId);
            SQLExtractCompanionEpisodeInfo(docId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorId"></param>
        private void LINQExtraCompanionEpisodeInfo(int doctorId)
        {
            // use LINQ query syntax to create a new type which has only some properties from two classes when COMAPNION and EPISODE tables join together, the storyid
            // of them are the same, the doctor's id is equal to the parameter and order by seasonyear and storyid
            var matchDoctor = from companion in companions
                              join episode in episodes on companion.StoryId equals episode.StoryId
                              where companion.DoctorId == doctorId
                              orderby episode.SeasonYear, companion.StoryId
                              select new { companion.Name, companion.Actor, episode.Title, episode.SeasonYear };

            // show the results
            foreach (var part in matchDoctor)
            {
                string companionLine = part.Name + " (" + part.Actor + ")";
                resultsLB.Items.Add(companionLine);
                string episodeLine = "\"" + part.Title + "\"" + " (" + part.SeasonYear + ")";
                resultsLB.Items.Add(episodeLine);
                resultsLB.Items.Add("");
                string episodeInfo = resultsLB.Items[1].ToString();
                int closeQuote = episodeInfo.LastIndexOf("\"");
                string firstEpisode = episodeInfo.Substring(1, closeQuote - 1);
                firstTB.Text = firstEpisode;
                string yearPart = episodeInfo.Substring(closeQuote + 2);
                string year = yearPart.Substring(1, yearPart.Length - 2);
                yearTB.Text = year;
            }
        }

        /// <summary>
        /// Use LINQ query to extract doctor's actor, doctor's age, the series number and the doctor's picture. Then,
        /// assign the values into the corresponding controls and displayed to uses. 
        /// </summary>
        /// <param name="doctorId">the selected doctor's id or default doctor's id</param>
        private void LINQExtraDoctorInfo(int doctorId)
        {
            // select the doctors when doctor's id is same as the parameter
            var firstDoctor = from doctor in doctors
                              where doctor.DoctorId == doctorId
                              select doctor;

            // show the results
            foreach (var doctor in firstDoctor)
            {
                actorTB.Text = doctor.Actor;
                seriesTB.Text = doctor.Series.ToString();
                ageTB.Text = doctor.Age.ToString();
                byte[] pic = doctor.Picture;
                MemoryStream stream = new MemoryStream(pic);
                Image image = Image.FromStream(stream);
                doctorPictureBox.Image = Image.FromStream(stream);
            }
        }

        /// <summary>
        /// Use query to get relevant data from EPISODE table and store the data into episode objects. Then add the objects into the
        /// episode list
        /// </summary>
        private void FillEpisodes()
        {
            try
            {
                SqlCommand command3 = new SqlCommand("SELECT * FROM EPISODE", Connection);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    string storyId = reader3["STORYID"].ToString();
                    int season = (int)reader3["SEASON"];
                    int year = (int)reader3["SEASONYEAR"];
                    string title = reader3["TITLE"].ToString();
                    Episode episode = new Episode(storyId, season, year, title);
                    episodes.Add(episode);
                }
                reader3.Close();
                statusLB.Text = "Doctor information read successfully!";
            }
            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }
        /// <summary>
        /// Use query to get relevant data from COMPANION table and store the data into companion objects. Then add the objects into the
        /// companion list
        /// </summary>
        private void FillCompanions()
        {
            try
            {
                SqlCommand command2 = new SqlCommand("SELECT * FROM COMPANION", Connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    string name = reader2["NAME"].ToString();
                    string actor = reader2["ACTOR"].ToString();
                    int docId = (int)reader2["DOCTORID"];
                    string storyId = reader2["STORYID"].ToString();

                    Companion companion = new Companion(name, actor, docId, storyId);
                    companions.Add(companion);
                }
                reader2.Close();
                statusLB.Text = "Companion information read successfully!";
            }
            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }

        /// <summary>
        /// Use query to get relevant data from DOCTOR table and store the data into doctor objects. Then add the objects into the
        /// doctor list
        /// </summary>
        private void FillDoctors()
        {
            try
            {
                SqlCommand command1 = new SqlCommand("SELECT * FROM DOCTOR", Connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    int doctorId = (int)reader1["DOCTORID"];
                    string actor = reader1["ACTOR"].ToString();
                    int series = (int)reader1["SERIES"];
                    int age = (int)reader1["AGE"];
                    string debut = reader1["DEBUT"].ToString();
                    byte[] picture = (byte[])reader1["PICTURE"];
                    Doctor doctor = new Doctor(doctorId, actor, series, age, debut, picture);
                    doctors.Add(doctor);
                }
                reader1.Close();
                statusLB.Text = "Doctor information read successfully!";
            }
            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }

        /// <summary>
        ///  Use query to get doctors' id from DOCTOR table and store the ids into a combobox
        /// </summary>
        private void PopulateDoctorId()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT DOCTORID FROM DOCTOR", Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    doctorIdCB.Items.Add(reader["DOCTORID"]);
                }
                statusLB.Text = "DoctorId is populated into the Doctor Combo box!";
                reader.Close();

            }
            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }

       
       /// <summary>
       /// Use SQL to obtain relevant data from DOCTOR table and store them into the corresponding controls. Then display the values
       /// </summary>
       /// <param name="doctorId">the selected doctor's id</param>
       
        private void   SQLExtractDoctorInfo(int doctorId)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT ACTOR,SERIES, AGE, PICTURE " +
                "FROM DOCTOR WHERE DOCTORID = @id", Connection);
                SqlParameter docId = new SqlParameter("@id", SqlDbType.Int);
                docId.Value = doctorId;
                command.Parameters.Add(docId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    actorTB.Text = (string)reader["ACTOR"];
                    seriesTB.Text = reader["SERIES"].ToString();
                    ageTB.Text = reader["AGE"].ToString();

                    // get the picture from the database and store it into the control and display it
                    byte[] photo = (byte[])reader["Picture"];
                    MemoryStream stream = new MemoryStream(photo);
                    Image image = Image.FromStream(stream);
                    doctorPictureBox.Image = Image.FromStream(stream);

                }
                statusLB.Text = "Doctor information filled in successfully!";
                reader.Close();
            }
            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }

        /// <summary>
        /// Use SQL to obtain relevant data from Companion and Episode tables and store them into the corresponding controls. Then display the values
        /// </summary>
        /// <param name="doctorId">the selected doctor's id</param>
        private void SQLExtractCompanionEpisodeInfo(int docId)
        {
            try
            { // join two tables and order the data based on seasonyear and storyid
                SqlCommand command = new SqlCommand("SELECT NAME, ACTOR, SEASONYEAR, TITLE FROM COMPANION C JOIN EPISODE E" +
                                                     " ON C.STORYID = E.STORYID AND DOCTORID = @docId ORDER BY SEASONYEAR,C.STORYID", Connection);
                SqlParameter doctorId = new SqlParameter("@docId", SqlDbType.Int);

                doctorId.Value = docId;

                command.Parameters.Add(doctorId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // The above line with companion name and actor in a format
                    string name = reader["NAME"].ToString();
                    string actor = reader["ACTOR"].ToString();
                    string companion = name + " (" + actor + ")";
                    resultsLB.Items.Add(companion);

                    // The below line with title and seasonyear in a format
                    string title = (string)reader["TITLE"];
                    int time = (int)reader["SEASONYEAR"];
                    string episode = "\"" + title + "\"" + " (" + time + ")";
                    resultsLB.Items.Add(episode);
                    resultsLB.Items.Add("");

                }

                // find the first episode title and earlist year when the selected doctor played with companion
                string episodeInfo = resultsLB.Items[1].ToString();
                int closeQuote = episodeInfo.LastIndexOf("\"");
                string firstEpisode = episodeInfo.Substring(1, closeQuote - 1);
                firstTB.Text = firstEpisode;
                string yearPart = episodeInfo.Substring(closeQuote + 2);
                string year = yearPart.Substring(1, yearPart.Length - 2);
                yearTB.Text = year;
                statusLB.Text = "Companion and Episode information filled in successfully!";
                reader?.Close();

            }

            catch (Exception ex)
            {
                statusLB.Text = "Datebase operation failed, due to: " + ex.Message;
            }
        }


        /// <summary>
        /// Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
