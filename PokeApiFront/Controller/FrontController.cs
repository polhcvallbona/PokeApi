using PokeApiBack.Models;
using PokeApiBack.Repositories;
using PokeApiBack.Services;
using PokeApiFront.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PokeApiFront.Controller
{
    public class FrontController
    {
        WelcomeForm welcomeForm = new WelcomeForm();
        MainForm mainForm = new MainForm();

        public FrontController()
        {

            SetListeners();
            LoadData();
            welcomeForm.Show();
        }

        private void SetListeners()
        {
            welcomeForm.bEntrar.Click += BEntrar_Click;
            mainForm.cbPokemonName1.SelectedIndexChanged += CbPokemonName1_SelectedIndexChanged;
            mainForm.cbPokemonName2.SelectedIndexChanged += CbPokemonName2_SelectedIndexChanged;
            mainForm.bComparar.Click += BComparar_Click;
            mainForm.cbPokemonCard1.SelectedIndexChanged += CbPokemonCard1_SelectedIndexChanged;
            mainForm.cbPokemonCard2.SelectedIndexChanged += CbPokemonCard2_SelectedIndexChanged;
        }

        private void CbPokemonCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.pbPokemonCard2.ImageLocation = ((Pokemon)mainForm.cbPokemonCard2.SelectedValue).images.small;
        }

        private void CbPokemonCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.pbPokemonCard1.ImageLocation = ((Pokemon)mainForm.cbPokemonCard1.SelectedValue).images.small;
        }

        private void BComparar_Click(object sender, EventArgs e)
        {
            if (mainForm.cbPokemonName1 != null && mainForm.cbPokemonName2 != null)
            {
                int pokemonMasFuerte = PokemonServices.ComparePokemonTypes(((Pokemon)mainForm.cbPokemonCard1.SelectedValue), ((Pokemon)mainForm.cbPokemonCard2.SelectedValue));
                if (pokemonMasFuerte == 2)
                {
                    mainForm.lIndicador.Text = "El pokemon " + mainForm.cbPokemonName2.Text + " és debil contra el pokemon " + mainForm.cbPokemonName1.Text;
                    mainForm.pPokemon1.BackColor = Color.Green;
                    mainForm.pPokemon2.BackColor = Color.Red;
                } else if (pokemonMasFuerte == 1)
                {
                    mainForm.lIndicador.Text = "El pokemon " + mainForm.cbPokemonName1.Text + " és debil contra el pokemon " + mainForm.cbPokemonName2.Text;
                    mainForm.pPokemon1.BackColor = Color.Red;
                    mainForm.pPokemon2.BackColor = Color.Green;
                } else
                {
                    mainForm.lIndicador.Text = "Ningun dels pokemon es debil contra l'altre";
                    mainForm.pPokemon1.BackColor = Color.Yellow;
                    mainForm.pPokemon2.BackColor = Color.Yellow;
                }
            }
        }

        private async void CbPokemonName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.Cursor = Cursors.WaitCursor;
            await GetPokemonCard1();
            mainForm.Cursor = Cursors.Default;
        }

        private async Task GetPokemonCard1()
        {
            if (mainForm.cbPokemonName1.Text != "" && mainForm.cbPokemonName1.Text != null)
            {
                var result = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName1.Text);
                mainForm.cbPokemonCard1.DataSource = result;
                string imageUrl = result[0].images.small;
                mainForm.pbPokemonCard1.ImageLocation = imageUrl;
            }
        }

        private async void CbPokemonName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.Cursor = Cursors.WaitCursor;
            await GetPokemonCard2();
            mainForm.Cursor = Cursors.Default;
        }

        private async Task GetPokemonCard2()
        {
            if (mainForm.cbPokemonName2.Text != "" && mainForm.cbPokemonName2.Text != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                var result = await PokemonRepository.GetAllPokemonsByName(mainForm.cbPokemonName2.Text);
                mainForm.cbPokemonCard2.DataSource = result;
                string imageUrl = result[0].images.small;
                mainForm.pbPokemonCard2.ImageLocation = imageUrl;
                Cursor.Current = Cursors.Default;
            }
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            welcomeForm.Hide();
            mainForm.ShowDialog();
            welcomeForm.Close();
            Application.Exit();
        }

        private async void LoadData()
        {
            mainForm.cbPokemonName1.DataSource = await PokemonRepository.GetAllPokemonNames();
            mainForm.cbPokemonName2.DataSource = await PokemonRepository.GetAllPokemonNames();
        }
    }
}
