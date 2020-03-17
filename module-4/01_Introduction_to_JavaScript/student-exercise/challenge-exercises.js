﻿/*
1. **iqTest** Bob is preparing to pass an IQ test. The most frequent task in this test 
    is to find out which one of the given numbers differs from the others. Bob observed
    that one number usually differs from the others in evenness. Help Bob — to check his 
    answers, he needs a program that among the given numbers finds one that is different in 
    evenness, and return the position of this number. _Keep in mind that your task is to help 
    Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)_

		iqTest("2 4 7 8 10") → 3 //third number is odd, while the rest are even
		iqTest("1 2 1 1") → 2 // second number is even, while the rest are odd
		iqTest("") → 0 // there are no numbers in the given set
        iqTest("2 2 4 6") → 0 // all numbers are even, therefore there is no position of an odd number
*/
    function iqTest(sequence){
        let array = sequence.split(" ");
        let numberArr = [];
        array.forEach(element => { 
            numberArr.push(parseInt(element))
        });
        let evenArray = [];
        let oddArray = [];
        for (let i = 0; i < numberArr.length - 1; i++){
            if (numberArr[i] % 2 == 0){
                evenArray.push(numberArr[i])
            }
            else {
                oddArray.push(numberArr[i])
            }
        };
        if (evenArray.length == 1){
            let outcast = numberArr.find(element => (element % 2 == 0));
            return numberArr.indexOf(outcast) + 1;
        }
        else if (oddArray.length == 1){
            let outcast = numberArr.find(element => (element % 2 == 1));
            return numberArr.indexOf(outcast) + 1;
        };
        return 0;
    }

/*
2. **titleCase** Write a function that will convert a string into title case, given an optional 
    list of exceptions (minor words). The list of minor words will be given as a string with each 
    word separated by a space. Your function should ignore the case of the minor words string -- 
    it should behave in the same way even if the case of the minor word string is changed.


* First argument (required): the original string to be converted.
* Second argument (optional): space-delimited list of minor words that must always be lowercase
except for the first word in the string. The JavaScript tests will pass undefined when this 
argument is unused.

		titleCase('a clash of KINGS', 'a an the of') // should return: 'A Clash of Kings'
		titleCase('THE WIND IN THE WILLOWS', 'The In') // should return: 'The Wind in the Willows'
        titleCase('the quick brown fox') // should return: 'The Quick Brown Fox'
*/
    


    function titleCase(string, optional){
        let converted = "";      
        let requiredArray = string.split(" ");
        if (!optional){
            
            for (let i = 0; i < requiredArray.length; i++){
                converted += (requiredArray[i].substr(0, 1).toUpperCase()) + (requiredArray[i].substr(1).toLowerCase()) + " ";
            }
        }
        else {
            let optionalArray = optional.split(" ");
            for (let i = 0; i < requiredArray.length; i++){
                let doesAlreadyContain = false;
                for (let j = 0; j < optionalArray.length; j++){
                    if (requiredArray[i].toLowerCase() == optionalArray[j].toLowerCase()){
                        if(i == 0) {
                            converted += (requiredArray[i].substr(0, 1).toUpperCase()) + (requiredArray[i].substr(1).toLowerCase()) + " ";
                            doesAlreadyContain = true;
                        }
                        else {
                            converted += (requiredArray[i].toLowerCase() + " ");
                            doesAlreadyContain = true;
                        }                   
                    }               
                }
                if (doesAlreadyContain){
                    continue;
                }
                else {
                    converted += (requiredArray[i].substr(0, 1).toUpperCase()) + (requiredArray[i].substr(1).toLowerCase()) + " ";
                }
            }     
        }
        return converted.trim();       
    }