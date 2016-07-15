$(document).ready(function() {



//Tooltip
$('.custom-tooltip').tooltip();


//Mobile menu
$('#navigation').mobileMenu({
	triggerMenu:'#navigation-toggle',
	subMenuTrigger: ".sub-nav-toggle",
	animationSpeed: 500 
});

});