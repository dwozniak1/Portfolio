#!/usr/bin/env python3
#Name: (Delaney Wozniak)
#Class: (INFO 1200)
#Section: X01
#Professor: (Bartholomew)
#Date: 11/8/2022
#Project #: Participation 9
#I declare that the source code contained in this assignment was written solely by me.
#I understand that copying any source code, in whole or in part, 
#constitutes cheating, and that I will receive a zero on this project
#if I am found in violation of this policy.

def display_welcome():
    print("The Test Scores program")
    print("Enter 'x' to exit")
    print("")

def get_scores():
    # create new list variable to hold scores
    scores = []
    while True:
        score = input("Enter test score: ")
        if score == "x":
            # return the scores list
            return  scores
        else:
            score = int(score)
            if score >= 0 and score <= 100:
                # add a new score to the list
                scores.append(score)
            else:
                print("Test score must be from 0 through 100. " +
                      "Score discarded. Try again.")

def process_scores(scores):
    # sort the scores
    scores.sort()

    # calculate total scores
    total = 0
    for score in scores:
        total += score
    
    # find the number of scores
    num_scores = len(scores)

    # calculate average score
    average = total/num_scores

    # find the low score
    low_score = min(scores)

    # find the high score
    high_score = max(scores)

    # median variable
    median = 0
    # find the median score
    median_index = num_scores // 2
    # check if the number of items in the list is odd
    if num_scores % 2 == 1:
        median = scores[median_index]
    # calculate the median for an even number of items in the list
    else:
        middle_1 = scores[median_index]
        middle_2 = scores[median_index-1]
        median = (middle_1 + middle_2) / 2
    
                
    # format and display the result
    print()
    print("Score total:       ", total)
    print("Number of Scores:  ", num_scores)
    print("Average Score:     ", average)
    print("Low Scores:        ", low_score)
    print("High Score:        ", high_score)
    print("Meidan:            ", median)


def main():
    display_welcome()
    # retrieve the list fro the get_scores() function
    scores = get_scores()
    # retrieve and display the values for the provided list
    process_scores(scores)
    print("")
    print("Bye!")

# if started as the main module, call the main function
if __name__ == "__main__":
    main()


