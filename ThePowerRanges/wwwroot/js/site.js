// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var count=1

function createNewElement()
{
    
    var newInput= document.createElement('div');

    newInput.innerHTML = "Expense:" + "<br>" + "<input type='text' id='newExpense_" + count + "'>" + "<br>" + "Amount:" + "<br>" + "R<input type='text' id='newExpense_" + count + "'>" + "<hr>";
    count = count + 1;

    document.getElementById("newExpense").appendChild(newInput);


}

function removeElement()
{ }
