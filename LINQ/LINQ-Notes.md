Video: https://www.youtube.com/watch?v=OF7lzlfpMok
Trainer : Ivaylo Kenov

using System.Collections.Generic;

List<int> numbers = new List<int>();
	->order ellements the way they were added;

HashSet<int> numbersSet = new HashSet<int>();
	-> holds unique values only;
	-> does not have indexation;
	-> does NOT guarantee sorting of the values;

SortedSet<int> sortedNumbers = new SortedNumbers();
	-> automatically sorts;

Dictionary<key, value> dict = new Dictionary<key, value>();
	->holds a key and a value;

SortedDictionary<key, value> dict = new SortedDictionary<key, value>();
	->sorts by key

Lambda Expressions - a lambda expression is an anonymous function containing expressions and statenents
- uses operator '=>'. Reads as 'goes to'
- left side specifies the input parameters
- right side holds the expression or the statement
numbers.Where(n => n > 10)

Any - reaturns bool value for at least one occurance. 
Any - returns true if all elements are true according to the condition

var = texts
	.OrderBy(t => t)
	.Where(t => t[0] == 'P' && t[t.length -1] == 'p');

string[] result = texts
	.OrderBy(t => t)
	.Where(t => t[0] == 'P' && t[t.length -1] == 'p')
	.toArray();
Lists<string> result = texts
	.OrderBy(t => t)
	.Where(t => t[0] == 'P' && t[t.length -1] == 'p')
	.toList();

-= LINQ Operations =-
.Where()
- seraches by given codition

.First() / FirstOrDefault()
- gets the first matched element

.Last() / LastOrDefault()
- gets the last matched element

.Select() / Cast()
- makes projection (conversion) to anther type

.OrderBy() / ThenBy() / OrderByDescending()
- orders a collection

.Reverse() - reverses the collection
array.Reverse() -> for list elements only

var result = array.AsEnumerable().Reverse();
-> when using LINQ;

.Average()
var result = texts.Average(t => t.Lenght);

var result = numbers
	.Where(t => t > 10)
	.Average();

.Count(<conditon>)
- counts elemtns

.Max()
-returns max value

.Min()
-returns min value

.Sum()
-returns the sum of all elements


var dict = new Dictionary<string, int>();

dict["Gosho"] = 4;
dict["Pesho"] = 13;
dict["Tosho"] = 2;

var result = dict.Where (x => x.Value > 2);

foreach (var keyValuePair in result) 
{
	CW(keyValuePair.Value);
}

//Output: 4, 13

var result = dict.Where (x => x.Value != "Gosho")
		.OrderBy(x => x.Key)
		.Sum(x => x.Value); 