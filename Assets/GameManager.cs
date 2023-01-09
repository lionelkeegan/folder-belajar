using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject grass;
    [SerializeField] GameObject dalan;
    [SerializeField] int extent = 10;
    [SerializeField] int frontdistance = 10;
    [SerializeField] int backDistance = -5;
    [SerializeField] int maxSameTerrainRepeat = 3;

    // int maxZpos;
    Dictionary<int, TerrainBlock> map = new Dictionary<int, TerrainBlock>(50);
    TMP_Text gameOverText;

    private void Start()
    {
        // Setup Game Over 
        gameOverPanel.SetActive(false);
        gameOverText = gameOverPanel.GetComponentInChildren<TMP_Text>();

        // for Back
        for (int z = backDistance; z <= 0; z++)
        {
            CreateTerrain(grass, z);
        }

        // for front
        for (int z = 1; z <= frontdistance; z++)
        {
            var prefab = GetNextRandomTerrainPrefab(z);

            // instantiate Terrain Block
            CreateTerrain(prefab, z);
        }

        player.SetUp(backDistance, extent);
    }
    private int playerLasMaxTravel;
    private void Update()
    {
        // check player if Life
        if (player.IsDie && gameOverPanel.activeInHierarchy == false)
           StartCoroutine( ShowGameOverPanel());
        // infinite Terrain System
        if (player.MaxTravel == playerLasMaxTravel)
            return;

        playerLasMaxTravel = player.MaxTravel;

        // make front Terrain
        var randTBPrefab = GetNextRandomTerrainPrefab(player.MaxTravel + frontdistance);
        CreateTerrain(randTBPrefab, player.MaxTravel + frontdistance);
        // erase back terrain
        var lastTB = map[player.MaxTravel - 1 + backDistance];

        // TerrainBlock lastTB= map[player.MaxTravel+frontdistance];
        // int lastPos = player.MaxTravel;
        // foreach (var (pos, tb) in map)
        // {
        //     if (pos<lastPos)
        //     {
        //         lastPos = pos;
        //         lastTB = tb;
        //     }
        // }

        // remove from list
        map.Remove(player.MaxTravel - 1 + backDistance);
        // remove scene terrain block
        Destroy(lastTB.gameObject);
        // setup player Can't move back
        player.SetUp(player.MaxTravel + backDistance, extent);
    }

    IEnumerator ShowGameOverPanel()
    {
        yield return new WaitForSeconds(2);

        gameOverText.text = "YOUR SCORE: " + player.MaxTravel;
        gameOverPanel.SetActive(true);
    }
    private void CreateTerrain(GameObject prefab, int zpos)
    {
        var go = Instantiate(prefab, new Vector3(0, 0, zpos), Quaternion.identity);
        var tb = go.GetComponent<TerrainBlock>();
        tb.Build(extent);

        map.Add(zpos, tb);
    }

    private GameObject GetNextRandomTerrainPrefab(int nextpos)
    {
        bool isUniform = true;
        var tbRef = map[nextpos - 1];
        for (int distance = 2; distance <= maxSameTerrainRepeat; distance++)
        {
            if (map[nextpos - distance].GetType() != tbRef.GetType())
            {
                isUniform = false;
                break;
            }
        }

        if (isUniform)
        {
            if (tbRef is Grass)
                return dalan;
            else
                return grass;
        }

        // determination of terrain block with 50% Probability
        return Random.value > 0.5f ? dalan : grass;
    }
        public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
