using System;
using System.Text.Json.Serialization;

public class BankTransferConfig
{
	public Config config;

	private const string filePath = "bank_transfer_config.json"

    public void BankTransferConfig()
	{
		try
		{
			ReadConfigFile();
		}catch (Exception ex)
		{
			Console.WriteLine("Error reading config file: " + ex.Message);
			setDefault();
			WriteConfigFile();
        }
    }
	
	public void ReadConfigFile()
	{
		string json = File.ReadAllText(filePath);
		config = JsonSerializer.DeserializeObject<Config>(json);
    }
	
	public void WriteConfigFile()
	{
		JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
		string json = JsonSerializer.Serialize(config, options);
		File.WriteAllText(filePath, json);
    }

	public void setDefault()
	{
		config = new Config
		config.lang = "en";
		config.transfer = new Transfer;
		config.transfer.threshld = 25000000;
		config.transfer.low_fee = 6500;
		config.transfer.high_fee = 15000;
		config.methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
		config.confirmation = new Confirmation;
		config.confirmation.en = "yes";
		config.confirmation.id = "ya";
    }
}
