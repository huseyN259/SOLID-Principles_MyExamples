namespace SOLID_Principles_Homework;

// BEFORE
/*interface IUser
{
	void Register(UserRegisterModel userRegisterModel);
	void Login(UserLoginModel userLoginModel);
	void Log(string message);
	void GetUserOrders(int userId);
	void GetAllOrders();
}*/


// AFTER
interface IUser
{
	void Register(string register);
	void Login(string login);
}

interface ILog
{
	void Log(string message);
}

interface IOrder
{
	void GetUserOrders(int userId);
	void GetAllOrders();
	void GetOrdersByDate(DateTime date);
}