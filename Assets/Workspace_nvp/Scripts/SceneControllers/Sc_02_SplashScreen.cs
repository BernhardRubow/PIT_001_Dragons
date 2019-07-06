using System.Collections;
using System.Collections.Generic;
using nvp.Events;
using UnityEngine;

public class Sc_02_SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await System.Threading.Tasks.Task.Delay(3000);
        EventController.InvokeEvent("splash screen shown", null, null);
    }

}
