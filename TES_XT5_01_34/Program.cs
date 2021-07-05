using System;
using static System.Console;

namespace TES_XT5_01_34
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine(" Nilai Prodas Semester XT5");
			string[] Nm = { "DANI","DINA","NADI","DIAN","ANDI",
							"RONI","ORIN","NIRO","ORNI","NORI",
							"RISA","RAIS","SARI","IRSA","ARSI"};
			int[,] NL = new int[15, 3]; int N; string NO;
			float RS, TN1 = 0, TN2 = 0, TN3 = 0, RR = 0;
			Random R = new Random();

			WriteLine(" +----+------+----+----+-----+-------+");
			WriteLine(" | No.| NAMA | N1 | N2 | N3  |  NA   |");
			WriteLine(" +----+------+----+----+-----+-------+");

			for (int X = 0; X < 15; X++) 
			{
				NL[X, 0] = R.Next(70, 99);
				NL[X, 1] = R.Next(70, 99);
				NL[X, 2] = R.Next(70, 99);
				RS = (float)(NL[X, 0] + NL[X, 1] + NL[X, 2]) / 3;
				RR += RS;
				TN1 += NL[X, 0]; TN2 += NL[X, 2]; TN3 += NL[X, 2];

				N = X + 1;
				NO = (N.ToString());
				if (N < 10) NO = string.Concat("0", N.ToString());
				WriteLine(" | {0} | {1} | {2} | {3} | {4} |   {5:0.00}   |",
									   NO, Nm[X], NL[X, 0], NL[X, 0], NL[X, 2], RS);
			}
			WriteLine(" +-----------+----+----+-------+--------+");
			WriteLine(" |Rata-rata  |{0:0.0}|{1:0.0}| {2:0.0}  | {3:0.00}  |", TN1 / 15, TN2 / 15, TN3 / 15, RR / 15);
			WriteLine(" +-----------+----+----+-------+--------+");
			WriteLine(" Report By = Rifki XT5/34");
			Write(" 12/02/2019");
			ReadKey();
		}
	}
}
