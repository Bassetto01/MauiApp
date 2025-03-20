namespace MauiApp;

public partial class ListProdutoPage : ContentPage
{
	public ListProdutoPage()
	{
        List<Produto> lista = Produto.Lista;

        InitializeComponent();

		lstProduto.ItemsSource = lista;

	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    { 
       Navigation.PushAsync(new ProdutoPage() { BindingContext = (((View)sender).BindingContext as Produto) });
    }
}