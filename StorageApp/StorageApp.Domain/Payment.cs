namespace StorageApp.Domain;

public class Payment
{
    public int Id { get; set; }
    public String PaymentType { get; set; }

    public bool IsDefault { get; set; }
    public String BankName { get; set; }
    public String IBAN { get; set; }
    public String PayPal { get; set; }

    public String CreditCardNumber { get; set; }
}