// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

google.charts.load('current', { 'packages': ['corechart'] });
function drawChart() {
    Expenses = parseInt(document.getElementById('Expensesvar').value);
    Income = parseInt(document.getElementById('Incomevar').value);
    Debt = parseInt(document.getElementById('Debtvar').value);
    Savings = parseInt(document.getElementById('Savingsvar').value);

    var data = google.visualization.arrayToDataTable([
        ['Budget', 'Pie Chart'],
        ['Expenses', Expenses],
        ['Income', Income],
        ['Debt', Debt],
        ['Savings', Savings],
    ]);
    var options = {
        title: 'Budget Pie Chart'
    };
    //the id is the DOM location to draw the chart
    var chart = new google.visualization.PieChart(document.getElementById('piechart'));
    chart.draw(data, options);
}
function createNewElement()
{

    var newInput= document.createElement('div');

    newInput.innerHTML = "Expense:" + "<br>" + "<input type='text' id='newExpense'>" + "<br>" + "Amount(R):" + "<br>"+ "<input type='text' id='newExpense'>"+ "<hr>";

    document.getElementById("newExpense").appendChild(newInput);


}

function removeElement()
{ }
