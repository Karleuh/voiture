using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Oui : MonoBehaviour
{   
    [SerializeField] private float quiTime;
    [SerializeField] private float speed;
    [SerializeField] Material whiteMat;
    [SerializeField] Material redMat;
    [SerializeField] Material blueMat;
    [SerializeField] Material yellowMat;
    [SerializeField] Material greenMat;

    private Gamepad gamepad;

    void Start (){
        gamepad = Gamepad.current;
    }
    public void TurnRed(InputAction.CallbackContext context){
        if (context.started){
            GetComponent<Renderer>().material = redMat;
        }
        if (context.canceled) {
            GetComponent<Renderer>().material = whiteMat;
        }
    }
    public void TurnGreen(InputAction.CallbackContext context) {
        if (context.started){
            GetComponent<Renderer>().material = greenMat;
        }
        if (context.canceled) {
            GetComponent<Renderer>().material = whiteMat;
        }
    }
    public void TurnBlue(InputAction.CallbackContext context){
        if (context.started){
            GetComponent<Renderer>().material = blueMat;
        }
        if (context.canceled) {
            GetComponent<Renderer>().material = whiteMat;
        }

    }
    public void TurnYellow(InputAction.CallbackContext context){
        if (context.started){
            GetComponent<Renderer>().material = blueMat;
        }
        if (context.canceled) {
            GetComponent<Renderer>().material = whiteMat;
        }
    }



    void Update(){

        if (gamepad.startButton.isPressed){
            quiTime += Time.deltaTime;

            if (quiTime>1){
                Debug.Log("Quit");
                Application.Quit();
            }
        }
        else {
            quiTime =0;
        }
    }

    public void Move(InputAction.CallbackContext context){
        Vector2 inputMovement = context.ReadValue<Vector2>();
        transform.position = new Vector3(inputMovement.x,inputMovement.y, 0)*speed;
    }


    //context.duration marche po

    // public void Quit(InputAction.CallbackContext context){
    //     Debug.Log("Quitting");
    //     if (context.duration > 1){
    //         Application.Quit();
    //         Debug.Log("quitOMG");
    //     }
    // }
}
