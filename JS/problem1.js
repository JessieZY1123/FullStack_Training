let salaries = {
    John:100,
    Ann: 160,
    Pete:130
}
const sum = Object.values(salaries).reduce(
    (previousValue, currentValue) => previousValue + currentValue,
);

console.log(sum)