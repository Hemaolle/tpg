var currentLocation;

function clickTest() {
	// window.alert("I am an alert box!");
	document.getElementById("redId").innerHTML = "test";
}

var areas = ["Market", "Courthouse", "Church", "Circus"];

window.onload = start;

function start () {
	for(var index in areas){
		placeDropDown.options[index] =
			new Option(areas[index], areas[index]);
	}
	document.getElementById("redId").innerHTML = "start";
	document.getElementById("currentLocation").innerHTML = areas[0];
	currentLocation = areas[0];
}

function onLocationChange(val) {
	// window.alert("location changed to " + val);
	currentLocation = val;
	document.getElementById("currentLocation").innerHTML = currentLocation;
}