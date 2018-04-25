using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {
    public GameObject Spear;
    public GameObject Sword;
    public GameObject Hammer;
    public GameObject BattleAxe;
    public GameObject BronzeAxe;
    public GameObject Guandao;
    public GameObject HandAxe;
    public GameObject Pike;

    [Range(1, 50)]
    public float reachDistance;
    public int weaponOut = 1; // 1 is spear, 2 is Sword, 3 is Hammer, 4 is BattleAxe, 5 is BronzeAxe, 6 is Guandao, 7 is HandAxe, 8 is Pike 
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
            if (Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, reachDistance))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(3);
                        Hammer.GetComponent<HammerSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("BattleAxe"))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity); 
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(4);
                        BattleAxe.GetComponent<HammerSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("BronzeAxe"))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(5);
                        BronzeAxe.GetComponent<SwordSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("Guandao"))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(6);
                        Guandao.GetComponent<spearThrust>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("HandAxe"))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(7);
                        HandAxe.GetComponent<SwordSwing>().enabled = true;
                    }
                    if (hit.transform.gameObject.name.Contains("Pike"))
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
                            BattleAxe.GetComponent<HammerSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BattleAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 5)
                        {
                            BronzeAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(BronzeAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 6)
                        {
                            Guandao.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Guandao, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 7)
                        {
                            HandAxe.GetComponent<SwordSwing>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(HandAxe, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        else if (weaponOut == 8)
                        {
                            Pike.GetComponent<spearThrust>().enabled = false;
                            Destroy(hit.transform.gameObject);
                            Instantiate(Pike, transform.root.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                        }
                        changeWeapon(8);
                        Pike.GetComponent<spearThrust>().enabled = true;
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
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);

        }
        else if (weapon == 2)
        {
            Debug.Log("The Sword is active");
            weaponOut = 2;
            transform.Find("Sword").gameObject.SetActive(true);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 3)
        {
            Debug.Log("The Hammer is active");
            weaponOut = 3;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(true);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 4)
        { 
            Debug.Log("The BattleAxe is active");
            weaponOut = 4;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(true);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 5)
        {
            Debug.Log("The BronzeAxe is active");
            weaponOut = 5;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(true);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 6)
        {
            Debug.Log("The Guandao is active");
            weaponOut = 6;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(true);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 7)
        {
            Debug.Log("The HandAxe is active");
            weaponOut = 7;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(true);
            transform.Find("Pike").gameObject.SetActive(false);
        }
        else if (weapon == 8)
        {
            Debug.Log("The Pike is active");
            weaponOut = 8;
            transform.Find("Sword").gameObject.SetActive(false);
            transform.Find("Spear").gameObject.SetActive(false);
            transform.Find("Hammer").gameObject.SetActive(false);
            transform.Find("BattleAxe").gameObject.SetActive(false);
            transform.Find("BronzeAxe").gameObject.SetActive(false);
            transform.Find("Guandao").gameObject.SetActive(false);
            transform.Find("HandAxe").gameObject.SetActive(false);
            transform.Find("Pike").gameObject.SetActive(true);
        }
    }
}
