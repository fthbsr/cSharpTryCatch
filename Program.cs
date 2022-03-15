using System;

    namespace hata_yonetimi
    {

        class Program{

            static void Main(string[] args){
                
                // try
                // {
                //     Console.WriteLine("Bir sayi giriniz :");
                //     int sayi = Convert.ToInt32(Console.ReadLine());
                //     Console.WriteLine("girdiginiz sayi " + sayi); 
                // }
                // catch (Exception  ex )
                // {
                //     Console.WriteLine("hata " + ex.Message );
                  
                // }
                // finally
                // {
                //     Console.WriteLine("islem tamamlandi");
                // }


                try
                {
                    // int a = int.Parse(null);
                    //int a = int.Parse("test");
                    int a = int.Parse("-200000000000");
                }
                catch (ArgumentNullException ex )
                {
                    
                   Console.WriteLine("Arguman hatasi aldiniz" + ex);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Veri tipi uygun degil");
                    Console.WriteLine(ex);

                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Cok kucuk veya buyuk deger girdiniz");
                    Console.WriteLine(ex);
                }
            }
        }
    }
