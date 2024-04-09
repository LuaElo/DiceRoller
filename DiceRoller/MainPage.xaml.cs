namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public void Clicar(object sender, EventArgs e) // botão
        {
            //Pegar o numero que o usuario escolheu
            int selectSides = Convert.ToInt32(qtdDados.SelectedItem);
            //usar esse numero com "limitador do metodo Random"
            //sortear um numero utilizado o metod random
            Random gerar = new Random();
            int gerarNumero = gerar.Next(1, selectSides + 1);
            //pegar esse resultado e exibir na label 
              gerarNumeroLabel.Text = gerarNumero.ToString();
           
        }

      




    }
}
