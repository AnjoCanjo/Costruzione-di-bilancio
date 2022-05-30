using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Costruzione_di_bilancio
{
	/// <summary>
	/// Logica di interazione per ModificaTassazioni.xaml
	/// </summary>
	public partial class ModificaTassazioni : Window
	{
		public ModificaTassazioni()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			double a = 0.0;
			double b = 0.0;
			if(double.TryParse(textBox.Text, out a) && double.TryParse(textBox1.Text, out b))
			{
				Tasse NewTax = new Tasse();
				if(NewTax.EditTasse(a, b))
				{
					Costruzione_di_bilancio.App.Tax;
				}
				else
				{

				}
			}
			else
			{
				MessageBox.Show("Valori inseriti non validi");
			}
			
		}
	}
}
