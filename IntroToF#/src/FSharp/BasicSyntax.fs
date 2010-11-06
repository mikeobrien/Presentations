module BasicSyntax 

    // This is a single line comment

    (*
        This is a multi line comment
    *)

    // <-- The "light" syntax uses indentation to define code blocks (Instead of explict keywords)

    // Binding a value to a name
    let x = 10

    // This is a tuple, it is represented as "(int * int)"
    let point = (5, 2)

    // This is a function, parameters are seperated by spaces
    let add x y = x + y

    // Spaces seperate parameters when calling it
    let result = add 10 5

    // Ah! But you can also pass a tuple with the paramers instead. Confusing eh? Looks like a C# function definition. But "(x, y)" is actually a tuple.
    let add2(x, y) = x + y

    // You can put a space between the function name and the tuple to make ths more clear.
    let add3 (x, y) = x + y

    // When you call it you can pass a tuple
    let result2 = add2(10, 5)

    // And you can add a space after the funtion name to make it more clear
    let result3 = add2 (10, 5)

    // You cant pass space seperated parameters into a function that expects a tuple
    let result4 = add2 10 5

    // Nor you can pass a tuple into a function with space seperated parameters
    let result5 = add (10, 5)

    // This does not apply to non F# functions. This is not a tuple: "("Hello {0}!", "Tony Clifton")"
    let result6 = System.String.Format("Hello {0}!", "Tony Clifton")


    (*
        Interestingly the tupled and non tupled form compile to the same thing 
        save the attribute on the non tupled form. Don Syme 

        [CompilationArgumentCounts(new int[] { 1, 1, 1 })]
        public static int add(int x, int y, int z)
        {
            return ((x + y) + z);
        }

        public static int add2(int x, int y, int z)
        {
            return ((x + y) + z);
        }
    *)
