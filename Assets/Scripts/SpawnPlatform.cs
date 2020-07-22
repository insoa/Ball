using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private Transform _pos;
    [SerializeField] private GameObject _obj;

    void OnTriggerEnter(Collider collider)
    {
        Spawn(_obj);
    }
    
    void Spawn(GameObject newPlatform)
    {
        newPlatform = Instantiate(_obj);
        newPlatform.transform.position = _pos.transform.position + new Vector3(18f, -50f, 0f);
        Destroy(_obj);
        _obj.transform.position = newPlatform.transform.position;
    }
    
}

