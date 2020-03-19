// add pageTitle
  const pageTitle = "My Shopping List";
// add groceries
  let groceries = [
    "eggs",
    "bread",
    "salmon",
    "udon",
    "soy milk",
    "coffee",
    "bananas",
    "grape juice",
    "arugula",
    "peppers"
  ];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  document.getElementById("title").innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.getElementById('groceries');
  groceries.forEach( (groceryItem) => {
    const li = document.createElement('li');
    li.innerText = groceryItem;
    ul.appendChild(li);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let groceryList = document.querySelectorAll('li');

  groceryList.forEach( (li) => {
    li.setAttribute("class", "completed")
  });
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
