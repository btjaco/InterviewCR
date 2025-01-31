using InterviewCR.Enums;
using InterviewCR.Models;
using InterviewCR.Rules;
using NRules;
using NRules.Fluent;
using System;

namespace InterviewCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem fries = new MenuItem("Fries", DietaryRestrictions.HALAL, 1.50m);
            MenuItem burger = new MenuItem("Hamburger", DietaryRestrictions.VEGAN, 3.50m);
            MenuItem soda = new MenuItem("Diet Coke", DietaryRestrictions.NONE, .99m);
            MenuItem iceCream = new MenuItem("Chocolate Ice Cream", DietaryRestrictions.GLUTEN_FREE, 1.50m);
            Combo burgerCombo = new Combo(fries, burger, soda);

            Customer fred = new Customer("Fred", DietaryRestrictions.HALAL);
            fred.OrderFood(iceCream, burgerCombo);

            Customer joy = new Customer("Joy", DietaryRestrictions.VEGAN);
            joy.OrderFood(iceCream);

            Customer bobby = new Customer("Bobby", DietaryRestrictions.NONE);
            bobby.OrderFood(burgerCombo, iceCream, burger, soda);

            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(OrderValidationRule).Assembly));

            var factory = repository.Compile();
            var session = factory.CreateSession();

            session.Insert(fred);
            session.Insert(joy);
            session.Insert(bobby);

            session.Fire();

            Console.ReadLine();
        }
    }
}
