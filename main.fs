module Assignment

// Problem 1
let rec prod (lst:int list) =
match lst with
| [] -> 1
| head :: tail -> head * product tail


// Problem 2
let rec map f (lst:int list) =
   match f with
      [] -> []
    | head::tail -> (f head)::(map f tail)

// Problem 3
let rec odd (lst:int list) =
match lst with
| [] -> []
| head :: tail ->
if head % 2 = 0 then
head :: odd tail


// Problem 4
let rec filter f lst =
match lst with
| [] -> []
| head :: tail ->
if f head then
head :: filter f tail
else
filter f tail