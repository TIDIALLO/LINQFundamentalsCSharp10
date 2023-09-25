using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
//var result = vm.GetAllQuery();
//var result = vm.GetSingleColumnQuery();
//var result = vm.GetSingleColumnMethod();
var result = vm.GetSpecificColumnsMethod();
// Display Results
vm.Display(result);