(function () {
	var date = new Date(1,2,3,4,5,8);

	$(document).ready
 	(
 		function(){
			$("aside").click
			(
				function () {
					$("body").toggleClass("offline");
				}
			);
		}
	);

	// function digitalWatch() {
	// 		var years = date.getYear();
	// 		var mounth = date.getMonth();
	// 		var days = date.getDay();
	// 		var hours = date.getHours();
	// 		var minutes = date.getMinutes();
	// 		var seconds = date.getSeconds();

	// 		if (years - 0 < 10) {
	// 			years = "000" + years;
	// 		} else if (years - 0 < 100) {
	// 			years = "00" + years;
	// 		} else if (years - 0 < 1000) {
	// 			years = "0" + years;
	// 		}

	// 		if (mounth - 0 < 10) {
	// 			mounth = "0" + mounth;
	// 		}

	// 		if (days - 0 < 10) {
	// 			days = "0" + days;
	// 		}

	// 		if (hours - 0 < 10) {
	// 			hours = "0" + hours;
	// 		}
	// 		if (minutes - 0 < 10) {
	// 			minutes = "0" + minutes;
	// 		}
	// 		if (seconds - 0 < 10) {
	// 			seconds = "0" + seconds;
	// 		}

	// 		document.getElementById("digital_watch").innerHTML = years + " " + mounth + " " + days + " " + hours + ":" + minutes + ":" + seconds;
	// 		seconds = seconds - 0 + 1;

	// 		date = new Date(years, mounth, days, hours, minutes, seconds);
	// 		setTimeout("digitalWatch()", 1000);
	// 	}

	// digitalWatch();
})();