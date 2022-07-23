let example = "What I'd like to tell on this topic is:";
let example2 = "Hi everyone!";
let truncate =function(str, maxlength){
    if(str.length < maxlength){
        return str;
    }
    let res = str.substring(0,maxlength-1)+"...";
    return res;
} 

let result = truncate(example,20);
console.log(result);
let result2 = truncate(example2,20);
console.log(result2);