var onoff : boolean = false;
var spinx : int = 0;
var spiny : float = 0;
var spinz : int = 0;

// Update is called once per frame
function Update () {
	if (Input.GetKey (KeyCode.R))
		transform.Rotate(spinx,spiny,spinz);

	if (Input.GetKey (KeyCode.T))
		transform.Rotate(-spinx,-spiny,-spinz);
}

