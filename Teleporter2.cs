using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Teleporter2 : MonoBehaviour
{
    [SerializeField]
    private float HighY;
    [SerializeField]
    private float LowY;
    [SerializeField]
    private float SpeedTime;

    private GameObject[] destinations;

    private void Start()
    {
        destinations = GameObject.FindGameObjectsWithTag("Teleporter2Destination");
    }
    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y >= HighY || transform.position.y <= LowY)
        { SpeedTime *= -1.0f; }
        //Vector3 is the exivilaunt of moving (0f, 0f, 1f);
        transform.position += new Vector3(0.0f, SpeedTime * Time.deltaTime, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    { //If the person with the tag Player one enters the portal it will transport them to the battlefield - if anything otherthan that player enters
      //"THIS" portal ignore
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        destinations = destinations.OrderBy(p => Vector3.Distance(transform.position, p.transform.position)).ToArray();
        other.gameObject.transform.position = destinations[0].transform.position;
    }

}