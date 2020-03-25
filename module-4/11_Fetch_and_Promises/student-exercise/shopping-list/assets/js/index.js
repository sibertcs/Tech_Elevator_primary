let shoppingList = [];



function populateShoppingList(){
    console.log("Making shopping list...")
    fetch ('assets/data/shopping-list.json')
    //fetch ('https://localhost:44322/api/groceries/')
    .then ( (response) => {
        return response.json();
    })
    .then ( (data) => {
        shoppingList = data;
        displayShoppingList();
        const button = document.querySelector(".loadingButton");
        button.removeEventListener('click', populateShoppingList);
    })
    .catch ( (err) => {
        console.error(err);
    })
    console.log("shopping list created");
}

function displayShoppingList(){
    if('content' in document.createElement('template')) {
        
        const container = document.querySelector("ul");
        
        shoppingList.forEach((item) => {
          const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);
          tmpl.querySelector('li').insertAdjacentHTML('afterbegin', item.name);
          if (item.completed){
            const circleCheck = tmpl.querySelector('.fa-check-circle');
            circleCheck.classList.add("completed");
          }
          container.appendChild(tmpl);
        });
      } else {
        console.error('Your browser does not support templates');
      }
}

document.addEventListener("DOMContentLoaded", () => {
    const button = document.querySelector(".loadingButton");
    button.addEventListener('click', populateShoppingList);
    
    
    
    
});