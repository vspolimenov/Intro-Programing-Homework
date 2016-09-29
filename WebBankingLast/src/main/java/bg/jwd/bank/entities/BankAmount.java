package bg.jwd.bank.entities;

import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Service;

@Service()
public  final class BankAmount {
	

	private double amount;
	
	
	public double getAmount() {
		return amount;
	}
	
	public void addInBank(double amount) {
	this.amount += amount;
		
	}
	
	public void getFromBank(double amount) {
		this.amount -= amount;
	}

}
