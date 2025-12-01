function greet() {
    console.log("Welcome to TypeScript!");
}
function main() {
    greet();
}
main();
// 2
function addNumbers(a, b) {
    return a + b;
}
var sum = addNumbers(10, 20);
console.log("Sum:", sum);
// 3
var multiply = function (a, b) {
    return a * b;
};
console.log("Multiplication:", multiply(5, 4));
