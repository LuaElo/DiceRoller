namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        Random gerar = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Clicar(object sender, EventArgs e) // botão
        {
                int gerarNumero = gerar.Next(1,11);
                gerarNumeroLabel.Text = $"{gerarNumero}";
           
        }

      




    }
}
