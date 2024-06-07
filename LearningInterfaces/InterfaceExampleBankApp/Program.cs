using InterfaceExampleBankApp;

VakifbankBank vakifbankBank = new();

vakifbankBank.Amount = 50000;
vakifbankBank.Months = 12;
vakifbankBank.InterestRate = 2;

vakifbankBank.GetCredit();

Console.WriteLine(vakifbankBank.ConvertToCSV());