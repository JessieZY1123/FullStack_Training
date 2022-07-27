let example = "sfgrav@gmail.com";
let checkEmailId = function(str){
    if(str.includes('@') && str.includes('.')){
        if(str.indexOf('.')> str.indexOf('@')){
            return true;
        }else{
            return false;
        }
    }
}
let res =checkEmailId(example);
console.log(res)