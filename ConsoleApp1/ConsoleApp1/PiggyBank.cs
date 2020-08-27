using System;
using System.Runtime.CompilerServices;

public delegate void EventListner(int value);

public class PiggyBank
{
	int currBalance;
	public event EventListner currBalanceUpdate;

	public PiggyBank()
	{
		currBalance = 0;
	}

	public void deposit(int val) {
		currBalance += val;
		currBalanceUpdate(currBalance);

	}

	public void withdraw(int val) {
		currBalance -= val;
	}


}

class balanceLogger {
	public void printBalance(int val)
	{
		Console.WriteLine("Current balance: " + val.ToString());
	}
}

class balanceWatcher
{ 
	public void printBalance(int val)
	{
		if (val > 500)
		{
			Console.WriteLine("You reached savings goal! Current balance: " +
				val.ToString()
				);
		}
		
	}
}
