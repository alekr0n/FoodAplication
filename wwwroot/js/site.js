// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let apiURL = "https://forkify-api.herokuapp.com/api/v2/recipes";
let apikey = "71199caf-7c88-4161-8c1a-f05bdef999d7";

function GetRecipes(recipeName) {
    let resp = await fetch('${apiURL}?search=${recipeName}&key=${apikey}');
    let result = await resp.json();
    console.log(result);
}
