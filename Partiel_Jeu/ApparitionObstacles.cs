using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparitionObstacles : MonoBehaviour
{
    public GameObject platformPierrePrefab;
    public GameObject platformPierreCassePrefab;
    public GameObject piquantPlatformPrefab;
    public GameObject speedLeftPrefab;
    public GameObject speedRightPrefab;

    public GameObject[] movingPlatforms;

    public float temps_Apparition = 0.8f;
    private float flux_Platforms;
    public float min_X = -2f, max_X = 2f;

    private int compteurPlatform;
    // Start is called before the first frame update
    void Start()
    {
        flux_Platforms = temps_Apparition;
    }

    // Update is called once per frame
    void Update()
    {
        ObstaclesApparition();
    }

    void ObstaclesApparition()
    {
        flux_Platforms += Time.deltaTime;

        if (flux_Platforms >= temps_Apparition) 
        {
            compteurPlatform++;

            Vector3 pos = transform.position;
            pos.x = Random.Range(min_X, max_X);

            GameObject newPlatform = null;

            if (compteurPlatform < 2)
            {

                newPlatform = Instantiate(platformPierrePrefab, pos, Quaternion.identity);

            }

            else if (compteurPlatform == 2)
            {

                if (Random.Range(0, 2) > 0)
                {

                    newPlatform = Instantiate(platformPierrePrefab, pos, Quaternion.identity);

                }
                else
                {

                    newPlatform = Instantiate(
                    movingPlatforms[Random.Range(0, movingPlatforms.Length)],
                        pos, Quaternion.identity);

                }

            }
        }
    }
}
