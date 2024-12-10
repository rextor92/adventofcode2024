open System
open System.Collections.Generic
open System.Diagnostics
open System.IO

type TwoLists = {
    First: List<int>
    Second: List<int>
}

let readLists () =
    let twoLists = { First = List<int>(); Second = List<int>() }
    let lines = File.ReadAllLines("input1.txt")
    for line in lines do
        let parts = line.Split([| ' ' |], StringSplitOptions.RemoveEmptyEntries)
        if parts.Length > 0 then
            twoLists.First.Add(int parts.[0])
        if parts.Length > 1 then
            twoLists.Second.Add(int parts.[1])
    twoLists

let computeTask1 () =
    let lists = readLists()
    lists.First.Sort()
    lists.Second.Sort()
    let mutable result = 0
    for i in 0 .. lists.First.Count - 1 do
        result <- result + Math.Abs(lists.First.[i] - lists.Second.[i])
    result

let computeTask2 () =
    let lists = readLists()
    let secondCounts = Dictionary<int, int>()
    for number in lists.Second do
        if secondCounts.ContainsKey(number) then
            secondCounts.[number] <- secondCounts.[number] + 1
        else
            secondCounts.[number] <- 1
    let mutable result = 0
    for number in lists.First do
        match secondCounts.TryGetValue(number) with
        | true, count -> result <- result + (number * count)
        | _ -> ()
    result

[<EntryPoint>]
let main args =
    if args.Length = 0 then
        printfn "Please provide a task number (1 or 2) as a command-line argument."
        0
    else
        let timer = Stopwatch()
        match Int32.TryParse(args.[0]) with
        | true, taskNumber when taskNumber = 1 || taskNumber = 2 ->
            if taskNumber = 1 then
                timer.Start()
                let task1Result = computeTask1()
                timer.Stop()
                printfn $"Task 1: Time elapsed: {timer.ElapsedMilliseconds} ms. Result is {task1Result}."
                timer.Reset()
            elif taskNumber = 2 then
                timer.Start()
                let task2Result = computeTask2()
                timer.Stop()
                printfn $"Task 2: Time elapsed: {timer.ElapsedMilliseconds} ms. Result is {task2Result}."
                timer.Reset()
            0
        | _ ->
            printfn "Invalid task number. Please provide 1 or 2 as a command-line argument."
            0
