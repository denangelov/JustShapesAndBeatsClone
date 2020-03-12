using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialGroup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hollowCirclePrefab;
    public Transform circlePrefab;
    public float radius = 1f;
    private float _duration = 0.1f;
    private GameObject[] _hexagons = new GameObject[5];

    void Start()
    {
        _createCenter();
        StartCoroutine(HexagonCoroutine());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void _createCenter()
    {
        Instantiate(circlePrefab, transform.position, transform.rotation);
    }

    IEnumerator HexagonCoroutine()
    {
        _instantiateHexagon(new Vector2(transform.position.x + radius, transform.position.y));
        yield return new WaitForSeconds(_duration);
        _instantiateHexagon(new Vector2(transform.position.x, transform.position.y - radius));
        yield return new WaitForSeconds(_duration);
        _instantiateHexagon(new Vector2(transform.position.x - radius, transform.position.y));
        yield return new WaitForSeconds(_duration);
        _instantiateHexagon(new Vector2(transform.position.x, transform.position.y + radius));

        yield return new WaitForSeconds(1f);

        // for (int i = 0; i < _hexagons.Length; i++)
        // {
        //     Destroy(_hexagons[i]);
        // }
    }

    private void _instantiateHexagon(Vector2 position)
    {
        Instantiate(hollowCirclePrefab, position, Quaternion.identity);
    }
}
