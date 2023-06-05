using System.Collections;
using System.Collections.Generic;
using GM.SystemTiles;
using UnityEngine;
using UnityEngine.WSA;

namespace GS.SetSprite
{
    public class SetSpriteScrip : MonoBehaviour
    {
/*        [SerializeField]
        private List<Sprite> _sprites = new List<Sprite>();
        [SerializeField]
        private List<Sprite> _spritesHover = new List<Sprite>();
        [SerializeField]
        private string HoverTag = "Hover";

        private List<string> _NamesType = new List<string>() { "Grass", "stone", "river", "oli", "golden"};
        private Sprite _IdleSprite, _HoverSprite;
        private void GetSprite()
        {
            int index = 0;
            if(_sprites.Count <= 0 || _spritesHover.Count <= 0)
                Debug.LogError($"Sprites not set");

            foreach (var item in _sprites)
            {
                
                if (_sprites[index] is null || _NamesType.Count != _sprites.Count)
                {
                    Debug.LogError($"Sprite not set or not equals count of list NameType {_NamesType.Count} and sprites {_sprites.Count}");
                    return;
                }

                for (int i = 0; i < _sprites.Count; i++)
                {
                    if (string.Equals(item.name.ToUpper(), _NamesType[i].ToUpper()))
                        _IdleSprite = _sprites[index];

                    if (string.Equals(_spritesHover[index].name.ToUpper(), _NamesType[i].ToUpper() + HoverTag.ToUpper()))
                        _HoverSprite = _spritesHover[index];
                }

                index++;
            }
        }
        public void SetSprite(out Sprite IdleSprite, out Sprite HoverSprite)
        {
            GetSprite();
            IdleSprite = _IdleSprite;
            HoverSprite = _HoverSprite;
        }*/
    }
}
