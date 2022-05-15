using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAdaniePiwa
{
    public partial class FormMain : Form
    {
        private readonly DataBase _repository = new DataBase();
        /// <summary>
        /// Konstruktor okna głownego aplikacji
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            //Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

      

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Aktualizacja danych w DataGridViewBooks przy ładowaniu okna
            RefreshDataGridViewBeers();
            //Dostosowanie tabeli DataGridViewBooks przy ładowaniu okna
            CustomizeDataGridViewBeers();
        }

        
      
        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w DataGridViewBeers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBeers_SelectionChanged(object sender, EventArgs e)
        {
           
            
            //Jeśli żadnen wiersz nie jest zaznaczony lub jest zaznaczonych więcej niż jeden to nic nie rób (return)
            int rowsCount = dataGridViewBeers.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;
            
            //weź pierwszy zaznaczony wiersz
            DataGridViewRow row = dataGridViewBeers.SelectedRows[0];

            //wyciągnij dane z zaznaczonego wiersza
            int beerId = int.Parse(row.Cells[0].Value.ToString());
            string beerName = row.Cells[1].Value.ToString();
            string breweryName = row.Cells[2].Value.ToString();
            string categoryName = row.Cells[6].Value.ToString();
            string styleName = row.Cells[7].Value.ToString();
            int abv = int.Parse(row.Cells[8].Value.ToString());
            int ibu = int.Parse(row.Cells[9].Value.ToString());
            string hopName = row.Cells[10].Value.ToString();
            string awardName = row.Cells[12].Value.ToString();
            string packageName = row.Cells[13].Value.ToString();
            

            //poustawiaj dane w textboxach wybranej książki
            textBoxId.Text = beerId.ToString();
            textBoxBrewery.Text = breweryName;
            textBoxName.Text = beerName;
            textBoxCategory.Text = categoryName;
            textBoxAbv.Text = abv.ToString();
            textBoxIbu.Text = ibu.ToString();
            textBoxStyle.Text = styleName;
            textBoxAwards.Text = awardName;
            textBoxPackage.Text = packageName;
            textBoxHop.Text = hopName.ToString();
            labelLastAction.Text = "Wybrano Piwo";


        }

        /// <summary>
        /// Metoda dostosowująca DataGridViewBooks - ustawianie widoczności kolumn i ich nazw
        /// </summary>
        private void CustomizeDataGridViewBeers()
        {
            //ustaw widoczność kolumn AuthorId i GenreId na niewidoczne
            //dataGridViewBeers.Columns["beerId"].Visible = false;
         

            ////ustaw nazwy kolumn na polskie
            dataGridViewBeers.Columns["Name"].HeaderText = "Nazwa Piwa";
            dataGridViewBeers.Columns["Name1"].HeaderText = "Browar";
            dataGridViewBeers.Columns["Country"].HeaderText = "Państwo";
            dataGridViewBeers.Columns["City"].HeaderText = "Miasto";
            dataGridViewBeers.Columns["Adress"].HeaderText = "Ulica";
            dataGridViewBeers.Columns["Name2"].HeaderText = "Kategoria";
            dataGridViewBeers.Columns["Name3"].HeaderText = "Styl";
            dataGridViewBeers.Columns["HopName"].HeaderText = "Chmiel";
            dataGridViewBeers.Columns["country1"].HeaderText = "Pochodzenie Chmielu";
            dataGridViewBeers.Columns["Name4"].HeaderText = "Nagroda";
            dataGridViewBeers.Columns["Name5"].HeaderText = "Opakowanie";
            dataGridViewBeers.Columns["Capacity"].HeaderText = "Pojemność";

        }
        /// <summary>
        /// metoda odwiwezajaca dane w DataGridViewBeers
        /// </summary>
        private void RefreshDataGridViewBeers()
        {
            //pobierz wszystkie piwa z bazy danych
            DataTable beers = _repository.GetBeers();

            //przypisz wszystkie piwa do DatagridViewBooks
            dataGridViewBeers.DataSource = beers;
            
        }
        /// <summary>
        /// metoda czyszcząca wszystkie textboxy
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxBrewery.Text = "";
            textBoxName.Text = "";
            textBoxCategory.Text = ""; 
            textBoxAbv.Text = "";
            textBoxIbu.Text = "";
            textBoxStyle.Text = "";
            textBoxAwards.Text = "";
            textBoxPackage.Text = "";
            textBoxHop.Text = "";
        }

     /// <summary>
     /// przycisk czyszczący   wszystkie textboxy
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>

        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            labelLastAction.Text = "Wyczyszczono pola";
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do dodawania nowego Piwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBeer_Click_1(object sender, EventArgs e)
        {
            string beerName = textBoxName.Text;
            string breweryName = textBoxBrewery.Text;
            string categoryName = textBoxCategory.Text;
            string styleName = textBoxStyle.Text;
            int abv = int.Parse(textBoxAbv.Text);
            int ibu = int.Parse(textBoxIbu.Text);
            string award = textBoxAwards.Text;
            string hopName = textBoxHop.Text;
            string packageName = textBoxPackage.Text;

            labelLastAction.Text = "Dodano Piwo";

            _repository.AddBeer(beerName, breweryName, categoryName, styleName, abv, ibu, award, hopName, packageName);

            RefreshDataGridViewBeers();
            ClearTextBoxes();
            labelLastAction.Text = "Dodano Piwo";
        }

        private void buttonDeleteBeer_Click(object sender, EventArgs e)
        {
            
                //wyciągnięcie bookId z textboxu
                int beerId = int.Parse(textBoxId.Text);

                //usunięcie książki z bazy danych
                _repository.DeleteBeer(beerId);

                RefreshDataGridViewBeers();
                ClearTextBoxes();
                labelLastAction.Text = "Usunięto Piwo:(";
            
        }
       

        private void buttonEditBeer_Click_1(object sender, EventArgs e)
        {
            //wyciągnięcie danych z textboxów
            int beerId = int.Parse(textBoxId.Text);
            string beerName = textBoxName.Text;
            string breweryName = textBoxBrewery.Text;
            string categoryName = textBoxCategory.Text;
            string styleName = textBoxStyle.Text;
            int abv = int.Parse(textBoxAbv.Text);
            int ibu = int.Parse(textBoxIbu.Text);
            string hopName = textBoxHop.Text;
            string awardName = textBoxAwards.Text;
            string packageName = textBoxPackage.Text;
            //aktualizacja książki
            _repository.EditBeer(beerId, beerName, breweryName, categoryName, styleName, abv, ibu, hopName, awardName, packageName);

            RefreshDataGridViewBeers();
            ClearTextBoxes();
            labelLastAction.Text = "Edytowano Piwo";

        }
    }
}
