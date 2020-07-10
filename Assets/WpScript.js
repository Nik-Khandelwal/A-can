var onoff : boolean = false;
var spinx : int = 0;
var spiny : int = 0;
var spinz : int = 0;
// Update is called once per frame
function Update () {
	if (Input.GetKeyDown (KeyCode.S))
        onoff = !onoff;

    if (onoff == true)
    	if(Input.GetKeyDown (KeyCode.L))
			transform.Rotate(spinx,spiny,spinz);
}

