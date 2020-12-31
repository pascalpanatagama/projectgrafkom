using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float interactDistance = 5f;
    Respawn lantai;

    public int jumlahKey4 = 0;
    public int jumlahKey3 = 0;
    public int jumlahKey2 = 0;
    public int jumlahKey1 = 0;

    void Start()
    {
        lantai = FindObjectOfType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    DoorScript doorScript = hit.collider.transform.parent.GetComponent<DoorScript>();
                    if (doorScript == null) return;

                    if(Inventory.keys[doorScript.index] == true)
                    {
                        doorScript.ChangeDoorState();
                    }
                    
                }
                else if(hit.collider.CompareTag("Key"))
                {
                    if (lantai.diLantai4)
                    {
                        jumlahKey4++;
                        Inventory.keys[hit.collider.GetComponent<Key>().index] = true;
                        //Debug.Log("found the key");
                        Destroy(hit.collider.gameObject);
                    } else if (lantai.diLantai3)
                    {
                        jumlahKey3++;
                        Inventory.keys[hit.collider.GetComponent<Key>().index] = true;
                        //Debug.Log("found the key");
                        Destroy(hit.collider.gameObject);
                    } else if (lantai.diLantai2)
                    {
                        jumlahKey2++;
                        Inventory.keys[hit.collider.GetComponent<Key>().index] = true;
                        //Debug.Log("found the key");
                        Destroy(hit.collider.gameObject);
                    }
                    else if (lantai.diLantai1)
                    {
                        jumlahKey1++;
                        Inventory.keys[hit.collider.GetComponent<Key>().index] = true;
                        //Debug.Log("found the key");
                        Destroy(hit.collider.gameObject);
                    }
                }

            }
        }
    }
}
