using UnityEngine;
using System.Collections;

public class PlayerInputReader : MonoBehaviour {

    public CharacterMovement playerMovementScript;
    public string moveXName = "Horizontal";
    public string moveYName = "Vertical";
    
    void Update()
    {
        playerMovementScript.moveDir.x = Input.GetAxis(moveXName);
        playerMovementScript.moveDir.z = Input.GetAxis(moveYName);
    }
}
