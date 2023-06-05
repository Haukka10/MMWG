using System.Collections.Generic;
using UnityEngine;

namespace GS.Maps
{
    public class GenMaps : MonoBehaviour
    {
        public int XMaxSzie;
        public int YMaxSzie;
        private Transform _Camera;
        public float _space;

        [SerializeField]
        private List<GameObject> _Titles = new List<GameObject>();
        [SerializeField]
        private int _TypeTitle;

        private Vector3 _Offset;
        public float CountTitle;
        private void Awake()
        {
            _Camera = FindObjectOfType<Camera>().transform; 
            _Offset.y = -YMaxSzie;
            GeneratorMaps();
        }
        private void RandTitles() => _TypeTitle = Random.Range(0, _Titles.Count);
        /// <summary>
        /// Generator maps starting with right to left
        /// </summary>
        private void GeneratorMaps()
        {
            for (int i = 0; i < YMaxSzie; i++)
            {
                for (int j = 0; j < XMaxSzie; j++)
                {
                    RandTitles();
                    _Titles[_TypeTitle].name = $"Titles {CountTitle}";

                    Instantiate(_Titles[_TypeTitle], _Offset, Quaternion.identity);
                    _Offset.x += _space;
                    CountTitle++;

                }
                _Offset.x = 0;
                _Offset.y++;
            }
            float HaftCountTitle = CountTitle / 2;
            Debug.Log(CountTitle + " CountTitle ");
            Debug.Log(HaftCountTitle + " Haft CountTitle ");

            //set camera to see all maps 
            var OffsetCamera = -YMaxSzie / 2;
            _Camera.transform.position = new Vector3(_Camera.transform.localPosition.x, OffsetCamera, -10);
        }
    }
}
