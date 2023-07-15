using System.Collections.Generic;
using UnityEngine;
using AI.Behaviour;
using GM.SystemTiles;


namespace GS.Maps
{
    public class GenMaps : MonoBehaviour
    {
        public int XMaxSzie;
        public int YMaxSzie;
        private Transform _Camera;
        public float _space;

        public AIBehaviour aIBehaviour;

        [SerializeField]
        private List<GameObject> _Titles = new List<GameObject>();
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

                    Instantiate(_Titles[_TypeTitle], _Offset, Quaternion.identity);
                    _Offset.x += _space;
                    CountTitle++;
                }
                _Offset.x = 0;
                _Offset.y++;
            }

            TilesSystem[] comp = GameObject.FindObjectsOfType<TilesSystem>();
            GetAllTitles(comp);

            float HaftCountTitle = CountTitle / 2;
            Debug.Log(CountTitle + " CountTitle ");
            Debug.Log(HaftCountTitle + " Haft CountTitle ");

            //set camera to see all maps 
            var OffsetCamera = -YMaxSzie / 2;
            _Camera.transform.position = new Vector3(_Camera.transform.localPosition.x, OffsetCamera, -10);
        }
        private void GetAllTitles(TilesSystem[] NameTitles)
        {
            foreach (var item in NameTitles)
            {
                aIBehaviour.SetTypes(item.Tile);
            }

            aIBehaviour.AllTitles.Add("Golden", aIBehaviour.typesGolden.ToArray());
            aIBehaviour.AllTitles.Add("Stone", aIBehaviour.typesStone.ToArray());
            aIBehaviour.AllTitles.Add("Grass", aIBehaviour.typesGrass.ToArray());
            aIBehaviour.AllTitles.Add("Oli", aIBehaviour.typesOli.ToArray());
            aIBehaviour.AllTitles.Add("River", aIBehaviour.typesRiver.ToArray());


        }
    }
}
