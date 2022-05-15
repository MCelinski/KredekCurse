using System;
using System.Data;
using System.Data.SqlClient;

namespace CPC2020_2_Lab3.Database
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public class Repository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// Metoda zwracająca wszystkie książki z tabeli Breweries
        /// </summary>
        /// <returns></returns>
        public DataTable GetBooks()
        {
            string query = "SELECT Books.*, Authors.FirstName, Authors.LastName, Genres.Name FROM Books JOIN Authors ON Books.AuthorId = Authors.Id JOIN Genres ON Books.GenreId = Genres.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda dodająca nową książkę do tabeli Books
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        public void AddBook(string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            string queryGetAuthorId = "SELECT Id FROM Authors WHERE FirstName='" + authorFirstName + "' AND LastName='" + authorLastName + "';";
            string queryGetGenreId = "SELECT Id FROM Genres WHERE Name='" + genre + "';";

            _connection.Open();

            SqlCommand commandGetAuthorId = new SqlCommand(queryGetAuthorId, _connection);
            int authorId = (int) commandGetAuthorId.ExecuteScalar();

            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, _connection);
            int genreId = (int) commandGetGenreId.ExecuteScalar();

            string insertBookQuery = "INSERT INTO Books VALUES ('" + title + "'," + yearOfPublish + "," + price + "," + authorId + "," + genreId + ");";
            SqlCommand commandInsertBook = new SqlCommand(insertBookQuery, _connection);
            commandInsertBook.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda usuwająca książkę z tabeli Books na podstawie bookId
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int bookId)
        {
            string queryDeleteBook = "DELETE FROM Books WHERE Id=" + bookId;

            _connection.Open();

            SqlCommand commandDeleteBook = new SqlCommand(queryDeleteBook, _connection);
            commandDeleteBook.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda edytująca książkę z tabeli Books
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        public void EditBook(int bookId, string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            string queryGetAuthorId = "SELECT Id FROM Authors WHERE FirstName='" + authorFirstName + "' AND LastName='" + authorLastName + "';";
            string queryGetGenreId = "SELECT Id from Genres WHERE Name='" + genre + "';";

            _connection.Open();

            SqlCommand commandGetAuthorId = new SqlCommand(queryGetAuthorId, _connection);
            int authorId = (int)commandGetAuthorId.ExecuteScalar();

            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, _connection);
            int genreId = (int)commandGetGenreId.ExecuteScalar();


            string updateBookQuery = "UPDATE Books SET Title='" + title + "',YearOfPublish=" + yearOfPublish + ", Price=" + price + ", AuthorId=" + authorId + ", GenreId=" + genreId + " WHERE Id=" + bookId + ";";
            SqlCommand commandInsertBook = new SqlCommand(updateBookQuery, _connection);
            commandInsertBook.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda sprawdzająca czy można się zalogować do aplikacji na podstawie login i password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        //public bool Login(string login, string password)
        //{
        //    string query = "SELECT COUNT(*) FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";

        //    _connection.Open();

        //    SqlCommand comm = new SqlCommand(query, _connection);
        //    int foundUsers = (int)comm.ExecuteScalar();

        //    _connection.Close();

        //    if (foundUsers >= 1)
        //        return true;
        //    return false;
        //}
    }
}
