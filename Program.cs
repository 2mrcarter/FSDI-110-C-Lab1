using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Test();
        }

        void Test(){
        Console.WriteLine("Hello World!");

        string name = "Joel";
        string lastName = "Carter";
        int age = 33;
        float average = 3.422f;
        decimal total = 1232.212m;
        bool found = false;
      //  char letter = "f";
      //  int positives = 123;
      //  double largeNumber = 123464512235;

   

            for( int i = 0; i < 10 ; i++ ){
                Console.WriteLine(i);
        
                if(i == 5) {
                Console.WriteLine("It's a five!!");
                }
            }
            string message = SayHello(name, "Carter", age);
            Console.WriteLine(message);

            ListTest();
        }   

        string SayHello(string name, String lastName, int age){
            if( age < 12){
            //return "Hello " + name;
            return $"Hello {name}";
            // return string.Concat("Hello", name);
            }
            // here
            return "w'sup everybody";
        }

        void ListTest(){

           // int[] ages = new int[5];
            List<int> listOfAges = new List<int>();
            listOfAges.Add(10);
            listOfAges.Add(20);
            listOfAges.Add(30);
            listOfAges.Add(40);
            listOfAges.Add(80);
            listOfAges.Add(-47);
            listOfAges.Add(97);
            listOfAges.Add(8);
            listOfAges.Add(97);
        
        //  vars

            var sum = 0;
            var smallest = listOfAges[0];
            var largest = listOfAges[0];
            var evens = 0;

                for(var i = 0; i < listOfAges.Count; i++){

                    //logic

                    var age = listOfAges[i];
                    sum += age;

                    if(age < smallest){
                        smallest = age;
                    }

                    if(age > largest){
                        age = largest;
                    }

                    if(age % 2 == 0){
                        evens += 1;

                    }

                };
            


            
            // print
            /*
                1 -> the sum of all the numbers
                2 -> the smallest number in the list
                3 -> the biggest number in the list
                4 -> the average of all number
                5 -> Count the even numbers in the list
                // % 2 == 0
            */  
            System.Console.WriteLine("Sum: " + sum);
            System.Console.WriteLine("Average: " + (sum / listOfAges.Count));
            System.Console.WriteLine("The min: " + smallest);
            System.Console.WriteLine("The max: " + largest);
            System.Console.WriteLine("There are " + evens + "even numbers.");
            
 
             
        }
    }
}
