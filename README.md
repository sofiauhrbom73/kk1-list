# MAI26MA-C#-KK1-SHOPPING-LIST

This assignment verifies that you can write simpler C# programs that test syntax, logic, methods, and object-oriented principles — everything we have covered so far in the course. The focus is on your ability to solve small problems independently, manage data in arrays and lists, and model using your own classes and objects.

## Part A — The Shopping List (lists)

Write a console program that keeps track of a shopping list containing the name and price of each item. Since we are not using objects in this part, you will manage the data using two parallel lists:

* names `List<string>` for the name of the product
* prices `List<int>` for the price of the product

where matching indexes belong together (`names[i]` costs `prices[i]`).

The program should continuously display the shopping list as a numbered list along with the total sum, for example:

1. Milk - 15 kr

2. Bread - 32 kr

3. Cheese - 89 kr

Total: 136 kr

### User input

An item: Enter an item name `(text)`. The program will then ask for the price `(an integer)` and add the item to the end of the list. If the user enters something that is not an integer for the price, the item should not be added.

A number: The item at that specific position is removed from the list *(both name and price)*. If the user enters a number that does not exist in the list, the program should display an error message instead of crashing.

Extra *(optional, does not affect your grade)*:

* The word "dyrast" *(most expensive)* prints out which item is the most expensive.

* Sort the list by price.
