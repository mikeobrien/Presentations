module PartialApplication

    // This is curried out of the box, no need to to anything special
    let add x y = x + y

    // Lets create a funtion that increments, that is based on the add function
    // We partially apply it by specifying the first parameter as 1
    let increment = add 1

    // Using mutable state for demo purposes. Normally you wouldnt do this.
    let mutable index = 0

    index <- increment index // index = 1
    index <- increment index // index = 2
    index <- increment index // index = 3
