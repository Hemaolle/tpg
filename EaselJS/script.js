var currentLocation;

function clickTest() {
	document.getElementById("redId").innerHTML = "test";
}

// var areas = ["Market", "Courthouse", "Church", "Circus"];

var areas = {
	"areas": [
		{
			"name": "Market",
			"description": "The market is full of sounds of bargaining."
		},
		{
			"name": "Courthouse",
			"description": "The courthouse is closed today."
		}
	]
};

window.onload = start;

function start () {
	currentLocation = areas.areas[0];
	updateLocationOptions();
	document.getElementById("currentLocation").innerHTML = areas.areas[0].name;
}

function onLocationChange(val) {
	currentLocation = val;
	document.getElementById("currentLocation").innerHTML = currentLocation;
	updateLocationOptions();
}

function updateLocationOptions() {
	var optionIndex = 1;
	for(var i = 0; i < areas.areas.length; i++){
		var area = areas.areas[i];
		if(area != currentLocation) {
			placeDropDown.options[optionIndex] =
				new Option(area.name, area.name);
			optionIndex = optionIndex + 1;
		}
	}
}