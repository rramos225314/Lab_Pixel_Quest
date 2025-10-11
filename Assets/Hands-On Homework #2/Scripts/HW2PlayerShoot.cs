using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;


    private const float Timer = 0.5f;
    private float _currntTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        if (!_canShoot)
        {
            _currntTime -= Time.deltaTime;
            
            if (_currntTime < 0)
            {
                _canShoot = true;
                _currntTime = Timer;
            }
        }




        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
        GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);
           
            _canShoot = false;
        }
    }
}
