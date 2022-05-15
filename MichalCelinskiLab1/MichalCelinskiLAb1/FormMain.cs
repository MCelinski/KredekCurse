using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalCelinskiLAb1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// zmienna przechowująca wartość pola textBoxAdd
        /// </summary>
        int number = 1;

        /// <summary>
        /// zmienna obslugujaca licznik zegara
        /// </summary>
        int counter = 1;

        /// <summary>
        /// zmiennna przechowująca referencję do nowego okna 
        /// </summary>
        FormNew formNew;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Przycisk zmieniajacy kolor tła i elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //Zmiana koloru tła
            BackColor = Color.Red;
            //zmiana koloru przycisku
            buttonColor.BackColor = Color.Green;
        }
        /// <summary>
        /// przycisk zmieniający kolor buttonColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor2_Click(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Green;
        }
        /// <summary>
        /// przycisk zwiekszajacy wartosc textBoxxAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego na liczbe
            number = Int32.Parse(textBoxAdd.Text);
            number += 7;
            // zamiana wartości liczbowej na zmienną typu string
            textBoxAdd.Text = number.ToString();
            //dodanie warunku
            if (number > 20)
            { 
                MessageBox.Show("uwaga przekroczono próg 20");
                BackColor = Color.Red;
            }
        }
        /// <summary>
        /// uruchomienie tiemra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //uruchomienei zegara
            timerCounter.Start();
        }
        /// <summary>
        /// Uruchomienie funkcji obsługiwanej przez wątek elementu timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zwiększenie zmiennej counter
            counter++;
            if (counter > 5)
                // po osiagniecu 5 do zmiennej counter dodawane jest 100 
                counter += 100;
            //odswieżenie zawartości textBoxAdd
            textBoxAdd.Text = counter.ToString();

        }
        /// <summary>
        /// funkcja tworzaca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            //utworzenie nowwego obiektu okna FormNew
            formNew = new FormNew();
            //przypisanie wartości do nowego okna
            formNew.mainWindowValue = "Michał Celiński";
            //otworzenie okna obiektu formNew
            formNew.Show();
        }
    }
}
