using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected abstract void OnTriggerEnter(Collider other);
}