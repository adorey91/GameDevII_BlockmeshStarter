using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkMove : MonoBehaviour
{
    [SerializeField] GameObject treeTrunk;
    [SerializeField] GameObject movedTrunk;
    [SerializeField] GameObject carrot;

    private void Start()
    {
        movedTrunk.SetActive(false);
        treeTrunk.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            treeTrunk.SetActive(false);
            movedTrunk.SetActive(true);
            carrot.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
