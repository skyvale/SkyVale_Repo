
//PARSE A JSON TEXT(STRING) INTO A JAVASCRIPT OBJECT
//USE data.js object "employees"
//converts JSON text (string) into a javascript object
//JSON.parse(var name assigned to the JSON object)

/*var obj = JSON.parse(text);
console.log(obj);

console.log(obj.employees[1].firstName + " " + obj.employees[1].lastName);
*/

//ACCESSING A JSON ARRAY
//Use data.js object "people"
//Use json_weather.js

//console.log(myJSON.people[0].job);


//Load JSON data in the HTML using DOM



/**********   PRACTICE EXERCISES   *******************/

//1. Create a JSON object in the blank json_weather.js file using the provided weatherData.txt file.
// Use the following line if code to test your new file: console.log(data.results.forecast[2].day);

console.log(data.results.forecast[2].day);

// 2. Console.log the forecast for the next 3 days in sentence (String) format
// example: Today is Saturday. The high is 82. The low is 65. It will be partly cloudy.

console.log("\nThe weather for the next three days looks like this:\n");
console.log("On Friday, " + data.results.forecast[0].date + " it will have a high of " + data.results.forecast[0].high +
            " and a low of " + data.results.forecast[0].low + ". It will be " + data.results.forecast[0].text + ".");
console.log("On Saturday, " + data.results.forecast[1].date + " it will have a high of " + data.results.forecast[1].high +
    " and a low of " + data.results.forecast[1].low + ". It will be " + data.results.forecast[1].text + ".");
console.log("On Sunday, " + data.results.forecast[2].date + " it will have a high of " + data.results.forecast[2].high +
    " and a low of " + data.results.forecast[2].low + ". It will be " + data.results.forecast[2].text + ".");


// 3. Console.log each of the employees showing their full names (from the object "employees"
// and jobs (from the object "people").

var obj = JSON.parse(text);

console.log("\nList of Employees:");
console.log(obj.employees[0].firstName + " " + obj.employees[0].lastName + ", " + myJSON.people[0].job);
console.log(obj.employees[1].firstName + " " + obj.employees[1].lastName + ", " + myJSON.people[1].job);
console.log(obj.employees[2].firstName + " " + obj.employees[2].lastName + ", " + myJSON.people[2].job);

