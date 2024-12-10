open System
open System.Diagnostics
open System.IO

let readLists () =
    let first = ResizeArray<int>()
    let second = ResizeArray<int>()
    let lines = File.ReadAllLines("input1.txt")
    for line in lines do
        let parts = line.Split([| ' ' |], StringSplitOptions.RemoveEmptyEntries)
        if parts.Length > 0 then
            first.Add(int parts.[0])
        if parts.Length > 1 then
            second.Add(int parts.[1])
    (first, second)

let computeTask1 () =
    let (first, second) = readLists()
    first.Sort()
    second.Sort()
    let mutable result = 0
    for i in 0 .. first.Count - 1 do
        result <- result + Math.Abs(first.[i] - second.[i])
    result

let computeTask2 () =
    let (first, second) = readLists()
    let mutable result = 0
    for i in 0 .. first.Count - 1 do
        result <- result + first.[i] * (second |> Seq.filter (fun x -> x = first.[i]) |> Seq.length)
    result

[<EntryPoint>]
let main argv =
    let timer = Stopwatch()
    timer.Start()
    let task1Result = computeTask1()
    timer.Stop()
    printfn "Task 1: Time elapsed: %d ms. Result is %d." timer.ElapsedMilliseconds task1Result
    timer.Reset()
    timer.Start()
    let task2Result = computeTask2()
    timer.Stop()
    printfn "Task 2: Time elapsed: %d ms. Result is %d" timer.ElapsedMilliseconds task2Result
    timer.Reset()
    Console.ReadKey() |> ignore
    0
