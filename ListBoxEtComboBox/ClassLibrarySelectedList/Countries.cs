namespace ClassLibrarySelectedList
{
    public class Countries
    {
        public Dictionary<string,bool> country = new Dictionary<string,bool>();

        public Countries()
        {
            country.Add("France",false);
            country.Add("Belgique", false);
            country.Add("Allemagne", false);
            country.Add("Japon", false);
            country.Add("Portugal", false);
            country.Add("Grece", false);
            country.Add("Bulgarie", false);
            country.Add("Espagne", false);
        }

        public void SelectCountry(string countryName)
        {
            country[countryName] = true;
        }
        public void UnSelectCountry(string countryName)
        {
            country[countryName] = false;
        }

        public void SelectAllCountry()
        {
            foreach (string countryName in country.Keys)
            {
                country[countryName] = true;
            }
        }

        public void UnSelectAllCountry()
        {
            foreach (string countryName in country.Keys)
            {
                country[countryName] = false;
            }
        }

        public void AddCountry(string toAdd)
        {
            country.Add(toAdd.Trim(), false);
        }

        public bool CheckIfCountryIsAlreadyInList(string toTest)
        {
            toTest = toTest.Trim();
            bool wasFound = false;
            if(country.Keys.Contains(toTest))
            {
                wasFound = true;
            }
            return wasFound;
        }

        public string FirstLetterToUpper(string toUp)
        {
            toUp[0].ToString().ToUpper();
            return toUp;
        }
    }
}