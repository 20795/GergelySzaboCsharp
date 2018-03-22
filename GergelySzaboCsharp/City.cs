using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GergelySzaboCsharp
{
    class City
    {
        private string name;
        private int nrOfInhabitants;
        private int averageIncome;
        private int nrOfTouristsPerYear;
        private int nrOfAccommodations = 0; //Defaultvärde = 0 eftersom inga accomodations finns lagrade i listan accomodations när vi skapar ett objekt av typen City!
        private List<Accommodation> accommodationList;
        private double avrageCostPerNight = 0;
        public City(string name, int nrOfInhabitants, int averageIncome, int nrOfTuristsPerYear)
        {
            this.name = name;
            this.nrOfInhabitants = nrOfInhabitants;
            this.averageIncome = averageIncome;
            this.nrOfTouristsPerYear = nrOfTuristsPerYear;
            accommodationList = new List<Accommodation>();
            this.PopulatingAccList();
            this.nrOfAccommodations = 0;
            this.avrageCostPerNight = 0;
        }
        public string Name { get => name; set => name = value; }
        public int NrofInhabitants { get => nrOfInhabitants; set => nrOfInhabitants = value; }
        public int AverageIncome { get => averageIncome; set => averageIncome = value; }
        public int NrOfTouristsPerYear { get => nrOfTouristsPerYear; set => nrOfTouristsPerYear = value; }
        public int NrOfAccommodations { get => nrOfAccommodations; set => nrOfAccommodations = value; }
        public List<Accommodation> AccommodationList { get => accommodationList; set => accommodationList = value; }
        public void PopulatingAccList()
        {
            //init SQL connection
            SqlConnection conn = new SqlConnection(); //Vi skapar ett objekt at typen SqlConnection
            conn.ConnectionString = "server=(local);Integrated Security=True; initial catalog=testDB";//såkallad connection String
            conn.Open(); //Vi öppnar länken mellan C# och SQL

            SqlCommand myQuery = new SqlCommand("SELECT * FROM " + name + ";", conn); // skapar ett SQL query
            SqlDataReader myReader = myQuery.ExecuteReader(); //nu kan vi läsa data från SQL

            int parsedResult;   //temp variabel för minstay
            int x = 0; //index för att populera AccommodationList
            while (myReader.Read())
            {
                int.TryParse(myReader[14].ToString(), out parsedResult);
                accommodationList.Add(
                    new Accommodation(
                        int.Parse(myReader[0].ToString() ?? "0"),//int 
                        int.Parse(myReader[2].ToString() ?? "0"),//int
                        myReader[3].ToString() ?? "null",
                        myReader[6].ToString() ?? "null",
                        myReader[7].ToString() ?? "null",
                        int.Parse(myReader[8].ToString() ?? "0"),//int
                        double.Parse(myReader[9].ToString() ?? "0.0"),
                        int.Parse(myReader[10].ToString() ?? "0"),//int
                        int.Parse(myReader[11].ToString() ?? "0"), //int
                        int.Parse(myReader[13].ToString() ?? "0"),//int
                        parsedResult,//int
                        double.Parse(myReader[17].ToString() ?? "0.0"),
                        double.Parse(myReader[18].ToString() ?? "0.0"),
                        myReader[16].ToString() ?? "null"
                    )
                );
                avrageCostPerNight = avrageCostPerNight + int.Parse(myReader[13].ToString() ?? "0");
                x++;
            }
            nrOfAccommodations = accommodationList.Count;
            avrageCostPerNight = avrageCostPerNight/accommodationList.Count;
            conn.Close();
        }
    }
}