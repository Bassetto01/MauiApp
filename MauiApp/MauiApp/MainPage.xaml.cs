namespace MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnTela2_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Tela2());
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = "Rafaela";
            produto.Preco = 300;
            produto.Categoria = "Menina Da Noite";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto });
        }

        private void btnOutro_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLista_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListProdutoPage());
        }
    }

}
