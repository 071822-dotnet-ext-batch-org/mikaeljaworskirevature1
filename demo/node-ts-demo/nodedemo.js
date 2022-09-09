const fs = require('fs-extra')
const otherFile = require('./otherFile.js');


console.log(`${otherFile.myVar} is one of the Monkeys`);

console.log(otherFile.myFunc('People who are not at 4th grade reading level by 10 years old,', 5));

fs.writeFileSync('./DeepThoughts.txt','Somitimes I wonder if penguins have Napolean complex.');

/**
 * 1. create some functions that will write to a new file
 * 2. append to that new file
 * 3. and then read from that file
 * 4. print the contents to console
 * 5. use variable(s) and a function that you exported from another module(file)
 *                                                  ...using Node, etc.
 */

