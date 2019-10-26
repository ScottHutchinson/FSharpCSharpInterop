namespace ICI.FSharpLibrary

module FMath =
    let inline Twice x = x + x

    let inline TwiceX (x: ^a) : ^a = x + x

    // Modifying an attribute of a DU case.
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
    //let fredEligible = RegisteredCustomer { fred with IsEligible = true }

    let sandra = Guest { Id = "Sandra" }

    // List of Discriminated Unions (DUs).
    let lst = [fred; sandra]
