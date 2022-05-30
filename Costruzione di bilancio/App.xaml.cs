using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Costruzione_di_bilancio
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public Tasse Tax { get; set; }
		public App()
		{
			Tax = new Tasse(0, 100);
		}
	}
}
