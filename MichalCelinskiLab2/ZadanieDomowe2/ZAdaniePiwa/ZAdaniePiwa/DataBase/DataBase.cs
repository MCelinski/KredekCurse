using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZAdaniePiwa
{
    /// <summary>
    /// Klasa  abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public class DataBase
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// metoda zwracająca wszystkie piwa z tabeli Breweries
        /// </summary>
        /// <returns></returns>
        public DataTable GetBeers()
        {
            string query = "SELECT Beers.Id, Beers.Name, Breweries.Name,Breweries.Country, Breweries.City, Breweries.Adress, BeerCategories.Name, BeerStyles.Name,Beers.abv,Beers.Ibu, Hops.HopName, Hops.country, Awards.Name, Packages.Name, Packages.Capacity FROM Beers JOIN Breweries ON Beers.Brewery_Id = Breweries.Id JOIN BeerCategories ON Beers.cat_Id = BeerCategories.Id JOIN BeerStyles ON Beers.Style_Id = BeerStyles.Id JOIN Hops on Beers.Hop_Id = Hops.Id JOIN Awards ON Beers.Awards_Id = Awards.Id JOIN Packages ON Beers.Package_Id = Packages.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /// <summary>
        /// metoda dodająca nową książkę do tabeli Beers
        /// </summary>
        /// <param name="brewery"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="style"></param>
        /// <param name="abv"></param>
        /// <param name="ibu"></param>
        /// <param name="award"></param>
        /// <param name="hop"></param>
        /// <param name="package"></param>
        public void AddBeer( string beerName, string breweryName, string categoryName, string styleName, int abv, int ibu, string award, string hopName, string packageName)
        {

            string queryGetBreweriesId = "SELECT Id FROM Breweries WHERE Name='" + breweryName + "';";
            string queryGetCategoryId = "SELECT Id FROM BeerCategories WHERE Name='" + categoryName + "';";
            string queryGetAwardId = "SELECT Id FROM Awards WHERE Name='" + award+ "';";
            string queryGetHopId = "SELECT Id FROM Hops WHERE HopName='" + hopName + "';";
            string queryGetStyleId = "SELECT Id FROM BeerStyles WHERE Name='" + styleName + "';";
            string queryGetPackageId = "SELECT Id FROM Packages WHERE Name='" + packageName + "';";

            _connection.Open();

            SqlCommand commandGetBreweriesId = new SqlCommand(queryGetBreweriesId, _connection);
            int breweriesId = (int)commandGetBreweriesId.ExecuteScalar();

            SqlCommand commandGetCategoryId = new SqlCommand(queryGetCategoryId, _connection);
            int categoryId = (int)commandGetCategoryId.ExecuteScalar();

            SqlCommand commandGetAwardId = new SqlCommand(queryGetAwardId, _connection);
            int awardId = (int)commandGetAwardId.ExecuteScalar();

            SqlCommand commandGetHopId = new SqlCommand(queryGetHopId, _connection);
            int hopId = (int)commandGetHopId.ExecuteScalar();

            SqlCommand commandGetStyleId = new SqlCommand(queryGetStyleId, _connection);
            int styleId = (int)commandGetStyleId.ExecuteScalar();

            SqlCommand commandGetPackageId = new SqlCommand(queryGetPackageId, _connection);
            int packageId = (int)commandGetPackageId.ExecuteScalar();

            string insertBeerQuery = ("INSERT INTO Beers VALUES(" + breweriesId + ",'" + beerName+ "'," +categoryId +"," + styleId +" ," +abv+","+ ibu+ "," +awardId+","+hopId +"," +packageId+");");
            //string insertBeerQuery = "INSERT INTO Beers VALUES (" + breweriesId + ",'" + beerName + "'," + categoryId + "," + styleId + "," + abv + "," + ibu + "," + awardId + "," + hopId + "," + packageId + ");";
            SqlCommand commandInsertBeer = new SqlCommand(insertBeerQuery, _connection);
            commandInsertBeer.ExecuteNonQuery();

            _connection.Close();
        }
        /// <summary>
        /// Metoda usuwająca książkę z tabeli Beers na podstawie BeerId
        /// </summary>
        /// <param name="beerId"></param>
            public void DeleteBeer(int beerId)
     {
        string queryDeleteBeer = "DELETE FROM Beers WHERE Id=" + beerId;

        _connection.Open();

        SqlCommand commandDeleteBeer = new SqlCommand(queryDeleteBeer, _connection);
        commandDeleteBeer.ExecuteNonQuery();

        _connection.Close();

    }/// <summary>
    /// metoda uswuająca piwo z tabeli beers
    /// </summary>
    /// <param name="brewery"></param>
    /// <param name="name"></param>
    /// <param name="category"></param>
    /// <param name="style"></param>
    /// <param name="abv"></param>
    /// <param name="ibu"></param>
    /// <param name="award"></param>
    /// <param name="hop"></param>
    /// <param name="package"></param>
        public void EditBeer(int beerId, string beerName,string breweryName,string categoryName, string styleName,int abv,int  ibu, string hopName, string awardName, string packageName)
        {
            string queryGetBreweriesId = "SELECT Id FROM Breweries WHERE Name='" + breweryName + "';";
            string queryGetCategoryId = "SELECT Id FROM BeerCategories WHERE Name='" + categoryName + "';";
            string queryGetAwardId = "SELECT Id FROM Awards WHERE Name='" + awardName + "';";
            string queryGetHopId = "SELECT Id FROM Hops WHERE HopName='" + hopName + "';";
            string queryGetStyleId = "SELECT Id FROM BeerStyles WHERE Name='" + styleName + "';";
            string queryGetPackageId = "SELECT Id FROM Packages WHERE Name='" + packageName + "';";

            _connection.Open();

            SqlCommand commandGetBreweriesId = new SqlCommand(queryGetBreweriesId, _connection);
            int breweriesId = (int)commandGetBreweriesId.ExecuteScalar();

            SqlCommand commandGetCategoryId = new SqlCommand(queryGetCategoryId, _connection);
            int categoryId = (int)commandGetCategoryId.ExecuteScalar();

            SqlCommand commandGetAwardId = new SqlCommand(queryGetAwardId, _connection);
            int awardId = (int)commandGetAwardId.ExecuteScalar();

            SqlCommand commandGetHopId = new SqlCommand(queryGetHopId, _connection);
            int hopId = (int)commandGetHopId.ExecuteScalar();

            SqlCommand commandGetStyleId = new SqlCommand(queryGetStyleId, _connection);
            int styleId = (int)commandGetStyleId.ExecuteScalar();

            SqlCommand commandGetPackageId = new SqlCommand(queryGetPackageId, _connection);
            int packageId = (int)commandGetPackageId.ExecuteScalar();


            string updateBeerQuery = "UPDATE Beers SET Brewery_Id='" + breweriesId + "',Name='" + beerName + "', cat_Id=" + categoryId + ", Style_Id=" + styleId + ", abv=" + abv + ",ibu=" + ibu + ",Awards_Id=" + awardId + ",Hop_Id=" + hopId + ",Package_Id=" + packageId + "WHERE Id=" + beerId + ";";
            SqlCommand commandInsertBeer = new SqlCommand(updateBeerQuery, _connection);
            commandInsertBeer.ExecuteNonQuery();
            _connection.Close();
        }
        /// <summary>
        /// Metoda usuwająca piwo z tabeli Beers na podstawie beerId
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int beerId)
        {
            string queryDeleteBeer = "DELETE FROM Beers WHERE Id=" + beerId;

            _connection.Open();

            SqlCommand commandDeleteBeer = new SqlCommand(queryDeleteBeer, _connection);
            commandDeleteBeer.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
