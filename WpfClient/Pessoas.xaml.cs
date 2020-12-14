using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfClient.Service;

namespace WpfClient
{
    /// <summary>
    /// Lógica interna para Pessoas.xaml
    /// </summary>
    public partial class Pessoas : Window
    {
        private PessoasClient Client;
        public int? SelectedPessoaId { get; set; }


        public Pessoas()
        {
            Client = new PessoasClient(new System.Net.Http.HttpClient());
            InitializeComponent();
            LoadDataGridPessoas();
        }

        public async void LoadDataGridPessoas()
        {
            try
            {
                var pessoas = await Client.GetPessoasAsync();
                dataGridPessoas.ItemsSource = pessoas.ToList();
            }
            catch(ApiException ex)
            {

            }
        }

        public async void AddPessoa()
        {
            try
            {
                var pessoa = new Pessoa
                {
                    Nome = nome.Text,
                    Sobrenome = sobrenome.Text,
                    Telefone = telefone.Text,
                };
                await Client.PostPessoaAsync(pessoa);
            }
            catch (ApiException ex)
            {

            }
            ResetDados();

            LoadDataGridPessoas();
        }

        public async void UpdatePessoa()
        {
            try
            {
                int id = SelectedPessoaId.Value;
                var pessoa = new Pessoa
                {
                    Id = id,
                    Nome = nome.Text,
                    Sobrenome = sobrenome.Text,
                    Telefone = telefone.Text,
                };
                await Client.PutPessoaAsync(id, pessoa);
            }
            catch (ApiException ex)
            {

            }
            ResetDados();

            LoadDataGridPessoas();
        }

        public async void DeletePessoa()
        {
            try
            {
                await Client.DeletePessoaAsync(SelectedPessoaId.Value);
            }
            catch (ApiException ex)
            {

            }
            ResetDados();

            LoadDataGridPessoas();
        }

        private void BtnGravar_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedPessoaId == null)
            {
                AddPessoa();
            }
            else
            {
                UpdatePessoa();
            }
        }

        private void dataGridPessoas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = dataGridPessoas.SelectedItem;
            if (selected != null)
            {
                var pessoa = selected as Pessoa;
                SelectedPessoaId = pessoa.Id;
                nome.Text = pessoa.Nome;
                sobrenome.Text = pessoa.Sobrenome;
                telefone.Text = pessoa.Telefone;
                BtnGravarText.Text = "Atualizar";
                BtnExcluir.IsEnabled = true;
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ResetDados();
        }

        private void ResetDados()
        {
            SelectedPessoaId = null;
            nome.Clear();
            sobrenome.Clear();
            telefone.Clear();
            BtnExcluir.IsEnabled = false;
            BtnGravarText.Text = "Gravar";
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedPessoaId != null)
            {
                DeletePessoa();
            }
        }
    }
}
