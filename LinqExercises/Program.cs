using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // ---------------- SORTING METHODS -------------------------------


            var numbers = new List<int>() { 8, 23, 14, 67, 29 };

            var orderNumbers = numbers.OrderBy(num => num);
            Console.WriteLine("Order:", orderNumbers);

            var descendingOrderNumbers = numbers.OrderByDescending(num => num);

            // var reverseNumber = numbers.Reverse();
            // Cannot assign void to an implicitely typed variable => can't assign it to a variable bc
            // the return type of Reverse is void 

            numbers.Reverse();

            // ------------ AGGREGATE METHODS ------------------

            var maxNumbers = numbers.Max();

            var sumOfNumbers = numbers.Sum();

            var averageNumber = numbers.Average();

            var count = numbers.Count();


            // Where is a filtering method
            var biggerNumbers = numbers.Where(num => num > 9);

            var bigNumbers2 = numbers.Select(num => num * 2);

            var firstNumber = numbers.First();

            var lastNumber = numbers.Last();

            // First matching item 
            var firstMatchingNumber = numbers.Where(num => num > 9).First();
            var firstMatchingNumber2 = numbers.First(num => num > 9);

            // ------------ QUANTIFIER OPERATIONS ------------------------

            var allNumbers = numbers.All(c => c > 5);
            Console.WriteLine(allNumbers);

            var anyNumbers = numbers.Any(c => c > 5);
            Console.WriteLine(anyNumbers);

            var containsNumber = numbers.Contains(7) || numbers.Contains(3);
            Console.WriteLine(containsNumber);

            var goodNumbers = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };
            var badNumbers = new List<int>() { 19, 11, 3, 9, 11, 19};

            var onlyGoodNumbers = numbers.Except(badNumbers);
            Console.WriteLine($"onlyGoodNumbers { String.Join(',', onlyGoodNumbers)}");

            var uniqueNumbers = numbers.Distinct();
            Console.WriteLine($"uniqueNumbers { String.Join(',', uniqueNumbers)}");


            // Skip will skip until the place in the sequence, not the index!
            var firstThreeNumsAndTheSixth = numbers.Take(3).Concat(numbers.Skip(5).Take(1));
            Console.WriteLine($" first 3 + 6 { String.Join(',', firstThreeNumsAndTheSixth )}");

            var animals = new List<Animal> {
                new Animal {Type = "Pikachu", HeightInInches = 24, WeightInPounds = 10},
                new Animal {Type = "Chazard", HeightInInches = 72, WeightInPounds = 250},
                new Animal {Type = "Bulbasaur", HeightInInches = 12, WeightInPounds = 250},
                new Animal {Type = "JigglyPuff", HeightInInches = 9, WeightInPounds = 5}
            };

            var animalsThatStartWithC = animals.Where(animal => animal.Type.StartsWith('C'));


            // Grouping collection by a given key 
            var groupAnimals = animals.GroupBy(animal => animal.Type.First());

            foreach (var animalGroup in groupAnimals)
            {
                Console.WriteLine($"Amimals that start with {animalGroup.Key}");

                foreach (var animal in animalGroup)
                {
                    Console.WriteLine(animal.Type);
                }
            }

            




        }
    }
}
