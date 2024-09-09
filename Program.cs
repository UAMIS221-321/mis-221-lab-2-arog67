//Variables

using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;

double numberOfSandwisches = 0;
double numberOfToppings = 0;
double tip = 0;

//Fixed Cost 
double COST_OF_SANDWICH = 4.75;
double Cost_OF_TOPPING = 0.55;
double DISCOUNT_AMOUNT = 0.10;

//get sandwhich number
System.Console.WriteLine("How many sandwiches are you buying");
numberOfSandwisches = double.Parse(Console.ReadLine());

//get topping number 
System.Console.WriteLine("How many toppings are on your sandwich?");
numberOfToppings = double.Parse(Console.ReadLine());

//get tip
System.Console.WriteLine("Would you like to leave a tip?");
tip = double.Parse(Console.ReadLine());

//math for order cost
double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwisches;
double totalToppingCost = Cost_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost= tip + baseCost * (1-DISCOUNT_AMOUNT);

System.Console.WriteLine("Your order cost is $"+orderCost);
