open System
open Library

open System.IO

[<EntryPoint>]
let main argv =
    //#printfn
    printfn "hello"
    printfn "Nice command-line arguments! Here's what JSON.NET has to say about them:"

    //#let
    let testValue=0;

    //#function
    let sampleFunction1 x = x*x + 3

    let result1 = sampleFunction1 4573

    printfn "the res is:%d" result1

    let mutable otherNumber = 2

    otherNumber <- otherNumber + 1

    printfn "'otherNumber' changed to be %d" otherNumber

    let path = @"c:\temp\MyTest.txt";

    let isPathExist=File.Exists path
    printfn "isPathExist %b" isPathExist

    let sr = File.OpenText path
    let s=sr.ReadLine() 
    printfn "s: %s" s

    argv
    |> Array.map getJsonNetJson
    |> Array.iter (printfn "%s")

    0 // return an integer exit code