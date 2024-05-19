#!/usr/bin/env python3

# display a welcome message
print("Welcome to Delaney Wozniak's Future Value Calculator")
print()

# this while loop will run until the user types something aside from "y"
choice = "y"
while choice.lower() == "y":
    is_valid = True # create the input validation condition check

    # while loop will check if the monthly_investment value is valid
    while is_valid == True:
        # retreive the user's inout for the monthly investment
        monthly_investment = float(input("Enter monthly investment:\t"))
        # validate the user's input to check if the value is . 0 or <= 1000
        if monthly_investment > 0 and monthly_investment <= 1000:
            is_valid = False
        # tell the user to try again since the value provided was invalid
        else:
            print("Please enter a value greater than 0 and less than or equal to 1000",
                    "Please try again.")

    is_valid = True # reste the input validation check
    # while loop to check the yearly interest rate
    while is_valid== True:
        # retreive the user's input for yearly interest rate
        yearly_interest_rate = float(input("Enter yearly interest rate:\t"))
        # validate the user's input, should be between 0 and 15
        if yearly_interest_rate > 0 and yearly_interest_rate <= 15:
            is_valid = False
        # ask the user to enter another value
        else:
            print("Please enter a vlaue greater than 0 and less than or equal to 15",
                    "Please try again.")

    is_valid = True #reset the input validation check
    # while loop to check if the user's input is valid
    while is_valid == True:
        # retreive the years fromt he user's input
        years = int(input("Enter number of years:\t\t"))
        # check if the years is between 0 and 50
        if years > 0 and years <= 50:
            is_valid = False
        # tell the user to enter another value
        else:
            print("Please enter a value greater than 0 and less than or equal to 50",
                    "Please try again.")

    print() # add a blank line

    # convert yearly values to monthly values
    monthly_interest_rate = yearly_interest_rate / 12 / 100
    months = years * 12

    # create variable for future value
    future_value = 0
    # for loop to calculate future value and display results
    for i in range(1, months + 1):
        # calculate the future value
        future_value += monthly_investment
        monthly_interest_amount = future_value * monthly_interest_rate
        future_value += monthly_interest_amount
        # display the year and the associated future values
        if i % 12 == 0:
            print("Year = ", i // 12, "\tFuture Value = ", round(future_value, 2))
    print()

    # see if the user wants to continue
    choice = input("Continue (y/n)? ")
    print()

print("Bye!")
