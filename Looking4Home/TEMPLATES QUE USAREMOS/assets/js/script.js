	/*----------------------IMAGEN QUE SE COLOCA BORROSA------------------------*/

	document.getElementById("myID").addEventListener("mouseover", function() {
	    $("#target").addClass("borroso");
	});

	document.getElementById("myID").addEventListener("mouseout", function() {	
	    $("#target").removeClass("borroso");
	});
	


	/*----------------OCULTAR IMAGEN DE PANEL LATERAL--------------------*/

	function fnc_toggle () {
	        $('#prueba').toggle();
	}



	/*------------------PESTAÑA PERFIL Y CERRAR SESION------------------*/

	/* When the user clicks on the button, 
	toggle between hiding and showing the dropdown content */
	function myFunction() {
	  document.getElementById("myDropdown").classList.toggle("show");
	}

	// Close the dropdown if the user clicks outside of it
	window.onclick = function(e) {
	  if (!e.target.matches('.dropbtn')) {
	  var myDropdown = document.getElementById("myDropdown");
	    if (myDropdown.classList.contains('show')) {
	      myDropdown.classList.remove('show');
	    }
	  }
	}
