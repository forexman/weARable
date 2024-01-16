using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchSwapMenu : MonoBehaviour
{
    public GameObject garmin, rolex, watch1, watch2, watch3;

    private GameObject active;
    // Start is called before the first frame update
    void Start()
    {
        active = garmin;
    }

    public void SwapWearable(GameObject selected){
        active.SetActive(false);
        selected.SetActive(true);
        active = selected;
    }
}
