<?php
	session_start();

	$image_id = isset($_GET["id"]) ? $_GET["id"] : false;

	if ($image_id === false) {
		header("HTTP/1.0 500 Internal Server Error");
		echo "No ID";
		exit(0);
	}

	if (!is_array($_SESSION["file_info"]) || !isset($_SESSION["file_info"][$image_id])) {
		header("HTTP/1.0 404 Not found");
		exit(0);
	}

	//sleep(5);

	header("Content-type: image/jpeg") ;
	header("Content-Length: ".strlen($_SESSION["file_info"][$image_id]));
	echo $_SESSION["file_info"][$image_id];
?>