console.log('Hey Hey, world! We\'re...');

let myVar = 'Mike';
function myFunc(str, myInt){
    return `${str} is ${myInt} times more likely to drop out of school.`
}

//module.exports = myVar;

exports.myVar = myVar;
exports.myFunc = myFunc;