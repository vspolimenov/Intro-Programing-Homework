package bg.jwd.bank.entities;

import org.springframework.stereotype.Service;

@Service
public class UserAccount {

	private String name;
	private double currentAmount;
	private double amountToChange;
	private String operations;
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name; 
		
	}
	
	public void setCurrentAmount(double amount) {
		this.currentAmount = amount;
	}
	
	public double getCurrentAmount() {
		return currentAmount;
	}
	
	public double getAmountToChange() {
		return amountToChange;
	}
	
	public void setAmountToChange(double amount) {
		this.amountToChange = amount;
	}
	
	
	public void Deposit() {
		this.currentAmount =this.currentAmount - this.amountToChange;
		System.out.println("depositing " + amountToChange);
	}

	public void Withdraw() {
		currentAmount += amountToChange;
	}

	public String getOperations() {
		return operations;
	}

	public void setOperations(String operations) {
		this.operations = operations;
	}


}
