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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
namespace Costruzione_di_bilancio
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void tile_add_op_Click(object sender, RoutedEventArgs e)
		{
			AggiungiOperazione win2 = new AggiungiOperazione();
			win2.Show();
		}

		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			Random r = new Random();
			tile_add_op.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_delete_op.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256),(byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_edit_op.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_example.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_edit_tax.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_reset.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_CE.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
			tile_SP.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
		}

		private void tile_edit_tax_Click(object sender, RoutedEventArgs e)
		{
			ModificaTassazioni win2 = new ModificaTassazioni();
			win2.Show();
		}
	}
}
