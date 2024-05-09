# Technical Test IRIS
Please use C# to complete these tasks, they can be done in any IDE. Take all the time
you need and come with the implementation for the problems before our interview.

# Problem 1: Check for Balanced Brackets in an expression
Given an expression string exp, write a program to examine whether the pairs and
the orders of “{“, “}”, “(“, “)”, “[“, “]” are correct in the given expression.

Example:
Input: exp = “[()]{}{[()()]()}” 
Output: Balanced
Explanation: all the brackets are well-formed
Input: exp = “[(])” 
Output: Not Balanced 
Explanation: 1 and 4 brackets are not balanced because 
there is a closing ‘]’ before the closing ‘(‘
# Problem 2: Single Number
Given a non-empty array of integers nums, every element appears twice except for one.
Find that single one.

Example 1:
Input: nums = [2,2,1]
Output: 1
Example 2:
Input: nums = [4,1,2,1,2]
Output: 4
Example 3:
Input: nums = [1]
Output: 1