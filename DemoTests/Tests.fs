module Tests

open System
open Xunit

type MyResult = AResult of string | OtherResult of string

let someStringValidation s =
    if String.IsNullOrWhiteSpace(s) then None
    else
        if s.StartsWith("a") then AResult s |> Some
        else OtherResult s |> Some
        
let prompt () = Console.ReadLine()

let rec getUserInputRecursive () =
    match prompt () |> someStringValidation with
    | None -> getUserInputRecursive ()
    | Some x -> Some x

let getUserInput = getUserInputRecursive ()

(*
    Just a proxy test.
    Imagine a card game where the user can `hit` or `stand`...
*)
[<Fact>]
let ``User enters Space, then Tab, then letter, returns AResult abc`` () =
    let inputs = [" "; "    "; "abc"]
    // ???
    // result -> pattern match success -> content should equal "AResult abc" 
    Assert.True(true)