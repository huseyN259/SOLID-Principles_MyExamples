// BEFORE
/*enum PaymentType
{
	CreditCard = 10,
	Cash = 20,
	NewPaymentType = 30,
}

class PaymentModel
{
	public PaymentType PaymentType { get; set; }
}

class CreditCard
{
	public void Pay()
	{
		Console.WriteLine("Credit Card Pay...");
	}
}

class Cash
{
	public void Pay()
	{
		Console.WriteLine("Cash Pay...");
	}
}

class NewPaymentType
{
	public void Pay()
	{
		Console.WriteLine("New Payment Type Pay...");
	}
}

class PaymentProcessor
{
	public bool Pay(PaymentModel model)
	{
		switch (model.PaymentType)
		{
			case PaymentType.CreditCard:
				(new CreditCard()).Pay();
				break;
			case PaymentType.Cash:
				(new Cash()).Pay();
				break;
			case PaymentType.NewPaymentType:
				(new NewPaymentType()).Pay();
				break;
		}

		return true;
	}
}

class Controller
{
	public void PaymentView()
	{
		var paymentProcessor = new PaymentProcessor();
		var paymentModel = new PaymentModel();
		paymentModel.PaymentType = PaymentType.CreditCard;
		paymentProcessor.Pay(paymentModel);
	}
}*/


// AFTER
interface IPayment
{
	void Pay();
}

class CreditCard : IPayment
{
	public void Pay()
	{
		Console.WriteLine("Credit Card Pay...");
	}
}

class Cash : IPayment
{
	public void Pay()
	{
		Console.WriteLine("Cash Pay...");
	}
}

class NewPaymentType : IPayment
{
	public void Pay()
	{
		Console.WriteLine("New Payment Type Pay...");
	}
}

class PaymentModel
{
	public IPayment? PaymentType { get; set; }
}

class PaymentProcessor
{
	public bool Pay(PaymentModel model)
	{
		model?.PaymentType?.Pay();

		return true;
	}
}

class Controller
{
	public void PaymentView(/*Model*/)
	{
		var paymentProcessor = new PaymentProcessor();
		var paymentModel = new PaymentModel();
		paymentModel.PaymentType = new NewPaymentType();
		paymentProcessor.Pay(paymentModel);
	}
}