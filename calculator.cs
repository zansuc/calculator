class calculator
{
	static word void main ( string [] args )
	{
		int a = 10;
		int b = 6;
		
		Consule.WriteLine ( " Hasil penambahan : {0} + {1} = {2}", a, b, Penambahan (a, b ));
		Consule.WriteLine ( " Hasil pengurangan : {0} - {1} = {2}", a, b, Pengurangan (a, b ));
		
		Console.WriteLine( " \n Tekan sembarang key untuk keluar ");
		Consule.ReadKey();
		
	}
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	static int Pengurangan (int a, int b)
	{
		return a - b;
	}
}