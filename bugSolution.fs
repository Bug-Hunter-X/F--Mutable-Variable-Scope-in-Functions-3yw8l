let mutable x = 10
let mutable y = 20

let add x y = 
    let mutable sum = x + y
    x <- x + 10 //modify x here
    y <- y + 10 //modify y here
    sum

let z = add x y
printf "%d\n" z

printf "%d %d\n" x y

//Here we see the values are updated because the function modifies them directly
let z2 = add x y
printf "%d\n" z2