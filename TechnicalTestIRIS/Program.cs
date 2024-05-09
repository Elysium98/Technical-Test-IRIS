static bool CheckBalanced(string exp)
{
    // Initialize a stack to keep track of opening parentheses
    Stack<char> stack = new Stack<char>();

    // Iterate through each character in the expression
    foreach (char c in exp)
    {
        // If the character is an opening parenthesis, push it onto the stack
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        // If the character is a closing parenthesis
        else if (c == ')' || c == ']' || c == '}')
        {
            // If there are no opening parentheses left to match
            if (stack.Count == 0)
            {
                return false; // The expression is unbalanced
            }

            // Pop the last opening parenthesis from the stack
            char lastOpening = stack.Pop();

            // Check if the current closing parenthesis matches the last opening parenthesis
            if ((c == ')' && lastOpening != '(') ||
                (c == ']' && lastOpening != '[') ||
                (c == '}' && lastOpening != '{'))
            {
                return false; // The parentheses do not match, so the expression is unbalanced
            }
        }
    }

    return stack.Count == 0; // If the stack is empty, the expression is balanced
}
static int SingleNumber(int[] nums)
{
    // Create a HashSet to store unique numbers
    HashSet<int> set = new HashSet<int>();

    // Iterate through each number in the array
    foreach (int num in nums)
    {
        // If the number is already in the HashSet, remove it
        // This means the number has occurred twice and is no longer unique
        if (set.Contains(num))
        {
            set.Remove(num);
        }
        // If the number is not in the HashSet, add it
        // This means the number is unique and has not occurred before
        else
        {
            set.Add(num);
        }
    }

    if (set.Count > 0)
    {
        return set.First();
    }
    else
    {
        // This indicates that no single number was found in the array
        throw new ArgumentException("No single number found.");
    }
}

int[] nums1 = { 2, 2, 1 };
int[] nums2 = { 4, 1, 2, 1, 2 };
int[] nums3 = { 1 };

int singleNumber1 = SingleNumber(nums1);
int singleNumber2 = SingleNumber(nums2);
int singleNumber3 = SingleNumber(nums3);

Console.WriteLine("The single number is: " + singleNumber1);
Console.WriteLine("The single number is: " + singleNumber2);
Console.WriteLine("The single number is: " + singleNumber3);

string exp1 = "[()]{}{[()()]()}";
string exp2 = "[(])";

Console.WriteLine("Expression 1 is " + (CheckBalanced(exp1) ? "Balanced" : "Not Balanced"));
Console.WriteLine("Expression 2 is " + (CheckBalanced(exp2) ? "Balanced" : "Not Balanced"));
