using UnityEngine;

public class SphereSignals : MonoBehaviour
{
    [SerializeField] private float _power;

    private Transform _transform;
    private Rigidbody _rb;    

    void Start()
    {        
        _rb = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();        
    }

    public void ScaleSignal()
    {
        _transform.localScale = new Vector3(4, 2, 3);
    }

    public void ForceSignal()
    {
        _rb.AddForce(Vector3.right * _power, ForceMode.Impulse);
    }

    public void DestroySignal()
    {
        Destroy(gameObject);
    }
}
