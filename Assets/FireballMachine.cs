using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMachine : MonoBehaviour
{
    public GameObject player;
    public GameObject fireballPrefab;
    private Transform _playerPos;
    private float _time = 0.0f;

    private const float _fireballCooldown = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerPos = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > _fireballCooldown)
        {
            _time = 0;
            // _time -= 2.0f;
            GameObject newFireball = Instantiate(fireballPrefab);
            Vector3 position = transform.position;
            newFireball.transform.position = position;
            Fireball fireballComponent = newFireball.GetComponent<Fireball>();
            fireballComponent.SetDirection(_playerPos.position - position);
        }
    }
}