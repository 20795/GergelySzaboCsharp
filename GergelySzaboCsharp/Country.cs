using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GergelySzaboCsharp
{
    class Country
    {
        private string name;
        private int nrOfInhabitants;
        private int bnpPerCapita;
        private List<City> cityList;
        public Country(string name, int nrOfnrOfInhabitants, int bnpPerCapita)
        {
            this.name = name;
            this.nrOfInhabitants = nrOfInhabitants;
            this.bnpPerCapita = bnpPerCapita;
            createList();
        }
        private void createList()
        {
            cityList = new List<City>();
        }
        public string Name { get => name; set => name = value; }
        public int NrOfInhabitants { get => nrOfInhabitants; set => nrOfInhabitants = value; }
        public int BnpPerCapita { get => bnpPerCapita; set => bnpPerCapita = value; }
        internal List<City> CityList { get => cityList; set => cityList = value; }

    }
}
