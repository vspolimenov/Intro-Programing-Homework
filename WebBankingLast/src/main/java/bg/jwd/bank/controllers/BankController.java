package bg.jwd.bank.controllers;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import bg.jwd.bank.HomeController;
import bg.jwd.bank.entities.BankAmount;
import bg.jwd.bank.entities.UserAccount;

@Controller
public class BankController {

	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@Autowired()
	UserAccount userAccount;
	
	@Autowired
	BankAmount bankAmount;
	
	@RequestMapping(value ="/home", method = RequestMethod.GET)
	public String acountInfo() {
		return "home";
	}
	
	@RequestMapping(value ="/Registration", method = RequestMethod.GET)
	public String registration() {
		return "Registration";
	}
	
	@RequestMapping(value ="/LoginSave", method = RequestMethod.GET)
	public String addAcountSave(Model model, @ModelAttribute(value = "SpringWeb") UserAccount userAccount) {
		

		if("deposit".equals(userAccount.getOperations())){
			if(userAccount.getAmountToChange() < userAccount.getCurrentAmount()) {
			userAccount.Deposit();
			bankAmount.addInBank(userAccount.getAmountToChange());
			}
			
			else {
				logger.info("YOU DO NOT HAVE ENOUGHT MONEY");
			}
			
		}
		
		if("withdraw".equals(userAccount.getOperations())){
			if(userAccount.getAmountToChange() < bankAmount.getAmount()) {
				userAccount.Withdraw();
		
				bankAmount.getFromBank(userAccount.getAmountToChange());
				}
			
				else {
					logger.info("NOT ENOUGHT MONEY IN BANK");
				}
			
		}
		
		model.addAttribute("userAccount", userAccount);
		model.addAttribute("bankAmount", bankAmount);
		return "home";
	}
		
	@RequestMapping(value ="/RegistrationSave", method = RequestMethod.GET)
	public String registrationSave(Model model, @ModelAttribute(value = "SpringWeb") UserAccount userAccount) {
		

		if("deposit".equals(userAccount.getOperations())){
			if(userAccount.getAmountToChange() < userAccount.getCurrentAmount()) {
			userAccount.Deposit();
			bankAmount.addInBank(userAccount.getAmountToChange());
			}
			
			else {
				logger.info("YOU DO NOT HAVE ENOUGHT MONEY");
			}
			
		}
		
		if("withdraw".equals(userAccount.getOperations())){
			if(userAccount.getAmountToChange() < bankAmount.getAmount()) {
				userAccount.Withdraw();
		
				bankAmount.getFromBank(userAccount.getAmountToChange());
				}
			
				else {
					logger.info("NOT ENOUGHT MONEY IN BANK");
				}
			
		}
		
		model.addAttribute("userAccount", userAccount);
		model.addAttribute("bankAmount", bankAmount);
		return "home";
	}
		
}
