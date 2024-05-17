using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy1Fire : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public static float shotDistance;
    public static Vector3 shotDirection;
    void Start()
    {
        StartCoroutine(SpawnBullets());
    }
    private IEnumerator SpawnBullets()
    {
        while (true)
        {
            float waitTime = Random.Range(4f, 7f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(enemyBulletPrefab, transform.position, Quaternion.identity);

            CalculateRandomShot();

        }
    }
    private void CalculateRandomShot()
    {
        shotDistance = Random.Range(7f, 13f); // ???? ??, ????? ?????? ???? ????
        float x = Random.Range(0f, 360f); // 0???? 360?? ?????? ????
        float y = Random.Range(0f, 360f);
        shotDirection = new Vector3(x, y, 0).normalized; // ?????? ????? ???
    }
}
