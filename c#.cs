using System;

namespace Demo
{
    class HelloWorld
    {
	public static int sub(int a,int b){
		return a-b;
	}
	public static int product(int a,int b){
		return a*b;
	}
	public static int add(int a, int b){
		return a+b;
	}
        static void Main(string[] args){
            Console.WriteLine(add(10,20));
	Console.WriteLine(add(10,20));
            Console.ReadLine();
        }
        
    }
}