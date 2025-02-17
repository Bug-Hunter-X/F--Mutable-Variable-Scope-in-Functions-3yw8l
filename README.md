# F# Mutable Variable Scope in Functions
This example demonstrates a common misunderstanding in F# regarding the scope of mutable variables within functions.  In F#, functions are by default immutable; they don't modify their inputs. Even if the inputs are mutable variables, the function does not change the values of those variables outside its scope. 

The `bug.fs` file shows the incorrect behavior. The `bugSolution.fs` file provides the correct way to achieve mutable variable modification within the function.