open System

//* Function
let hello() =
    //? Display Message (prompt)
    printf "Enter your name: "

    //? Take string input
    let name = Console.ReadLine()

    //? Display formatted message
    printfn "Hello, %s!" name

    (*
    %i - Integer
    %f - Float
    %b - 
    %s - String
    .*)

//* Function - call
hello()

Console.ReadKey |> ignore   //! Hold Console Screen
