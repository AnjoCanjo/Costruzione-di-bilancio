using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Costruzione_di_bilancio
{
	public class Tasse
	{
		private double IRES{ get; set; }
		private double IRAP{ get; set; }
		public Tasse()
		{
			IRES = 24.0;
			IRAP = 3.9;
		}
		public Tasse(double IRES, double IRAP)
		{
			if(Enumerable.Range(0, 101).Contains((int)Math.Ceiling(IRES)) && Enumerable.Range(0, 101).Contains((int)Math.Ceiling(IRAP)))
			{
				this.IRES = IRES;
				this.IRAP = IRAP;
			}
		}
		public bool EditTasse(double IRES, double IRAP)
		{
			if (Enumerable.Range(0, 101).Contains((int)Math.Ceiling(IRES)) && Enumerable.Range(0, 101).Contains((int)Math.Ceiling(IRAP)))
			{
				this.IRES = IRES;
				this.IRAP = IRAP;
				return true;
			}
			return false;
		}
	}
}
