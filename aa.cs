using System;
namespace moneychange
{
	class program
	{
		public static void Main(string[] args)
		{
			string name, visa, ulang;
	 		int pilihan;
	 		int tukar1, tukar2, tukar3, tukar4, tukar5, tukar6, tukar7, tukar8, tukar9,tukar10;
	 		int tukar11, tukar12, tukar13, tukar14, tukar15, tukar16, tukar17, tukar18, tukar19, tukar20;
	 		int tukar21, tukar22, tukar23, tukar24, tukar25, tukar26, tukar27, tukar28, tukar29, tukar30 , tukar31;

	 		double kurs1;
	 		double hasil1, hasil2, hasil3, hasil4, hasil5, hasil6, hasil7, hasil8, hasil9, hasil10;
	 		double hasil11, hasil12, hasil13, hasil14, hasil15, hasil16, hasil17, hasil18, hasil19, hasil20;
	 		double hasil21, hasil22, hasil23, hasil24, hasil25, hasil26, hasil27, hasil28, hasil29, hasil30, hasil31;

			Console.Clear();
			Console.WriteLine("Penukaran Uang:");
			Console.WriteLine("");
		 
			Console.Write("Masukkan nomor visa:");
			visa = Console.ReadLine();

			Console.Write("Masukkan Nama Anda:");
			name = Console.ReadLine();
            Console.WriteLine("");

			transaksi :

				do
				{
					Console.WriteLine("======================Daftar Mata Uang Asing Yang Tersedia======================== ");

					Console.WriteLine("1. Poundsterling to Ringgit              |       16. US Dollar to Poundsterling");
					Console.WriteLine("2. Poundsterling to Rupiah               |       17. US Dollar to Ringgit");
					Console.WriteLine("3. Poundsterling to US Dollar            |       18. US Dollar to Rupiah");
					Console.WriteLine("4. Poundsterling to Yen                  |       19. US Dollar to Yen");
					Console.WriteLine("5. Poundsterling to Won                  |       20. US Dollar to Won");
                    Console.WriteLine("");
					Console.WriteLine("6. Ringgit to Poundsterling              |       21. Yen to Poundsterling");
					Console.WriteLine("7. Ringgit to Rupiah                     |       22. Yen to Ringgit");
					Console.WriteLine("8. Ringgit to US Dollar                  |       23. Yen to Rupiah");
					Console.WriteLine("9. Ringgit to Yen                        |       24. Yen to US Dollar");
					Console.WriteLine("10. Ringgit to Won                       |       25. Yen to Won");
                    Console.WriteLine("");
					Console.WriteLine("11. Rupiah to Poundsterling              |       26. Won to Poundsterling");
					Console.WriteLine("12. Rupiah to Ringgit                    |       27. Won to Ringgit");
					Console.WriteLine("13. Rupiah to US Dollar                  |       28. Won to Rupiah");
					Console.WriteLine("14. Rupiah to Yen                        |       29. Won to US Dollar");
					Console.WriteLine("15. Rupiah to Won                        |       30. Won to Yen");
					Console.WriteLine("31. Won to kaliurang");
                    Console.WriteLine("");						                        
					Console.Write("Masukkan Pilihan Anda :");
					pilihan = int.Parse(Console.ReadLine());
					Console.Clear();

					

					if(pilihan==1)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Poundsterling => Ringgit ================");
						kurs1 = (double) 6.38;
						Console.Write("Enter Nominal Poundsterling : ");
						tukar1 = int.Parse(Console.ReadLine());
						hasil1 = (double) tukar1*kurs1;
						Console.WriteLine(" Your Current Money : MYR " + hasil1 );

					}
					else if(pilihan==2)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Poundsterling => Rupiah ================");
						kurs1 = (double) 19272.55;
						Console.Write("Enter Nominal Poundsterling : ");
						tukar2 = int.Parse(Console.ReadLine());
						hasil2 = (double) tukar2*kurs1;
						Console.WriteLine("Your Current Money : Rp " + hasil2 );

					}
					else if(pilihan==3)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Poundsterling => US Dollar ================");
						kurs1 = (double) 2.32;
						Console.Write("Enter Nominal Poundsterling : ");
						tukar3 = int.Parse(Console.ReadLine());
						hasil3 = (double) tukar3*kurs1;
						Console.WriteLine(" Your Current Money : $ " + hasil3 );

					}
					else if(pilihan==4)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Poundsterling => Yen ================");
						kurs1 = (double) 195.09;
						Console.Write("Enter Nominal Poundsterling : ");
						tukar4 = int.Parse(Console.ReadLine());
						hasil4 = (double) tukar4*kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil4 );

					}
					else if(pilihan==5)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Poundsterling => Won ================");
						kurs1 = (double) 1538.32;
						Console.Write("Enter Nominal Poundsterling : ");
						tukar5 = int.Parse(Console.ReadLine());
						hasil5 = (double) tukar5*kurs1;
						Console.WriteLine(" Your Current Money : KRW " + hasil5 );

					}
					else if(pilihan==6)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Ringgit => Poundsterling ================");
						kurs1 = (double) 6.38;
						Console.Write("Enter Nominal Ringgit : ");
						tukar6 = int.Parse(Console.ReadLine());
						hasil6 = (double) tukar6/kurs1;
						Console.WriteLine(" Your Current Money : £ " + hasil6 );

					}
					else if(pilihan==7)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Ringgit => Rupiah ================");
						kurs1 = (double) 3991.44;
						Console.Write("Enter Nominal Ringgit : ");
						tukar7 = int.Parse(Console.ReadLine());
						hasil7 = (double) tukar7*kurs1;
						Console.WriteLine("Your Current Money : Rp " + hasil7 );

					}
					else if(pilihan==8)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Ringgit => US Dollar ================");
						kurs1 = (double) 504.08;
						Console.Write("Enter Nominal Ringgit : ");
						tukar8 = int.Parse(Console.ReadLine());
						hasil8 = (double) tukar8/kurs1;
						Console.WriteLine(" Your Current Money : $ " + hasil8 );

					}
					else if(pilihan==9)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Ringgit => Yen ================");
						kurs1 = (double) 500.037;
						Console.Write("Enter Nominal Ringgit : ");
						tukar9 = int.Parse(Console.ReadLine());
						hasil9 = (double) tukar9/kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil9 );

					}
					else if(pilihan==10)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Ringgit => Won ================");
						kurs1 = (double) 500.0036;
						Console.Write("Enter Nominal Ringgit : ");
						tukar10 = int.Parse(Console.ReadLine());
						hasil10 = (double) tukar10/kurs1;
						Console.WriteLine(" Your Current Money : KRW " + hasil10 );

					}
					else if(pilihan==11)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Rupiah => Poundsterling ================");
						kurs1 = (double) 19272.55;
						Console.Write("Enter Nominal Rupiah : ");
						tukar11 = int.Parse(Console.ReadLine());
						hasil11 = (double) tukar11/kurs1;
						Console.WriteLine(" Your Current Money : £ " + hasil11 );

					}
					else if(pilihan==12)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Rupiah => Ringgit ================");
						kurs1 = (double) 3991.44;
						Console.Write("Enter Nominal Rupiah : ");
						tukar12 = int.Parse(Console.ReadLine());
						hasil12 = (double) tukar12/kurs1;
						Console.WriteLine("Your Current Money : MYR " + hasil12  );

					}
					else if(pilihan==13)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Rupiah => US Dollar ================");
						kurs1 = (double) 14737.75;
						Console.Write("Enter Nominal Rupiah : ");
						tukar13 = int.Parse(Console.ReadLine());
						hasil13 = (double) tukar13/kurs1;
						Console.WriteLine(" Your Current Money : $ " + hasil13 );

					}
					else if(pilihan==14)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Rupiah => Yen ================");
						kurs1 = (double) 629.19;
						Console.Write("Enter Nominal Rupiah : ");
						tukar14 = int.Parse(Console.ReadLine());
						hasil14 = (double) tukar14/kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil14 );

					}
					else if(pilihan==15)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Rupiah => Won ================");
						kurs1 = (double) 512.53;
						Console.Write("Enter Nominal Rupiah : ");
						tukar15 = int.Parse(Console.ReadLine());
						hasil15 = (double) tukar15/kurs1;
						Console.WriteLine(" Your Current Money : KRW " + hasil15 );

					}
					else if(pilihan==16)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ US Dollar => Poundsterling ================");
						kurs1 = (double) 2.32;
						Console.Write("Enter Nominal US Dollar : ");
						tukar16 = int.Parse(Console.ReadLine());
						hasil16 = (double) tukar16/kurs1;
						Console.WriteLine(" Your Current Money : £ " + hasil16 );

					}
					else if(pilihan==17)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ US Dollar => Ringgit ================");
						kurs1 = (double) 508.08;
						Console.Write("Enter Nominal US Dollar : ");
						tukar17 = int.Parse(Console.ReadLine());
						hasil17 = (double) tukar17*kurs1;
						Console.WriteLine("Your Current Money : MYR " + hasil17 );

					}
					else if(pilihan==18)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ US Dollar => Rupiah ================");
						kurs1 = (double) 14737.75;
						Console.Write("Enter Nominal US Dollar : ");
						tukar18 = int.Parse(Console.ReadLine());
						hasil18 = (double) tukar18*kurs1;
						Console.WriteLine(" Your Current Money : Rp " + hasil18 + ",00" );

					}
					else if(pilihan==19)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ US Dollar => Yen ================");
						kurs1 = (double) 610.17;
						Console.Write("Enter Nominal US Dollar : ");
						tukar19 = int.Parse(Console.ReadLine());
						hasil19 = (double) tukar19*kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil19 );

					}
					else if(pilihan==20)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ US Dollar => Won ================");
						kurs1 = (double) 1636.71;
						Console.Write("Enter Nominal US Dollar : ");
						tukar20 = int.Parse(Console.ReadLine());
						hasil20 = (double) tukar20*kurs1;
						Console.WriteLine(" Your Current Money : KRW " + hasil20 );

					}
					if(pilihan==21)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Yen => Poundsterling ================");
						kurs1 = (double) 195.09;
						Console.Write("Enter Nominal Yen : ");
						tukar21 = int.Parse(Console.ReadLine());
						hasil21 = (double) tukar21/kurs1;
						Console.WriteLine(" Your Current Money : £ " + hasil21 );

					}
					else if(pilihan==22)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Yen => Ringgit ================");
						kurs1 = (double) 500.097;
						Console.Write("Enter Nominal Yen : ");
						tukar22 = int.Parse(Console.ReadLine());
						hasil22 = (double) tukar22*kurs1;
						Console.WriteLine("Your Current Money : MYR " + hasil22 );

					}
					else if(pilihan==23)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Yen=> Rupiah ================");
						kurs1 = (double) 629.19;
						Console.Write("Enter Nominal Yen : ");
						tukar23 = int.Parse(Console.ReadLine());
						hasil23 = (double) tukar23*kurs1;
						Console.WriteLine(" Your Current Money : Rp " + hasil23  );

					}
					else if(pilihan==24)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Yen => US Dollar ================");
						kurs1 = (double) 610.17;
						Console.Write("Enter Nominal Yen : ");
						tukar24 = int.Parse(Console.ReadLine());
						hasil24 = (double) tukar24/kurs1;
						Console.WriteLine(" Your Current Money : $ " + hasil24 );

					}
					else if(pilihan==25)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Yen => Won ================");
						kurs1 = (double) 500.097;
						Console.Write("Enter Nominal Yen : ");
						tukar25 = int.Parse(Console.ReadLine());
						hasil25 = (double) tukar25*kurs1;
						Console.WriteLine(" Your Current Money : KRW " + hasil25 );

					}
					else if(pilihan==26)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => Poundsterling ================");
						kurs1 = (double) 1538.32;
						Console.Write("Enter Nominal Won : ");
						tukar26 = int.Parse(Console.ReadLine());
						hasil26 = (double) tukar26/kurs1;
						Console.WriteLine(" Your Current Money : £ " + hasil26 );

					}
					else if(pilihan==27)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => Ringgit ================");
						kurs1 = (double) 500.036;
						Console.Write("Enter Nominal Won : ");
						tukar27 = int.Parse(Console.ReadLine());
	  					hasil27 = (double) tukar27*kurs1;
						Console.WriteLine("Your Current Money : MYR " + hasil27 );

					}
					else if(pilihan==28)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => Rupiah ================");
						kurs1 = (double) 512.53;
						Console.Write("Enter Nominal Won : ");
						tukar28 = int.Parse(Console.ReadLine());
						hasil28 = (double) tukar28*kurs1;
						Console.WriteLine(" Your Current Money : Rp " + hasil28 );

					}
					else if(pilihan==29)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => US Dollar ================");
						kurs1 = (double) 1636.71;
						Console.Write("Enter Nominal Won : ");
						tukar29 = int.Parse(Console.ReadLine());
						hasil29 = (double) tukar29/kurs1;
						Console.WriteLine(" Your Current Money : $" + hasil29 );

					}
					else if(pilihan==30)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => Yen ================");
						kurs1 = (double) 500.097;
						Console.Write("Enter Nominal Won : ");
						tukar30 = int.Parse(Console.ReadLine());
						hasil30 = (double) tukar30/kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil30 );

					}
						else if(pilihan==31)
					{
						Console.WriteLine("Name :	" + name);
						Console.WriteLine("Visa :	" + visa);
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("================ Won => Kaliurang ================");
						kurs1 = (double) 500.097;
						Console.Write("Enter Nominal Won : ");
						tukar31 = int.Parse(Console.ReadLine());
						hasil31 = (double) tukar31/kurs1;
						Console.WriteLine(" Your Current Money : JPY " + hasil31 );
					}
					else
					{
						Console.WriteLine("Pilih angka yang tersedia!!!");
						goto transaksi;
					}
					Console.Clear();
					
				}while(pilihan >= 32);

				Console.WriteLine("==================== Thank You ====================");
				Console.Write("Apakah Anda Ingin Mengulangi Transaksi? (Y/N)");
				ulang = Console.ReadLine();

				if(ulang=="Y")
				goto transaksi;
			
		}
	}
}