using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {
    public GameObject Spear;
    public GameObject Sword;
    public GameObject Hammer;
    public GameObject Axe;
    public int weaponOut = 1; // 1 is spear, 2 is Sword, 3 is Hammer, 4 is Axe
    public GameObject script;

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
                            Spear.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Sword.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Hammer.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Axe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(1);
                        Spear.GetComponent<spearThrust>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("Sword"))
                    {
                        if (weaponOut == 1)
                        {
                            Spear.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Sword.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Hammer.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Axe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(2);
                        Sword.GetComponent<SwordSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("Hammer"))
                    {
                        if (weaponOut == 1)
                        {
                            Spear.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Sword.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 3)
                        {
                            Hammer.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Axe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(3);
                        Hammer.GetComponent<HammerSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("Axe"))
                    {
                        if (weaponOut == 1)
                        {
                            Spear.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Spear, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 2)
                        {
                            Sword.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Sword, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                            
                        }
                        else if (weaponOut == 3)
                        {
                            Hammer.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Hammer, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 4)
                        {
                            Axe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Axe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity); 
                        }
                        changeWeapon(4);
                        Axe.GetComponent<HammerSwing>().enabled = true;
                    }
                }
            }
        }
	}
    void changeWeapon(int weapon)
    {
        if (weapon == 1)
        {
            Debug.Log("The Spear is active");
            weaponOut = 1;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(true);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(false);
            
        }
        else if (weapon == 2)
        {
            Debug.Log("The Sword is active");
            weaponOut = 2;
            transform.Find("Sword").gameObject.SetActive(true);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(false);
        }
        else if (weapon == 3)
        {
            Debug.Log("The Hammer is active");
            weaponOut = 3;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(true);
            transform.Find("Axe").gameObject.SetActive(false);
        }
        else if (weapon == 4)
        { 
            Debug.Log("The Axe is active");
            weaponOut = 4;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("Axe").gameObject.SetActive(true);
        }
    }
}
