using System;
class Program
{
    static void Main(string[] args)
    {
       
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        bankTransferConfig.ReadConfigFile();
        if(bankTransferConfig.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
        }
        else
        {
            Console.WriteLine("Masukkan Jumlah uang yang akan di transfer: ");
        }

        string jawaban = Console.ReadLine();


        if(jawaban <= bankTransferConfig.config.transfer.threshold) 
        {
            
        }

        if(bankTransferConfig.config.lang == "en")
        {
            Console.WriteLine("Transfer Fee = ");
            Console.WriteLine("Amount = ");
            Console.WriteLine("Select transfer method: ");
        }
        else
        {
            Console.WriteLine("Biaya Transfer = ");
            Console.WriteLine("Total Biaya = ");
            Console.WriteLine("Pilih Metode Transfer: ");
        }

        
        
        for(int i = 1; i < bankTransferConfig.config.methods)
            
           
            
        //string jawaban2 = Console.ReadLine();
    }
}