using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventHandler : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    TimerScript timerScript;
    [SerializeField] GameObject Timer;
    [SerializeField] GameObject oGameOverMenu;

    // Start is called before the first frame update
    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        if(gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
        
    }

    void Start()
    {
        timerScript = Timer.GetComponent<TimerScript>();
    }
    void Update()
    {

        if (timerScript.fTimer <= 0)
        {
            oGameOverMenu.SetActive(true);
        }
    }
}
