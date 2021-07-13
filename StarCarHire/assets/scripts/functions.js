/**
* Hybrid
* Starter Theme.
* Created by Anonymous.
*/
(function($) {
	$(document).ready(function() {
		afterPageLoad();
	});

	function afterPageLoad() {
		$(document).foundation();

		var wow = new WOW({mobile: false});

		wow.init();

		$('#popup').magnificPopup({
			type: 'inline',
			preloader: false,
			modal: true
		});
	}
}) (jQuery);