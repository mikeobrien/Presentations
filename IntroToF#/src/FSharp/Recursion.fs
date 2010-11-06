module Recursion

    // The imperative version
    let imperativeFactorial x = 
        let mutable acc = 1
        for i = x downto 1 do acc <- acc * i
        acc

    // The "rec" keyword explicitely marks a function as recursive
    let rec factorial acc x =
        if x = 0 then acc
        else factorial (acc * x) (x - 1)
    // ------^ This is the last call, there for the "tail call"

    let result = factorial 1 10

    // The factorial function gets compiled into this (Represented in C#)
    // This is the compiler optimization that ensures we dont have a stack 
    // overflow; IE simply turning it into a while loop.

    //    public static int factorial(int a, int x)
    //    {
    //        while (x != 0)
    //        {
    //            x--;
    //            a *= x;
    //        }
    //        return a;
    //    }

    // Ah! We dont have to loop to sum!
    let rec sum acc l = 
        if List.Empty = l then acc
        else sum (acc + (List.head l)) (List.tail l)

    let total2 = sum 0 [22; 6; 98; 11]