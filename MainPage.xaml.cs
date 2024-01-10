namespace AppNumerosdaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumber(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		GenerateLuckNumbers(sender, e);
	}

	private void GenerateLuckNumbers(object sender, EventArgs e)
	{
        var random = new Random();
        var luckNumbers = new List<int>();

        while (luckNumbers.Count < 6)
		{
            var number = random.Next(1, 61);

            if (!luckNumbers.Contains(number))
			{
                luckNumbers.Add(number);
            }
        }

        n1.Text = luckNumbers[0].ToString("D2");
		n2.Text = luckNumbers[1].ToString("D2");
		n3.Text = luckNumbers[2].ToString("D2");
		n4.Text = luckNumbers[3].ToString("D2");
		n5.Text = luckNumbers[4].ToString("D2");
		n6.Text = luckNumbers[5].ToString("D2");
        
    }

}