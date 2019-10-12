// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

google.charts.load('current', { 'packages': ['corechart'] });
function drawChart() {
    Expenses = parseInt(document.getElementById('Expensesvar').value);
    Income = parseInt(document.getElementById('Incomevar').value);
    Debt = parseInt(document.getElementById('Debtvar').value);
    Savings = parseInt(document.getElementById('Savingsvar').value);


function createNewElement()
{
    
    var newInput= document.createElement('div');

    newInput.innerHTML = "Expense:" + "<br>" + "<input type='text' asp-for='Expenses[" + count + "]'>" + "<br>" + "Amount:" + "<br>" + "R<input type='text' asp-for='Amounts[" + count + "]'>" + "<hr>";
    count = count + 1;

    document.getElementById("newExpense").appendChild(newInput);


}

function removeElement()
{ }
