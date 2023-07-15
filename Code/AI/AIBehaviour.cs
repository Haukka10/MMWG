using GS.Maps;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI.Behaviour
{
    public class AIBehaviour : MonoBehaviour
    {
        public GenMaps Titles;
       [HideInInspector] public List<TypeTitle> typesStone = new List<TypeTitle>();
       [HideInInspector] public List<TypeTitle> typesGolden = new List<TypeTitle>();
       [HideInInspector] public List<TypeTitle> typesGrass = new List<TypeTitle>();
       [HideInInspector] public List<TypeTitle> typesOli = new List<TypeTitle>();
       [HideInInspector] public List<TypeTitle> typesRiver = new List<TypeTitle>();

        public Dictionary<string, TypeTitle[]> AllTitles = new Dictionary<string, TypeTitle[]>();
        public TypeTitle SetTypes(TypeTitle typeTitle)
        {
            SetTypesLists(typeTitle, typeTitle.Name);
            return typeTitle;
        }
        /// <summary>
        /// Set all types to other lists
        /// </summary>
        /// <param name="typeTitle"></param>
        /// <param name="name"></param>
        private void SetTypesLists(TypeTitle typeTitle, string name)
        {
            switch (name)
            {
                case "Golden":
                    typesGolden.Add(typeTitle);
                    break;
                case "Stone":
                    typesStone.Add(typeTitle);
                    break;
                case "Grass":
                    typesGrass.Add(typeTitle);
                    break;
                case "Oli":
                    typesOli.Add(typeTitle);
                    break;
                case "River":
                    typesRiver.Add(typeTitle);
                    break;
            }
        }
    }
}
