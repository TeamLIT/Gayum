using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {
    public GameObject Spear;
    public GameObject Sword;
    public GameObject Hammer;
    public GameObject Axe;
    int weaponOut = 1; // 1 is spear, 2 is Sword, 3 is Hammer, 4 is Axe
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("pressed E");
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, transform.forward, out hit))
            {
                Debug.Log("Hit the object");
                if (hit.transform.tag=="Item")
                {
                    Debug.Log("object is an item");
                    if (hit.transform.gameObject.name.Contains("Spear"))
                    {
                        if (weaponOut == 1)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        changeWeapon(1);
                    }
                    if (hit.transform.gameObject.name.Contains("Sword"))
                    {
                        if (weaponOut == 1)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        changeWeapon(2);
                    }
                    if (hit.transform.gameObject.name.Contains("Hammer"))
                    {
                        if (weaponOut == 1)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        changeWeapon(3);
                    }
                    if (hit.transform.gameObject.name.Contains("Axe"))
                    {
                        if (weaponOut == 1)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
                            
                        }
                        changeWeapon(4);
                    }
                }
            }
        }
	}
    void changeWeapon(int weapon)
    {
        if (weapon == 1)
        {
            weaponOut = 1;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(true);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(false);
        }
        else if (weapon == 2)
        {
            weaponOut = 2;
            transform.Find("Sword").gameObject.SetActive(true);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(false);
        }
        else if (weapon == 3)
        {
            weaponOut = 3;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(true);
            transform.Find("Axe").gameObject.SetActive(false);
        }
        else if (weapon == 4)
        {
            weaponOut = 4;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(true);
        }
    }
}
