# Setup: 
1. Clone the repo
2. Create a new class in the "Answers" directory with the name "YourNameAns.cs"
3. Inherit from the Interface IAnswer and implement its members

## Challenge 1: 

In the "Part1" function

Ask the user for 2 numbers

Print a box on the screen with the dimensions X by Y corresponding to the numbers the user entered

Once this is complete then continue to part 2

### Example Input:

User enters 3 and 5

### Output:

    XXX
    X X
    X X
    X X
    XXX

## Challenge 2:

In the "Part2" function

In the root of the repo there is a text file name "Part2Input.txt". Read it into the program and print out the boxes with sizes corresponding with the given XY values. And with the boxes being composed of the given character from the input with the  format of 
```
<X>:<Y>:<Character>
```

(Hint: you will have to remember to tell msbuild to copy the file to the output directory)

### Example File Input:

    3:2:A
    7:4:X
    1:7:R

### Output:

    AAA
    AAA

    XXXXXXX
    X     X
    X     X
    XXXXXXX

    R
    R
    R
    R
    R
    R
    R
