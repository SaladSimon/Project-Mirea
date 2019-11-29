using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootIfGrabbed : MonoBehaviour
{
    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button LeftshootingButton;
    public OVRInput.Button RightshootingButton;
    public int maxNumberOfBullet = 10;
    public Text bulletText;
    public AudioClip shootingAudio;
    public GameObject gun;
    public float range = 100f;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot = GetComponent<SimpleShoot>();
        ovrGrabbable = GetComponent<OVRGrabbable>();
        bulletText.text = maxNumberOfBullet.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (ovrGrabbable.isGrabbed && maxNumberOfBullet > 0)
        {
            if (ovrGrabbable.grabbedBy.GetController() == OVRInput.Controller.LTouch)
            {
                if (OVRInput.GetDown(LeftshootingButton))
                {
                    print("Работает");
                    //  VibrationManager.singleton.TriggerVibration(shootingAudio,ovrGrabbable.grabbedBy.GetController());
                    //  GetComponent<AudioSource>().PlayOneShot(shootingAudio);
                    simpleShoot.TriggerShoot();
                    maxNumberOfBullet--;
                    bulletText.text = maxNumberOfBullet.ToString();
                }
            }
            if (ovrGrabbable.grabbedBy.GetController() == OVRInput.Controller.RTouch)
            {
                if (OVRInput.GetDown(RightshootingButton))
                {
                    print("Работает");
                    //  VibrationManager.singleton.TriggerVibration(shootingAudio,ovrGrabbable.grabbedBy.GetController());
                    //  GetComponent<AudioSource>().PlayOneShot(shootingAudio);
                    simpleShoot.TriggerShoot();
                    maxNumberOfBullet--;
                    bulletText.text = maxNumberOfBullet.ToString();
                }
            }
        }
    }
        }

        //    void Shoot()
        //   {
        //    RaycastHit hit;
        // if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hit, range))
        // {
        //     Destroy(hit.transform);
        //   }
        //   }
   
