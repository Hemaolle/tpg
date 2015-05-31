var currentLocation;

function clickTest() {
	document.getElementById("redId").innerHTML = "test";
}

var areas = ["Market", "Courthouse", "Church", "Circus"];

window.onload = start;

function start () {
	currentLocation = areas[0];
	updateLocationOptions();
	document.getElementById("redId").innerHTML = "start";
	document.getElementById("currentLocation").innerHTML = areas[0];
}

function onLocationChange(val) {
	currentLocation = val;
	document.getElementById("currentLocation").innerHTML = currentLocation;
	updateLocationOptions();
}

function updateLocationOptions() {
	var optionIndex = 1;
	for(var index in areas){
		if(areas[index] != currentLocation) {
			placeDropDown.options[optionIndex] =
				new Option(areas[index], areas[index]);
			optionIndex = optionIndex + 1;
		}
	}
}