let menu = { width: 200, height: 300, title: "My menu" };

let multiplyNumeric = function (object) {
    for (const [key, value] of Object.entries(object)) {
        if (typeof value === 'number') {
            object[key] = value * 2;
        }
    }
}
multiplyNumeric(menu)

console.log(menu);