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


let m1 = {
    name1: 'Mike',
    age: 10,
    myDeets: function() {
        return `${this.name1} is ${this.age} is years oooold`
    }
}

console.log(m1.myDeets());

//class instantiation

let m3 = class m2 {
    constructor(name, age) {
        this.name1 = name,
        this.age = age
    }
}

let m4 =  new m3 ('Bibby', 73);
console.log(m4.age, m4.name1, m3.name);
let m5 = new m3('Arely', 40);
console.log(m5.age, m5.name1);

//Try Catch block, a Get Setter, and static class
class m6 {
    constructor(name = 'Default', age = 2) {
        this.name1 = name,
        this.age = age
    }
    get nameAndAge() {
        return `${this.name1} is ${this.age} is years oooold` 
    }

    set setAge(v){
        if (v > 100 | v < 1) { throw new RangeError(`That age, ${v} is invalid.`) }
        else {
            this.age = v;
        }
    }
    static staticName = 'Mac';

    static gimmeStatic(){
        return `Do you wanna get jammed up, ${this.staticName}?`
    }
}; //<== are these optional?

let m7 = new m6('Also Mikael', 30);
console.log(m7.nameAndAge);
m7.setAge = 25;
console.log(m7.nameAndAge);
// m7.setAge = 125
// console.log(m7.nameAndAge); //sets a valid throw error
console.log(m6.gimmeStatic());

let m8 = new m6();
console.log(m8.nameAndAge);

let m9 = new m6('Dave');
console.log(m9.name1, m9.age);

//Inheritence

class m6Inheriting extends m6 {
    constructor(myName, page, address = '123 Sesame St.'){
        super(myName, page);
        this.address = address;
    };
};

let n1 = new m6Inheriting('Larry', 37);
console.log(`My best friend ${n1.name1} is ${n1.age} years young and lives at ${n1.address}`);

const list = document.querySelector('.oli');
console.log(list.lastElementChild.textContent);
list.lastElementChild.classList.add('redBackground');


//group assignment
const xhr = new XMLHttpRequest();
console.log(`The readystate is ${xhr.readyState}`);
xhr.onreadystatechange = () => {
    if (xhr.readyState == 4 && xhr.status == 200) {
        displayJoke1InBroswer();
    }
    else {
        console.log('Jokes not ready yet.');
    }
}; 

xhr.open('GET', 'http://api.icndb.com/jokes/226', true);
xhr.send();

function displayJoke1InBroswer(){    

    console.log();
    //under the same 'div' write 5 'p' that each have their own joke
    let body1 = document.body
    let myDiv1 = document.createElement('div');
    let par1 = document.createElement('p');

    myDiv1.appendChild(par1);
    body1.appendChild(myDiv1);
    let resText1 = JSON.parse(xhr.responseText);
    console.log(resText1);
    par1.textContent = resText1.value.joke;

}

const xhr1 = new XMLHttpRequest();
console.log(`The readystate is ${xhr1.readyState}`);
xhr1.onreadystatechange = () => {
    if (xhr.readyState == 4 && xhr1.status == 200) {
        displayJoke2InBrowser();
    }
    else {
        console.log('Jokes not ready yet.');
    }
};

xhr1.open('GET', 'http://api.icndb.com/jokes/16', true);
xhr1.send();

function displayJoke2InBrowser(){    

    console.log();
    //under the same 'div' write 5 'p' that each have their own joke
    let body1 = document.body
    let myDiv1 = document.createElement('div');
    let par1 = document.createElement('p');

    myDiv1.appendChild(par1);
    body1.appendChild(myDiv1);
    let resText1 = JSON.parse(xhr1.responseText);
    console.log(resText1);
    par1.textContent = resText1.value.joke;

}

const xhr2 = new XMLHttpRequest();
console.log(`The readystate is ${xhr2.readyState}`);
xhr2.onreadystatechange = () => {
    if (xhr2.readyState == 4 && xhr2.status == 200) {
        displayJoke3InBroswer();
    }
    else {
        console.log('Jokes not ready yet.');
    }
};

xhr2.open('GET', 'http://api.icndb.com/jokes/187', true);
xhr2.send();

function displayJoke3InBroswer(){    

    console.log();
    //under the same 'div' write 5 'p' that each have their own joke
    let body1 = document.body
    let myDiv1 = document.createElement('div');
    let par1 = document.createElement('p');

    myDiv1.appendChild(par1);
    body1.appendChild(myDiv1);
    let resText1 = JSON.parse(xhr2.responseText);
    console.log(resText1);
    par1.textContent = resText1.value.joke;

}

const xhr3 = new XMLHttpRequest();
console.log(`The readystate is ${xhr3.readyState}`);
xhr3.onreadystatechange = () => {
    if (xhr3.readyState == 4 && xhr3.status == 200) {
        displayJoke4InBroswer();
    }
    else {
        console.log('Jokes not ready yet.');
    }
};

xhr3.open('GET', 'http://api.icndb.com/jokes/323', true);
xhr3.send();

function displayJoke4InBroswer(){    

    console.log();
    //under the same 'div' write 5 'p' that each have their own joke
    let body1 = document.body
    let myDiv1 = document.createElement('div');
    let par1 = document.createElement('p');

    myDiv1.appendChild(par1);
    body1.appendChild(myDiv1);
    let resText1 = JSON.parse(xhr3.responseText);
    console.log(resText1);
    par1.textContent = resText1.value.joke;

}

const xhr4 = new XMLHttpRequest();
console.log(`The readystate is ${xhr4.readyState}`);
xhr4.onreadystatechange = () => {
    if (xhr4.readyState == 4 && xhr4.status == 200) {
        displayJoke5InBroswer();
    }
    else {
        console.log('Jokes not ready yet.');
    }
};

xhr4.open('GET', 'http://api.icndb.com/jokes/369', true);
xhr4.send();

function displayJoke5InBroswer(){    

    console.log();
    //under the same 'div' write 5 'p' that each have their own joke
    let body1 = document.body
    let myDiv1 = document.createElement('div');
    let par1 = document.createElement('p');

    myDiv1.appendChild(par1);
    body1.appendChild(myDiv1);
    let resText1 = JSON.parse(xhr4.responseText);
    console.log(resText1);
    par1.textContent = resText1.value.joke;

}