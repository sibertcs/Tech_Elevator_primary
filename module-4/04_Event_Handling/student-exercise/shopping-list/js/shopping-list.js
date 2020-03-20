let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
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
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

document.addEventListener('DOMContentLoaded', () => {
  setPageTitle();
  displayGroceries();

  const groceryItems = document.querySelectorAll("li");
  
  groceryItems.forEach((item) => {
    item.addEventListener('click', () => {
      markItemComplete(item);
    })
    item.addEventListener('dblclick', () => {
      markItemIncomplete(item);
    })

  })

  function markItemComplete(element){
    element.classList.add("completed");
    element.querySelector('i').classList.add('completed');
  };

  function markItemIncomplete(element){
    element.classList.remove("completed");
    element.querySelector('i').classList.remove('completed');
  };

  const changeAll = document.getElementById('toggleAll')
  changeAll.addEventListener('click', () => {
    groceryItems.forEach((item) => {
      if(allItemsIncomplete){
        markItemComplete(item);
     
        changeAll.innerText = 'Mark All Incomplete';
      }
      else {
        markItemIncomplete(item);
     
        changeAll.innerText = 'Mark All Complete';
      }
    })
    allItemsIncomplete = !allItemsIncomplete;
  })

  
})


