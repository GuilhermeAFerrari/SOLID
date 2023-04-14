using LSP.Payments;

//CreditCard card = new CreditCard();
//DebitCard card = new DebitCard();
NubankRewards card = new NubankRewards();

card.Validate();
card.CollectPayment();

Console.ReadLine();