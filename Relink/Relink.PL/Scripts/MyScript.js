(function () {
	var date = new Date(1970,2,13,4,51,8);

    // offline click
	$("aside").click
	(
		function () {
			$("body").toggleClass("offline");
		}
	);

    // clock
	(function digitalWatch() {
	    var years = date.getFullYear();
	    var mounth = date.getMonth();
	    var days = date.getDate();
	    var hours = date.getHours();
	    var minutes = date.getMinutes();
	    var seconds = date.getSeconds();

	    if (years - 0 < 10) {
	        years = "000" + years;
	    } else if (years - 0 < 100) {
	        years = "00" + years;
	    } else if (years - 0 < 1000) {
	        years = "0" + years;
	    }

	    if (mounth - 0 < 10) {
	        mounth = "0" + mounth;
	    }

	    if (days - 0 < 10) {
	        days = "0" + days;
	    }

	    if (hours - 0 < 10) {
	        hours = "0" + hours;
	    }
	    if (minutes - 0 < 10) {
	        minutes = "0" + minutes;
	    }
	    if (seconds - 0 < 10) {
	        seconds = "0" + seconds;
	    }

	    document.getElementById("digital_watch").innerHTML = years + " " + mounth + " " + days + " " + hours + ":" + minutes + ":" + seconds;
	    seconds += 1;

	    date = new Date(years, mounth, days, hours, minutes, seconds);
	    setTimeout(digitalWatch, 1000);
	})();

	$('#GetQuest').click(function (e) {

	    $.ajax({
	        url: "/Pages/AJAX/GetQuest.cshtml",
	        type: "post",
	    }).success(function (req) {
	    	$("#money").text("Money:" + req + "$");
	    });
	})

	$(".shopmenu li.shoppage li").click(function (e) {
	    $.ajax({
	        url: "/Pages/AJAX/BySome.cshtml",
	        type: "post",
	        data: $(e.target).attr("id"),
	    }).success(function (req) {
	    	$("#money").text("Money:" + req + "$");
	    });
	})
})();