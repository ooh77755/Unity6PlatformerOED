using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float shotCounter;
    [SerializeField] float minTimeBetweenShots = 1f;
    [SerializeField] float maxTimeBetweenShots = 3f;
    [SerializeField] float enemyProjectileSpeed = 10f;
    float laserDestroyTime = 3f;

    //cached refs
    [SerializeField] GameObject enemyLaser;

    private void Start()
    {
        shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
    }

    private void Update()
    {
        CountDownToNextShot();
    }

    private void CountDownToNextShot()
    {
        shotCounter -= Time.deltaTime;

        if (shotCounter <= 0f)
        {
            Firing();
            shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
        }
    }

    private void Firing()
    {
        GameObject laser = Instantiate(enemyLaser, transform.position, Quaternion.identity);
        laser.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(enemyProjectileSpeed, 0f);
        Destroy(laser, laserDestroyTime);
    }
}
