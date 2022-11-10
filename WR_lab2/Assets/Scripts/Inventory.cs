using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static int charge;
    public Texture2D[] hudCharge;
    public RawImage chargeHudGUI;

    // Generator
    public Texture2D[] meterCharge;
    public Renderer meter;
    public AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        charge = 0;
    }

    // Update is called once per frame
    void Update() { }

    void CellPickup()
    {
        HUDon();
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        charge++;
        chargeHudGUI.texture = hudCharge[charge];
        meter.material.mainTexture = meterCharge[charge];
    }

    void HUDon()
    {
        if (!chargeHudGUI.enabled)
        {
            chargeHudGUI.enabled = true;
        }
    }
}
