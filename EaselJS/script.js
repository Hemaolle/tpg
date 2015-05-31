var currentLocation;

function clickTest() {
	document.getElementById("redId").innerHTML = "test";
}

// var areas = ["Market", "Courthouse", "Church", "Circus"];

var areas = {
	"market": {
		"name": "Market",
		"description": "The market is full of sounds of bargaining."
	},
	"courthouse": {
		"name": "Courthouse",
		"description": "The courthouse is closed today."
	}
};

window.onload = start;

function start () {
	currentLocation = areas["market"];
	document.getElementById("currentLocation").innerHTML = currentLocation.name;
	updateLocationOptions();
}

function onLocationChange(val) {
	currentLocation = areas[val];
	document.getElementById("currentLocation").innerHTML = currentLocation.name;
	updateLocationOptions();
}

function updateLocationOptions() {
	var optionIndex = 1;
	for(var areaKey in areas){
		if(areas.hasOwnProperty(areaKey)) {
			var area = areas[areaKey];
			if(area != currentLocation) {
				placeDropDown.options[optionIndex] =
					new Option(area.name, areaKey);
				optionIndex = optionIndex + 1;
			}
		}
	}
}