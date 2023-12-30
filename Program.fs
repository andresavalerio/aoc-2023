namespace AdventOfCode2023

open System

module D1Trebuchet =
    let inp = 
        "1abc2\n\
        pqr3stu8vwx\n\
        a1b2c3d4e5f\n\
        treb7uchet"

    let getCalibration (s: string): int =
        let predicate = fun (x: char) -> Char.IsDigit x

        let chars = s.ToCharArray()

        let first = 
            Array.find predicate chars
            |> Char.ToString

        let last =
            Array.find predicate (chars |> Array.rev)
            |> Char.ToString
        
        first + last 
        |> int

    let total = 
        inp.Split("\n")
        |> Seq.map getCalibration
        |> Seq.sum

    printfn "%A" total