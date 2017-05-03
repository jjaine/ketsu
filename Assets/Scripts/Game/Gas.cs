﻿using UnityEngine;

namespace Game
{
    public class Gas : MonoBehaviour
    {
        public string SfxCollectDefault;
        public string SfxCollectLast;

        public static int GasToCollect;
        public static int GasCollected;

        public GameObject ExplosionPrefab;

        void Awake()
        {
            GasToCollect = 0;
            GasCollected = 0;
        }

        void Start()
        {
            GasToCollect++;
        }

        void OnTriggerEnter(Collider other)
        {
            var otherType = other.GetComponent<MapObject>().Type;
            if (otherType != MapObjectType.Fox && otherType != MapObjectType.Wolf &&
                otherType != MapObjectType.Ketsu) return;

            GasCollected++;
            GasToCollect--;

            if (GasToCollect > 0) AkSoundEngine.PostEvent(SfxCollectDefault, gameObject);
            else AkSoundEngine.PostEvent(SfxCollectLast, gameObject);

            Instantiate(ExplosionPrefab, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}