using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
	internal class Ember
	{
		public double testSuly { get;private set; }
		public double testMagassag { get;private set; }

		public Ember(double TestSuly, double TestMagassag)
		{
			testSuly = TestSuly;
			testMagassag = TestMagassag;

		}


		public override string ToString()
		{
			return $"Testsúly: {testSuly}\n Testmagasság: {testMagassag}";
		}

		public double TestTomegIndex()
		{
			double tt = Math.Round(testSuly / Math.Pow(testMagassag,2), 2);

			return tt;
		}
		public bool NormalTTi (double TTi)
		{
			if (TTi < 25 && TTi >= 18.5)
			{
				return true ;

			}
			else { return false; }
		}
	}
}
