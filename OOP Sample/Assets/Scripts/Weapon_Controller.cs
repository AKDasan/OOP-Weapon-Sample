using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : MonoBehaviour
{
    public GameObject player_Hand;
    public GameObject pistol;
    public GameObject rifle;

    public GameObject equippedWeapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (equippedWeapon != null)
            {
                Destroy(equippedWeapon);
            }

            if (pistol != null)
            {
                equippedWeapon = Instantiate(pistol, player_Hand.transform.position, player_Hand.transform.rotation);
                equippedWeapon.transform.SetParent(player_Hand.transform);
            }
            else
            {
                Debug.Log("Pistol atanmamýþtýr!");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (equippedWeapon != null)
            {
                Destroy(equippedWeapon);
            }

            if (rifle != null)
            {
                equippedWeapon = Instantiate(rifle, player_Hand.transform.position, player_Hand.transform.rotation);
                equippedWeapon.transform.SetParent(player_Hand.transform);
            }
            else
            {
                Debug.Log("Rifle atanmamýþtýr!");
            }
        }
    }
}
