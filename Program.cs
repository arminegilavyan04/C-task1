// list
List<int> mylist = new List<int>();
mylist.Add(124);
mylist.Add(222);
mylist.Add(738);
mylist.Add(894);
mylist.Add(316);
mylist.Add(547);
foreach (int number in mylist)
{

    string numberStr = number.ToString();

    int largestDigit = 0; 
    int smallestDigit = 9; 

    
    foreach (char digitChar in numberStr)
    {
        
        int digit = (int)char.GetNumericValue(digitChar);

        
        if (digit > largestDigit)
        {
            largestDigit = digit;
        }

        
        if (digit < smallestDigit)
        {
            smallestDigit = digit;
        }
    }

    
    Console.WriteLine($"Number: {number}, Largest digit: {largestDigit}, Smallest digit: {smallestDigit}");

}
//dictionary
Dictionary<string, int> myDictionary = new Dictionary<string, int>();


myDictionary.Add("protein", 10);
myDictionary.Add("creatin", 5);
myDictionary.Add("fiber", 8);
myDictionary.Add("carbon", 12);
myDictionary.Add("fat", 15);

//queue
Console.WriteLine("Dictionary consists of:");
foreach (var obj in myDictionary)
{
    Console.WriteLine($"{obj.Key}: {obj.Value}");
}

Queue<int> myQueue = new Queue<int>();


myQueue.Enqueue(10);
myQueue.Enqueue(27);
myQueue.Enqueue(30);
myQueue.Enqueue(48);
myQueue.Enqueue(51);


Console.WriteLine("Queue contents are:");
foreach (int item in myQueue)
{
    Console.WriteLine(item);
}
Console.WriteLine(myQueue.Dequeue());
Console.WriteLine(myQueue.Dequeue());
foreach (int item in myQueue)
{
    Console.WriteLine("The final queue will conatin "+item);
}

//stack
Stack<int> myStack = new Stack<int>();

myStack.Push(10);
myStack.Push(20);
myStack.Push(30);
myStack.Push(40);
myStack.Push(50);


Console.WriteLine("Stack contents:");
foreach (int item in myStack)
{
    Console.WriteLine(item);
}
Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.Pop());
foreach (int item in myStack)
{
    Console.WriteLine("The final queue will conatin "+item);
}

//array sum
int[] numbers = { 12, 25, 38, 41, 5, 68, 7, 18, 93, 70 };

int sum0 = 0;
int sum1 = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0) 
    {
        sum0 += number; 
    }
}

Console.WriteLine("Sum of even numbers: " + sum0);

foreach (int number in numbers)
{
sum1+= number;
}
sum1 /= 2;
Console.WriteLine("Average sum of all elements will be: " + sum1);

