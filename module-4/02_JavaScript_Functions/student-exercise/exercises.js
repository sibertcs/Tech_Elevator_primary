/*
 * Document this function
 */
/**
 * This function will check the parameters/time and location which 
 * are (month, day, and hemisphere) to see if it is summer.
 * @param {number} month, the month, between 1 and 12, inclusive.
 * @param {number} day, the day, between 1 and 20, inclusive. Defaults to 1.
 * @param {string} hemisphere, the hemisphere, 'southern' or 'northern'. Defaults to 'northern'.
 */
function isSummer(month, day = 1, hemisphere = 'northern') {
  if (month === 7 || month === 8) {
    return hemisphere === 'northern';
  } else if (month === 6 && day >= 20) {
    return hemisphere === 'northern';
  } else if (month === 9 && day <= 20) {
    return hemisphere === 'northern';
  } else if (month === 1 || month === 2) {
    return hemisphere === 'southern';
  } else if (month === 12 && day >= 20) {
    return hemisphere === 'southern';
  } else if (month === 3 && day <= 20) {
    return hemisphere === 'southern';
  } else {
    return false;
  }
}

/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the students is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * We admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */
  function isAdmitted(gpa, satScore = 0, recommendation = false){
    if (gpa > 4.0 || satScore > 1300 || gpa > 3.0 && recommendation || satScore > 1200 && recommendation){
      return true;
    }
    return false;
  }
/**
 * Write a function called useParameterToFilterArray so that it takes an anonymous
 * function and uses that in `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction){
    return unfilteredArray.filter(element => { 
      return filterFunction(element)});
}


/**
 * Write a function called makeNumber to take two strings
 * of digits, concatenate them together, and then return
 * the value back as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * should return the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */
  function makeNumber(first, second){
    return parseInt(first+second);
  }
/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds them all together. Return the result.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */
  function addAll(){
    if (arguments.length == 0){
      return 0;
    }   
    else {
      let array = [];
      for (let i = 0; i < arguments.length; i++){
        array.push(arguments[i]);
      };
      return array.reduce(
        (accumulator, currentNum) => {
          return accumulator + currentNum;
        }
      )
    }
    
  }
/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */
/**
 * 
 * @param {*} words an array of words that will be prepended by 'Happy'
 */
  function makeHappy(words){
    return words.map(
      (word) => {
        return 'Happy ' + word;
      }
    )
  }
/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into mailing addresses in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */
/**
 * 
 * @param {*} objects an array of objects that each have the following keys: streetNumber, streetName, streetType, city, state, zip
 */
  function getFullAddressesOfProperties(objects){
    let address = "";
    return objects.map(
      (object) => {
        return (object.streetNumber + " " + object.streetName + " " + object.streetType + " " + object.city + " " + object.state + " " + object.zip);         
      }
    )  
  }
  
/*
 * Create and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It should work for strings and numbers.
 */
/**
 * Function that finds the largest element in the array (largest number if the array is an array of numbers, 
 * or last word when alphabetized if the array is an array of strings)
 * @param {array} array an array of strings or an array of words that will be evaluated
 */
  function findLargest(array){
    let largest = array[0]
    array.forEach(
      (element) => {
        if (typeof array[0] == "string"){
          if (element[0] > largest[0]){
            largest = element;
          }
        }
        else {
          if (element > largest){
            largest = element;
          }
        }
      }
    )
    return largest;
  }
  
/*
 * CHALLENGE
 * Create and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays and add up all sub values and return
 * the sum. For instance, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * You would return 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */

  function getSumOfSubArrayValues(nestedArray){
    if(!nestedArray){
      return 0;
    }
    let initialValue = 0;
    return nestedArray.reduce((outer, array) => {
        return outer + array.reduce((inner, current) => {
            return inner + current;
          }, initialValue
        );
      }, initialValue
    );
  };
  
  
  
