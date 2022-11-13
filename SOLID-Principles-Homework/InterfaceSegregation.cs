// BEFORE 
/*interface IHuman
{
	void Eat();
	void Talk();
	void Walk();
	void Sleep();
	void Run();
}

class Human : IHuman
{
	public void Eat()
	{
		throw new NotImplementedException();
	}

	public void Run()
	{
		throw new NotImplementedException();
	}

	public void Sleep()
	{
		throw new NotImplementedException();
	}

	public void Talk()
	{
		throw new NotImplementedException();
	}

	public void Walk()
	{
		throw new NotImplementedException();
	}
}

class FoodBank
{
	// I don't need just humans. The FOOD BANK may provide food to animals too.
	public void AddToList(IHuman human)
	{
		throw new NotImplementedException();
	}

	// This does not look right!
	public void AddToList(IAnimal animal)
	{
		throw new NotImplementedException();
	}
}

interface IAnimal
{
	void Eat();
	void Bark();
	void Walk();
	void Sleep();
	void Run();
	void Bite();
}*/


// AFTER
interface IOmnivore
{
	void Eat();
}

interface IHuman : IOmnivore
{
	void Talk();
	void Walk();
	void Sleep();
	void Run();
}

interface IAnimal : IOmnivore
{
	void Bark();
	void Walk();
	void Sleep();
	void Run();
	void Bite();
}

class FoodBank
{
	public void AddToList(IOmnivore omnivore)
	{
		throw new NotImplementedException();
	}
}