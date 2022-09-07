function message (){
console.log('Hey there Tiger');
}

// message();

// alert('I see you Mr. Jenkins');
// confirm('tag your it.');
// let ret = prompt ('Tag me?', 'Tag');

// console.log(`You answered ${ret}`);

// below is very similar to the using() statement in c# to instruct garbage collecter
{
    // let var1 = 5; //this block scopes the variable so it can't be used outside the curly brackets
    var var2 = 6; //whereas a var with var (dated version) can be used outside the block scope
}

// console.log(var1); //can't be used
console.log(var2); //can be used

//JS doesnt have int, bool, string, etc as declaring keywords.
//Js has WEAK TYPING
//C# variable can't be changed after declaring
//JS variables can each time it's declared


//const is the JS version of readonly
const MYCONST = 'Who ya gonna call?...'
console.log(MYCONST);
// MYCONST = 'Ghostbusters!'//won't print

const MYCONST1 = MYCONST + 'Ghostbusters!'
console.log(MYCONST1);

//operands and operators
let five = 5, four = 4;
console.log(five - four);
console.log(five + four);
console.log(five ** four);
console.log(five % four);
console.log(five / four);
console.log(five * four);
console.log(Math.pow(five, four));

// 3 '='s is a strict equality.
five = 5;
console.log(five === 5); //this prints true becuase it is exact in match. Otherwise it would be false


//truthy and falsey. If you are evaluating a 'nothingburger' you get true
// falsey = false, "", 0, NaN, null, undefined
//Everything else is Truthy
if (null){
    console.log('WHAT?!?! an empty string?');
}
else {
    console.log('As expected an empty string evaluates to false.');
}

console.log();

//conversion

let five1 = String(five);
let five3 = Boolean(five1);
console.log(five3);

//JSON in JavaScript
// create an object
let jason = {
    name: "Mike Hatake",
    age: 43,
    height: "6'1\""
};
let jasonStr = JSON.stringify(jason);// converts to string
console.log(jasonStr);
let jasonStr1 = JSON.parse(jasonStr);// converts to it orginal object
console.log(jasonStr1);

console.log(jasonStr1.name, jasonStr1.age, jasonStr1.height + '\n');

jason.weight = 120;
console.log(jason);

function func1 (param1, param2) {
    alert (`There's a ${param1} function ${param2}ing here!`);
}
func1(); //invoke the fucntion with '()'
func1('dang', 'funct');

let func2 = func1;
func2();
console.log(func2());

function func3 (param1, param2) {
    return `There's a ${param1} function ${param2}ing here!`;
}
console.log(func3('short', 'rollerblad'));

//function expression
let func4 = function(param1){
    return ++param1;
}
console.log(func4(5));

//arrow expression

let func7 = () => 'congrats. you called a 0 parameter function.';//arrow func with mult params
let func5 = param1 => ++param1;//arrow func with 1 param
let func6 = (p1, p2) => ++p1+p2;//arrow func with mult params
let ret5 = func5(5);
console.log(ret5);

let func8 = p1 => {
    let myVar = `${p1} is `;
    let myVar1 = 'spartaaaaaa!';
    return myVar + myVar1;
}

console.log(func8('Revature'));

//nested function

function closure(myNested){
    return () => ++myNested;
}

let closure1 = closure(40);
console.log(`${closure1()} is how old my dog is.`);
console.log(`${closure1()} is how old my dog is.`);
console.log(`${closure1()} is how old my dog is.`);
console.log(`${closure1()} is how old my dog is.`);
console.log(`${closure1()} is how old my dog is.`);
console.log(`${closure1()} is how old my dog is.`);


