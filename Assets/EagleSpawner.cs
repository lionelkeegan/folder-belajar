using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField] GameObject eaglePrefab;
    [SerializeField] int spawnZpos = 7;
    [SerializeField] Player player;
    [SerializeField] float timeOut = 7;

    [SerializeField] float timer=0;
    int playerLasMaxTravel = 0;

    private void SpanwEagle()
    {
        player.enabled = false;
        var position = new Vector3(player.transform.position.x, 2, player.CurrentTravel + spawnZpos);
        var rotation = Quaternion.Euler(0, 180, 0);
        var eagleObject = Instantiate(eaglePrefab, position, rotation);
        var eagle = eagleObject.GetComponent<Eagle>();
        eagle.SetUpTarget(player);
    }
    private void Update()
    {
        // if player has to front
        if (player.MaxTravel != playerLasMaxTravel)
        {
            // reset time
            timer = 0;
            playerLasMaxTravel = player.MaxTravel;
        }
        if (timer < timeOut)
        {
            timer += Time.deltaTime;
            return;
        }
        if (player.IsJumping() == false && player.IsDie == false)
            SpanwEagle();
    }

    // IEnumerator Timer()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForEndOfFrame();
    //     }
    // }
}
