# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 

Theeranith Atchaklab 570611016
## Revision, put your commit number here
* Sort from larger to smaller:
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: compare 2 number if number of next indext less than previous indext ,then swap the number ,do the same next indext on and on until there are finished sort. 

2. What if two numbers equal, what will happen? 

Answer: 2 number are adjacent and next number are  still sort. 

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 times

4. Why we need flag variable ? 

Answer: when there are already sort we can go out  from while loop.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: faster because big(o) will changed from n^2 to be n, but ther can't sort finished.