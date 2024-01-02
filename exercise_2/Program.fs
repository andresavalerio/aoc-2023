namespace AdventOfCode2023

open System

module D2CubeConundrum =
    let inp =
        "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\n\
        Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\n\
        Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\n\
        Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\n\
        Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
    
    let red_cubes = 12
    let green_cubes = 13
    let blue_cubes = 14

    let splitGames (s: string) = s.Split("\n")

    let splitId (s: string) = s.Split(":")

    let splitRounds (s: string) = s.Split(";")

    let splitCubes (s: string) = s.Split(",")

    let validateGame (game: string): int =
        let x = splitId game
        let id = x[0].Split(" ")[1] |> int
        let gameRounds = splitRounds x[1]

        let cubes = Array.map splitCubes gameRounds

        0
    
    splitGames inp
    |> Array.map validateGame
    |> ignore