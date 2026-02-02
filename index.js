// // Variables.
// let x = 123;
// console.log("The value of X is ", x);
// console.log(typeof x);
// y = 124.4
// console.log(typeof y)
// let name = 'Vishnu';
// console.log(typeof name);
// console.log(`The type of x is ${typeof x}`);
// let online = true;
// console.log(`The status is ${online}`);

// // Arithmetic operators
// /* 
// The arithmetic operators are +, -, /, *, **, and %
// */ 
// // console.log(++x);
// y++
// console.log(y)

// // input from user by using window.prompt
// let username = window.prompt("What is your username?");
// console.log(`musername`);
// input form user by using html element
// let username;
// document.getElementById("submit").onclick = function(){
//     username = document.getElementById("text").value;
//     document.getElementById("h1text").innerText = `Welcome ${username}`;
// };


// Type conversion
// let age
// age = window.prompt("Enter your age: ");
// age = age + 10; 
// console.log("Your age after 10 years will be ", age);
// Here the variable age has string type value. 
// When add 10 to the age the string treated as string and it is concatenated to given input.

//Know wenahve to convert string to number
// age = Number(age);
// age = age + 10;
// console.log("Your age after 10 years will be ", age);
// console.log(typeof age);

// age = String(age);
// console.log(typeof age);


// let X = "summer time"
// let y = "summer time"
// let z = "summer time"

// X = Boolean(X)
// y = Boolean(y)
// z = Boolean(z)
// console.log(X, typeof X)
// console.log(y, typeof y)
// console.log(z, typeof z)        

// Constant Variables
// const pi = 3.14;
// document.getElementById("submit").onclick = function(){
//     radius = document.getElementById("text").value;
//     let area = pi * radius * radius;
//     document.getElementById("result").innerText   = `Area of circle is ${area}`;
// }
let count = 0;
 
document.getElementById("submit").onclick = function(){
    sum =  document.getElementById("text").value;
    if (sum === ""){
        count++;

    }else if (sum !== ""){
        count = count + Number(sum);
    }
    document.getElementById("result").innerText = count;
}