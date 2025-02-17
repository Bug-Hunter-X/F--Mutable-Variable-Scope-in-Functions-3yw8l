let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

x <- 100
y <- 200

printf "%d %d\n" x y

//This will print the original values of x and y because the add function is not modifying the values of x and y
let z2 = add x y
printf "%d\n" z2