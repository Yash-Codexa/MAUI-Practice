namespace PagesDemo;

public partial class PerfectPay_Home : ContentPage
{
	decimal bill;
	int tip;
	int noPersons = 1;
	public PerfectPay_Home()
	{
		InitializeComponent();
	}
	private void txtBill_Completed(Object sender, EventArgs e)
	{
		bill = decimal.Parse(txtBill.Text);
		CalculateTotal();
	}

	private void CalculateTotal()
	{
		var totaltip = (bill * tip) / 100;

		var tipByPerson = (totaltip / noPersons);
		lblTipByPerson.Text = $"{tipByPerson:C}";

		var subTotal = (bill / noPersons);
		lblSubtotal.Text = $"{subTotal:C}";

		var totalByPerson = (bill + totaltip) / noPersons;
		lblTotal.Text = $"{totalByPerson:C}";
	}

	private void sldTip_Changed(Object sender, ValueChangedEventArgs e)
	{
		tip = (int)sldTip.Value;
		lblTip.Text = $"Tip: {tip}%";
		CalculateTotal();

	}

	private void btnTip_Clicked(Object sender, EventArgs e)
	{
		if (sender is Button)
		{
			var btn = (Button)sender;
			var percentage = int.Parse(btn.Text.Replace("%", ""));
			sldTip.Value = percentage;
		}
	}

	private void btnMinus_Clicked(Object sender, EventArgs e)
	{
		if (noPersons > 1)
		{
			noPersons--;
		}
		lblNoPersons.Text = noPersons.ToString();
		CalculateTotal();
	}
	private void btnPlus_Clicked(Object sender, EventArgs e)
	{
		noPersons++;
		lblNoPersons.Text = noPersons.ToString();
		CalculateTotal();
	}

	private void ImageDemo_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ImagesDemo());
    }
}