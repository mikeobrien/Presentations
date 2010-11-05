module Immutability

    // Type definition
    type Credentials = { Username : string; Password : string }

    // Value binding
    let someUser = { Username = "someuser"; Password = "$3cr3t" }

    // Sad trombone! 

    someUser.Username <- "soemthingelse"

    someUser <- { Username = "anotheruser"; Password = "$3cr3t" }
    
    let someUser = { Username = "anotheruser"; Password = "$3cr3t" }

    // "But I want to change it, waaaaah!" No problem, create a new one.

    let newUser = { someUser with Username = "anotheruser" }