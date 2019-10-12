// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function createNewElement()
{

    var newInput= document.createElement('div');

    newInput.innerHTML = "Expense:" + "<br>" + "<input type='text' id='newExpense'>" + "<br>" + "Amount(R):" + "<br>"+ "<input type='text' id='newExpense'>"+ "<hr>";

    document.getElementById("newExpense").appendChild(newInput);


}

function removeElement()
{ }
