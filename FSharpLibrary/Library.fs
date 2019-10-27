namespace ICI.FSharpLibrary

module FMath =
    let inline Twice x = x + x

    let inline TwiceX (x: ^a) : ^a = x + x

    //[<CLIMutable>]
    type RegisteredCustomer = {
        Id: string
        IsEligible: bool
    }

    type UnregisteredCustomer = {
        Id: string
    }

    type Customer =
        | RegisteredCustomer of RegisteredCustomer
        | Guest of UnregisteredCustomer

    let fred = RegisteredCustomer { Id = "Fred"; IsEligible = false }
    let sandra = Guest { Id = "Sandra" }

    // List of Discriminated Unions (DUs).
    let CustomerList = [fred; sandra]

    // Modifying an attribute of a DU case.
    //let fredEligible = RegisteredCustomer { fred with IsEligible = true } <-- compile Error.
    // vvvv Warning: pattern match does not match all cases.
    //let fredEligible = let (RegisteredCustomer regFred) = fred in RegisteredCustomer { regFred with IsEligible = true }
